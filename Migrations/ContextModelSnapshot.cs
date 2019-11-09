﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using midterm.Data;

namespace midterm.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("midterm.Models.Ability", b =>
                {
                    b.Property<int>("AbilityID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<int>("TeacherID");

                    b.HasKey("AbilityID");

                    b.HasIndex("CourseID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("midterm.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("course_dur");

                    b.Property<string>("course_lang");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("midterm.Models.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("group_level");

                    b.Property<string>("group_name");

                    b.Property<int>("group_stud_num");

                    b.HasKey("GroupID");

                    b.ToTable("Groups");

                    b.HasData(
                        new { GroupID = -1, group_level = "Advanced", group_name = "English1602", group_stud_num = 10 }
                    );
                });

            modelBuilder.Entity("midterm.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("room_number");

                    b.Property<int>("room_seat_num");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("midterm.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseID");

                    b.Property<int>("GroupID");

                    b.Property<int>("RoomID");

                    b.Property<int>("TeacherID");

                    b.Property<int>("sch_day");

                    b.HasKey("ScheduleID");

                    b.HasIndex("CourseID");

                    b.HasIndex("GroupID");

                    b.HasIndex("RoomID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("midterm.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupID");

                    b.Property<string>("stud_mail");

                    b.Property<string>("stud_name");

                    b.Property<string>("stud_phone");

                    b.HasKey("StudentID");

                    b.HasIndex("GroupID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("midterm.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("teach_mail");

                    b.Property<string>("teach_name");

                    b.Property<int>("teach_phone");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("midterm.Models.Ability", b =>
                {
                    b.HasOne("midterm.Models.Course", "course")
                        .WithMany("abilities")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("midterm.Models.Teacher", "teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("midterm.Models.Schedule", b =>
                {
                    b.HasOne("midterm.Models.Course", "course")
                        .WithMany("schedules")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("midterm.Models.Group", "group")
                        .WithMany("schedules")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("midterm.Models.Room", "room")
                        .WithMany("schedules")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("midterm.Models.Teacher", "teacher")
                        .WithMany("schedules")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("midterm.Models.Student", b =>
                {
                    b.HasOne("midterm.Models.Group", "group")
                        .WithMany("students")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
