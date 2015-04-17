using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Ria2015_Grupo2_Laboratorio1.Vistas
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void ButtomAgregar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Agregar imagén");
        }

        private void ButtomCargar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cargar imagén");
            OpenFileDialog dialogo = new OpenFileDialog();

            dialogo.Multiselect = false;
            dialogo.Filter = "jpg (*.jpg)|*.jpg";
            dialogo.FilterIndex = 1;
            dialogo.InitialDirectory = "C:\\Users\\Marcelo\\Desktop\\fing.tecnoinf.cursos.ria";
            bool? userClickedOK = dialogo.ShowDialog();
 
            if (userClickedOK == true)
            {
                System.IO.Stream archivo = dialogo.File.OpenRead();
                BitmapImage bi = new BitmapImage();
                bi.SetSource(archivo);
                ImageCargar.Source = bi;
                archivo.Close();
            }
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
