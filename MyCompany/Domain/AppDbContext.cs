using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }  //ПРОЕЦИРУЕМ ОБЪЕКТЫ НА РЕАЛЬНЫЕ ТАБЛИЦЫ В БД
        public DbSet<MessageItem> MessageItems { get; set; }
        public DbSet<ProtocolItem> ProtocolsItems { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "kumi@anzhero.ru",
                NormalizedEmail = "KUMI@ANZHERO.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Pfrjkt,ftimczkjvfnm11hfp"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField { 
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), 
                CodeWord = "PageIndex", 
                Title = "Главная"
            });
           
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), 
                CodeWord = "PageMessages", 
                Title = "Информационные сообщения"
            });

            /*
              modelBuilder.Entity<TextField>().HasData(new TextField
              {
                  Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), 
                  CodeWord = "PageContacts", 
                  Title = "Контакты"
              });
            */
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("0643705b-db8f-43a3-98de-359df2f5b6f7"),
                CodeWord = "PageProtocols",
                Title = "Протоколы"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("15a11537-7471-48df-86db-4fec77f492c4"),
                CodeWord = "PageNPA",
                Title = "Нормативные правовые акты"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("0bc287e6-f3a3-4444-88cf-94cc5049c275"),
                CodeWord = "PageMunControl",
                Title = "Муниципальный контроль"
            });
        }
    }
}
