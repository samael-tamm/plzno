using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int maxattempts = 3;
        int loggedin = 0;
        string username = "admin";
        string pass = "admin";
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(System.Object sender, RoutedEventArgs e)
        {
            if (maxattempts > 0 && loggedin!=1)
            {
                if (username1.Text == "admin" && password.Password == "admin")
                    loggedin = 1;
                else
                    maxattempts--;
            }

            if (maxattempts <= 0)
            {
                maxattempts = 0;
                info1.Text = "Too many failed login attempts.";
            }
            else
                info1.Text = "Login failed. Remaining attempts: " + maxattempts;

            if (loggedin == 1)
                this.Frame.Navigate(typeof(BlankPage1));

        }
    }
}
