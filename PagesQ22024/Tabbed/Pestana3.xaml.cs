namespace PagesQ22024.Tabbed;

public partial class Pestana3 : ContentPage
{
    double Pi=3.14159;
    public Pestana3()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (validarCampos())
            {

                double areaCirculo = Pi *( Math.Pow(double.Parse(txtN1.Text),2));
                txtResultado.Text = $"El área del círculo es: {areaCirculo}";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "Aceptar");
        }
    }

    private bool validarCampos()
    {
        if (txtN1.Text is null)
        {
            DisplayAlert("ADVERTENCIA", "Campo del número está en blanco", "Aceptar");
            return false;
        }

        else
        {
            return true;
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtN1.Text = "";
        //txtN2.Text = "";
        txtResultado.Text = "";
    }
}