using SQliteDemo.DataContext;
using SQliteDemo.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQliteDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Crear la base de datos
            GetContext().Database.EnsureCreated();
            MainPage = new MainPage();
        }

        public static AppDbContext GetContext()
        {
            //Dependencia de servicios
            //Nombre del archivo
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
