using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservation.Model
{
    public class ReservationList
    {
        public List<Reservation> ListRes { get; set; }


        public ReservationList()
        {
            Reservation res1 = new Reservation(1, new DateTime(2021, 4, 8));
            Reservation res2 = new Reservation(5, new DateTime(2021, 4, 8));
            Reservation res3 = new Reservation(7, new DateTime(2021, 4, 9));
            Reservation res4 = new Reservation(8, new DateTime(2021, 4, 10));
            ListRes = new List<Reservation>
            {
                res1,
                res2,
                res3,
                res4
            };
        }


    }
}
