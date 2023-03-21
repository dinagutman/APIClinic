using System;
using System.Collections.Generic;

namespace DALClinic.Models;

public partial class Street
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Address> Addresses { get; } = new List<Address>();
}
