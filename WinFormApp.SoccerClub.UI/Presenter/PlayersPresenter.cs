using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinFormApp.SoccerClub.Core.DataModel;
using WinFormApp.SoccerClub.UI.Controls;
using WinFormApp.SoccerClub.UI.Model;

namespace WinFormApp.SoccerClub.UI.Presenter
{
    public class PlayersPresenter
    {
        private DataModel _model;
        private PlayersView _view;
     
        public PlayersPresenter(DataModel model, PlayersView view)
        {
            _model = model;
            _view = view;
            _view.Presenter = this;
            BindDataGridView();
        }

        private void ShowEditablePlayer(Player player)
        {
            _view.lblCurrentID.Text = player.Id.ToString();
            _view.txtBoxName.Text = player.Name;
            _view.domainUpDownAge.Text = player.Age.ToString();
            _view.comboBoxPosition.Text = player.Position.ToString();
            //Hello World! It is my first commit to the Git SC...)
        }

        

        internal void OpenCreator()
        {
            var playerCreator = new CreatePlayerWin();
            playerCreator.Show();
        }

        internal void UpdatePlayer()
        {
            var editablePlayer = ReadEditablePlayer();
            if (!_model.SelectedPlayer.Equals(editablePlayer))
            {
                _model.Update(editablePlayer);
                ShowEditablePlayer(_model.SelectedPlayer);
                _model.UpdateRow(_view.dataGridPlayers.SelectedRows[0]);
            }
        }

        public List<Player> ReadSelectedPlayers(DataGridViewSelectedRowCollection selectedRows)
        {
            List<Player> players = new List<Player>();
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    Player playerToAdd = new Player()
                    {
                        Id = int.Parse(row.Cells["Id"].Value.ToString()),
                        Name = row.Cells["Name"].Value.ToString(),
                        Age = int.Parse(row.Cells["Age"].Value.ToString()),
                        Position = (Position)Enum.Parse(typeof(Position), row.Cells["Position"].Value.ToString())
                    };
                    players.Add(playerToAdd);
                }

                return players;
            }
            else // TODO: Rewrite this dummy branch.
            {
                var message = false
                    ? "Multiply rows cannot be editable at the same time."
                    : "Error during row selection.";

                throw new ArgumentException(message);
            }
        }

        private void BindDataGridView()
        {
            _view.dataGridPlayers.DataSource = _model.PlayersData;
            _view.dataGridPlayers.DataMember = _model.PlayersData.TableName;
            _view.dataGridPlayers.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCells);
        }

        public void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_view.dataGridPlayers.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in _view.dataGridPlayers.SelectedRows)
                {
                    try
                    {
                        int id = int.Parse(row.Cells["Id"].Value.ToString());
                        _model.DeleteMember(id);
                        _view.dataGridPlayers.Rows.Remove(row);
                        _view.lblCurrentID.Text = null;
                        _view.txtBoxName.Text = null;
                        _view.domainUpDownAge.Text = null;
                        _view.comboBoxPosition.Text = null;
                    }
                    catch (Exception ex)
                    {
                        InvokeErrorBox(ex);
                    }
                }
            }
            else
            {
                InvokeErrorBox(new ArgumentException("Row was not specified.", nameof(_view.dataGridPlayers.SelectedRows)));
            }
        }

        public void DataGridPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (_view.dataGridPlayers.SelectedRows.Count > 0)
            {
                var data = _view.dataGridPlayers.SelectedRows[0];
                var players = ReadSelectedPlayers(_view.dataGridPlayers.SelectedRows);
                _model.SelectedPlayer = players.FirstOrDefault();
                ShowEditablePlayer(_model.SelectedPlayer);
            }
        }

        public void InvokeErrorBox(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private Player ReadEditablePlayer()
        {
            Player player = new Player()
            {
                Id = _model.SelectedPlayer.Id,
                Name = _view.txtBoxName.Text,
                Age = int.Parse(_view.domainUpDownAge.Text),
                Position = (Position)Enum.Parse(typeof(Position), _view.comboBoxPosition.Text)
            };

            return player;
        }
    }
}
