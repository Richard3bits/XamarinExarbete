using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinExarbete
{

    public delegate void slideDispatcher();

    public partial class ColorTemplateView : ContentView
    {
        public event slideDispatcher slideEvent;

        public Color Color { get; set; }

        public ColorTemplateView()
        {
            InitializeComponent();
        }

        void OnRedSliderChanged(object sender, ValueChangedEventArgs e)
        {
            double red = redSlider.Value;
            double green = greenSlider.Value;
            double blue = blueSlider.Value;

            int redInt = (int) (255 * red);
            int greenInt = (int) (255 * green);
            int blueInt = (int) (255 * blue);

            string redToHexString = ToHex(redInt);
            string greenToHexString = ToHex(greenInt);
            string blueToHexString = ToHex(blueInt);

            Color = Color.FromRgb(red, green, blue);
            // box.BackgroundColor = Color;
            colorLabel.Text = "Färgkod\nHex: #" + redToHexString + greenToHexString + blueToHexString + '\n'
                + "RGB(" + redInt + ", " + greenInt + ", " + blueInt + ")";

            slideEvent.Invoke();
        }

        private static string ToHex(int value)
        {
            string st = "" + value;
            string formString = (st.Length < 2) ? "0{0:X}" : "{0:X}";

            return string.Format(formString, value);
        }
    }
}
