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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnsig1_Click(object sender, RoutedEventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtexep2.Visibility = Visibility.Visible;
            }
            else
            {
                if (txtappat.Text == "")
                {
                    txtexep2.Visibility = Visibility.Visible;
                }
                else
                {
                    if (txtapmat.Text == "")
                    {
                        txtexep2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        if (txtedad.Text == "")
                        {
                            txtexep2.Visibility = Visibility.Visible;
                        }
                        else
                        {
                            panel.Children.Clear();

                            switch (btnsig1.ClickMode)
                            {
                                case 0:
                                    panel.Children.Add(new paso2());
                                    break;
                            }
                        }
                    }
                }

            }
        
        }
    }
}
