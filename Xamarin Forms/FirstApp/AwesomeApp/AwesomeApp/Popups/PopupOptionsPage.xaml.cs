using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Rg.Plugins.Popup.Animations;

using Xamarin.Forms;
using Rg.Plugins.Popup.Pages;

namespace AwesomeApp.Popups
{	
	public partial class PopupOptionsPage : PopupPage
    {	
		public PopupOptionsPage()
		{
			InitializeComponent();

            // Default animation
            Animation = new Rg.Plugins.Popup.Animations.ScaleAnimation();
        }
    }
}

