using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Job_serach.Models
{
    public class user_type
    {
     [Key] public int    UserTypeID { get;set; }
        public string  UserType { get; set; }
  
    }
}
