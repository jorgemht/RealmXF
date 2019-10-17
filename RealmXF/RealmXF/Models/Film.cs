namespace RealmXF.Models
{
    using Realms;

    public class Film : RealmObject
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public double Ranting { get; set; }
        public double ReleaseYear { get; set; }
    }
}
