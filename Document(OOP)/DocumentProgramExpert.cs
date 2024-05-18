namespace Document;

internal class DocumentProgramExpert : DocumentProgramPro
{
    public override void SaveDocument(string format)
    {
        if (format == "doc")
            Console.WriteLine("Document is Saved in doc format");
        else if (format == "pdf")
            Console.WriteLine("Document is Saved in pdf format");
        else
            Console.WriteLine("Invalid file format");
    }
}
