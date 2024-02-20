using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Job_serach.Models
{
    public class Candidate_type
    {
        [Key] public int CandidateTypeID { get; set; }
      public string CandidateType { get; set; }
    }
}
