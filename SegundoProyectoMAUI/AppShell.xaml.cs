﻿using SegundoProyectoMAUI.Pages;

namespace SegundoProyectoMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(SegundaPage), typeof(SegundaPage));
	}
}
