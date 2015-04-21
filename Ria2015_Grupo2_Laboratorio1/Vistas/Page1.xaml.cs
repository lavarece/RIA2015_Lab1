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
using System.IO;

namespace Ria2015_Grupo2_Laboratorio1.Vistas
{
    public partial class Page1 : Page
    {

        List<Imagenes> ListaImagenes = new List<Imagenes>();

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
            string Mensaje = "¿ Esta seguro de querer agregar esta imagen ?"; 
            MessageBoxResult result = MessageBox.Show( Mensaje, "Confirmar", MessageBoxButton.OKCancel);

            if (result == MessageBoxResult.OK)
            {

                ListadeImagenes.ItemsSource = null;

                Imagenes objImagen = new Imagenes();

                objImagen.titulo = TextBoxTitulo.Text;
                objImagen.descripcion = TextBoxDescripcion.Text;

                ListaImagenes.Add(objImagen);


                ListadeImagenes.ItemsSource = ListaImagenes;

                Uri uriImage = new Uri("../img/carpeta_de_imagenes.jpg", UriKind.Relative);
                BitmapImage objBI = new BitmapImage(uriImage);
                ImageCargar.Source = objBI;
                TextBoxTitulo.Text = "";
                TextBoxDescripcion.Text = "";
            }
   
        }
        private void ButtomCargar_Click(object sender, RoutedEventArgs e)
        {
   
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagenes |*.jpg;*.png";

            if (dialog.ShowDialog() == true)
            {
                using (FileStream fs = dialog.File.OpenRead())
                {
                    BitmapImage img = new BitmapImage();
                    img.SetSource(fs);
                    ImageCargar.Source = img;
                }

                
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
