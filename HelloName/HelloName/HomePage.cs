﻿using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloName
{

    class HomePage : ContentPage
    {
        Entry name;
        public HomePage()
        {
            name = new Entry
            {
                Placeholder = "Enter name",
                Text = "",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = Xamarin.Forms.Device.GetNamedSize(NamedSize.Medium, typeof(Entry)),
                AutomationId = "name"
            };
            Button saveButton = new Button
            {
                Text = "Save",
                FontSize = Xamarin.Forms.Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "saveButton"
            };
            saveButton.Clicked += SaveButton;
            var stack = new StackLayout
            {
                Children = {
                    name, saveButton
                },
                Padding = 5
            };
            var scroll = new ScrollView { Content = stack };
            Content = scroll;
        }
        private async void SaveButton(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                await DisplayAlert("Saved", "Welcome, " + name.Text, "OK");
            }
            Analytics.TrackEvent("Save Clicked");
        }
    }
}
