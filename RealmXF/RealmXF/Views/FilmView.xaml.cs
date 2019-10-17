namespace RealmXF.Views
{
    using RealmXF.ViewModels;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmView : ContentPage
    {
        public FilmView()
        {
            InitializeComponent();

            BindingContext = new FilmViewModel();
        }
    }
}