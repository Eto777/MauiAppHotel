namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        // Adiciona as suítes ao Picker

        pck_quarto.Items.Add("Suíte Lua Crescente");
        pck_quarto.Items.Add("Suíte Arcana");
        pck_quarto.Items.Add("Suíte Eclipse");
        pck_quarto.Items.Add("Suíte Nebulosa");
        pck_quarto.Items.Add("Suíte Noite Eterna");
    }


    // Botão avançar

    private async void btn_avancar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }


    // =========================
    // CONTROLE DE ADULTOS
    // =========================

    void MaisAdultos(object sender, EventArgs e)
    {
        // Máximo: 10

        if (stpAdultos.Value < 10)
        {
            stpAdultos.Value++;

            lblAdultos.Text =
                stpAdultos.Value.ToString();
        }
    }

    void MenosAdultos(object sender, EventArgs e)
    {
        // Mínimo: 0

        if (stpAdultos.Value > 0)
        {
            stpAdultos.Value--;

            lblAdultos.Text =
                stpAdultos.Value.ToString();
        }
    }


    // =========================
    // CONTROLE DE CRIANÇAS
    // =========================

    void MaisCriancas(object sender, EventArgs e)
    {
        // Máximo: 10

        if (stpCriancas.Value < 10)
        {
            stpCriancas.Value++;

            lblCriancas.Text =
                stpCriancas.Value.ToString();
        }
    }

    void MenosCriancas(object sender, EventArgs e)
    {
        // Mínimo: 0

        if (stpCriancas.Value > 0)
        {
            stpCriancas.Value--;

            lblCriancas.Text =
                stpCriancas.Value.ToString();
        }
    }


    // =========================
    // SUÍTES
    // =========================

    void pck_quarto_SelectedIndexChanged(object sender, EventArgs e)
    {
        boxSuite.IsVisible = true;

        imgSuite.IsVisible = true;
        lblDescricaoSuite.IsVisible = true;

        switch (pck_quarto.SelectedItem?.ToString())
        {
            case "Suíte Lua Crescente":

                imgSuite.Source = "lc.png";

                lblDescricaoSuite.Text =
                "Inspirada na suavidade da lua. Um refúgio acolhedor com noites tranquilas e iluminação suave.";

                break;


            case "Suíte Arcana":

                imgSuite.Source = "a.png";

                lblDescricaoSuite.Text =
                "Misteriosa e elegante. Ideal para quem ama magia, encanto e sofisticação.";

                break;


            case "Suíte Eclipse":

                imgSuite.Source = "e.png";

                lblDescricaoSuite.Text =
                "Luxo envolto em sombras, charme noturno e atmosfera única.";

                break;


            case "Suíte Nebulosa":

                imgSuite.Source = "n.png";

                lblDescricaoSuite.Text =
                "Uma experiência cósmica cercada por estrelas e conforto.";

                break;


            case "Suíte Noite Eterna":

                imgSuite.Source = "ne.png";

                lblDescricaoSuite.Text =
                "Elegância e conforto absoluto para noites inesquecíveis.";

                break;
        }
    }
}