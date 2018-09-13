using Xamarin.Forms;
using System;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            InitializeComponent();
        }

        string message1 = "Hello World!";
        string message2 = "Goodbye World!";

        void HandleButtonClick(object sender, System.EventArgs e)
        {
            if(MyAwesomeLabel.Text == message1)
            {
                MyAwesomeLabel.Text = message2;
            }
            else
            {
                MyAwesomeLabel.Text = message1;
            }
        }
    }
}
