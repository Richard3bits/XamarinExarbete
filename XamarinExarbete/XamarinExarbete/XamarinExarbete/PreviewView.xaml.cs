using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinExarbete
{
    public partial class PreviewView : ContentView
    {
        public PreviewView()
        {
            InitializeComponent();
        }

        public void updateBackgroundTheme(Color backgroundColor)
        {
            view.BackgroundColor = backgroundColor;
            label.TextColor = InvertedColor(backgroundColor);
        }

        public void updateButtonTheme(Color backgroundButtonColor)
        {
            button.BackgroundColor = backgroundButtonColor;
            button.TextColor = InvertedColor(backgroundButtonColor);
        }

        private static Color InvertedColor(Color color)
        {
            return Color.FromRgb(
                1 - color.R,
                1 - color.G,
                1 - color.B);
        }
    }
}
