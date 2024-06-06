namespace Milestone1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Fase 1
            Console.WriteLine("FASE 1");
            char[] nombre = { 'E', 'r', 'n', 'e', 's', 't' };

            Console.WriteLine("Nombre:");
            foreach (char letra in nombre)
            {
                Console.WriteLine(letra);
            }

            // Fase 2
            Console.WriteLine("\nFASE 2");
            List<char> nombreList = nombre.ToList();

            Console.WriteLine("Nombre (consonante/vocal):");
            foreach (char letra in nombreList)
            {
                if (char.IsLetter(letra))
                {
                    Console.WriteLine(IsVowel(letra) ? "VOCAL" : "CONSONANTE");
                }
                else if (char.IsDigit(letra))
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
            }

            // Fase 3
            Console.WriteLine("\nFASE 3");
            Dictionary<char, int> letraCountMap = new Dictionary<char, int>();

            foreach (char letra in nombreList)
            {
                if (char.IsLetter(letra))
                {
                    char lowerLetra = char.ToLower(letra);

                    if (letraCountMap.ContainsKey(lowerLetra))
                    {
                        letraCountMap[lowerLetra]++;
                    }
                    else
                    {
                        letraCountMap[lowerLetra] = 1;
                    }
                }
            }

            foreach (var kvp in letraCountMap)
            {
                Console.WriteLine($"Lletra: {kvp.Key}, Vegades: {kvp.Value}");
            }

            // Fase 4
            Console.WriteLine("\nFASE 4");
            List<char> apellido = new List<char> { 'A', 'p', 'e', 'l', 'l', 'i', 'd', 'o' };

            nombreList.Add(' ');
            nombreList.AddRange(apellido);

            string fullName = new string(nombreList.ToArray());

            Console.Write("FullName: ");
            Console.WriteLine(fullName);
        }

        static bool IsVowel(char c)
        {
            char lowerChar = char.ToLower(c);
            return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
        }
    }
}
