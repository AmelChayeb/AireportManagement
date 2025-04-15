using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Display(Name ="date of birth")]
        [DataType(DataType.DateTime)]
        //public int PassengerId { get; set; }
        public DateTime BirthDate { get; set; }
        public String  EmailAdress { get; set; }
        [MaxLength(25,ErrorMessage ="longeur maximale est 25")]
        [MinLength(3, ErrorMessage = "longeur minimale est 3")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [Key]
        [StringLength(7)] //seance 2/27 6 seance 

        public String PassportNumber { get; set; }
        public String TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "FirstName=" + this.FirstName + "LastName=" + this.LastName;
        }
        //public bool CheckProfile(String FirstName, String LastName)
        //{
        //    return this.FirstName == FirstName && this.LastName==LastName;
        //}
        //public bool CheckProfile(String FirstName, String LastName, String Email)
        //{
        //    return this.FirstName == FirstName && this.LastName == LastName && this.EmailAdress==Email;
        //}
        public bool CheckProfile(String FirstName, String LastName, String Email=null)
        {
            if (EmailAdress == null) {
                return this.FirstName == FirstName && this.LastName == LastName;
                    }
            else
            {
                return this.FirstName == FirstName && this.LastName == LastName && this.EmailAdress == Email;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'am a passenger");
        }
    }
}
