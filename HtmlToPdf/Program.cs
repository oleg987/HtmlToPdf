using iText.Html2pdf;

namespace HtmlToPdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var file = new FileStream("baseTemplateToHtml.html", FileMode.Open);

            using var reader = new StreamReader(file);

            string html = reader.ReadToEnd();

            ConvertToPdf(html);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done");
            Console.ResetColor();
        }

        static void ConvertToPdf(string html)
        {
            using var file = new FileStream("output.pdf", FileMode.Create);

            HtmlConverter.ConvertToPdf(html, file);
        }
    }
}