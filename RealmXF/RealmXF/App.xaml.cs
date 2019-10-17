using RealmXF.Services.Film;
using RealmXF.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RealmXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ServiceDependency();

            MainPage = new MainView();
        }

        private void ServiceDependency()
        {
            DependencyService.Register<IFilmService, FilmService>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
