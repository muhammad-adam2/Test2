using System;

using Xamarin.Forms;

namespace AmaSociety.Services
{
    public class AuthenticationService : ContentPage
    {
        public AuthenticationService()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

