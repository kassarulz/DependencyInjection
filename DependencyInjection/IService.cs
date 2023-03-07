using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IService
    {
        public void PrintMethod();
        public string GetObjectCreationDateTime { get; }
    }
}
