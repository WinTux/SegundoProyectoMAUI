using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls.Maps;
using System.Diagnostics;

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

	//Event handler para clic en el mapa
	async void OnMapaClic(object sender, MapClickedEventArgs e) {
		Debug.WriteLine($"[MapClicked] {e.Location.Latitude} {e.Location.Longitude}");
		Polygon recuadro = new Polygon {
			StrokeWidth = 8,
			StrokeColor = Color.FromArgb("#00AADD"),
			FillColor = Color.FromArgb("#8800AADD"),
			Geopath = { 
				new Location(-16.500872902488986, -68.13283585711244),
                new Location(-16.50102849289487, -68.13270040555715),
                new Location(-16.50114036360522, -68.13283719821695),
                new Location(-16.500975772192856, -68.13296057983167)
            }
        };
		mimapa.MapElements.Add(recuadro);

		Polyline polyline = new Polyline {
            StrokeWidth = 18,
            StrokeColor = Color.FromArgb("#00AADD"),
            Geopath = {
                new Location(-16.501049066827807, -68.1322980742047),
                 new Location(-16.50102977876982, -68.13351311488884),
                  new Location(-16.50149783510087, -68.13287206693407)
            }
        };
        mimapa.MapElements.Add(polyline);

		Circle circulo = new Circle {
			Center = new Location(-16.50422255954157, -68.1311709570947),
			Radius = new Distance(200),
			StrokeColor = Color.FromArgb("#AAAA11"),
			StrokeWidth = 15,
			FillColor = Color.FromArgb("#99AAAA11")
        };
		mimapa.MapElements.Add(circulo);
    }
}