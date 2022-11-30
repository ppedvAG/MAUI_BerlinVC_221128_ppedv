namespace MAUI_BerlinVC_221128_ppedv.Navi;

public partial class RoutingBsp : ContentPage
{
	public RoutingBsp()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//layouts");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//navi/routeTarget?RouteItem1={Ety_ItemToSend.Text}");
    }
}