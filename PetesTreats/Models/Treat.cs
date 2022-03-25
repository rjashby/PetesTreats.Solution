using System.Collections.Generic;

namespace PetesTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<TreatFlavor> JoinEntities { get;}
  }
}