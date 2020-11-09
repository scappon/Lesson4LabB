using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson4LabB
{
    public partial class MainPage : ContentPage
    {

        public string myText { get; set; }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            myLabel.Text = myText;
        }
    }
}
