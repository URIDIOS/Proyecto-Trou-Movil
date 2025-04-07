using Registro.Services;
using Registro.ViewModel;

namespace Registro.Views;

public partial class CreateAccontView : ContentPage
{
	public CreateAccontView()
	{
		InitializeComponent();
	}

	// Bot�n de "Registrar"
	private async void Button_Clicked(object sender, EventArgs e)
	{

		var nombreText = nombre.Text;
		var correoText = correo.Text;
		var contrase�aText = contrase�a.Text;

		if (string.IsNullOrWhiteSpace(nombreText) ||
			string.IsNullOrWhiteSpace(correoText) ||
			string.IsNullOrWhiteSpace(contrase�aText))
		{
			await DisplayAlert("Error", "Todos los campos son obligatorios", "OK");
			return;
		}

		var nuevoRegistro = new RegistroViewModel
		{
			Nombre = nombreText,
			Correo = correoText,
			Contrase�a = contrase�aText
		};

		var apiService = new ApiService();
		bool success = await apiService.RegistrarUsuario(nuevoRegistro);

		if (success)
		{
			await DisplayAlert("�xito", "Usuario registrado correctamente", "OK");
			await Navigation.PushAsync(new Login()); // Ir a Login
		}
		else
		{
			await DisplayAlert("Error", "No se pudo registrar el usuario", "OK");
		}
	}

	// Bot�n "�Ya tienes cuenta?"
	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Login());
	}
}
