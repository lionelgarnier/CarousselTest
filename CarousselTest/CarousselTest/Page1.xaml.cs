using CarouselView.FormsPlugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CarousselTest
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            var myCarousel = new CarouselViewControl();
            myCarousel.ItemsSource = new List<int> { 1, 2, 3, 4, 5 };
            myCarousel.ItemTemplate = new DataTemplate (typeof(View1));
            myCarousel.Position = 0; //default
            myCarousel.InterPageSpacing = 10;
            myCarousel.Orientation = Orientation.Horizontal;

            this.Content = myCarousel;
        }
    }
}
