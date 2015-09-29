using System;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace App1
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public Customer[] Names => new Customer[] { "Robert", "Billy", "Leslie", "Doug" };

        public async void Click()
        {
            await new MessageDialog("!").ShowAsync();
        }


    }

    public class Customer
    {
        public string Title { get; set; }

        public async void Clicky()
        {
            await new MessageDialog("!").ShowAsync();
        }

        public static implicit operator Customer(string s) => new Customer
        {
            Title = s
        };
    }
}