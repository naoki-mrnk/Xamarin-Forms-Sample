using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReserveClassroom
{
    public partial class MainPage : ContentPage
    {
        public String date;
        public String time;
        public String room;
        public MainPage()
        {
            InitializeComponent();
        }

        void reserveButton_Clicked(System.Object sender, System.EventArgs e)
        {
            date = dateText.Date.ToString("yyyy/MM/dd");
            time = timeText.Time.ToString(@"hh\:mm");
            room = roomName.SelectedItem.ToString();
            Navigation.PushAsync(new DisplayDataPage(date, time, room));
        }

        void dateText_DateSelected(System.Object sender, Xamarin.Forms.DateChangedEventArgs e)
        {
        }
    }
}
