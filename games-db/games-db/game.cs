using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace games_db
{
    class game
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public string _type { get; set; }
        public string _platform { get; set; }
        public DateTime _gamedate { get; set; }
        public string _editor { get; set; }
        public game()
        {
        }

        public game(int ID, string Name, string Type, string Platform, DateTime GameDate, string Editor)
        {
            _id = ID;
            _name = Name;
            _type = Type;
            _platform = Platform;
            _gamedate = GameDate;
            _editor = Editor;
        }
    }
}
