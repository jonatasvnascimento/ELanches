using ELanches.Context;
using ELanches.Models;
using ELanches.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ELanches.Repositories
{
    public class LanchesRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;
        public LanchesRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(c => c.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lanchesId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lanchesId);
        }
    }
}
