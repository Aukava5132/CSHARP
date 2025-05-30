namespace Lab7;

public interface IContainer<TElement> 
{
    int Count { get;}
    Article this[ int index ] { get;set;}
    void Add( TElement element );
    void Delete( TElement element );
}