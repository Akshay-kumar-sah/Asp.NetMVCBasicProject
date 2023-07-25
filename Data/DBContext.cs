using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data
{
    public class DBContext :DbContext
    {
       public DBContext(DbContextOptions<DBContext>options):base(options)
       {

       }

       public DbSet<BookModel>Books {get;set;}
       
      

    }
}