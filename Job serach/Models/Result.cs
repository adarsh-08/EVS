using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Job_serach.Models;

public class Result
{
    [Key] public int ResultID { get; set; }
    
    
  public int vote_count { get; set; }
    public virtual candidate candidate { get; set; }
    [ForeignKey("candidateFK")]
    public int candidateFK { get; set; }

    public virtual Address address { get; set; }
    [ForeignKey("addressFK")]
    public string addressFK { get; set; }

    public virtual party party { get; set; }
    [ForeignKey("partyFK")]
    public int partyFK { get; set; }

}
