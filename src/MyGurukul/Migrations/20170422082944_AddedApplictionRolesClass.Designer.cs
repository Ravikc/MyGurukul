using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyGurukul.Data;

namespace MyGurukul.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170422082944_AddedApplictionRolesClass")]
    partial class AddedApplictionRolesClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyGurukul.Models.Alert", b =>
                {
                    b.Property<int>("AlertID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlertType");

                    b.Property<string>("Content");

                    b.HasKey("AlertID");

                    b.ToTable("Alert");
                });

            modelBuilder.Entity("MyGurukul.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("IPAddress");

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("MyGurukul.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("Lastname");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MyGurukul.Models.Attendance", b =>
                {
                    b.Property<int>("AttendanceID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentSubjectID");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("StudentID");

                    b.HasKey("AttendanceID");

                    b.HasIndex("CurrentSubjectID");

                    b.HasIndex("StudentID");

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("MyGurukul.Models.Complaint", b =>
                {
                    b.Property<int>("ComplaintID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int>("StudentID");

                    b.HasKey("ComplaintID");

                    b.HasIndex("StudentID");

                    b.ToTable("Complaint");
                });

            modelBuilder.Entity("MyGurukul.Models.CourseOutcome", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int?>("DepartmentID");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("CourseOutcome");
                });

            modelBuilder.Entity("MyGurukul.Models.CurrentSubject", b =>
                {
                    b.Property<int>("CurrentSubjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseType");

                    b.Property<int>("Credits");

                    b.Property<int>("DepartmentID");

                    b.Property<int>("FacultyID");

                    b.Property<int>("Semester");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("SubjectID");

                    b.HasKey("CurrentSubjectID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("SubjectID");

                    b.ToTable("CurrentSubject");
                });

            modelBuilder.Entity("MyGurukul.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentLevel");

                    b.Property<string>("DepartmentName");

                    b.Property<int>("Stream");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("MyGurukul.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentSubjectID");

                    b.Property<int>("StudentID");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CurrentSubjectID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("MyGurukul.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserId");

                    b.HasKey("FacultyId");

                    b.HasIndex("UserId");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("MyGurukul.Models.Holiday", b =>
                {
                    b.Property<int>("HolidayID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.HasKey("HolidayID");

                    b.ToTable("Holiday");
                });

            modelBuilder.Entity("MyGurukul.Models.MentorAllotment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FacultyID");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("StudentID");

                    b.ToTable("MentorAllotment");
                });

            modelBuilder.Entity("MyGurukul.Models.ProgramOutcome", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<int?>("DepartmentID");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("ProgramOutcome");
                });

            modelBuilder.Entity("MyGurukul.Models.Result", b =>
                {
                    b.Property<int>("ResultID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentSubjectID");

                    b.Property<DateTime>("ExamDate");

                    b.Property<string>("ExamName");

                    b.Property<int>("Marks");

                    b.Property<int>("StudentID");

                    b.HasKey("ResultID");

                    b.HasIndex("CurrentSubjectID");

                    b.HasIndex("StudentID");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("MyGurukul.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentSemester");

                    b.Property<int>("Section");

                    b.Property<string>("USN");

                    b.Property<string>("UserID");

                    b.HasKey("StudentId");

                    b.HasIndex("USN")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MyGurukul.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SubjectCode");

                    b.Property<string>("SubjectName");

                    b.HasKey("SubjectID");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("MyGurukul.Models.TimeTable", b =>
                {
                    b.Property<int>("TimeTableID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentSubjectID");

                    b.Property<int>("EndTime");

                    b.Property<int>("StartTime");

                    b.HasKey("TimeTableID");

                    b.HasIndex("CurrentSubjectID");

                    b.ToTable("TimeTable");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("MyGurukul.Models.ApplicationRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyGurukul.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyGurukul.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("MyGurukul.Models.ApplicationRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyGurukul.Models.Attendance", b =>
                {
                    b.HasOne("MyGurukul.Models.CurrentSubject", "CurrentSubject")
                        .WithMany()
                        .HasForeignKey("CurrentSubjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("MyGurukul.Models.Complaint", b =>
                {
                    b.HasOne("MyGurukul.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyGurukul.Models.CourseOutcome", b =>
                {
                    b.HasOne("MyGurukul.Models.Department")
                        .WithMany("CourseOutcomes")
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("MyGurukul.Models.CurrentSubject", b =>
                {
                    b.HasOne("MyGurukul.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyGurukul.Models.Enrollment", b =>
                {
                    b.HasOne("MyGurukul.Models.CurrentSubject", "CurrentSubject")
                        .WithMany()
                        .HasForeignKey("CurrentSubjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyGurukul.Models.Faculty", b =>
                {
                    b.HasOne("MyGurukul.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MyGurukul.Models.MentorAllotment", b =>
                {
                    b.HasOne("MyGurukul.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyGurukul.Models.ProgramOutcome", b =>
                {
                    b.HasOne("MyGurukul.Models.Department")
                        .WithMany("ProgramOutcomes")
                        .HasForeignKey("DepartmentID");
                });

            modelBuilder.Entity("MyGurukul.Models.Result", b =>
                {
                    b.HasOne("MyGurukul.Models.CurrentSubject", "CurrentSubject")
                        .WithMany()
                        .HasForeignKey("CurrentSubjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyGurukul.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyGurukul.Models.Student", b =>
                {
                    b.HasOne("MyGurukul.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("MyGurukul.Models.TimeTable", b =>
                {
                    b.HasOne("MyGurukul.Models.CurrentSubject", "CurrentSubject")
                        .WithMany()
                        .HasForeignKey("CurrentSubjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
