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
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addbutton_Click(object sender, EventArgs e)
        {
            game NewGame = new game(gamegrid.RowCount, namebox.Text, platformbox.Text, typebox.Text, datebox.Value, editorbox.Text);
            gamegrid.Rows.Add(NewGame._id, NewGame._name, NewGame._platform, NewGame._type, NewGame._gamedate, NewGame._editor);
        }

        private void typebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gamegrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enamebox.Text = gamegrid.Rows[e.RowIndex].Cells["GName"].FormattedValue.ToString();
            eplatformbox.Text = gamegrid.Rows[e.RowIndex].Cells["Platform"].FormattedValue.ToString();
            etypebox.Text = gamegrid.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
            edatebox.Text = gamegrid.Rows[e.RowIndex].Cells["GameDate"].FormattedValue.ToString();
            eeditorbox.Text = gamegrid.Rows[e.RowIndex].Cells["Editor"].FormattedValue.ToString();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
