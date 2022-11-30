namespace MAUI_BerlinVC_221128_ppedv.Plattformspezifika;

public partial class Plattformspezfika : ContentPage
{
	public Plattformspezfika()
	{
		InitializeComponent();

		Lbl_DeviceInfo.Text = DeviceInfo.Idiom.ToString();

		if (DeviceInfo.Platform == DevicePlatform.Android)
			Lbl_DeviceInfo.BackgroundColor = Colors.Red;
        else
            Lbl_DeviceInfo.BackgroundColor = Colors.Green;

		Lbl_Orientation.Text = new DeviceOrientationService().GetOrientation().ToString();
    }
}