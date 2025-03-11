using System;
using System.Collections.Generic;

namespace Stank3391_PROG73020_Quiz4.Entities;

/* This page was generated from the db scaffolding.
 * It is representing a BP Measurement
 */
public partial class Bpmeasurement
{
    public int BpmeasurementId { get; set; }

    public int Systolic { get; set; }

    public int Diastolic { get; set; }

    public DateTime MeasurementDate { get; set; }

    public string MeasurementPositionId { get; set; } = null!;

    public virtual MeasurementPosition MeasurementPosition { get; set; } = null!;
}
