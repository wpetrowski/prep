namespace code.utility.matching
{
    public delegate Property PropertyAccessor<in Item, out Property>(Item input);
}