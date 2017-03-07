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
            previewView = new PreviewView(Color.White, Color.White);
            colorStack.Children.Add(previewView);
        }

        void OnSliderPageChanged()
        {
            previewView.updateColors(ColorView.Color, ColorView.Color);
        }
    }
}
