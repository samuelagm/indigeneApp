using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using IndigeneApp.Models;

namespace IndigeneApp.Mappings
{
    public class AccountMap : ClassMap<Account>
    {
        public AccountMap() {
            Id(x => x.Id);
            Map(x => x.AccountName);
            Map(x => x.Password);
        }
    }
}
