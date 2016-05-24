using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.SoccerClub.Core.DataModel;

namespace WinFormApp.SoccerClub.Core.DataAccess
{
    /// <summary>
    /// Provides interactions with database.
    /// </summary>
    public class MemberAccess : ConnectionAccess, IDBAccessible
    {
        private readonly QueriesBuilder query;

        /// <summary>
        /// Creates instance for interaction with database.
        /// </summary>
        public MemberAccess() : base("playersDB")
        {
            query = new QueriesBuilder("players", typeof(Player));
        }

        /// <summary>
        /// Add player to the database.
        /// </summary>
        /// <param name="player">Specify player to add.</param>
        /// <returns>True if operation succeded, otherwise returns false.</returns>
        public bool AddMember(Player player)
        {
            SqlCommand command = new SqlCommand()
            {
                Connection = new SqlConnection(ConnectionString),
                CommandText = query.InsertMember,
                CommandType = CommandType.Text
            };

            command.Parameters.AddWithValue("@Name", player.Name);
            command.Parameters.AddWithValue("@Age", player.Age);
            command.Parameters.AddWithValue("@Position", player.Position.ToString());

            command.Connection.Open();
            var rowsAffected = command.ExecuteNonQuery();
            command.Connection.Close();
            command.Dispose();

            return rowsAffected > 0;
        }

        /// <summary>
        /// Deletes the player from the database by its id.
        /// </summary>
        /// <param name="id">Member id.</param>
        /// <returns>True if operation succeded, otherwise returns false.</returns>
        public bool DeleteMember(int id)
        {
            SqlCommand command = new SqlCommand()
            {
                Connection = new SqlConnection(ConnectionString),
                CommandText = query.DeleteById,
                CommandType = CommandType.Text
            };

            command.Connection.Open();
            command.Parameters.AddWithValue("@Id", id);
            var rowsAffected = command.ExecuteNonQuery();
            command.Connection.Close();
            command.Dispose();

            return rowsAffected > 0;
        }

        /// <summary>
        /// Get all data from the database table.
        /// </summary>
        /// <returns>DataTable object.</returns>
        public DataTable GetAllMembers()
        {
            DataTable dataTable = new DataTable();
            
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                dataAdapter.SelectCommand = new SqlCommand();
                dataAdapter.SelectCommand.Connection = new SqlConnection(ConnectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = query.ReadAll;

                dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        /// <summary>
        /// Gets member by its id.
        /// </summary>
        /// <param name="id">Id of the member.</param>
        /// <returns>DataRow object.</returns>
        public DataRow GetMemberById(int id)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                dataAdapter.SelectCommand = new SqlCommand();
                dataAdapter.SelectCommand.Connection = new SqlConnection(ConnectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = query.ReadById;

                dataAdapter.SelectCommand.Parameters.AddWithValue("@Id", id);
                dataAdapter.Fill(dataTable);

                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }

        /// <summary>
        /// Updates particular player.
        /// </summary>
        /// <param name="player">Specify player to update.</param>
        /// <returns>True if operation succeded, otherwise returns false.</returns>
        public bool UpdateMember(Player player)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = new SqlConnection(ConnectionString);
                command.CommandType = CommandType.Text;
                command.CommandText = query.UpdateById;
                command.Parameters.AddWithValue("@Id", player.Id);
                command.Parameters.AddWithValue("@Name", player.Name);
                command.Parameters.AddWithValue("@Age", player.Age);
                command.Parameters.AddWithValue("@Position", player.Position.ToString());

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}
