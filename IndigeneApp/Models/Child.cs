using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndigeneApp.Models
{
    public class Child
    {
        public virtual int Id { get; protected set; }
        public virtual String Name { get; set; }
        public virtual int Age { get; set; }
        public virtual Indigene Parent { get; set; }
    }
}
