using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Ria2015_Grupo2_Laboratorio1
{
    
    public partial class MainPage : UserControl
    {

        
        public MainPage()
        {
            InitializeComponent();
 
        }

        private void ButtomIniciar_Click(object sender, RoutedEventArgs e)
        {
            
            HyperlinkButton LinkButton = sender as HyperlinkButton;

            if (TextBlockUsuario.Text == "Usuario")
            {
                TextBlockUsuario.Text = TextBoxUsuario.Text;
                TextBlockUsuario.FontSize = 15;
                TextBoxUsuario.Visibility = Visibility.Collapsed;
                LinkButton.Content = "Salir";
                LinkButton.Tag = "/Vistas/Page1.xaml";
                
            }
            else
            {
                LinkButton.Content = "Iniciar";
                LinkButton.Tag = "/Vistas/Page2.xaml";
                TextBlockUsuario.FontSize = 10;
                TextBlockUsuario.Text = "Usuario";
                TextBoxUsuario.Visibility = Visibility.Visible;
                TextBoxUsuario.Text = "";
            }

            PageMain.Navigate(new Uri(LinkButton.Tag.ToString(), UriKind.Relative));
           
        }
       
    }
}
