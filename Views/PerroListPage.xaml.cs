using KevinRosero_ExamenFinal.Models;

namespace KevinRosero_ExamenFinal.Views;

public partial class PerroListPage : ContentPage
{
    Perro selected;
    public PerroListPage()
	{
		InitializeComponent();
	}
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PerroItemPage));
    }

    private void ActualizarDatos(object sender, EventArgs e)
    {
        perrosListKR.ItemsSource = App.PerroRepoKR.GetAllPerros();
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as Perro;
        await Navigation.PushAsync(new PerroItemPage
        {
            auxKR = selected,
            BindingContext = selected,
        });
    }

    private static List<Perro> UpdateList()
    {
        List<Perro> perros = App.PerroRepoKR.GetAllPerros();
        return perros;
    }
}