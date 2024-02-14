using System.Security.Cryptography.X509Certificates;
using Blog2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog2.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
          builder.ToTable("Post");

          builder.HasKey(x => x.Id);
          builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

          builder.Property(x => x.Title)
            .IsRequired()
            .HasColumnName("Title")
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);

          builder.Property(x => x.Summary)
            .IsRequired()
            .HasColumnName("Summary")
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

          builder.Property(x => x.Body)
            .IsRequired()
            .HasColumnName("Body")
            .HasColumnType("TEXT");

          builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

          builder.Property(x => x.CreateDate)
          .IsRequired()
          .HasColumnName("CreateDate")
          .HasColumnType("SMALLDATETIME")
          .HasDefaultValueSql("GETDATE()");

          builder.Property(x => x.LastUpdateDate)
            .IsRequired()
            .HasColumnName("LastUpdateDate")
            .HasColumnType("SMALLDATETIME")
            .HasDefaultValueSql("GETDATE()");

          builder.HasIndex(x => x.Slug, "IX_Post_Slug")
            .IsUnique();
        }
    }
}