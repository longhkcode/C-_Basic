// using System.Text;
// Console.OutputEncoding = Encoding.UTF8;
//
// Random rand = new Random();
// int[,] matrix = new int[10, 10];
//
// int row = matrix.GetLength(0);
// int col = matrix.GetLength(1);
//
// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < col; j++)
//     {
//         matrix[i, j] = rand.Next(0, 2);
//     }
// }
//
// // In ra màn hình
// for (int i = 0; i < row; i++)
// {
//     for (int j = 0; j < col; j++)
//     {
//         if (matrix[i, j] == 0)
//             Console.Write(". ");
//         else
//             Console.Write("# ");
//     }
//     Console.WriteLine();
// }


using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Random rand = new Random();

// Tạo map
int[,] map = new int[10, 10];
int row = map.GetLength(0);
int col = map.GetLength(1);

// Random map
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        map[i, j] = rand.Next(0, 2);
    }
}
int plx = 0;
int ply = 0;
while (true)
{
    Console.Clear();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i == plx && j == ply)
            {
                Console.Write("P ");
            }else if (map[i, j] == 0)
            {
                Console.Write(". ");
            }
            else
            {
                Console.Write("# ");
            }
        }
        Console.WriteLine();
    }
    
    var key = Console.ReadKey(true).Key;
    int newX = plx;
    int newY = ply;
    switch (key)
    {
        case ConsoleKey.W: newX--; break; 
        case ConsoleKey.S: newX++; break; 
        case ConsoleKey.A: newY--; break; 
        case ConsoleKey.D: newY++; break; 
    }
    bool IsValidMove(int x, int y, int[,] map)
    {
        int row = map.GetLength(0);
        int col = map.GetLength(1);

        // Kiểm tra ra ngoài map
        if (x < 0 || x >= row || y < 0 || y >= col)
            return false;

        // Kiểm tra vật cản
        if (map[x, y] == 1)
            return false;

        return true;
    }
    if (IsValidMove(newX, newY, map))
    {
        plx = newX;
        ply = newY;
    }
    
}