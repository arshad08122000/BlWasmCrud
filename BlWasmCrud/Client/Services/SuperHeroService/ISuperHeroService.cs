using BlWasmCrud.Shared;

namespace BlWasmCrud.Client.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        public List<SuperHero> heroes { get; set; }
        public List<comic> comics { get; set; }

        Task GetComics();
        Task GetSuperHeroes();

        Task<SuperHero> GetSingleHero(int id); 
    }
}
