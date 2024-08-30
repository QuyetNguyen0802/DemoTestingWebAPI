﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApi;

    public class ProductDbContext : DbContext
    {
        public ProductDbContext (DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductApi.Product> Product { get; set; } = default!;
    }
