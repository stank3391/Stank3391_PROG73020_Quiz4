﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Stank3391_PROG73020_Quiz4.Entities;

/* This page was generated from the db scaffolding.
 * It is representing a the DB context.
 */
public partial class BpmeasurementsContext : DbContext
{
    public BpmeasurementsContext()
    {
    }

    public BpmeasurementsContext(DbContextOptions<BpmeasurementsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bpmeasurement> Bpmeasurements { get; set; }

    public virtual DbSet<MeasurementPosition> MeasurementPositions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=BPMeasurements;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bpmeasurement>(entity =>
        {
            entity.ToTable("BPMeasurements");

            entity.Property(e => e.BpmeasurementId).HasColumnName("BPMeasurementId");
            entity.Property(e => e.MeasurementPositionId).HasMaxLength(450);

            entity.HasOne(d => d.MeasurementPosition).WithMany(p => p.Bpmeasurements)
                .HasForeignKey(d => d.MeasurementPositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MeasurementPosition");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
