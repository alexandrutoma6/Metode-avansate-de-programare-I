using System.IO;

TextReader load = new StreamReader(@"../../fisier.txt");
int n = int.Parse(load.ReadLine());

int[,] matrix = new int[n, n];
string buffer;
while ((buffer = load.ReadLine()) != null)
{
    string[] t = buffer.Split(' ');
    int ns = int.Parse(t[0]);
    int nf = int.Parse(t[1]);
    matrix[ns, nf] = 1;
    matrix[nf, ns] = 1;
}
WriteMatrix(matrix);
Console.WriteLine();

int nrimpar = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int s = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == 0)
            s++;
    }
    if (s % 2 == 1)
        nrimpar++;
}
if (nrimpar > 2)
    Console.WriteLine("Graful nu este eulerian");
else
    Console.WriteLine("Graful este eulerian");



static void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}