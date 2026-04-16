// See https://aka.ms/new-console-template for more information
// for (int i = 1; i <= 10; i ++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());
// bool checkSCP = false;
// for (int i = 0; i <= Math.Sqrt(n); i++)
// {
//     if (n == i * i)
//     {
//         Console.WriteLine("{0}= {1}*{1}",n,i);
//         Console.WriteLine("{0} la so chinh phuong",n);
//         checkSCP = true;
//         break;
//     }
// }
// if (!checkSCP)
// {
//     Console.WriteLine("{0} khong phai la so chinh phuong",n);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// if (n == (int)Math.Sqrt(n) * (int)Math.Sqrt(n))
// {
//     Console.WriteLine("{0} la so chinh phuong",n);
// } else{
//     Console.WriteLine("{0} ko la so chinh phuong",n);
// }
// int count = 0;
// for (int i = 1; i < 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         Console.WriteLine(i);
//         count++;
//     }
//     if (count == 5) break;
// }

// bool checkSNT = true;
// int n = Convert.ToInt32(Console.ReadLine());
// if (n <= 1)
// {
//     Console.WriteLine("{0} ko phai la so nguyen to",n);
//     checkSNT = false;
// }
//
// for (int i = 2; i <= Math.Sqrt(n); i++)
// {
//     if (n % i == 0)
//     {
//         Console.WriteLine("{0} ko phai la so nguyen to",n);
//         checkSNT = false;
//     }
// }
//
// if (checkSNT)
// {
//     Console.WriteLine("{0} la so nguyen to", n);
// }


int[] arr = { 1, 3, 7, 2, 5, 9, 4 };
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length-i-1; j++)
    {
        if (arr[j] > arr[j+1])
        {
            int temp = arr[j];
            arr[j] = arr[j+1];
            arr[j+1] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

