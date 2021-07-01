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
        public int Level;
        public DateTime Date;
        public Reservation res;
        public Boolean Reserved;
        public void ShowStatus(DateTime dateRes, int level) {
            res = DC.Reservation.FirstOrDefault(r => r.Room == Num && r.Level == level && r.Date == dateRes);
            Date = dateRes;
            Level = level;
            Reserved = res != null;

            if (Reserved)
                this.BackColor = Color.Maroon;
            else
                this.BackColor = Color.DarkGray;

            updateContextMenuStrip();
        }
        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            lbNum.Text = Num.ToString();
        }

        private void libererMenuItem_Click(object sender, EventArgs e)
        {
            if (Reserved)
            {
                DC.Reservation.DeleteOnSubmit(res);
                DC.SubmitChanges();
                this.BackColor = Color.DarkGray;
                Reserved = false;
                updateContextMenuStrip();
            }
        }

        private void reserverMenuItem_Click(object sender, EventArgs e)
        {
            if (!Reserved)
            {
                res = new Reservation() { Level = Level, Room = Num, Date = Date };
                DC.Reservation.InsertOnSubmit(res);
                DC.SubmitChanges();
                this.BackColor = Color.Maroon;
                Reserved = true;
                updateContextMenuStrip();
            }
        }

        private void updateContextMenuStrip()
        {
            libererMenuItem.Visible = Reserved;
            reserverMenuItem.Visible = !Reserved;
        }
    }
}
