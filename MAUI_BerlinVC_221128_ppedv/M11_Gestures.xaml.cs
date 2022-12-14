namespace MAUI_BerlinVC_221128_ppedv;

public partial class Gestures : ContentPage
{
    public Gestures()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Lbl_Main.Text = "TAPPED";
    }

    private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
    {
        Lbl_Main.Text = "SWIPED";
    }

    private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        await DisplayAlert("PAN", "PAN-DETECTED", "ok");
    }

    private async void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        await DisplayAlert("PINCH", "PINCH-DETECTED", "ok");
    }
}