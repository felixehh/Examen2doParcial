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

namespace Examen2doParcial
{
    /// <summary>
    /// Lógica de interacción para paso3.xaml
    /// </summary>
    public partial class paso3 : UserControl
    {
        public paso3()
        {
            InitializeComponent();
        }

        private void btnfin_Click(object sender, RoutedEventArgs e)
        {
            if (txttarjeta.Text == "")
            {
                txtexep3.Visibility = Visibility.Visible;
            }
            else
            {
                if (txtcvv.Text == "")
                {
                    txtexep3.Visibility = Visibility.Visible;
                }
                else
                {
                    if (txtexpr.Text == "")
                    {
                        txtexep3.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (txtaño.Text =="")
                        {
                            txtexep3.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            txtexep3.Visibility = Visibility.Hidden;
                        }
                    }

                }
            }
        }
    }
}
