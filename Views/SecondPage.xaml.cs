namespace Assignment1_the_basics.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    private void NumOfCandles_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        ImageContainer.Clear();
        int result = int.Parse(Age_Entry.Text) + 10;
        initial_message.Text = "hello " + Name_Entry.Text + " your age in 10 years will be: " + result;

        int slider_value = (int)NumOfCandles.Value;
        for (int i = 0; i < slider_value; i++)
        {
            Image image = new Image
            {
                Source = "candle.png",
                HeightRequest = 70,
                WidthRequest = 70,
                Margin = 3
            };

            ImageContainer.Children.Add(image);
        }
    }
}