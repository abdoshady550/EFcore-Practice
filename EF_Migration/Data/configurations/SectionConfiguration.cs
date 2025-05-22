using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Migration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Migration.Data.configurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

            builder.Property(x => x.SectionName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(p => p.Course)
                .WithMany(e => e.Sections)
                .HasForeignKey(p => p.CourseId)
                .IsRequired();

            builder.OwnsOne(p => p.TimeSlot, ts =>
            {
                ts.Property(x => x.StartTime).HasColumnType("time").HasColumnName("StartTime");
                ts.Property(x => x.EndTime).HasColumnType("time").HasColumnName("EndTime");

            });

            builder.HasOne(e => e.Instractor)
                .WithMany(e => e.sections)
                .HasForeignKey(x => x.InstractorId)
                .IsRequired(false);

            builder.HasOne(c => c.Schedule)
                .WithMany(p => p.sections)
                .HasForeignKey(x => x.ScheduleId)
                .IsRequired();

            builder.HasMany(e => e.Students)
                .WithMany(e => e.sections)
                .UsingEntity<Enrollment>();
            builder.ToTable("Sections");



        }

    }
}
