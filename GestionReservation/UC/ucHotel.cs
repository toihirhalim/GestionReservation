using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionReservation.UC
{
    public partial class ucHotel : UserControl
    {
        public int level = 0;
        public ucHotel()
        {
            InitializeComponent();
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            showStatus();
        }

        private void showStatus()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ucRoom)
                {
                    ucRoom room = (ucRoom)item;
                    room.ShowStatus(dtPicker.Value, level);
                }

            }
        }

        private void showSelectedLevel()
        {
            foreach (Button btn in levels.Controls)
            {
                if(btn.Text.Equals("" + level))
                {
                    btn.BackColor = Color.Blue;
                }else
                {
                    btn.BackColor = Color.Transparent;
                }
            }
                
        }

        private void ucHotel_Load(object sender, EventArgs e)
        {
            showSelectedLevel();
            showStatus();
        }

        private void levelBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int l = level;

            try
            {
                l = int.Parse(btn.Text);
            }
            catch (Exception)
            {

            }

            level = l;
            showSelectedLevel();
            showStatus();
        }
    }
}
