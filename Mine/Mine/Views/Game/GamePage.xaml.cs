﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Mine.Views
{
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
        }

        async void GameButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("SU", "Go RedHawks", "OK");
        }
    }

    
}
