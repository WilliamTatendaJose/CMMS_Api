using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Asset
{
    public int Id { get; set; }
    public string Name { get; set; }= string.Empty;
    public string Description { get; set; } = string.Empty;
    public int OrganizationId { get; set; }
    public required Organization Organization { get; set; } 
    public int LocationId { get; set; }
    public Location? Location { get; set; }
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
    public ICollection<WorkOrder> WorkOrders { get; set; } = [];
}