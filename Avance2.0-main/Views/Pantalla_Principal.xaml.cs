namespace Registro.Views;

public partial class Pantalla_Principal : ContentPage
{
	int count = 0;

	public Pantalla_Principal()
	{
		InitializeComponent();
	}

	private void PushButton_Pressed(object sender, EventArgs e)
	{
		var color = PushButton.BackgroundColor.ToHex();

		if (color == "#FF0000") //Red
		{
			PushButton.BackgroundColor = Color.FromArgb("#0f0"); //Green
			StatusLabel.Text = "Abierto";
			StatusLabel.TextColor = Color.FromArgb("#0f0");
		}
		else
		{
			PushButton.BackgroundColor = Color.FromArgb("#f00"); //Red again
			StatusLabel.Text = "Cerrado";
			StatusLabel.TextColor = Color.FromArgb("#f00");
		}
	}
}


