using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.SoccerClub.Core.DataModel;

namespace WinFormApp.SoccerClub.UI
{
    public interface IEditable<T> where T: class
    {
        int Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        Position Position { get; set; }
        T ToObject();
    }
}
