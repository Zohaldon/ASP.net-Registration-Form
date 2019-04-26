using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RegistrationForm.Models
{
    public class RegistrationFormContext : DbContext
    {
        public RegistrationFormContext (DbContextOptions<RegistrationFormContext> options)
            : base(options)
        {
        }

        public DbSet<RegistrationForm.Models.Member> Member { get; set; }
    }
}
