using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Poc_MasterDetail_Tabbed
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MasterDetailPage
            {
                Master = new ContentPage
                {
                    Title = "Master",
                    Content = new StackLayout
                    {
                        Children =
                        {
                            new Label {Text = "Test 1"},
                            new Label {Text = "Test 2"}
                        }
                    }
                },
                Detail = new TabbedPage
                {
                    Children =
                    {
                        new ContentPage {Title = "Page1", Content = new Label {Text = "Label page 1"} },
                        new ContentPage {Title = "Page2", Content = new Label {Text = "Label page 2"} },
                        new ContentPage {Title = "Page3", Content = new Label {Text = "Label page 3"} },
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
