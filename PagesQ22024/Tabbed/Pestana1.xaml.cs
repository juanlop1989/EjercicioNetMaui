namespace PagesQ22024.Tabbed;

public partial class Pestana1 : ContentPage
{
    public Pestana1()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (validarCampos())
            {
                double multiplicacion = double.Parse(txtN1.Text) * double.Parse(txtN2.Text);
                txtResultado.Text = $"El �rea del Rect�ngulo es: {multiplicacion}";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "Aceptar");
        }
    }

    private bool validarCampos()
    {
        if (txtN1.Text is null || txtN1.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Campo primer n�mero en blanco", "Aceptar");
            return false;
        }
        else if (txtN2.Text is null || txtN2.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Campo segundo n�mero en blanco", "Aceptar");
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
        txtN2.Text = "";
        txtResultado.Text = "";
    }
}