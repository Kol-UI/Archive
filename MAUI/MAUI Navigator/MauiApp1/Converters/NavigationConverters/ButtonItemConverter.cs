using System;
using System.Globalization;
using System.Collections.ObjectModel;
using Microsoft.Maui;
using MauiApp1.Classes;

namespace MauiApp1.Converters.NavigationConverters
{
    public class ButtonItemConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = $"{value}";
            NavigationCategory result;
            if (Enum.TryParse(text, out result))
            {
                switch (result)
                {
                    case NavigationCategory.Migration:
                        return Colors.DodgerBlue;
                    case NavigationCategory.Issues:
                        return Colors.OrangeRed;
                    case NavigationCategory.Sample:
                        return Colors.DarkTurquoise;
                    case NavigationCategory.Test:
                        return Colors.PaleGreen;
                    default:
                        break;
                }
            }

            return Colors.DarkBlue; // default
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        internal static NavigationCategory ConvertColorBack(Color buttonColor)
        {
            Dictionary<string, NavigationCategory> colorMappings = new Dictionary<string, NavigationCategory>
            {
                { "#00CED1", NavigationCategory.Sample },  // DarkTurquoise
                { "#1E90FF", NavigationCategory.Migration },   // DodgerBlue
                { "#FF4500", NavigationCategory.Issues },     // OrangeRed
                { "#98FB98", NavigationCategory.Test },   // PaleGreen
            };

            if (buttonColor is not null)
            {
                string rgbaHex = buttonColor.ToRgbaHex();

                if (colorMappings.ContainsKey(rgbaHex))
                {
                    return colorMappings[rgbaHex];
                }
                else
                {
                    return NavigationCategory.Unknown;
                }
            }
            return NavigationCategory.None;
        }
    }
}