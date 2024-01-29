using System;
using MauiApp1;
using MauiApp1.Classes;
using MauiApp1.Views.IssuesWorkflow;
using MauiApp1.Views.TestWorkflow;
using MauiApp1.Views.SampleWorkflow;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using MauiApp1.Views.MigrationWorkflow;

namespace MauiApp1.Converters.NavigationConverters
{
    public class ButtonToNavigationConverter : IValueConverter
    {
        internal static Page Convert(string buttonText, Color buttonColor)
        {
            if (buttonText is not null)
            {
                NavigationCategory colorToCategory = ButtonItemConverter.ConvertColorBack(buttonColor);
                switch(colorToCategory)
                {
                    case NavigationCategory.Migration:
                        return ButtonCategoryMigrationConverter(buttonText);
                    case NavigationCategory.Sample:
                        return ButtonCategorySampleConverter(buttonText);
                    case NavigationCategory.Issues:
                        return ButtonCategoryIssuesConverter(buttonText);
                    case NavigationCategory.Test:
                        return ButtonCategoryTestConverter(buttonText);
                    default:
                        return null;
                }
            }

            return null;
        }

        internal static Page ButtonCategoryMigrationConverter(string buttonText)
        {
            switch (buttonText)
            {
                case "Resource Theme":
                    return new ResourceThemeTestPage();
                case "Title View":
                    return new TitleViewTestPage();
                default:
                    return null;
            }
        }

        internal static Page ButtonCategoryIssuesConverter(string buttonText)
        {
            switch (buttonText)
            {
                case "Label Measuring":
                    return new LabelMeasuringPage();
                case "Secondary ToolBarItem":
                    return new SecondaryToolBarItemWindowsPage();
                case "Scroll Neither":
                    return new ScrollViewOrientationNeitherPage();
                case "Next Button Entry":
                    return new NextButtonEntryPage();
                case "HasUnevenRows False":
                    return new HasUnevenRowsFalsePage();
                case "Snaps Diabled":
                    return new CollectionSnapsDiabledPage();
                default:
                    return null;
            }
        }

        internal static Page ButtonCategorySampleConverter(string buttonText)
        {
            switch (buttonText)
            {
                case "Absolute Demo":
                    return new AbsoluteDemoPage();
                case "Open Grid Demo":
                    return new GridDemoPage();
                case "Clock Page":
                    return new ClockPage();
                case "Essential Syntax Page":
                    return new EssentialSyntaxPage();
                case "Hello Xaml Page":
                    return new HelloXamlPage();
                case "Keypad Page":
                    return new KeypadPage();
                case "ListView Demo":
                    return new ListViewDemoPage();
                case "OneShot DateTime":
                    return new OneShotDateTimePage();
                case "Shared Resources":
                    return new SharedResourcesPage();
                case "Slider Bindings":
                    return new SliderBindingsPage();
                case "Slider Transforms":
                    return new SliderTransformsPage();
                case "Static Constants":
                    return new StaticConstantsPage();
                case "Xaml + Code":
                    return new XamlPlusCodePage();
                case "AppThemeBinding":
                    return new AppThemeBindingDemoPage();
                case "Array Demo":
                    return new ArrayDemoPage();
                case "FontImage Demo":
                    return new FontImageDemoPage();
                case "HSL Color Demo":
                    return new HslColorDemoPage();
                case "Null Demo":
                    return new NullDemoPage();
                case "OnIdiom Demo":
                    return new OnIdiomDemoPage();
                case "OnPlatform Demo":
                    return new OnPlatformDemoPage();
                case "Reference Demo":
                    return new ReferenceDemoPage();
                case "Static Demo":
                    return new StaticDemoPage();
                case "Type Demo":
                    return new TypeDemoPage();
                default:
                    return null;
            }
        }

        internal static Page ButtonCategoryTestConverter(string buttonText)
        {
            switch (buttonText)
            {
                case "WebView Test":
                    return new WebViewTestPage();
                case "Tooltip Test":
                    return new TooltipTestPage();
                case "HTML Label":
                    return new LabelHtmlTestPage();
                case "Local HTML":
                    return new LocalHtmlTestPage();
                default:
                    return null;
            }
        }


        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}