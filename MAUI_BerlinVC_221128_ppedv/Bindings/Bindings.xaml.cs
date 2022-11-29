namespace MAUI_BerlinVC_221128_ppedv.Bindings;

public partial class Bindings : ContentPage
{
	public Bindings()
	{
		InitializeComponent();
	}

    private async void Btn_Show_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Person", (Stl_DataBinding.BindingContext as Person).Name, "ok");
    }

    private void Btn_Altern_Clicked(object sender, EventArgs e)
    {
        (Stl_DataBinding.BindingContext as Person).Alter++;
    }

    private void Btn_Neu_Clicked(object sender, EventArgs e)
    {
        (Stl_DataBinding.BindingContext as Person).WichtigeTage.Add(new DateTime(2000,1,1));
    }
}