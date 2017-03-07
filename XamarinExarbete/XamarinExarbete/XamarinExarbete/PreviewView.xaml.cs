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
        public PreviewView(Color backgroundColor, Color backgroundButtonColor)
        {
            InitializeComponent();
            updateColors(backgroundColor, backgroundButtonColor);
        }

        public void updateColors(Color backgroundColor, Color backgroundButtonColor)
        {
            view.BackgroundColor = backgroundColor;
            button.BackgroundColor = backgroundButtonColor;
        }
    }
}
