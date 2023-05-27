using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class ConcertConfiguration : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.HasOne(c => c.Artiste).WithMany(a => a.Concerts).
                HasForeignKey(p => p.ArtisteFk).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Festival).WithMany(f=>f.Concerts)
                .HasForeignKey(p => p.FestivalFk).OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(rdv => new
            {
                rdv.ArtisteFk,
                rdv.FestivalFk,
                rdv.DateConcert
            });
        }
    }
}
