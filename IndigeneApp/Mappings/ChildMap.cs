using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using System.Threading.Tasks;
using IndigeneApp.Models;

namespace IndigeneApp.Mappings
{
    class ChildMap : ClassMap<Child>
    {
        public ChildMap() {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Age);
            References(x => x.Parent);
        }
    }
}
