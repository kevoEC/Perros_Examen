using KevinRosero_ExamenFinal.Models;
using System.Xml.Linq;

namespace KevinRosero_ExamenFinal.Views;
[QueryProperty(nameof(auxKR), "Aux")]
public partial class PerroItemPage : ContentPage
{
    Perro Item = new Perro();
    Perro Aux = new Perro();
    bool _flag;
    public PerroItemPage()
	{
		InitializeComponent();
	}
    public Perro auxKR
    {
        get => Aux;
        set
        {
            Aux = value;
        }
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        Item = Aux;
        Item.Name_KevinR = name.Text;
        Item.Raza_KevinR = raza.Text;
        Item.Edad_KevinR = edad.Text;
        Item.Esta_Vacunado = _flag;

        if (string.IsNullOrEmpty(Item.Name_KevinR) || string.IsNullOrEmpty(Item.Raza_KevinR) || string.IsNullOrEmpty(Item.Edad_KevinR))
        {
            return;
        }
        App.PerroRepoKR.AddNewPerro(Item);
        await Shell.Current.GoToAsync("..");
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    async void DeletedClicked(object sender, EventArgs e)
    {
        Item = Aux;
        App.PerroRepoKR.RemovePerro(Item);
        await Shell.Current.GoToAsync("..");
    }
}