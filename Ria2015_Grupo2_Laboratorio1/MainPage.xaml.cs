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

            LinkButton.Content = "Salir";
            TextBlockUsuario.Text = "Hola " + TextBoxUsuario.Text;
            PageMain.Navigate(new Uri(LinkButton.Tag.ToString(), UriKind.Relative));

        }
       
    }
}
