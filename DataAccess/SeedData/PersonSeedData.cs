using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SeedData
{
    public class PersonSeedData : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData
                (
            new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St",
                DateOfBirth = new DateTime(1993, 1, 1),
                Gender = "Male"
            },
            new Person
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Age = 28,
                Email = "jane.doe@example.com",
                PhoneNumber = "123-456-7891",
                Address = "124 Main St",
                DateOfBirth = new DateTime(1995, 2, 2),
                Gender = "Female"
            },
            new Person
            {
                Id = 3,
                FirstName = "Alice",
                LastName = "Smith",
                Age = 35,
                Email = "alice.smith@example.com",
                PhoneNumber = "123-456-7892",
                Address = "125 Main St",
                DateOfBirth = new DateTime(1988, 3, 3),
                Gender = "Female"
            },
            new Person
            {
                Id = 4,
                FirstName = "Bob",
                LastName = "Smith",
                Age = 40,
                Email = "bob.smith@example.com",
                PhoneNumber = "123-456-7893",
                Address = "126 Main St",
                DateOfBirth = new DateTime(1983, 4, 4),
                Gender = "Male"
            },
            new Person
            {
                Id = 5,
                FirstName = "Charlie",
                LastName = "Brown",
                Age = 25,
                Email = "charlie.brown@example.com",
                PhoneNumber = "123-456-7894",
                Address = "127 Main St",
                DateOfBirth = new DateTime(1998, 5, 5),
                Gender = "Male"
            },
            new Person
            {
                Id = 6,
                FirstName = "David",
                LastName = "Johnson",
                Age = 45,
                Email = "david.johnson@example.com",
                PhoneNumber = "123-456-7895",
                Address = "128 Main St",
                DateOfBirth = new DateTime(1978, 6, 6),
                Gender = "Male"
            },
            new Person
            {
                Id = 7,
                FirstName = "Eva",
                LastName = "Johnson",
                Age = 32,
                Email = "eva.johnson@example.com",
                PhoneNumber = "123-456-7896",
                Address = "129 Main St",
                DateOfBirth = new DateTime(1991, 7, 7),
                Gender = "Female"
            },
            new Person
            {
                Id = 8,
                FirstName = "Frank",
                LastName = "Miller",
                Age = 50,
                Email = "frank.miller@example.com",
                PhoneNumber = "123-456-7897",
                Address = "130 Main St",
                DateOfBirth = new DateTime(1973, 8, 8),
                Gender = "Male"
            },
            new Person
            {
                Id = 9,
                FirstName = "Grace",
                LastName = "Miller",
                Age = 37,
                Email = "grace.miller@example.com",
                PhoneNumber = "123-456-7898",
                Address = "131 Main St",
                DateOfBirth = new DateTime(1986, 9, 9),
                Gender = "Female"
            },
            new Person
            {
                Id = 10,
                FirstName = "Henry",
                LastName = "Adams",
                Age = 55,
                Email = "henry.adams@example.com",
                PhoneNumber = "123-456-7899",
                Address = "132 Main St",
                DateOfBirth = new DateTime(1968, 10, 10),
                Gender = "Male"
            },
            new Person
            {
                Id = 11,
                FirstName = "Isabella",
                LastName = "Adams",
                Age = 27,
                Email = "isabella.adams@example.com",
                PhoneNumber = "123-456-7900",
                Address = "133 Main St",
                DateOfBirth = new DateTime(1996, 11, 11),
                Gender = "Female"
            },
            new Person
            {
                Id = 12,
                FirstName = "Jack",
                LastName = "Wilson",
                Age = 38,
                Email = "jack.wilson@example.com",
                PhoneNumber = "123-456-7901",
                Address = "134 Main St",
                DateOfBirth = new DateTime(1985, 12, 12),
                Gender = "Male"
            },
            new Person
            {
                Id = 13,
                FirstName = "Karen",
                LastName = "Wilson",
                Age = 42,
                Email = "karen.wilson@example.com",
                PhoneNumber = "123-456-7902",
                Address = "135 Main St",
                DateOfBirth = new DateTime(1981, 1, 13),
                Gender = "Female"
            },
            new Person
            {
                Id = 14,
                FirstName = "Larry",
                LastName = "Martinez",
                Age = 33,
                Email = "larry.martinez@example.com",
                PhoneNumber = "123-456-7903",
                Address = "136 Main St",
                DateOfBirth = new DateTime(1990, 2, 14),
                Gender = "Male"
            },
            new Person
            {
                Id = 15,
                FirstName = "Megan",
                LastName = "Martinez",
                Age = 29,
                Email = "megan.martinez@example.com",
                PhoneNumber = "123-456-7904",
                Address = "137 Main St",
                DateOfBirth = new DateTime(1994, 3, 15),
                Gender = "Female"
            },
            new Person
            {
                Id = 16,
                FirstName = "Nancy",
                LastName = "Garcia",
                Age = 46,
                Email = "nancy.garcia@example.com",
                PhoneNumber = "123-456-7905",
                Address = "138 Main St",
                DateOfBirth = new DateTime(1977, 4, 16),
                Gender = "Female"
            },
            new Person
            {
                Id = 17,
                FirstName = "Oscar",
                LastName = "Garcia",
                Age = 52,
                Email = "oscar.garcia@example.com",
                PhoneNumber = "123-456-7906",
                Address = "139 Main St",
                DateOfBirth = new DateTime(1971, 5, 17),
                Gender = "Male"
            },
            new Person
            {
                Id = 18,
                FirstName = "Patricia",
                LastName = "Rodriguez",
                Age = 31,
                Email = "patricia.rodriguez@example.com",
                PhoneNumber = "123-456-7907",
                Address = "140 Main St",
                DateOfBirth = new DateTime(1992, 6, 18),
                Gender = "Female"
            },
            new Person
            {
                Id = 19,
                FirstName = "Quentin",
                LastName = "Clark",
                Age = 27,
                Email = "quentin.clark@example.com",
                PhoneNumber = "123-456-7908",
                Address = "141 Main St",
                DateOfBirth = new DateTime(1996, 7, 19),
                Gender = "Male"
            },
            new Person
            {
                Id = 20,
                FirstName = "Rachel",
                LastName = "Clark",
                Age = 35,
                Email = "rachel.clark@example.com",
                PhoneNumber = "123-456-7909",
                Address = "142 Main St",
                DateOfBirth = new DateTime(1988, 8, 20),
                Gender = "Female"
            }
            );
        }
    }
}