namespace bguallasaminExamen.Vista;

public partial class vista2 : ContentPage
{
	public vista2(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO\n" + usuario;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vista.vista1());
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double monto = double.Parse(txtMonto.Text);
        double saldoInicial = (100 * monto)/15;
        double cuota = (saldoInicial/3)+(saldoInicial*0.05);
        lblCuota.Text = cuota.ToString("0.00");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vista.vista3(lblUsuario.Text,
            txtNombre.Text,
            txtApellido.Text,
            pickVoltaje.SelectedItem.ToString(),
            pickFecha.Date.ToString("yyyy-MM-dd"),
            pickCiudad.SelectedItem.ToString(),
            txtMonto.Text,
            lblCuota.Text));
    }
}