using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndigeneApp.Models;
namespace IndigeneApp
{
    public class ValidationHelper
    {
        private Object appModel;
        public ValidationHelper(Object appModel) {
            this.appModel = appModel;
        }

        public Boolean IsValid {
            get {
                return (this.objectValidation().Count == 0) ? true : false;
            }
        }

        public String Message() {
            var emptyFields = this.objectValidation();
            String fieldString = (emptyFields.Count > 1) ? "following fields" : "field";
            String areString = (emptyFields.Count > 1) ? "are" : "is";
            String themString = (emptyFields.Count > 1) ? "them" : "it";
            String message = "";
            if (emptyFields.Count > 0) {
                String messageformat = "The {0}: {1} {2} empty, please fill {3} and then re-submit";
                String fields = "";
                foreach (String field in emptyFields) {
                    fields += (field + " , ");
                }

                StringBuilder sb = new StringBuilder(fields);
                sb[fields.LastIndexOf(",")] = ' ';
                fields = sb.ToString();
                if (emptyFields.Count > 1) {
                    sb[fields.LastIndexOf(",")] = '&';
                    fields = sb.ToString();
                }

                message = String.Format(messageformat, fieldString, fields.Trim(), areString, themString);
            }
            return message;
        }


        private List<String> objectValidation() {
            var props = appModel.GetType().GetProperties();
            List<String> emptyProperties = new List<string>();
            foreach (var prop in props) {
                if (prop.CustomAttributes.Count() > 0) {
                    var customAttribute = prop.CustomAttributes.ElementAt(0);
                    if (customAttribute.AttributeType == typeof(ValidationAttribute)) {
                        var value = prop.GetValue(appModel);
                        if (value == null || value == "") {
                            emptyProperties.Add(customAttribute.ConstructorArguments
                                .ElementAt(0).Value.ToString());
                        }
                    }
                }
            }
            return emptyProperties;
        }
    }
}
