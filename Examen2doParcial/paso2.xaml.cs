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
    /// Lógica de interacción para paso2.xaml
    /// </summary>
    public partial class paso2 : UserControl
    {
        public paso2()
        {
            InitializeComponent();
        }

        private void btnsig2_Click(object sender, RoutedEventArgs e)
        {

            if (txtcorr.Text == "")
            {
                txtexep.Visibility = Visibility.Visible;
            }
            else
            {
                if (txttel.Text == "")
                {
                    txtexep.Visibility = Visibility.Visible;
                }
                else
                {
                    if (txtcel.Text == "")
                    {
                        txtexep.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        panel1.Children.Clear();

                        switch (btnsig2.ClickMode)
                        {
                            case 0:
                                panel1.Children.Add(new paso3());
                                break;
                        }
                    }
                    
                }
            }
        }
    }
}
