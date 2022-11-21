using System.Linq;

namespace StringProject
{
    public class Capitalizer
    {
        public string Sentence { get; set; }

        public void UserInput()
        {
            Console.Write("Bitte geben Sie ihren Satz ein: ");
            Sentence = Console.ReadLine();
        }

        public void Capitalize()
        {
            // alles klein schreiben und bei Leerzeichen teilen
            string[] words = Sentence.ToLower().Split(' ');


            // erstes Zeichen großschreiben
            for (int i = 0; i < words.Length; i++)
            {
                string cache = "";
                int counter = 1;

                foreach (var item in words[i])
                {
                    if (counter == 1)
                    {
                        cache += char.ToUpper(item);
                    }
                    else
                    {
                        cache += item;
                    }

                    counter++;
                }

                words[i] = cache;
            }

            // Satz wieder zusammensetzen und am Ende Leerzeichen entfernen
            Sentence = "";

            foreach (string wort in words)
            {
                Sentence += string.Format("{0} ", wort);
            }

            Sentence = Sentence.Trim();
        }

        public void Output()
        {
            Console.WriteLine("\nAusgabe:");
            Console.WriteLine(Sentence);
        }
    }
}
