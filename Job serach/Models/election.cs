using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Job_serach.Models
{
    public class election
    {
        [Key]public int  ElectionID { get; set;}
        public string ElectionType { get; set; }
 
    }
}
