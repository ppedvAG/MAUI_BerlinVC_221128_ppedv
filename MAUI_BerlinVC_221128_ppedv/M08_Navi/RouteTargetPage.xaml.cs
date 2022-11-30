namespace MAUI_BerlinVC_221128_ppedv.Navi;

//Diese Page erwartet bei einer Navigation zu ihr ein Item, welches dann in die
//Eigenschaft Item1 gelegt wird (vgl. RoutingBsp.xaml.cs)
[QueryProperty(nameof(Item1), "RouteItem1")]
public partial class RouteTargetPage : ContentPage
{
	public string Item1 { set => Lbl_Show.Text = value; }

	public RouteTargetPage()
	{
		InitializeComponent();
	}
}