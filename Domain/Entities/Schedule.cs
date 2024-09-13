using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Schedule
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int AssetId { get; set; }
    public Asset? Asset { get; set; }
    public int FrequencyId { get; set; }
    public Frequency Frequency { get; set; }

 
}
public enum Frequency
{
    Daily,
    Weekly,
    Monthly,
    Quarterly,
    Annually
}