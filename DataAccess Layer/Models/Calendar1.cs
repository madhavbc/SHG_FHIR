﻿using System;
using System.Collections.Generic;

namespace DataAccess_Layer.Models;

public partial class Calendar1
{
    public DateOnly? Gregorian { get; set; }

    public string? BikramSambat { get; set; }

    public string? BikramSambatNe { get; set; }
}
