using System;
using System.Data;
using System.Windows.Forms;
using WinFormApp.SoccerClub.Core.BusinessService;
using WinFormApp.SoccerClub.Core.DataAccess;
using WinFormApp.SoccerClub.Core.DataModel;

namespace WinFormApp.SoccerClub.UI.Model
{
    public class DataModel
    {
        private readonly IDBAccessible db;
        private readonly IMemberService service;

        public Player SelectedPlayer { get; set; }
        public DataTable PlayersData { get; set; }

        public DataModel()
        {
            db = new MemberAccess();
            service = new SoccerMemberService(db);
            LoadData();
        }

        public void DeleteMember(int id)
        {
            service.DeleteMember(id);
        }

        private void LoadData()
        {
            PlayersData = service.GetAllMembers();
        }

        internal void Update(Player currentPlayer)
        {
            bool affected = service.UpdateMember(currentPlayer);
            if (affected)
            {
                SelectedPlayer = currentPlayer;
            }
            else
            { 
                throw new Exception("Data was not affected.");
            }
        }

        internal void InsertPlayer(Player player)
        {
            bool affected = service.AddMember(player);
            if (!affected)
            {
                throw new Exception("Data was not affected.");
            }
        }

        public void UpdateRow(DataGridViewRow row)
        {
            row.Cells["Id"].Value = SelectedPlayer.Id;
            row.Cells["Name"].Value = SelectedPlayer.Name;
            row.Cells["Age"].Value = SelectedPlayer.Age;
            row.Cells["Position"].Value = SelectedPlayer.Position.ToString();
        }
    }
}
