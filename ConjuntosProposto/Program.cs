HashSet<int> cursoA = new HashSet<int>();
HashSet<int> cursoB = new HashSet<int>();
HashSet<int> cursoC = new HashSet<int>();


Console.Write("How many students for course A? ");
int a = int.Parse(Console.ReadLine());
for (int i = 0; i < a ; i++){
    cursoA.Add(int.Parse(Console.ReadLine()));
}
Console.Write("How many students for course B? ");
int b = int.Parse(Console.ReadLine());
for (int i = 0; i < b ; i++){
    cursoB.Add(int.Parse(Console.ReadLine()));
}
Console.Write("How many students for course C? ");
int c = int.Parse(Console.ReadLine());
for (int i = 0; i < c ; i++){
    cursoC.Add(int.Parse(Console.ReadLine()));
}
HashSet<int> students = new HashSet<int>(cursoA);
students.UnionWith(cursoB);
students.UnionWith(cursoC);
Console.Write("Total students: " + students.Count);