using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReserveClassroom
{
    public partial class DisplayDataPage : ContentPage
    {
        public DisplayDataPage(String date, String time, String room)
        {
            InitializeComponent();

            dateLabel.Text = date;
            timeLabel.Text = time;
            pickerLabel.Text = room;
        }
    }
}
