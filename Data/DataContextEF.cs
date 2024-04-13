
using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;


namespace HelloWorld.Data
{
    public class DataContextEF : DbContext
    {

        public DbSet<Computer>? Computer { get; set; }
        // OnConfiguring จะถูกเรียกก็ต่อเมื่อสร้าง Context ขึ้นมา
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // ถ้าเราตั้งค่า Config ที่ 1 แล้ว ถ้ามีการตั้งค่า Config ที่ 2 อีกมันก็จะเช็คว่าตัว Config อื่นยังไม่ได้ตั้งค่า
            if (!options.IsConfigured) // ตรวจสอบถ้ายังไม่มีตัวไหนตั้งค่า Config
            {
                options.UseSqlServer("Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;",
                    options => options.EnableRetryOnFailure()); // ส่งค่า CallBack กลับมา กรณีที่ครั้งแรกเชื่อมต่อ database ไม่สำเร็จ
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("TutorialAppSchema");

            modelBuilder.Entity<Computer>()
            // .HasNoKey(); // กรณีคิวรี่ Data โดยไม่มี primary key
            .HasKey(c => c.ComputerId);
            // .ToTable("Computer", "TutorialAppSchema");
            // .ToTable("ชื่อตาราง", "ชื่อ Schema");
        }


    }
}