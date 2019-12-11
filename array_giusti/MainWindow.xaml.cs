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

namespace array_giusti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i;
            int numero = int.Parse(txtnumero.Text);
            
            if (numero < 0)
            {
                MessageBox.Show("IL NUMERO DEVE ESSERE MAGGIORE DI 0 NABBONE", "IMPOSSIBILE", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                int[] array = new int[numero];
                for (i = 0;i < array.Length;i++)
                {
                    array[i] = random.Next(1, 9);
                }
                lblrisultato.Content = "";
            }
        }
    }
}
