using code.utility.matching;

namespace code.prep.movies
{
  public class IsPublishedAfter : IMatchA<Movie>
  {
    private readonly int _year;

    public IsPublishedAfter(int year)
    {
      _year = year;
    }

    public bool matches(Movie item)
    {
      return item.date_published.Year > _year;
    }
  }
}