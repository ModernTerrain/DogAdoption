﻿using Microsoft.EntityFrameworkCore;
using DogAdoption.Models;

namespace DogAdoption.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new DogAdoptionContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DogAdoptionContext>>());

            if (context == null || context.Dog == null)
            {
                throw new NullReferenceException(
                    "Null BlazorBookContext or Dog DbSet");
            }

            if (context.Dog.Any())
            {
                return;
            }

            context.Dog.AddRange(
                new Dog
                {
                    Name = "Joe",
                    Age = 5,
                    Breed = "Mutt",
                    Size = "Large",
                    Description = "One of the dogs of all time",
                    Hypoallergenic = false,
                    ImageFileName = "dog4.jpg",
                    AdoptionFee = 60m,
                    Status = "Available"
                },
                new Dog
                {
                    Name = "Brad",
                    Age = 10,
                    Breed = "German Shepherd",
                    Size = "Large",
                    Description = "One of the dogs of all time",
                    Hypoallergenic = false,
                    ImageFileName = "dog.jpeg",
                    AdoptionFee = 30.5m,
                    Status = "Available"
                },
                new Dog
                {
                    Name = "Anna",
                    Age = 2,
                    Breed = "Chihuahua",
                    Size = "Small",
                    Description = "One of the dogs of all time",
                    Hypoallergenic = true,
                    ImageFileName = "dog2.jpg",
                    AdoptionFee = 0m,
                    Status = "Adoption Pending"
                },
                new Dog
                {
                    Name = "Jason",
                    Age = 5,
                    Breed = "German Shepherd",
                    Size = "Large",
                    Description = "One of the dogs of all time",
                    Hypoallergenic = true,
                    ImageFileName = "dog.jpeg",
                    AdoptionFee = 75m,
                    Status = "Adoption Pending"
                },
                new Dog
                {
                    Name = "Kay",
                    Age = 7,
                    Breed = "Mutt",
                    Size = "Medium",
                    Description = "One of the dogs of all time",
                    Hypoallergenic = false,
                    ImageFileName = "dog4.jpg",
                    AdoptionFee = 45m,
                    Status = "Available"
                },
                new Dog
                {
                    Name = "Alan",
                    Age = 1,
                    Breed = "Golden Retriever",
                    Size = "Small",
                    Description = "One of the dogs of all time",
                    Hypoallergenic = false,
                    ImageFileName = "dog3.jpg",
                    AdoptionFee = 80m,
                    Status = "Available"
                }
                );


            context.SaveChanges();
        }

    }
}
