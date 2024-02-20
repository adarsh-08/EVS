using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Job_serach.Models
{
    public class user
    {
        [Key]public string VoterID { get; set; }
        public string  Def_Password { get; set; }
        public Boolean isActive { get; set; }
        public string AADHAAR { get; set; }
        public virtual voter voter2{ get; set; }

        [ForeignKey("voter2FK")]
        public int voter2FK { get; set; }
        public virtual user_type usertypeid { get; set; }

        [ForeignKey("userttypeidFK")]
        public int usertypeidFK { get; set; }
    }
}
