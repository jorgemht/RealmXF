namespace RealmXF.Views
{
    using RealmXF.Services.Film;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            DependencyService.Get<IFilmService>().GetAll();
        }
    }
}