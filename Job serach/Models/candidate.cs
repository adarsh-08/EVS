using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Job_serach.Models
{
    public class candidate
    {
        [Key] public int CandidateID { get; set; }
        
        [ForeignKey("voterFK")]
        public virtual voter voter{ get; set; }
        public  string voterFK { get; set; }

        
        [ForeignKey("address1FK")]
        public virtual Address address1 { get; set; }
        public int address1FK { get; set; }

        [ForeignKey("electionFK")]
        public virtual election election { get; set; }
        public int electionFK { get; set; }

        [ForeignKey("partyFK")]
        public virtual party party{ get; set; }
        public int partyFK { get; set; }

        [ForeignKey("Candidate_typeFK")]
        public virtual Candidate_type candidate_type { get; set; }
        public int candidate_typeFK { get; set; }


   
    }
}
