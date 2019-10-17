namespace RealmXF.Services.Film
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IFilmService
    {
        Task<List<Models.Film>> GetAll(bool update = false);

        Task<Models.Film> Add();

        Task<Models.Film> Update();

        Task<Models.Film> Remove();
    }
}
