using KevinRosero_ExamenFinal.Data;
using KevinRosero_ExamenFinal.Service;

namespace KevinRosero_ExamenFinal;

public partial class App : Application
{
    public static PerroDataBaseKR PerroRepoKR { get; private set; }
    public static PerrosCall API { get; private set; }  
    public App(PerroDataBaseKR repo, PerrosCall api)
	{
		InitializeComponent();

		MainPage = new AppShell();
        PerroRepoKR = repo;
        API = api;
    }
}
