using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class MyService : IService
    {
        string _currentDateTime;
        public MyService()
        {
            this._currentDateTime = DateTime.Now.ToString("MMMM-dd hh.mm.ss.ffffff");
        }
        public void PrintMethod()
        {
            Console.WriteLine("Hello from MyService!");
        }

        public string GetObjectCreationDateTime
        {
            get { return this._currentDateTime; }
        }
    }
}
