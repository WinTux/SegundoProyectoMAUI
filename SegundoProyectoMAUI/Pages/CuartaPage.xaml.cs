using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls.Maps;

namespace SegundoProyectoMAUI.Pages;

public partial class CuartaPage : ContentPage
{
	public CuartaPage()
	{
		InitializeComponent();
		Location ubicacion = new Location(-16.501742494113223, -68.13289753867922);
		MapSpan mapSpan = new MapSpan(ubicacion, 0.01,0.01);
		mimapa.MoveToRegion(mapSpan);

		//Pin de forma programática
		mimapa.Pins.Add(new Pin { 
			Label = "Pepe está en el Prado",
			Location = new Location(-16.501671433114943, -68.13275397002235)
		});

		//mimapa.MapType = MapType.Satellite;
    }
}