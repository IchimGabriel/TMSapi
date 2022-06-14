using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Auditing
{
    internal class AuditService
    {
        private readonly ApplicationDbContext _context;

        public AuditService(ApplicationDbContext context) => _context = context;

        public async Task<List<AuditDto>> GetUserTrailsAsync(Guid userId)
        {
            var trails = await _context.AuditTrails
                .Where(a => a.UserId == userId)
                .OrderByDescending(a => a.DateTime)
                .Take(250)
                .ToListAsync();

            return trails.Adapt<List<AuditDto>>();
        }
    }
}
