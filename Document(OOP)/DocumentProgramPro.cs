namespace Document;

internal class DocumentProgramPro : DocumentProgramBasic
{
    public sealed override void EditDocument()
    {
        Console.WriteLine("Document is Edited");
    }
    public override void SaveDocument(string format)
    {
        if (format == "doc")
            Console.WriteLine("Document is Saved in doc format");
        else if (format == "pdf")
            Console.WriteLine("For pdf format, buy Expert packet");
        else
            Console.WriteLine("Invalid File Format");
    }
}
