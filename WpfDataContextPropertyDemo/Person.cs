using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataContextPropertyDemo
{
    class Person
    {
        public string FirstName { set; get; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
