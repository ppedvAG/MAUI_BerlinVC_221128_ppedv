namespace MAUI_BerlinVC_221128_ppedv;

public partial class Controls : ContentPage
{
	public Controls()
	{
		InitializeComponent();		
	}

    //Eventhandler des Button.Clicked-Event
    private void Button_Clicked(object sender, EventArgs e)
    {
        //Verwendung des sender-Parameters (enthält Event-auslösendes Objekt; hier Button)
        (sender as Button).Text = "Clicked";
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Lbl_Output.Text = Sdr_Value.Value.ToString();
    }
}