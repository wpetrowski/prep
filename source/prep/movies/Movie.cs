using System;
using code.utility;
using code.utility.matching;

namespace code.prep.movies
{
  public class Movie : IEquatable<Movie>
  {
    public string title { get; set; }
    public ProductionStudio production_studio { get; set; }
    public Genre genre { get; set; }
    public int rating { get; set; }
    public DateTime date_published { get; set; }

    public bool Equals(Movie other)
    {
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;

      return this.title.Equals(other.title);
    }

    public override bool Equals(object obj)
    {
      return Equals(obj as Movie);
    }

    public override int GetHashCode()
    {
      return title.GetHashCode();
    }

    public static Criteria<Movie> published_by(ProductionStudio studio)
    {
      return x => x.production_studio == studio;
    }

    public static Criteria<Movie> published_by_pixar_or_disney()
    {
      return x => x.production_studio == ProductionStudio.Pixar;
    }
  }
}
