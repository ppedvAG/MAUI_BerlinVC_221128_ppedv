namespace MAUI_BerlinVC_221128_ppedv.Navi;

public partial class NavPageBsp : ContentPage
{
	public NavPageBsp()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Bindings.Bindings());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Layouts());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Page page = new McSubscriberPage();

        MessagingCenter.Send(this, "nachricht", "HALLO");

        Navigation.PushModalAsync(page);
    }
}