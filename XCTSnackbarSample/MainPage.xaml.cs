using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;

namespace XCTSnackbarSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var actions = new SnackBarActionOptions
            {
                Action = () => DisplayAlert("Thank you!", "Subscribed now!", "OK"),
                Text = "No"
            };

            var options = new SnackBarOptions
            {
                MessageOptions = new MessageOptions
                {
                    Foreground = Color.White,
                    Message = "Did you subscribe to my channel yet?!"
                },
                BackgroundColor = Color.FromHex("#2196F3"),
                Duration = TimeSpan.FromSeconds(10),
                Actions = new[] { actions }
            };

            await (sender as VisualElement).DisplaySnackBarAsync(options);
        }
    }
}
