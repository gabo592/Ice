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

namespace Ice.Presentacion.Principal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsDarkMode { get; set; }

        private readonly PaletteHelper paletteHelper;

        private ITheme theme;

        public MainWindow()
        {
            InitializeComponent();
            paletteHelper = new PaletteHelper();
            theme = LoginWindow.paletteHelper.GetTheme();
            IsDarkMode = theme.GetBaseTheme() == BaseTheme.Dark;
            ToggleButtonDarkMode.IsChecked = IsDarkMode;
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void ButtonMaximizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Maximized;
        }

        private void ButtonRestaurar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
        }

        private void ButtonMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ToggleButtonDarkMode_Click(object sender, RoutedEventArgs e)
        {
            theme = paletteHelper.GetTheme();

            IsDarkMode = theme.GetBaseTheme() == BaseTheme.Dark;

            if (IsDarkMode)
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
    }
}
