namespace SegundoProyectoMAUI.Pages;

public partial class QuintaPage : ContentPage
{
	public QuintaPage()
	{
		InitializeComponent();
	}
	public void OnBotonClic(object sender, EventArgs e)
	{
		if(video.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            video.Pause(); 
		else
			video.Play();
		//video.Stop();
		//video.Position
		//video.Volume
		
    }
}