using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogAdoption.Models;

namespace DogAdoption.Data
{
    public class MessageContext : DbContext
    {
        public MessageContext (DbContextOptions<MessageContext> options)
            : base(options)
        {
        }

        public DbSet<DogAdoption.Models.Message> Message { get; set; } = default!;
    }
}
