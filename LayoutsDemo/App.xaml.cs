﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinPage3();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
