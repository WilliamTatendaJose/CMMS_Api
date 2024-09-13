using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }= string.Empty;
    public string? Description { get; set; }
    public int OrganizationId { get; set; }
    public required Organization Organization { get; set; }
    public ICollection<Asset>? ssets { get; set; }
}