using System.Collections.ObjectModel;
using MauiApp1.Classes;
using MauiApp1.Converters.NavigationConverters;
using MauiApp1.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace MauiApp1.Views;

public partial class NavigatorPage : ContentPage
{
    public ObservableCollection<ButtonItem> ButtonItems { get; set; } = new ObservableCollection<ButtonItem>
    {
        new ButtonItem { Text = "Hello Xaml Page", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Open Grid Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Data Trigger Test", Category = NavigationCategory.Migration },
        new ButtonItem { Text = "Issue Test", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "Clock Page", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Essential Syntax Page", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Keypad Page", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "ListView Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "OneShot DateTime", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Shared Resources", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Slider Bindings", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Slider Transforms", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Static Constants", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Xaml + Code", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Label Measuring", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "Secondary ToolBarItem", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "Absolute Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "WebView Test", Category = NavigationCategory.Test },
        new ButtonItem { Text = "Tooltip Test", Category = NavigationCategory.Test },
        new ButtonItem { Text = "Scroll Neither", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "Next Button Entry", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "HasUnevenRows False", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "AppThemeBinding", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Array Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "FontImage Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "HSL Color Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Null Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "OnIdiom Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "OnPlatform Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Reference Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Static Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Type Demo", Category = NavigationCategory.Sample },
        new ButtonItem { Text = "Snaps Diabled", Category = NavigationCategory.Issues },
        new ButtonItem { Text = "HTML Label", Category = NavigationCategory.Test },
        new ButtonItem { Text = "Local HTML", Category = NavigationCategory.Test },
        new ButtonItem { Text = "Resource Theme", Category = NavigationCategory.Migration },
        new ButtonItem { Text = "Title View", Category = NavigationCategory.Migration },
    };
    
    public NavigatorPage()
	{
        InitializeComponent();
        BindingContext = this;

        // CollectionView Performance Test:
        // for(int i = 0; i < 100; i++) ButtonItems.Add(new ButtonItem { Text = "Open Grid Demo", Category = NavigationCategory.Sample });
        var source = ButtonItems.OrderBy(Btn => Btn.Text).ToList();

        navigationCollection.ItemsSource = source;
    }

    void NavigationBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        if (sender is Button button)
        {
            string buttonText = button.Text;
            //Color buttonColor = button.BackgroundColor;
            Color buttonColor = button.TextColor;
            var pageToNavigate = ButtonToNavigationConverter.Convert(buttonText, buttonColor);

            if (pageToNavigate != null)
            {
                Navigation.PushAsync(pageToNavigate);
            }
        }
    }

}