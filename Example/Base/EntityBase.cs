namespace Example.Base;

public class EntityBase<TKey> 
{
    public TKey Id { get; set; }
    public DateTime CreateDate { get; set; }
}