using MyMVCApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseContext.DataBaseContext
{
    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
