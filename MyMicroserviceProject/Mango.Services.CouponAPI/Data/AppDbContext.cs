using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponId = 1,
                CouponCode = "1000A",
                DiscountAmount = 100,
                MinAmount = 500
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponId = 2,
                CouponCode = "1000B",
                DiscountAmount = 10,
                MinAmount = 50
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponId = 3,
                CouponCode = "1000C",
                DiscountAmount = 150,
                MinAmount = 500
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponId = 4,
                CouponCode = "1000D",
                DiscountAmount = 140,
                MinAmount = 200
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponId = 5,
                CouponCode = "1000E",
                DiscountAmount = 10,
                MinAmount = 50
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon()
            {
                CouponId = 6,
                CouponCode = "1000F",
                DiscountAmount = 180,
                MinAmount = 350
            });


        }


    }
}
