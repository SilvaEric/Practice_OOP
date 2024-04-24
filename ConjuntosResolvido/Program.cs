using System.Globalization;
using ConjuntosResolvido.entities;

Console.Write("Enter file full path: ");
string path = Console.ReadLine();
HashSet<User> conjunto = new HashSet<User>();
try {
    using(StreamReader sr = File.OpenText(path)){
        while(!sr.EndOfStream){
            string [] line = sr.ReadLine().Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            conjunto.Add(new User(name, instant));
        }
    }
    Console.WriteLine("Total users: " + conjunto.Count());
}
catch(IOException e){
    Console.WriteLine("An error as ocurred");
    Console.WriteLine(e.Message);
}