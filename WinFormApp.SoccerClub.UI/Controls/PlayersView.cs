using System;
using System.Windows.Forms;
using WinFormApp.SoccerClub.UI.Presenter;

namespace WinFormApp.SoccerClub.UI.Controls
{
    public partial class PlayersView : UserControl
    {
        public PlayersPresenter Presenter { get; set; }

        public PlayersView()
        {
            InitializeComponent();
            dataGridPlayers.SelectionChanged += DataGridPlayers_SelectionChanged;
            btnDelete.Click += BtnDelete_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnCreate.Click += BtnCreate_Click;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.OpenCreator();
            }
            catch (Exception ex)
            {
                Presenter.InvokeErrorBox(ex);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.UpdatePlayer();
            }
            catch (Exception ex)
            {
                Presenter.InvokeErrorBox(ex);
            }
        }

        private void DataGridPlayers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Presenter.DataGridPlayers_SelectionChanged(sender, e);
            }
            catch (Exception ex)
            {
                Presenter.InvokeErrorBox(ex);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Presenter.BtnDelete_Click(sender, e);
            }
            catch (Exception ex)
            {
                Presenter.InvokeErrorBox(ex);
            }
        }
    }
}
