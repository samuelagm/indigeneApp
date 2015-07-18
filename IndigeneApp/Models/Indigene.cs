using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndigeneApp.Models;
using System.Collections.ObjectModel;

namespace IndigeneApp.Models
{
    public class Indigene
    {
        public virtual int Id { get; protected set; }
        [ValidationAttribute("First name")]
        public virtual String FirstName { get; set; }
        [ValidationAttribute("Other names")]
        public virtual String OtherNames { get; set; }
        [ValidationAttribute("Village")]
        public virtual String Village { get; set; }
        [ValidationAttribute("Date of birth")]
        public virtual DateTime DateOfBirth { get; set; }
        [ValidationAttribute("Marital status")]
        public virtual String MaritalStatus { get; set; }
        [ValidationAttribute("Gender")]
        public virtual String Sex { get; set; }
        [ValidationAttribute("Phone number")]
        public virtual String PhoneNumber { get; set; }
        [ValidationAttribute("Occupation")]
        public virtual String Occupation { get; set; }
        [ValidationAttribute("Name of parents")]
        public virtual String NameOfParents { get; set; }
        [ValidationAttribute("Place of residence")]
        public virtual String PlaceOfResidence { get; set; }
        public virtual String Comments { get; set; }
        public virtual String ElligibilityImage {
            get {
                String elligibilityImage = "..\\Media\\appbar.billing.png";
                String inelligibilityImage = "..\\Media\\appbar.checkmark.thick.unchecked.png";
                DateTime now = DateTime.UtcNow;
                int age = now.Year - DateOfBirth.Year;
                if (now.Month < DateOfBirth.Month || (now.Month == DateOfBirth.Month && now.Day < DateOfBirth.Day)) age--;
                String result = (age >= 18) ? elligibilityImage : inelligibilityImage;
                Console.WriteLine(result);
                return result;
            }
        }
        public virtual String Elligibility {
            get {
                DateTime now = DateTime.UtcNow;
                int age = now.Year - DateOfBirth.Year;
                if (now.Month < DateOfBirth.Month || (now.Month == DateOfBirth.Month && now.Day < DateOfBirth.Day)) age--;
                String result = (age >= 18) ? "Elligible" : "Not Elligible";
                return result;
            }
        }

        public virtual String FullName {
            get {
                return this.FirstName + " " + this.OtherNames;
            }
        }

        public virtual int Age {
            get {
                DateTime now = DateTime.UtcNow;
                int age = now.Year - DateOfBirth.Year;
                if (now.Month < DateOfBirth.Month || (now.Month == DateOfBirth.Month && now.Day < DateOfBirth.Day)) age--;
                return age;
            }
        }

        public virtual IList<Child> Children { get; set; }

        public Indigene() {
            this.Children = new List<Child>();
        }

        public virtual void AddChild(Child child) {
            child.Parent = this;
            Children.Add(child);
        }
    }
}
