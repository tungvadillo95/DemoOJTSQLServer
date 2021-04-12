using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEventStudent.Models
{
    public class OJTDbContext : IdentityDbContext<ApplicationUser>
    {
        public OJTDbContext(DbContextOptions<OJTDbContext> options) : base(options)
        {

        }
        public DbSet<Capacity> Capacities { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Wiki> Wikis { get; set; }
        public DbSet<EventContent> EventContents { get; set; }
        public DbSet<EventContentCapacity> EventContentCapacity { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<RoleCourse> RoleCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Wiki>().HasKey(wk => new { wk.TableId, wk.StatusId });
            modelBuilder.Entity<EventContentCapacity>().HasKey(ecc => new { ecc.EventContentId, ecc.CapacityId });
            // ** n - 1 **
            modelBuilder.Entity<EventContent>()
                 .HasOne<ApplicationUser>(ec => ec.ApplicationUser)
                 .WithMany(s => s.EventContents)
                 .HasForeignKey(ec => ec.StudentId);
            // ** n - 1 **
            modelBuilder.Entity<EventContent>()
                 .HasOne<Course>(ec => ec.Course)
                 .WithMany(c => c.EventContents)
                 .HasForeignKey(ec => ec.CourseCurrentId);
            // ** n - 1 **
            //modelBuilder.Entity<RoleCourse>()
            //    .HasOne<ApplicationUser>(rc => rc.Student)
            //    .WithMany(u => u.RoleCourses)
            //    .HasForeignKey(rc => rc.StudentId);

            //modelBuilder.Entity<RoleCourse>()
            //    .HasOne<ApplicationUser>(rc => rc.Teacher)
            //    .WithMany(u => u.RoleCourses)
            //    .HasForeignKey(rc => rc.TeacherId);

            //modelBuilder.Entity<RoleCourse>()
            //    .HasOne<ApplicationUser>(rc => rc.Doctor)
            //    .WithMany(u => u.RoleCourses)
            //    .HasForeignKey(rc => rc.DoctorId);
        }


        // ** 1 - 1 **
        //modelBuilder.Entity<Student>()
        //    .HasOne<StudentAddress>(s => s.Address)
        //    .WithOne(ad => ad.Student)
        //    .HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);

        // ** n - 1 **
        //modelBuilder.Entity<Student>()
        // .HasOne<Grade>(s => s.Grade)
        // .WithMany(g => g.Students)
        // .HasForeignKey(s => s.CurrentGradeId);


        // ** n - n **
        //modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.SId, sc.CId});

        //modelBuilder.Entity<StudentCourse>()
        //    .HasOne<Student>(sc => sc.Student)
        //    .WithMany(s => s.StudentCourses)
        //    .HasForeignKey(sc => sc.SId);


        //    modelBuilder.Entity<StudentCourse>()
        //    .HasOne<Course>(sc => sc.Course)
        //    .WithMany(s => s.StudentCourses)
        //    .HasForeignKey(sc => sc.CId);
    }
}
