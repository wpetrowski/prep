using code.utility.matching;

namespace code.prep.movies
{
  public class IsPublishedBetween : IMatchA<Movie>
  {
    private readonly int _start;
    private readonly int _end;

    public IsPublishedBetween(int start, int end)
    {
      _start = start;
      _end = end;
    }

    public bool matches(Movie movie)
    {
      return movie.date_published.Year >= _start && movie.date_published.Year <= _end;
    }
  }
}