using System;
using System.Collections.Generic;

namespace DALClinic.Models;

public partial class Patient
{
    public int Id { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public int Address { get; set; }

    public virtual Address AddressNavigation { get; set; } = null!;
}
