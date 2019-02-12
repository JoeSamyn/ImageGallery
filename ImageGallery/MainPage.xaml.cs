using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageGallery
{
    public partial class MainPage : ContentPage
    {
        int index = 1;
        public MainPage()
        {
            InitializeComponent();

            LoadImage();


        }

        void LoadImage()
        {
            var imgSrc = new UriImageSource { Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", index)) };
            imgSrc.CachingEnabled = false;

            image.Source = imgSrc;

            text.Text = String.Format("{0}", index);
        }

        //Left Arrow
        void Click_Left_Arrow(object sender, System.EventArgs e)
        { 
            if (index == 1)
            {
                index = 10;
            }
            index--;
            LoadImage();

        }

        //Right Arrow
        void Click_Right_Arrow(object sender, System.EventArgs e)
        {

            if (index == 10)
            {
                index = 1;
            }
            index++;
            LoadImage();

        }
    }
}
