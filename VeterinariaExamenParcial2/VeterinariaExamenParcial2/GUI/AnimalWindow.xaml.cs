using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VeterinariaExamenParcial2.Controlador;
using VeterinariaExamenParcial2.Modelo;

namespace VeterinariaExamenParcial2.GUI
{
    /// <summary>
    /// Lógica de interacción para AnimalWindow.xaml
    /// </summary>
    public partial class AnimalWindow : Window
    {
        public AnimalWindow()
        {
            InitializeComponent();
            CargarTipo();
            CargarAnimales();
        }
        public void CargarTipo(){
            string[] categoria = { "Felino", "Canino", "Roedor", "Ave" };
            cmbTipo.ItemsSource = categoria;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AnimalControlador _CAN = new AnimalControlador();
            Animal _animal = new Animal();
            string mensaje;
            _animal.Nombre = txtNombre.Text;
            _animal.Tipo = cmbTipo.SelectedValue.ToString();
            _animal.Precio = float.Parse(txtPrecio.Text);
            mensaje = _CAN.InsertarAnimal(_animal);
            this.MostrarMensaje(mensaje);
        }
        private void MostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
            this.CargarAnimales();
        }
        public void CargarAnimales()
        {
            AnimalControlador _CAN = new AnimalControlador();
            dtgLista.ItemsSource = _CAN.All();
        }
    }
}
