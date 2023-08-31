using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Dummy text here and here and here and here",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Royal Villa 2",
                    Details = "Dummy text here and here and here and here",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 3,
                    Name = "Royal Villa 3",
                    Details = "Dummy text here and here and here and here",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 4,
                    Name = "Royal Villa 4",
                    Details = "Dummy text here and here and here and here",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Royal Villa 5",
                    Details = "Dummy text here and here and here and here",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
                );

            //modelBuilder.Entity<VillaNumber>().HasData(
            //   new VillaNumber()
            //   {
            //       VillaNum = 1,
            //       SpecialDetails = "None 1",
            //       CreatedDate = DateTime.Now,
            //       UpdatedDate = DateTime.Now
            //   },
            //   new VillaNumber()
            //   {
            //       VillaNum = 2,
            //       SpecialDetails = "None 2",
            //       CreatedDate = DateTime.Now,
            //       UpdatedDate = DateTime.Now
            //   },
            //   new VillaNumber()
            //   {
            //       VillaNum = 3,
            //       SpecialDetails = "None 3",
            //       CreatedDate = DateTime.Now,
            //       UpdatedDate = DateTime.Now
            //   },
            //   new VillaNumber()
            //   {
            //       VillaNum = 4,
            //       SpecialDetails = "None 4",
            //       CreatedDate = DateTime.Now,
            //       UpdatedDate = DateTime.Now
            //   },
            //   new VillaNumber()
            //   {
            //       VillaNum = 5,
            //       SpecialDetails = "None 5",
            //       CreatedDate = DateTime.Now,
            //       UpdatedDate = DateTime.Now
            //   }
            //   );
        }
    }
}
