using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WinFormApp.SoccerClub.Core;
using WinFormApp.SoccerClub.Core.DataModel;

namespace WinFormApp.SoccerClub.Tests.Unity
{
    [TestClass]
    public class SqlQueryValidation
    {
        private readonly string tblName = "players";
        private readonly Type dataModelType = typeof(Player);

        private readonly QueriesBuilder actualQueryObj;

        public SqlQueryValidation()
        {
            actualQueryObj = new QueriesBuilder(tblName, dataModelType);
        }

        [TestMethod]
        public void ValidateInsertQuery()
        {
            var actual = actualQueryObj.InsertMember;

            Assert.AreEqual(OriginalQueries.Insert, actual);
        }

        [TestMethod]
        public void ValidateReadAllQuery()
        {
            Assert.AreEqual(OriginalQueries.ReadAll, actualQueryObj.ReadAll);
        }

        [TestMethod]
        public void ValidateReadByIdQuery()
        {
            Assert.AreEqual(OriginalQueries.ReadById, actualQueryObj.ReadById);
        }

        [TestMethod]
        public void ValidateUpdateByIdQuery()
        {
            Assert.AreEqual(OriginalQueries.UpdateById, actualQueryObj.UpdateById);
        }

        [TestMethod]
        public void ValidateDeleteByIdQuery()
        {
            Assert.AreEqual(OriginalQueries.DeleteById, actualQueryObj.DeleteById);
        }


    }

    public static class OriginalQueries
    {
        public static readonly string Insert = "INSERT INTO players(Name, Age, Position) VALUES(@Name, @Age, @Position)";
        public static readonly string ReadAll = "SELECT * FROM players";
        public static readonly string ReadById = ReadAll + " WHERE Id = @Id";
        public static readonly string UpdateById = "UPDATE players SET [Name] = @Name, [Age] = @Age, [Position] = @Position " + 
            "WHERE ([Id] = @Id)";
        public static readonly string DeleteById = "DELETE FROM players WHERE (Id = @Id)";

    }
}
