namespace Clase1;

public partial class N3 : Form
{
    public N3()
    {
        InitializeComponent();
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;

        if (String.IsNullOrEmpty(name))
        {
            MessageBox.Show(
                "Error: Debe Ingresar Un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        MessageBox.Show($"Bienvenido {name} ", "Ingreso Validado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtHistorial.Text = $"Bienvenido {name}";

    }
}