﻿using System.Windows.Input;

namespace MauiApp1.Views.SampleWorkflow;

public partial class TypeDemoPage : ContentPage
{
    public ICommand CreateCommand { get; private set; }

    public TypeDemoPage()
    {
        InitializeComponent();

        CreateCommand = new Command<Type>((Type viewType) =>
        {
            View view = (View)Activator.CreateInstance(viewType);
            view.VerticalOptions = LayoutOptions.Center;
            stackLayout.Add(view);
        });

        BindingContext = this;
    }
}
