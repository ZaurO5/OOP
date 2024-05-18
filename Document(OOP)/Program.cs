namespace Document;
internal class Program
{
    static void Main(string[] args)
    {
        InputKeyDesc: Console.WriteLine("Key daxil edin: ");
        string key = Console.ReadLine();

        {
            switch (key)
            {
                case "Basic":
                    DocumentProgramBasic documentProgramBasic = new DocumentProgramBasic();
                    documentProgramBasic.OpenDocument();
                    documentProgramBasic.EditDocument();
                    documentProgramBasic.SaveDocument("pptx");
                    break;
                case "Pro":
                    DocumentProgramPro documentProgramPro = new DocumentProgramPro();
                    documentProgramPro.OpenDocument();
                    documentProgramPro.EditDocument();
                    documentProgramPro.SaveDocument("pdf");
                    break;
                case "Expert":
                    DocumentProgramExpert documentProgramExpert = new DocumentProgramExpert();
                    documentProgramExpert.OpenDocument();
                    documentProgramExpert.EditDocument();
                    documentProgramExpert.SaveDocument("doc");
                    break;
                default:
                    goto InputKeyDesc;
            }
        }
    }
}


