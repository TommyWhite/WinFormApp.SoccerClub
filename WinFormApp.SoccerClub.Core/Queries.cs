using System;
using System.Linq;
using System.Reflection;

namespace WinFormApp.SoccerClub.Core
{
    /// <summary>
    /// Provides class with SQL queries according particular table.y
    /// </summary>
    public class QueriesBuilder
    {
        /// <summary>
        /// Name of the table that current model working with.
        /// </summary>
        public string TableName { get; private set; }

        /// <summary>
        /// Holds mapping data model and particular data table in DB
        /// </summary>
        public Type CurrentModelType { get; private set; }

        /// <summary>
        /// Instance of the class with queries.
        /// </summary>
        /// <param name="tableName">Secify name of the table to interact with.</param>
        public QueriesBuilder(string tableName, Type modelType)
        {
            TableName = tableName;
            CurrentModelType = modelType;
        }

        private PropertyInfo[] ModelProperties
        {
            get
            {
                return CurrentModelType.GetProperties();
            }
        }

        private string TableFields
        {
            get
            {
                return string.Join(", ", ModelProperties.Select(p => p.Name.ToString()));
            }
        }

        private string TableParameters
        {
            get
            {
                return string.Join(", @", ModelProperties.Select(f => f.Name)).Insert(0, "@");
            }
        }

        #region === Sql Queries ===

        public string InsertMember
        {
            get
            {
                var insertingFields = TableFields.Remove(0, TableFields.IndexOf(',') + 1);
                var insertingValues = TableParameters.Remove(0, TableParameters.IndexOf(',') + 1);
                return $"INSERT INTO {TableName}({insertingFields}) " +
                    $"VALUES({insertingValues})";
            }
        }

        public string ReadAll
        {
            get
            {
                return $"SELECT * FROM {TableName}";
            }
        }

        public string ReadById
        {
            get
            {
                return $"{ReadAll} WHERE Id = @Id";
            }
        }

        public string UpdateById
        {
            get
            {
                var parameters = ModelProperties.Select(p => p.Name.Insert(0, $"[{p.Name}] = @")).ToList();
                parameters.RemoveAt(0);
                var parametersString = string.Join(", ", parameters);
                return $"UPDATE {TableName} SET {parametersString} WHERE ([Id] = @Id)";
            }
        }

        public string DeleteById
        {
            get
            {
                return $"DELETE FROM {TableName} WHERE (Id = @Id)";
            }
        }

        #endregion === Sql Queries ===
    }
}