namespace KidsLearningApp;

public partial class KidsAppMainPage : ContentPage
{
	public KidsAppMainPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		ImageButton button = (ImageButton)sender;
		Navigation.PushAsync(new KidsLearningDetailPage(button.CommandParameter.ToString()));
    }
}