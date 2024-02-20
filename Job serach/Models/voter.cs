using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.Contracts;
using System.Numerics;

namespace Job_serach.Models
{
    public class voter
    {
        [Key] public string AADHAAR { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string FatherName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthdayDate { get; set; }
        public int Age { get; set; }
        public string phoneNo{get;set;}

        public virtual Address DistrictID1 { get; set; }
        [ForeignKey("DistrictID1FK")]
        public int DistrictID1FK { get; set; }

  

    }
}
