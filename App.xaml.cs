using KevinRosero_ExamenFinal.Data;
namespace KevinRosero_ExamenFinal;

public partial class App : Application
{
    public static PerroDataBaseKR PerroRepoKR { get; private set; }
    public App(PerroDataBaseKR repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
        PerroRepoKR = repo;
    }
}
