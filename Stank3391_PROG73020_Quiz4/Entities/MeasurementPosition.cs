using System;
using System.Collections.Generic;

namespace Stank3391_PROG73020_Quiz4.Entities;

/* This page was generated from the db scaffolding.
 * It is representing a Measurement Position.
 */
public partial class MeasurementPosition
{
    public string MeasurementPositionId { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Bpmeasurement> Bpmeasurements { get; set; } = new List<Bpmeasurement>();
}
