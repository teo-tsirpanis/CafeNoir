using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeNoir.Core {

    public class Employee {


        public Guid ID { get; set; } = Guid.NewGuid();
        public string Name { get; set; }    
        public string Surname { get; set; }

        public EmployeeType EmployeeType { get; set; }

        public int SallaryPerMonth { get; set; }

        public Employee() {

        }
    }
}
