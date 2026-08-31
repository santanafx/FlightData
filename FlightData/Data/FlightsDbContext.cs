using Microsoft.EntityFrameworkCore;

public class FlightsDbContext : DbContext
{
  public FlightsDbContext(DbContextOptions options) : base(options)
  {

  }
}