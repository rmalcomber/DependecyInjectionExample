using DependencyInjectionExample.Interfaces;

namespace DependencyInjectionExample
{
    public class TextToWrite
    {
        public static void WriteText(IWriter writer, IAuthorNameProvider authorNameProvider)
        {
            writer.WriteLine("Welcome to a series of injection dependency.");
            writer.WriteLine("============================================");
            writer.WriteLine("");
            writer.WriteLine("Here is some text for you to see");
            writer.Write("Signed: ");
            writer.Write(authorNameProvider.AuthorName);
        }
    }
}