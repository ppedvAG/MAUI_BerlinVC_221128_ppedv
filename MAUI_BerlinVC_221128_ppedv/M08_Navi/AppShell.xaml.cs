namespace MAUI_BerlinVC_221128_ppedv.Navi;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        //Manuelle Routen-Registrierung
        Routing.RegisterRoute("navi/routeTarget", typeof(RouteTargetPage));
    }
}