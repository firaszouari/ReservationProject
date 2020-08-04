using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ReservationProject
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        HotelEntities hotelEntities;
        Reservation reservation;

        public RadForm1()
        {
            hotelEntities = new HotelEntities();
            reservation = new Reservation();
            getGanttData();

            InitializeComponent();
        }
        

        private void getGanttData()
        {
            using (hotelEntities)
            {
                var query = from reserv in hotelEntities.Reservation
                            join room in hotelEntities.Room on reserv.RoomNum equals room.RoomNum
                            select new
                            {
                                idRoom = reserv.RoomNum,
                                nameRoom = room.Description,
                                checkIn = reserv.Checkin,
                                checkOut = reserv.Checkout,
                                totDays = reserv.Totaldays,
                                availabilityRoom = room.Availability
                            };
                foreach (var q in query)
                {
                    Reservation_Gantt.TreeListMappings.KeyFieldName = q.idRoom.ToString();
                    Reservation_Gantt.TreeListMappings.ParentFieldName = q.nameRoom;
                    Reservation_Gantt.ChartMappings.TextFieldName = q.availabilityRoom;
                    Reservation_Gantt.ChartMappings.StartDateFieldName = q.checkIn.ToString();
                    Reservation_Gantt.ChartMappings.FinishDateFieldName = q.checkOut.ToString();
                    Reservation_Gantt.ChartMappings.DurationFieldName = q.totDays.ToString();
                }
            }
        }
    }
}
