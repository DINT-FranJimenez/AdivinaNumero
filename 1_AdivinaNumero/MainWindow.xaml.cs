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

namespace _1_AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Random aletorio = new Random();
        private static int num = aletorio.Next(0,101);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            if (num == Convert.ToInt32(resultadoTextBox.Text))
                respuestaTextBlock.Text = "Lo has adivinado!";
            else if (Convert.ToInt32(resultadoTextBox.Text) > num)
                respuestaTextBlock.Text = "Te has pasado de largo";
            else if (Convert.ToInt32(resultadoTextBox.Text) < num)
                respuestaTextBlock.Text = "Te has quedado corto";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBox.Text = "";
            num = aletorio.Next(0, 101);
        }
    }
}
