using System;
using System.Linq;
using Mappings;
using MM.PersonManagerApp.Logic.PersonManagement;
using MM.PersonManagerApp.Logic.PersonManagement.Contract;
using Ninject;

namespace MM.PersonManagerApp.UI.Consoleclient
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();

            new KernelInitializer().Initialize(kernel);

            var manager = kernel.Get<IPersonManager>();

            var adults = manager.GetAllAdults();
            var children = manager.GetAllChildren();
            var statistic = manager.GetAgeStatistic();

            Console.WriteLine($"### Erwachsene ({statistic.AmountAdults}) ###");
            adults.ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.WriteLine($"\n### Kinder ({statistic.AmountChildren}) ###");
            children.ToList().ForEach(p => Console.WriteLine(p.Name));

            Console.ReadKey();
        }
    }
}
