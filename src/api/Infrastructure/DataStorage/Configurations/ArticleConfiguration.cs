using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataStorage.Configurations
{
  public class ArticleConfiguration : IEntityTypeConfiguration<Article>
  {
    public void Configure(EntityTypeBuilder<Article> builder)
    {
      builder.Property(p => p.Title)
        .HasMaxLength(50)
        .IsRequired();
    }
  }
}