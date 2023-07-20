namespace loginApp;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignIn(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//SignIn");
    }
}