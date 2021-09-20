﻿// <auto-generated />
using KleineDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KleineDemo.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KleineDemo.Models.Hero", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Catchphrase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Powerlevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("KleineDemo.Models.Weapon", b =>
                {
                    b.Property<string>("RegistrionNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("HeroId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistrionNumber");

                    b.HasIndex("HeroId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("KleineDemo.Models.Weapon", b =>
                {
                    b.HasOne("KleineDemo.Models.Hero", "Hero")
                        .WithMany("MyWeapons")
                        .HasForeignKey("HeroId");

                    b.Navigation("Hero");
                });

            modelBuilder.Entity("KleineDemo.Models.Hero", b =>
                {
                    b.Navigation("MyWeapons");
                });
#pragma warning restore 612, 618
        }
    }
}
