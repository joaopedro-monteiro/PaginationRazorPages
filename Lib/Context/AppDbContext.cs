﻿using Lib.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Context;

public class AppDbContext : DbContext
{
    public DbSet<Exemplo> Exemplo { get; set; }
}
