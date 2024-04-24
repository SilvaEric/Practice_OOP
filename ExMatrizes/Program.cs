int  l ,c;

string [] vet = Console.ReadLine().Split(" ");

l  = int.Parse(vet[0]);
c = int.Parse(vet[1]);

int [,] matriz = new int [l , c];

for( int i = 0; i < l; i++){
    string [] aux = Console.ReadLine().Split(" ");
    for(int j = 0; j < c; j++){
        matriz [i,j] = int.Parse(aux[j]);
    }
}
int valor = int.Parse(Console.ReadLine());

for( int i = 0; i < l; i++){
    for(int j = 0; j < c; j++){
        if (matriz[i,j] == valor){
            Console.WriteLine("Position " + i + "," +j + " :"); 
            if( j >= 1){
                Console.WriteLine("Left: " + matriz[i,j-1]);
            }
            if( j < c -1){
                Console.WriteLine("Right: " + matriz[i,j+1]);
            }
            if( i >= 1){
                Console.WriteLine("Up: " + matriz[i-1,j]);
            }
            if( i < l - 1){
                Console.WriteLine("Down: " + matriz[i+1,j]);
            }
           
        }
    }
}