class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Bir string ifade girin: ");
            string inputString = Console.ReadLine();

            Console.Write("Çıkartılacak karakterin indeksini girin: ");
            int index = int.Parse(Console.ReadLine());

            if (index < default(int) || index >= inputString.Length)
            {
                Console.WriteLine("Geçersiz indeks. Lütfen default(int) ile string uzunluğu arasında bir indeks girin.");
                return;
            }

            string result = RemoveCharAtIndex(inputString, index);
            Console.WriteLine("Sonuç: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş. İndeks için bir tamsayı girin.");
        }
    }

    static string RemoveCharAtIndex(string input, int index)
    {
        if (index == default(int))
            return input.Substring(1);
        if (index == input.Length - 1)
            return input.Substring(default(int), input.Length - 1);
        return input.Substring(default(int), index) + input.Substring(index + 1);
    }
}