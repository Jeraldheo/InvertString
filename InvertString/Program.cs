using System.Text;

namespace InvertString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? data = Console.ReadLine();
            string invertedString = GetInvertedString(data);
            Console.WriteLine($"Cadena de texto invertida: {invertedString}");
        }

        public static string GetInvertedString(string? data)
        {
            StringBuilder invertedString = new StringBuilder();
            int length = data.Length;
            for(int i = length-1; i>=0; i--)
            {
                invertedString.Append(data[i]);
            }
            return invertedString.ToString();
        }
    }
}