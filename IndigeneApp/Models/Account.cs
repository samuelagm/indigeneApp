using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndigeneApp.Models
{
    public class Account
    {
        public virtual int Id { get; protected set; }
        [ValidationAttribute("Account Name")]
        public virtual String AccountName { get; set; }
        [ValidationAttribute("Password")]
        public virtual String Password { get; set; }
    }
}
