using System.ComponentModel.DataAnnotations;

namespace Job_serach.Models
{
    public class Address
    {
        [Key] public int DistrictID { get; set; }
        
  public string Locality { get; set; }
    public string City { get; set; }
    public string State { get; set; }
   public string Zip { get; set; }
    }
}
