using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Usuarios
{
    public class PerfilesServices
    {
        private readonly Context _context;

        public PerfilesServices(Context context)
        {
            _context = context;
        }

        public async Task<List<Perfil>> GetPerfilesAsync()
        {
            return await _context.Perfiles.ToListAsync();
        }

        public async Task<bool> CrearPerfil(Perfil perfil)
        {
            _context.Perfiles.Add(perfil);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
