
public class FlightService : IFlightService
{
  private readonly FlightsDbContext _dbContext;
  public FlightService(FlightsDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public Flight CreateFlight(Flight flight)
  {
    var savedFlight = _dbContext.Add(flight);
    _dbContext.SaveChanges();
    return savedFlight.Entity;
  }

  public string? DeleteFlight(int id)
  {
    var savedFlight = _dbContext.Flights.Find(id);

    if (savedFlight == null)
      return null;

    _dbContext.Flights.Remove(savedFlight);
    _dbContext.SaveChanges();

    return $"Successfully deleted flight with id: {id}";
  }

  public List<Flight> GetAllFlights()
  {
    return _dbContext.Flights.ToList();
  }

  public Flight? GetFlightById(int id)
  {
    var savedFlight = _dbContext.Flights.Find(id);

    if (savedFlight == null)
      return null;

    return savedFlight;
  }

  public Flight UpdateFlight(int id, Flight updatedFlight)
  {
    var savedFlight = _dbContext.Flights.Find(id);

    if (savedFlight == null)
      return null;

    _dbContext.Entry(savedFlight).CurrentValues.SetValues(updatedFlight);
    _dbContext.SaveChanges();

    return savedFlight;
  }
}