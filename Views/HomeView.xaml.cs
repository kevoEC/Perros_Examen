using KevinRosero_ExamenFinal.Models;

namespace KevinRosero_ExamenFinal.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
	}
    private async void llamarAPI(object sender, EventArgs e)
    {
        PerroAPI resp;
        resp = await App.API.GetPerros();
        try
        {
            Uri imageurl = new Uri(resp.message);
            imgperro.Source = ImageSource.FromUri(imageurl);
        }
        catch (Exception)
        {
            await Application.Current.MainPage.DisplayAlert("Alerta", "No se logró contactar a la API", "OK");
        }
    }
}