using SegundoProyectoMAUI.Pages;
using System.Diagnostics;
using ZXing.Net.Maui;

namespace SegundoProyectoMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        lectorCodigo.Options = new BarcodeReaderOptions() { 
            AutoRotate = true,
            Formats = BarcodeFormat.QrCode,
            TryHarder = true,
            Multiple = false
        };

    }

	async void OnCodigoBarrasDetectado(object sender, BarcodeDetectionEventArgs evento)
	{
		Dispatcher.Dispatch(() =>{
            Debug.WriteLine("Se detectó un código de barras/QR");
            resultadoCodigo.Text = $"{evento.Results[0].Value} {evento.Results[0].Format}";
        });

    }

    async void OnBotonSegundaPageClic(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SegundaPage));
    }
    async void OnBotonTerceraPageClic(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TerceraPage));
    }
}

