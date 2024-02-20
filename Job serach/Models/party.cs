using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Job_serach.Models
{
    [Index(nameof(PartyName),nameof(Symbol))]
    public class party
    {
      [Key] public int PartyID { get; set; }
 public string PartyName {  get; set; }
 public string Symbol { get; set; }
  public string PartyLeader { get; set; }
 
    }
}
