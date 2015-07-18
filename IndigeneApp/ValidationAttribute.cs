using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndigeneApp
{
    [System.AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Property,
                       AllowMultiple = true)  // multiuse attribute
]
    public class ValidationAttribute : System.Attribute
    {
        public String AttributeName;
        public ValidationAttribute(String attributName){
            this.AttributeName = attributName;
        }
    }
}
