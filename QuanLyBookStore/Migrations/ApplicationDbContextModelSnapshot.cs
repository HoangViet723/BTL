﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyBookStore.Data;

#nullable disable

namespace QuanLyBookStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("QuanLyBookStore.Models.DonMua", b =>
                {
                    b.Property<string>("MaDM")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateBuy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhach")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaDM");

                    b.HasIndex("TenSach");

                    b.ToTable("DonMua");
                });

            modelBuilder.Entity("QuanLyBookStore.Models.HopDong", b =>
                {
                    b.Property<string>("MaHD")
                        .HasColumnType("TEXT");

                    b.Property<string>("DateEnd")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateStart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Luong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaHD");

                    b.HasIndex("TenNV");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("QuanLyBookStore.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNV")
                        .HasColumnType("TEXT");

                    b.Property<string>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Quequan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QuanLyBookStore.Models.Sach", b =>
                {
                    b.Property<string>("MaSach")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSach");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("QuanLyBookStore.Models.DonMua", b =>
                {
                    b.HasOne("QuanLyBookStore.Models.Sach", "Sach")
                        .WithMany()
                        .HasForeignKey("TenSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("QuanLyBookStore.Models.HopDong", b =>
                {
                    b.HasOne("QuanLyBookStore.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("TenNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });
#pragma warning restore 612, 618
        }
    }
}
