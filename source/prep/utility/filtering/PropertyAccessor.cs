namespace prep.utility.filtering
{
    public delegate TProperty PropertyAccessor<in TItem, out TProperty>(TItem item);
}