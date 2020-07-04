using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class MyWorkerContext:DbContext
    {
        public MyWorkerContext(DbContextOptions<MyWorkerContext>options):base(options)
        {

        }

        public DbSet<Worker> MyWorkers { get; set; }
    }
}
