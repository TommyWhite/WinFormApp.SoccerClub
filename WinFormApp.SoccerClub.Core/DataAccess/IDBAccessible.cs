using System.Data;
using WinFormApp.SoccerClub.Core.DataModel;

namespace WinFormApp.SoccerClub.Core.DataAccess
{
    public interface IDBAccessible
    {
        /// <summary>
        /// Method to get particular member from the database by id.
        /// </summary>
        /// <param name="id">Specify id of the member.</param>
        /// <returns></returns>
        DataRow GetMemberById(int id);

        /// <summary>
        /// Method to get all member from the database.
        /// </summary>
        /// <returns></returns>
        DataTable GetAllMembers();

        /// <summary>
        /// Method to create new member.
        /// </summary>
        /// <param name="player">Member to create.</param>
        /// <returns>True if succeded, otherwise returns false.</returns>
        bool AddMember(Player player);

        /// <summary>
        /// Method to 
        /// </summary>
        /// <param name="player">Member to update.</param>
        /// <returns>True if succeded, otherwise returns false.</returns>
        bool UpdateMember(Player player);

        /// <summary>
        /// Method to delete particular member.
        /// </summary>
        /// <param name="player">Player to delete.</param>
        /// <returns>True if succeded, otherwise returns false.</returns>
        bool DeleteMember(int id);
    }
}
