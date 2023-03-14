using Microsoft.AspNetCore.Mvc;
using DVDMovie.Models;

namespace DVDMovie.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleDataController : ControllerBase
{
    private DataContext context;
    public SampleDataController(DataContext ctx)
    {
        context = ctx;
    }

    [HttpGet("[action]")]
    public Movie GetMovie() {
        return context.Movies.OrderBy(p => p.MovieId).First();
    }
}
