using System;
using Xamarin.Forms;
using ShapesApp.Models;
using ShapesApp.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ShapesApp.ViewModels
{
    public class GraphBarsViewModels : INotifyPropertyChanged
    {
        public GraphBarsViewModels()
        {
            // Graph 1
            value1 = 8;
            value2 = 9;
            value3 = 1;
            value4 = 4;
            value5 = 8;
            value6 = 5;
            value7 = 4;
            // Graph 2
            value1_2 = 1;
            value2_2 = 2;
            value3_2 = 0;
            value4_2 = 1;
            value5_2 = 3;
            value6_2 = 5;
            value7_2 = 4;
            // Graph 3
            value1_3 = 12;
            value2_3 = 8;
            value3_3 = 7;
            value4_3 = 10;
            value5_3 = 6;
            value6_3 = 9;
            value7_3 = 6;
            // Graph 4
            value1_4 = 3;
            value2_4 = 6;
            value3_4 = 3;
            value4_4 = 4;
            value5_4 = 4;
            value6_4 = 3;
            value7_4 = 2;

            
            

        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        


        public double value1 { get; set; }
        public double value2 { get; set; }
        public double value3 { get; set; }
        public double value4 { get; set; }
        public double value5 { get; set; }
        public double value6 { get; set; }
        public double value7 { get; set; }

        public double value1_2 { get; set; }
        public double value2_2 { get; set; }
        public double value3_2 { get; set; }
        public double value4_2 { get; set; }
        public double value5_2 { get; set; }
        public double value6_2 { get; set; }
        public double value7_2 { get; set; }

        public double value1_3 { get; set; }
        public double value2_3 { get; set; }
        public double value3_3 { get; set; }
        public double value4_3 { get; set; }
        public double value5_3 { get; set; }
        public double value6_3 { get; set; }
        public double value7_3 { get; set; }

        public double value1_4 { get; set; }
        public double value2_4 { get; set; }
        public double value3_4 { get; set; }
        public double value4_4 { get; set; }
        public double value5_4 { get; set; }
        public double value6_4 { get; set; }
        public double value7_4 { get; set; }

        public Color BarColor1;
        public Color BarColor2;
        public Color BarColor3;
        public Color BarColor4;
        public Color BarColor5;
        public Color BarColor6;
        public Color BarColor7;

        public Color NumberColor1;
        public Color NumberColor2;
        public Color NumberColor3;
        public Color NumberColor4;
        public Color NumberColor5;
        public Color NumberColor6;
        public Color NumberColor7;

        public double ValueHeight1;
        public double ValueHeight2;
        public double ValueHeight3;
        public double ValueHeight4;
        public double ValueHeight5;
        public double ValueHeight6;
        public double ValueHeight7;

        



        // Graph 1
        public string NumberValue1
        {
            get => value1.ToString();
            set => value1.ToString();
        }

        public string NumberValue2
        {
            get => value2.ToString();
            set => value2.ToString();
        }

        public string NumberValue3
        {
            get => value3.ToString();
            set => value3.ToString();
        }

        public string NumberValue4
        {
            get => value4.ToString();
            set => value4.ToString();
        }

        public string NumberValue5
        {
            get => value5.ToString();
            set => value5.ToString();
        }

        public string NumberValue6
        {
            get => value6.ToString();
            set => value6.ToString();
        }

        public string NumberValue7
        {
            get => value7.ToString();
            set => value7.ToString();
        }



        // Graph 2
        public string NumberValue1_2
        {
            get => value1_2.ToString();
            set => value1_2.ToString();
        }

        public string NumberValue2_2
        {
            get => value2_2.ToString();
            set => value2_2.ToString();
        }

        public string NumberValue3_2
        {
            get => value3_2.ToString();
            set => value3_2.ToString();
        }

        public string NumberValue4_2
        {
            get => value4_2.ToString();
            set => value4_2.ToString();
        }

        public string NumberValue5_2
        {
            get => value5_2.ToString();
            set => value5_2.ToString();
        }

        public string NumberValue6_2
        {
            get => value6_2.ToString();
            set => value6_2.ToString();
        }

        public string NumberValue7_2
        {
            get => value7_2.ToString();
            set => value7_2.ToString();
        }



        // Graph 3
        public string NumberValue1_3
        {
            get => value1_3.ToString();
            set => value1_3.ToString();
        }

        public string NumberValue2_3
        {
            get => value2_3.ToString();
            set => value2_3.ToString();
        }

        public string NumberValue3_3
        {
            get => value3_3.ToString();
            set => value3_3.ToString();
        }

        public string NumberValue4_3
        {
            get => value4_3.ToString();
            set => value4_3.ToString();
        }

        public string NumberValue5_3
        {
            get => value5_3.ToString();
            set => value5_3.ToString();
        }

        public string NumberValue6_3
        {
            get => value6_3.ToString();
            set => value6_3.ToString();
        }

        public string NumberValue7_3
        {
            get => value7_3.ToString();
            set => value7_3.ToString();
        }



        // Graph 4
        public string NumberValue1_4
        {
            get => value1_4.ToString();
            set => value1_4.ToString();
        }

        public string NumberValue2_4
        {
            get => value2_4.ToString();
            set => value2_4.ToString();
        }

        public string NumberValue3_4
        {
            get => value3_4.ToString();
            set => value3_4.ToString();
        }

        public string NumberValue4_4
        {
            get => value4_4.ToString();
            set => value4_4.ToString();
        }

        public string NumberValue5_4
        {
            get => value5_4.ToString();
            set => value5_4.ToString();
        }

        public string NumberValue6_4
        {
            get => value6_4.ToString();
            set => value6_4.ToString();
        }

        public string NumberValue7_4
        {
            get => value7_4.ToString();
            set => value7_4.ToString();
        }




        //public double valueHeight1
        //{
        //    get { return ValueHeight1; }
        //    set
        //    {
        //        if (value1 == 0)
        //        {
        //            ValueHeight1 = 0;
        //        }
        //        else if (value1 == 1) // 1 Session
        //        {
        //            ValueHeight1 = 30;
        //        }
        //        else if (value1 == 2) // 2 Sessions
        //        {
        //            ValueHeight1 = 60;
        //        }
        //        else if (value1 == 3) // 3 Sessions
        //        {
        //            ValueHeight1 = 90;
        //        }
        //        else if (value1 == 4) // 4 Sessions
        //        {
        //            ValueHeight1 = 120;
        //        }
        //        else if (value1 == 5) // 5 Sessions
        //        {
        //            ValueHeight1 = 150;
        //        }
        //        else if (value1 == 6) // 6 Sessions
        //        {
        //            ValueHeight1 = 180;
        //        }
        //        else if (value1 == 7) // 7 Sessions
        //        {
        //            ValueHeight1 = 210;
        //        }
        //        else if (value1 == 8) // 8 Sessions
        //        {
        //            ValueHeight1 = 240;
        //        }
        //        else if (value1 >= 9) // 9 and more Sessions
        //        {
        //            ValueHeight1 = 270;
        //        }
        //    }
        //}






    }
}
