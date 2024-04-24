
Console.Write("Enter file full path: ");
string path = Console.ReadLine();
Dictionary<string, int> dict = new Dictionary<string, int>();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] vet = sr.ReadLine().Split(",");
            string nome = vet[0];
            int votos = int.Parse(vet[1]);

            if (!dict.ContainsKey(nome)) 
            { 
                dict.Add(nome, votos); 
            }
            else
            {
                dict[nome] += votos;
            }
        }

    }
    foreach (var item in dict)
    {
        Console.WriteLine(item.Key + ": " + item.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
