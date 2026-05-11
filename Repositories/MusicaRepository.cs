using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ativ_MVC.Contexts;
using Ativ_MVC.Models;

namespace Ativ_MVC.Repositories
{
    public class MusicaRepository
    {
        
        private readonly MusicaDbContext _context;

        public MusicaRepository(MusicaDbContext context)
        {
            _context = context;

        }

   public List<Musica>ObterMusica()
        { 
            return _context.Musica.ToList();
            
        }


    }
}