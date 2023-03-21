using System;
using System.Collections.Generic;

namespace DALClinic.Models;

public partial class Address
{
    public int Id { get; set; }

    public int City { get; set; }

    public int Street { get; set; }

    public int? HouseNumber { get; set; }

    public int? ApartmentNumber { get; set; }

    public virtual City CityNavigation { get; set; } = null!;

    public virtual ICollection<Patient> Patients { get; } = new List<Patient>();

    public virtual Street StreetNavigation { get; set; } = null!;
}
