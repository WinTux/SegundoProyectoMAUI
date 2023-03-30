using System.Timers;

namespace SegundoProyectoMAUI.Pages;

public partial class SegundaPage : ContentPage
{
	public SegundaPage()
	{
		InitializeComponent();
		var temporizador = new System.Timers.Timer(1000);
		temporizador.Elapsed += new ElapsedEventHandler(RedibujarReloj);
		temporizador.Start();
	}

	public void RedibujarReloj(object sender, ElapsedEventArgs e) {
		var graficosView = this.relojGraphicsView;//Nombre que viene de la vista xaml
		graficosView.Invalidate();
	}
}