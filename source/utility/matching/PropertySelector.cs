namespace code.utility.matching
{
    public delegate Property PropertySelector<in Item, out Property>(Item input);
}