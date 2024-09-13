﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Vendor
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string?Description { get; set; }
    public int OrganizationId { get; set; }
    public Organization?Organization { get; set; }
}
