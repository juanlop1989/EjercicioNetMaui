namespace PagesQ22024.Tabbed;

public partial class Pestana2 : ContentPage
{
    public Pestana2()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (validarCampos())
            {
                double multiplicacion = double.Parse(txtN1.Text) * double.Parse(txtN1.Text);
                txtResultado.Text = $"El área del cuadrado es: {multiplicacion}";
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