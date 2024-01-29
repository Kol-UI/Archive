using System.Collections.ObjectModel;
using MauiApp1.Classes;

namespace MauiApp1.Views.IssuesWorkflow;

public partial class CollectionSnapsDiabledPage : ContentPage
{
    public ObservableCollection<ButtonItem> ButtonItems { get; set; } = new ObservableCollection<ButtonItem>
    {
        new ButtonItem { Text = "Hello Xaml Page", Category = NavigationCategory.Sample },
        
    };

    public CollectionSnapsDiabledPage()
	{
		InitializeComponent();
        for(int i = 0; i < 100; i++) ButtonItems.Add(new ButtonItem { Text = "Open Grid Demo", Category = NavigationCategory.Sample });
        var source = ButtonItems.OrderBy(Btn => Btn.Text).ToList();
        CollectionViewTestIssue.ItemsSource = source;
    }
}
