using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Job_serach.Models
{
    [Index(nameof(voterIDFK),IsUnique =true)]
    public class vote
    {
    [Key]public string VoteID { get; set; }

        public virtual user voterID { get; set; }
        [ForeignKey("voterIDFK")]
        public string voterIDFK { get; set; }

        public virtual party partyID { get; set; }
        [ForeignKey("partyIDFK")]
        public int partyIDFK { get; set; }

        public virtual candidate candidateID { get; set; }
        [ForeignKey("candidateIDFK")]
        public int candidateIDFK { get; set; }

        public virtual Address districtID{ get; set; }
        [ForeignKey("districtIDFK")]
        public int disctrictIDFK { get; set; }

        public string def_password { get; set; }

        public string enter_password { get; set;  }
       // IF(def_password==enter_password)
        
 
    }
}
