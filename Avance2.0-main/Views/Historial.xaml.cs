namespace Registro.Views;

public partial class Historial : ContentPage
{
	public Historial()
	{
		InitializeComponent();
	}



    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Pantalla_Principal());
    }

    private  async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Videos());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Videos());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Videos());
    }
}