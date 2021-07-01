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
    public partial class ucRoom : UserControl
    {
        DCDataContext DC = new DCDataContext();
        public int Num { get; set; }
        public void ShowStatus(DateTime dateRes, int level) {
            Reservation res = DC.Reservation.FirstOrDefault(r => r.Room == Num && r.Level == level && r.Date == dateRes);

            if(res != null)
                this.BackColor = Color.Maroon;
            else
                this.BackColor = Color.DarkGray;
        }
        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            lbNum.Text = Num.ToString();
        }
    }
}
