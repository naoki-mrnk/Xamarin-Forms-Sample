using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingPractice
{
    public partial class MainPage : ContentPage
    {
        public string AnyText { get; set; }
        public MainPage()
        {
            InitializeComponent();
            this.AnyText = "Study DataBinding!";
            this.BindingContext = this;
        }
    }
}
