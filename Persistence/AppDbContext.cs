using System;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
public required DbSet<Activity> Activities { get; set; }
}
