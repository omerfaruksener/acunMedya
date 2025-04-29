using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriDogrulama2
{
    public class KisiselVeriler
    {
        [ZorunluAlan("Name field must not be empty")]
        public string name;
        [ZorunluAlan("LastName field must not be empty")]
        public string lastName;
        [ZorunluAlan("Department field must not be empty")]
        public string Department;
    }

}

