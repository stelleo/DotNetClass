using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Resume.Models;

namespace Resume.Migrations
{
    [DbContext(typeof(ResumeContext))]
    [Migration("20170603201709_Migrate1")]
    partial class Migrate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Resume.Models.ResumeMain", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descr");

                    b.Property<string>("Email");

                    b.Property<string>("MyName");

                    b.Property<string>("Objective");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("ResDate");

                    b.Property<string>("ResName");

                    b.Property<string>("Summary");

                    b.HasKey("ID");

                    b.ToTable("ResumeMain");
                });
        }
    }
}
