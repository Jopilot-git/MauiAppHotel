namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void voltar_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new ContratacaodaHospedagem());
    }
}




