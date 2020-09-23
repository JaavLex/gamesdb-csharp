using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            game NewGame = new game(gamegrid.RowCount + 1, namebox.Text, platformbox.Text, typebox.Text, datebox.Value, editorbox.Text);

            String[] row = new string[] { NewGame._id.ToString(), NewGame._name, NewGame._platform, NewGame._type, NewGame._gamedate.ToString(), NewGame._editor };

            gamegrid.Rows.Add(row);
        }
    }
}
