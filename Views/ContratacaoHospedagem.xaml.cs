namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        pck_quarto.Items.Add("Suíte Lua Crescente");
        pck_quarto.Items.Add("Suíte Arcana");
        pck_quarto.Items.Add("Suíte Eclipse");
        pck_quarto.Items.Add("Suíte Nebulosa");
        pck_quarto.Items.Add("Suíte Noite Eterna");
    }

    private async void btn_avancar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}