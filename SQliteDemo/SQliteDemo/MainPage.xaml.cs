using SQliteDemo.DataContext;
using SQliteDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQliteDemo
{
    public partial class MainPage : ContentPage
    {
        private readonly AppDbContext _context;
        public MainPage()
        {
            InitializeComponent();
            _context = App.GetContext();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //El ORM
                //Insert Artistas Values ("Hugo")
                _context.Artistas.Add(new Artista
                {
                    Nombre = txtNombre.Text
                });
                _context.SaveChanges();

                 DisplayAlert("Alert", "Exitoso", "OK");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

            //El ORM
            // Select  * from artistas
            this.lvArtistas.ItemsSource = _context.Artistas.ToList();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            this.lvArtistasFiltrado.ItemsSource = _context.Artistas.
                Where(x => x.Nombre.Contains(txtFiltro.Text.Trim()));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {

                List<Artista> artistas = new List<Artista>();
                artistas.Add( new Artista { Nombre=txtNombre.Text});
                artistas.Add(new Artista { Nombre = txtNombre2.Text });
                artistas.Add(new Artista { Nombre = txtNombre3.Text });

                _context.AddRange(artistas);
                _context.SaveChanges();

                DisplayAlert("Alert", "Exitoso", "OK");
            }
            catch (Exception)
            {

                throw;
            }

          
        }
    }
}
