using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int OrganizationId { get; set; }
    public required Organization Organization { get; set; }
    public ICollection<Asset> Assets { get; set; } = [];
}