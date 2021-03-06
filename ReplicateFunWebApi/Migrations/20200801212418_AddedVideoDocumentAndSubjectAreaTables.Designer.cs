﻿// <auto-generated />
using FunApp.WebApI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FunApp.WebApI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200801212418_AddedVideoDocumentAndSubjectAreaTables")]
    partial class AddedVideoDocumentAndSubjectAreaTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FunApp.Common.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectAreaId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectAreaId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("FunApp.Common.Models.Retrospection", b =>
                {
                    b.Property<int>("RetrospectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaOfImprovement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HappinessIndex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("TeamMemberId")
                        .HasColumnType("int");

                    b.Property<string>("Wentwell")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RetrospectionId");

                    b.HasIndex("TeamMemberId");

                    b.ToTable("Retrospection");
                });

            modelBuilder.Entity("FunApp.Common.Models.SubjectArea", b =>
                {
                    b.Property<int>("SubjectAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectAreaId");

                    b.ToTable("SubjectAreas");
                });

            modelBuilder.Entity("FunApp.Common.Models.TeamMember", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FunName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hobbies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestedTechnologies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JoinedOn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedInLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimarySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondarySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamMemberId");

                    b.ToTable("TeamMembers");

                    b.HasData(
                        new
                        {
                            TeamMemberId = 1,
                            Name = "Ashish"
                        });
                });

            modelBuilder.Entity("FunApp.Common.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectAreaId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectAreaId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("FunApp.Common.Models.Document", b =>
                {
                    b.HasOne("FunApp.Common.Models.SubjectArea", "SubjectArea")
                        .WithMany()
                        .HasForeignKey("SubjectAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FunApp.Common.Models.Retrospection", b =>
                {
                    b.HasOne("FunApp.Common.Models.TeamMember", "TeamMember")
                        .WithMany()
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FunApp.Common.Models.Video", b =>
                {
                    b.HasOne("FunApp.Common.Models.SubjectArea", "SubjectArea")
                        .WithMany()
                        .HasForeignKey("SubjectAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
