namespace MAUI_BerlinVC_221128_ppedv;

public partial class XamlGrundlagen : ContentPage
{
	public XamlGrundlagen()
	{
		InitializeComponent();

		Btn_KlickMich.Text = "Klick mich massiv";
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
		(sender as Button).Text = "Button wurde geklickt";

		if(await DisplayAlert("FRAGE", "Soll was gemacht werden?", "OK", "Abbruch"))
			Lbl_Output.Text = "COOL";
    }
}