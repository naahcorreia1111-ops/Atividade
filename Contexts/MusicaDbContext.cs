using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ativ_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Ativ_MVC.Contexts
{
public class MusicaDbContext(DbContextOptions<MusicaDbContext> options) : DbContext(options)
{
    public DbSet<Musica> Musica {get; set;}



}
}