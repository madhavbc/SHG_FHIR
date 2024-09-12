﻿using System;
using System.Collections.Generic;

namespace DataAccess_Layer.Models;

public partial class Complient
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int PatientId { get; set; }

    public int EncounterId { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? Duration { get; set; }

    public string? Interval { get; set; }

    public string? Severity { get; set; }

    public string? Title { get; set; }

    public DateTime? DeletedAt { get; set; }

    public int? DeletedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
