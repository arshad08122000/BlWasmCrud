using BlWasmCrud.Shared;

namespace BlWasmCrud.Client.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        public List<SuperHero> heroes { get; set; }
        public List<comic> comics { get; set; }

        public Task GetComics()
        {
            throw new NotImplementedException();
        }

        public Task<SuperHero> GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetSuperHeroes()
        {
            throw new NotImplementedException();
        }
    }
}
