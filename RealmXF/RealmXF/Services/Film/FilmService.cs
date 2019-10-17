namespace RealmXF.Services.Film
{
    using Realms;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class FilmService : IFilmService
    {
        Realm realm;

        public FilmService()
        {
            realm = Realm.GetInstance();
        }

        public async Task<List<Models.Film>> GetAll(bool update = false)
        {
            if (update)
            {
                await Task.Delay(10);
            }
           
            return realm.All<Models.Film>().ToList();
        }

        public Task<Models.Film> Add()
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Film> Update()
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Film> Remove()
        {
            throw new System.NotImplementedException();
        }
    }
}
