using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hf.Web.Controllers
{
    public class SchoolController : Controller
    {
        public ActionResult Index()
        {
            var context = new HfContext();
            var exists = context.Database.Exists();


            //var companies = context.Schools;
            //foreach (var company in companies)
            //{
            //    Console.WriteLine("Company: {0} {1}",
            //        company.Id, company.Name);
            //}
            //Console.ReadKey();


            return View();
        }
    }

    [Database(Name = "HF")]
    public class HfContext : DbContext
    {
        public HfContext() : base("name=HfDbConnection") { }
        public DbSet<School> Schools { get; set; }
    }

    [Table(Name = "data_school")]
    public class School
    {
        [Column(Name = "id")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(Name = "name")]
        public int Name { get; set; }
    }
}