﻿using System;
using Xamarin.Forms;
#if WINDOWS_UWP
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.ApplicationModel;
#elif __MACOS__
using AppKit;
#endif

namespace ConferenceKiosk
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

		private async void GoBtnClicked(object sender, EventArgs e)
		{
#if WINDOWS_UWP
            var pref = ViewModePreferences.CreateDefault(ApplicationViewMode.CompactOverlay);
            pref.CustomSize = new Windows.Foundation.Size(400, 900);

            await ApplicationView.GetForCurrentView().TryEnterViewModeAsync(ApplicationViewMode.CompactOverlay, pref);
#elif __MACOS__
			NSApplication.SharedApplication.MainWindow.ToggleFullScreen(NSApplication.SharedApplication.MainWindow);
			NSApplication.SharedApplication.MainWindow.Level = NSWindowLevel.Floating;
#endif
			await Navigation.PushAsync(new GuidePage());
		}
    }
}
