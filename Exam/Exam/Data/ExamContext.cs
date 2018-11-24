using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exam.Models;

namespace Exam.Models
{
    public class ExamContext : DbContext
    {
        public ExamContext (DbContextOptions<ExamContext> options)
            : base(options)
        {
        }

        public DbSet<Exam.Models.Product> Product { get; set; }

        public DbSet<Exam.Models.Category> Category { get; set; }
    }
}
