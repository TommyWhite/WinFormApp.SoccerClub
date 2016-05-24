using System;
using System.Windows.Forms;
using WinFormApp.SoccerClub.Core.DataModel;
using WinFormApp.SoccerClub.UI.Controls;
using WinFormApp.SoccerClub.UI.Model;

namespace WinFormApp.SoccerClub.UI.Presenter
{
    public class PlayerCreatorPresenter
    {
        private DataModel _model;
        private PlayersEditorView _view;

        public PlayerCreatorPresenter(DataModel model, PlayersEditorView view)
        {
            _model = model;
            _view = view;
            _view.Presenter = this;
        }

        public void InvokeErrorBox(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void CreatPlayer(Player player)
        {
            _model.InsertPlayer(player);
        }
    }
}
