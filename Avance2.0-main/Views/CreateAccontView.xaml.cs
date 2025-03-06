namespace Registro.Views;

public partial class CreateAccontView : ContentPage
{
	public CreateAccontView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Login());
    }

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Views.Login());
	}
}