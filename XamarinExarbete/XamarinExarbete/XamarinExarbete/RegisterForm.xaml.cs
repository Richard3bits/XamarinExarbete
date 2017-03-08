using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExarbete
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterForm : ContentPage
    {
        private PreviewView previewView;

        public RegisterForm()
        {
            InitializeComponent();
            previewView = new PreviewView();
            colorStack.Children.Add(previewView);
        }

        void OnSliderPageChanged()
        {
            if (colorSwitch.IsToggled)
            {
                previewView.updateBackgroundTheme(ColorView.Color);
            }
            else
            {
                previewView.updateButtonTheme(ColorView.Color);
            }
        }
    }
}
