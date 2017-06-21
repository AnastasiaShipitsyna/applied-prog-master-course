using Exporter.Resolver;
using Exporter.Interface;
using Exporter.Entity;
using Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporterLab
{
    class MainProgram
    {
        
        static void Main(string[] args)
        {
            var list = new List<IEntity>();
            list.Add(new Student {Name="Ken", Surname="Rakutube", Age=23});
            list.Add(new Student { Name = "Jenya", Surname = "Tretyakov", Age = 22 });

            var e = new Kernel();
            var exporter = e.Get<IExporter>();

            System.Diagnostics.Process.Start(exporter.Export(list));
        }
    }
}
