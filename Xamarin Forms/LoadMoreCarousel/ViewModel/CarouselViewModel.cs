using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LoadMore
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            for (int i = 1; i < 25; i++)
            {
                ImageCollection.Add(new CarouselModel("Image" + i + ".jpg"));
            }

        }
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}