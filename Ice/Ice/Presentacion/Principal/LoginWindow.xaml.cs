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
using MaterialDesignThemes.Wpf;
using Ice.Servicios.Seguridad;

namespace Ice.Presentacion.Principal
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        /// <summary>
        /// Indica si está aplicado el tema oscuro.
        /// </summary>
        public bool IsDarkTheme { get; set; }

        /// <summary>
        /// Ayudante para la paleta de color.
        /// </summary>
        public static PaletteHelper paletteHelper;

        /// <summary>
        /// Proveedor de servicio para los usuarios.
        /// </summary>
        private readonly UsuarioService usuarioService;

        public LoginWindow()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            paletteHelper = new PaletteHelper();
        }

        private void ToggleButtonDarkMode_Click(object sender, RoutedEventArgs e)
        {
            AplicarTema();
        }

        private void AplicarTema()
        {
            ITheme theme = paletteHelper.GetTheme();

            IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark;

            if (IsDarkTheme)
            {
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                theme.SetBaseTheme(Theme.Dark);
            }

            paletteHelper.SetTheme(theme);
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void ButtonIngresar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = TxtBoxUsuario.Text;
            string clave = PasswordBoxUsuario.Password;

            try
            {
                usuarioService.Login(nombre, clave);

                if (usuarioService.HasError())
                {
                    MessageBox.Show(this, usuarioService.GetErrorMessage(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                MainWindow mainWindow = new MainWindow();

                Application.Current.MainWindow = mainWindow;

                mainWindow.Show();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
