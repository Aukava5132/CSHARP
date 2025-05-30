namespace Lab7;

public interface IFileContainer<TElement> : IContainer<TElement> 
{
    void Save( String fileName );
    void Load( String fileName );
    Boolean IsDataSaved {get;}
}
