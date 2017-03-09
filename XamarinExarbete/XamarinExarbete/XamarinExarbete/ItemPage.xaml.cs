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
	public partial class ItemPage : ContentPage
	{
		public int row = 0;
		public int column = 0;
		public ItemPage()
		{
			InitializeComponent();
			myStackLayout.Children.Add(GetItem());
		}

		private View GetItem()
		{

			Grid g = new Grid();
			g.RowSpacing = 0;
			g.ColumnSpacing = 0;
			for (int i = 0; i < 18; i++)
			{
				StackLayout r = new StackLayout();
				r.HeightRequest = 140;
				//r.VerticalOptions = LayoutOptions.FillAndExpand;
				Image m = new Image
				{
					Source = "https://i.ytimg.com/vi/jcXNXvsS0wI/maxresdefault.jpg",
					Aspect = Aspect.AspectFill,	
				};
				Label l = new Label
				{
					Text = $"Pris:{i * 10}",
					FontSize = 12,
					VerticalOptions = LayoutOptions.Start
				};
				r.Children.Add(m);
				r.Children.Add(l);

				g.RowDefinitions.Add(new RowDefinition
				{
					Height = new GridLength(140, GridUnitType.Absolute)
					//Height = new GridLength(1, GridUnitType.Auto)
				});


				g.Children.Add(r, column, row);
				UpdateCounters();
			}

			return g;
		}

		private void UpdateCounters()
		{
			column = column == 1 ? 0 : 1;
			row = column == 1 ? row : row + 1;
		}

		//public StackLayout GetItemPair()
		//{
		//	StackLayout s = new StackLayout
		//	{
		//		Orientation = StackOrientation.Horizontal,
		//		HorizontalOptions = LayoutOptions.FillAndExpand

		//	};

		//	s.Children.Add(new ProductItem()
		//	{
		//		HorizontalOptions = LayoutOptions.FillAndExpand
		//	});
		//	s.Children.Add(new ProductItem()
		//	{
		//		HorizontalOptions = LayoutOptions.FillAndExpand
		//	});
		//	return s;
		//}
	}
}
