namespace Document;

internal class DocumentProgramBasic
{
    public void OpenDocument()
    {
        Console.WriteLine("Document is opened");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Can Edit in Pro and Expert versions");
    }
    public virtual void SaveDocument(string format)
    {
        Console.WriteLine("Can Save in Pro and Expert versions");
    }

}
