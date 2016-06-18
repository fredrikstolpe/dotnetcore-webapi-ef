using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // using (var db = new BloggingContext())
            // {
            //     db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //     var count = db.SaveChanges();
            // }
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
