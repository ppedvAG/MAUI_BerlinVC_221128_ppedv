namespace MAUI_BerlinVC_221128_ppedv.Navi;

[QueryProperty(nameof(Item1), "RouteItem1")]
public partial class RouteTargetPage : ContentPage
{
	public string Item1 { set => Lbl_Show.Text = value; }

	public RouteTargetPage()
	{
		InitializeComponent();
	}
}