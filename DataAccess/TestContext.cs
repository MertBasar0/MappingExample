using Entities;
using Entities.OneToMany;
using Entities.TableSpliting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-AK0MLSE8; Database=MappingDB; integrated security=True; MultipleActiveResultSets=True;");
        }
        //Mapping Configürasyonlarının yazıldığı ilişkilendirmeler için DbSet tanımlamalarına ihtiyaç yoktur.
        //Data işlemleri direk olarak DbContext sınıfının miras verildiği sınıf new'lendikten sonra, bunun referansı üzerinden yapılabilir.
        //Mapping'e gerek olmadan yalnızca navigation proplar ve ForeignKey tanımlamalarıyla gerçekleştirilen ilişkilendirme
        //yöntemleri de mevcuttur. Bunlar için DbSet tanımlamaları gereklidir. Bu şekilde gerçekleştirilen ilişkilendirme yönteminin adı
        //Fully Defined'dır.
        //EF Core'da ConditionalMapping yalın yazılması için henüz geliştirilmemiş olabilir. Bunu sor!!
        //ManyToMany ilişkilerde compositeKeyTable tablosu her şekilde olmak zorunda.Entity Framework dahil.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OneToManyRelationshipConfiguration(modelBuilder);

            ManyToManyRelationshipConfiguration(modelBuilder);

            TableSplitingConfiguration(modelBuilder);

        }

        private void ManyToManyRelationshipConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentTeacher>().HasKey(x => new { x.StudentId, x.TeacherId });

            modelBuilder.Entity<StudentTeacher>()
                .HasOne<Student>(x => x.Student)
                .WithMany(x => x.StudentTeachers)
                .HasForeignKey(x => x.StudentId);

            modelBuilder.Entity<StudentTeacher>()
                .HasOne<Teacher>(x => x.Teacher)
                .WithMany(x => x.StudentTeachers)
                .HasForeignKey(x => x.TeacherId);
        }


        private void OneToManyRelationshipConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasMany(c => c.StudentTwos)
                .WithOne(s => s.Course)
                .IsRequired();
        }

        private void TableSplitingConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedOrder>(
             dob =>
             {
                 dob.ToTable("Orders");
                 dob.Property(o => o.Status).HasColumnName("Status");
             });

            modelBuilder.Entity<Order>(
                ob =>
                {
                    ob.ToTable("Orders");
                    ob.Property(o => o.Status).HasColumnName("Status");
                    ob.HasOne(o => o.DetailedOrder).WithOne()
                        .HasForeignKey<DetailedOrder>(o => o.Id);
                });
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<StudentTeacher> StudentTeachers { get; set; }

        public DbSet<Course>? Courses { get; set; }

        public DbSet<StudentTwo> StudentTwos { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
