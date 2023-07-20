namespace loginApp;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_SignUp(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("//SignUp");
    }
}