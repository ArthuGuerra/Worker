using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkerEnum.Models
{
    public class Departament
    {
        public string Name { get; set; }

        public Departament(){}
        public Departament(string name)
        {
            Name = name;
        }
    }
}