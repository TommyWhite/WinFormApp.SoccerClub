using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp.SoccerClub.UI.Model;
using WinFormApp.SoccerClub.UI.Presenter;

namespace WinFormApp.SoccerClub.UI
{
    public partial class CreatePlayerWin : Form
    {
        public CreatePlayerWin()
        {
            InitializeComponent();
            var model = new DataModel();
            var presenter = new PlayerCreatorPresenter(model, playersCreator);
        }
    }
}
