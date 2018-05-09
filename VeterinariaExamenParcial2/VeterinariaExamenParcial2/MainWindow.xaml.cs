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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VeterinariaExamenParcial2.Controlador;
using VeterinariaExamenParcial2.GUI;
using VeterinariaExamenParcial2.Modelo;

namespace VeterinariaExamenParcial2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            AnimalWindow obAW = new AnimalWindow();
            obAW.Show();
            //this.Close();
        }

        private void btnInicio_Click_1(object sender, RoutedEventArgs e)
        {
            Usuario _usuario = new Usuario();
            UsuarioControlador _ctUsuario = new UsuarioControlador();
            _usuario.username = txtUserName.Text;
            _usuario.contrasenia = pwtPassword.Password;
            if (_ctUsuario.auntenticarUsuario(_usuario) == true)
            {
                AnimalWindow _WAW = new AnimalWindow();
                _WAW.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usario o Contraseña invalida", "Error");
            }
        }
    }
}
