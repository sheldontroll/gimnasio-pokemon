using gimnasio_pokemon.Models;
using Microsoft.EntityFrameworkCore;

namespace gimnasio_pokemon.Data
{
    public class CentrosContext : DbContext
    {
        public DbSet<Centro> Centros { get; set; }


        public CentrosContext(DbContextOptions dco) : base(dco){

        }
    }
}