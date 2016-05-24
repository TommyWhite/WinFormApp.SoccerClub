using System.Windows.Forms;
using WinFormApp.SoccerClub.Core.DataModel;
using WinFormApp.SoccerClub.UI.Model;
using WinFormApp.SoccerClub.UI.Presenter;

namespace WinFormApp.SoccerClub.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializePlayersControl();
        }

        private void InitializePlayersControl()
        {
            var model = new DataModel();
            var presenter = new PlayersPresenter(model, playersView);
        }
    }
}
