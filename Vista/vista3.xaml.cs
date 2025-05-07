namespace bguallasaminExamen.Vista;

public partial class vista3 : ContentPage
{
	public vista3(string usuario,
		string nombre,
		string apellido,
		string va,
		string fecha,
		string ciudad,
		string monto_inicial,
		string cuota_mensual)
	{
		InitializeComponent();
		lblUsuario.Text = usuario;
		lblNombre.Text = nombre;
		lblApellido.Text = apellido;
		lblVa.Text = va;
		lblFecha.Text = fecha;
		lblCiudad.Text = ciudad;
		lblMontoInicial.Text = monto_inicial;
		lblCuotaMensual.Text = cuota_mensual;
		double pagoTotal = double.Parse(cuota_mensual) * 3;
		lblPagoTotal.Text = pagoTotal.ToString("0.00");

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Vista.vista1());
    }
}