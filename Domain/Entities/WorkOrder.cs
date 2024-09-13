using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class WorkOrder
{
    public int Id { get; set; }
    public string? scription { get; set; }
    public DateTime DueDate { get; set; }
    public int AssetId { get; set; }
    public Asset? Assets{ get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = new User();
    public WorkOrderStatus Status { get; set; }
    
}
public enum WorkOrderStatus
{
    Open,
    InProgress,
    Completed,
    Cancelled
}