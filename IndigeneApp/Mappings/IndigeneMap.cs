using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using IndigeneApp.Models;

namespace IndigeneApp.Mappings
{
    class IndigeneMap : ClassMap<Indigene>
    {
        public IndigeneMap() {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.OtherNames);
            Map(x => x.MaritalStatus);
            Map(x => x.Sex);
            Map(x => x.PhoneNumber);
            Map(x => x.Occupation);
            Map(x => x.PlaceOfResidence);
            Map(x => x.Village);
            Map(x => x.Comments);
            Map(x => x.DateOfBirth);
            Map(x => x.NameOfParents);
            HasMany(x => x.Children).Cascade.Delete();
        }
    }
}
