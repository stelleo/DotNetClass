using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Resume.Models
{
    public class ResumeContext : DbContext
    {
        public ResumeContext (DbContextOptions<ResumeContext> options)
            : base(options)
        {
        }

        public DbSet<Resume.Models.ResumeMain> ResumeMain { get; set; }
    }
}
