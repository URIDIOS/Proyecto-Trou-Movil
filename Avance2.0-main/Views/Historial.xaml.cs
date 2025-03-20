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

}