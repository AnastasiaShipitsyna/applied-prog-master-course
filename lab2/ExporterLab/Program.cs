using Kernel;
using Exporter.Interface;
using Exporter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExporterLab
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var list = new List<IEntity>();
            list.Add(new User {Name="Irina", Surname="Teplova", Age=22});
            list.Add(new User { Name = "Elvira", Surname = "Tretyakov", Age = 22});

            var e = new Kernel.Kernel();
            var exporter = e.Get<IExporter>();

            System.Diagnostics.Process.Start(exporter.Export(list));
        }
    }
}
