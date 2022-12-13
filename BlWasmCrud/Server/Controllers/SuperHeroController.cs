using BlWasmCrud.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlWasmCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<comic> comics= new List<comic> {
            new comic{
                ComicId=1,ComicName="aa",
            },
            new comic{
                ComicId=2,ComicName="bb",
            } 
        };

        public static List<SuperHero> superheroes = new List<SuperHero> {
            new SuperHero{ 
                Id=1,
                firstname="arshad",
                lastname="I",
                Heroname="superman",
                Comic=comics[0]
            },
            new SuperHero{
                Id=2,
                firstname="abi",
                lastname="I",
                 Heroname="batman",
                Comic=comics[1]
        } 
        };


        [HttpGet("")]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return superheroes;
        }


        [HttpGet("")]
        public async Task<ActionResult<List<comic>>> GetComics()
        {
            return comics;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSuperHero(int id)
        {
            /*Passes the get id as a parameter*/ 
            var hero = superheroes.FirstOrDefault(h=>h.Id==id);
            if(hero==null)
            {
                return NotFound("Sorry,No hero Found");
            }
            return Ok(hero);
        }


    }
}
