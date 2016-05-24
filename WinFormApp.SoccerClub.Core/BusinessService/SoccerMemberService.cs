using System;
using System.Data;
using WinFormApp.SoccerClub.Core.DataAccess;
using WinFormApp.SoccerClub.Core.DataModel;

namespace WinFormApp.SoccerClub.Core.BusinessService
{
    /// <summary>
    /// Service for interaction with database.
    /// </summary>
    public class SoccerMemberService : IMemberService
    {
        private readonly IDBAccessible db;

        /// <summary>
        /// Creates instance of the SoccerMemberService
        /// </summary>
        /// <param name="dbAccess">Specify database.</param>
        public SoccerMemberService(IDBAccessible dbAccess)
        {
            db = dbAccess;
        }

        /// <summary>
        /// Deletes member.
        /// </summary>
        /// <param name="id">Member's id.</param>
        /// <returns>Data affected status.</returns>
        public bool DeleteMember(int id)
        {
            return db.DeleteMember(id);
        }

        /// <summary>
        /// Get all members from database.
        /// </summary>
        /// <returns>DataTable object.</returns>
        public DataTable GetAllMembers()
        {
            return db.GetAllMembers();
        }

        /// <summary>
        /// Gets member by id.
        /// </summary>
        /// <param name="Id">Id of the member to get.</param>
        /// <returns>DataRow</returns>
        public DataRow GetMemberById(int id)
        {
            return db.GetMemberById(id);
        }

        /// <summary>
        /// Insert Player member to the database.
        /// </summary>
        /// <param name="player">Player instance.</param>
        /// <returns>Data affected status.</returns>
        public bool AddMember(Player player)
        {
            return db.AddMember(player);
        }

        /// <summary>
        /// Updates player's info.
        /// </summary>
        /// <param name="player">Player to update.</param>
        /// <returns>Data affected status.</returns>
        public bool UpdateMember(Player player)
        {
            return db.UpdateMember(player);
        }
    }
}