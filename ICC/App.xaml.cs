﻿using Xamarin.Forms;
using ICC.Pages;

namespace ICC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomePage();

            //var tabbedPage = new TabbedPage();
            //tabbedPage.Children.Add(new HomePage());
            //tabbedPage.Children.Add(new SettingsPage());

            //MainPage = tabbedPage;

            //var home = new HomePageEmpty();

            //HomePageEmpty.MyNewMthod(home);
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
