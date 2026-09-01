
public class FlightService : IFlightService
{
  private readonly FlightsDbContext _dbContext;
  public FlightService(FlightsDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public Flight CreateFlight(Flight flight)
  {
    throw new NotImplementedException();
  }

  public string? DeleteFlight(int id)
  {
    throw new NotImplementedException();
  }

  public List<Flight> GetAllFlights()
  {
    throw new NotImplementedException();
  }

  public Flight? GetFlightById(int id)
  {
    throw new NotImplementedException();
  }

  public Flight UpdateFlight(int id, Flight updatedFlight)
  {
    throw new NotImplementedException();
  }
}