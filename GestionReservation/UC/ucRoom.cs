using GestionReservation.Model;
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
        public int Num { get; set; }
        public void ShowStatus(DateTime dateRes) {
            foreach (Reservation res in ucHotel.DB.ListRes)
            {
                if(res.Num == this.Num && res.DateRes == dateRes.Date )
                {
                    this.BackColor = Color.Red;
                    return;
                }
            }
            this.BackColor = Color.Yellow;
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
