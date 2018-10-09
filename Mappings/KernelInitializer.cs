using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring.Contract;
using DataStoring.InMemory;
using MM.PersonManagerApp.Data.DataStoring;
using MM.PersonManagerApp.Logic.PersonManagement;
using MM.PersonManagerApp.Logic.PersonManagement.Contract;
using Ninject;

namespace Mappings
{
    public class KernelInitializer
    {
        public void Initialize(IKernel kernel)
        {
            kernel.Bind<IPersonRepository>().To<PersonMemRepository>();
            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IFileStorer>().To<FileStorer>();
        }
    }
}
