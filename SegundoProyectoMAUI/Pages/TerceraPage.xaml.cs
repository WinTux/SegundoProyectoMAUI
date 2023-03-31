using CommunityToolkit.Maui.Core;

namespace SegundoProyectoMAUI.Pages;

public partial class TerceraPage : ContentPage
{
	public TerceraPage()
	{
		InitializeComponent();
	}
	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e) {
		var stream = await lienzo.GetImageStream(250,250);
		Dispatcher.Dispatch(() => {
			imagen.Source = ImageSource.FromStream(()=> stream);
		});
	}
}