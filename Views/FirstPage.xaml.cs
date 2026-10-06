using Microsoft.Maui.Controls;
using System.Net.Security;

namespace Assignment1_the_basics.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    private void on_calculate(object sender, EventArgs e)
    {
        int result = int.Parse(Age_Entry.Text) + 10;
        initial_message.Text = "hello " + Name_Entry.Text +" your age in 10 years will be: "+ result;

        for (int i = 0; i < result; i++)
        {
            Image image = new Image
            {
                Source = "candle.png",
                HeightRequest = 100,
                WidthRequest = 100,
                Margin = 5
            };

            ImageContainer.Children.Add(image);
        }
    }
}