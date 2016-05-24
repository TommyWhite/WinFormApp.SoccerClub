using System;
using System.Windows.Forms;
using WinFormApp.SoccerClub.Core.DataModel;
using WinFormApp.SoccerClub.UI.Presenter;

namespace WinFormApp.SoccerClub.UI.Controls
{
    public partial class PlayersEditorView : UserControl
    {
        public PlayerCreatorPresenter Presenter { get; set; }

        public PlayersEditorView()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Player player = ReadFieldsToPlayer();
                Presenter.CreatPlayer(player);
            }
            catch (Exception ex)
            {
                Presenter.InvokeErrorBox(ex);
            }
        }

        public Player ReadFieldsToPlayer()
        {
            Player player = new Player();
            player.Name = txtBoxName.Text;
            player.Age = int.Parse(domainUpDownAge.Text);
            player.Position = (Position)Enum.Parse(typeof(Position), comboBoxPosition.Text);

            return player;
        }
    }
}
