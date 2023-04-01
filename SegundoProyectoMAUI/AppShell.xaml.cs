using SegundoProyectoMAUI.Pages;

namespace SegundoProyectoMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SegundaPage), typeof(SegundaPage));
        Routing.RegisterRoute(nameof(TerceraPage), typeof(TerceraPage));
        Routing.RegisterRoute(nameof(CuartaPage), typeof(CuartaPage));
    }
}
