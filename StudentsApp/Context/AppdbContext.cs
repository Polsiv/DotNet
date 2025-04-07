using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;
using StudentsApp.Models;

namespace StudentsApp.Context;

public partial class AppdbContext : DbContext
{
    public AppdbContext()
    {
    }

    public AppdbContext(DbContextOptions<AppdbContext> options): base(options)
    {
    }

    public virtual DbSet<student> students { get; set; }
}
