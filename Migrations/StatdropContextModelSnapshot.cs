// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Statdrop.Data;

namespace Statdrop.Migrations
{
    [DbContext(typeof(StatdropContext))]
    partial class StatdropContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Statdrop.Models.Solutions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatePlayed")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rival")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RivalScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Team")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TeamScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Solutions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DatePlayed = new DateTime(2021, 8, 20, 21, 4, 57, 875, DateTimeKind.Local).AddTicks(2721),
                            Rival = "Ballers",
                            RivalScore = 23m,
                            Team = "Unicorns n Rainbows",
                            TeamScore = 30m,
                            Title = "Scrims"
                        },
                        new
                        {
                            Id = 2,
                            DatePlayed = new DateTime(2021, 8, 20, 21, 4, 57, 877, DateTimeKind.Local).AddTicks(6941),
                            Rival = "Peons",
                            RivalScore = 32m,
                            Team = "GrayJoy",
                            TeamScore = 29m,
                            Title = "Scrims2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
