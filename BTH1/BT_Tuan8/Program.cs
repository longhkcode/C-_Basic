// See https://aka.ms/new-console-template for more information
// BT1_1
// Console.Write("Nhap so phan tu n = ");
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"Nhap phan tu thu {i}: ");
//     arr[i] = int.Parse(Console.ReadLine());
// }
//
// Console.WriteLine("\nMang theo chieu xuoi:");
// for (int i = 0; i < n; i++)
// {
//     Console.Write(arr[i] + " ");
// }
//
// Console.WriteLine("\nMang theo chieu nguoc:");
// for (int i = n - 1; i >= 0; i--)
// {
//     Console.Write(arr[i] + " ");
// }


//  BT_1.2
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
//
// int tong = 0;
// for (int i = 0; i < n; i++)
// {
//     tong+=arr[i];
// }
// Console.WriteLine(tong);
// double avg =  (double)tong / n;
// Console.WriteLine(avg);


// BT1_3
// int n = int.Parse(Console.ReadLine()); 
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//      arr[i] = int.Parse(Console.ReadLine());
// }
//
// int max = arr[0];
// for(int i=1;i<n;i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }
// Console.WriteLine(max);
//
// int min = arr[0];
// for(int i=1;i<n;i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }
// Console.WriteLine(min);

//BT2_1
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
//
// int chan = 0;
// int le = 0;
// int nguyento = 0;
//
// for (int i = 0; i < n; i++)
// {
//
//     if (arr[i] % 2 == 0)
//     {
//         chan++;
//     }else{
//         le++;
//     }
//
//     if (LaSoNguyenTo(arr[i])) nguyento++;
// }
//
// Console.WriteLine("So chan: " + chan);
// Console.WriteLine("So le: " + le);
// Console.WriteLine("So nguyen to: " + nguyento);
//
// static bool LaSoNguyenTo(int x)
// {
//     if (x < 2) return false;
//
//     for (int i = 2; i <= Math.Sqrt(x); i++)
//     {
//         if (x % i == 0)
//             return false;
//     }
//     return true;
// }

// BT2_2
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// Array.Sort(arr);
// Console.WriteLine(string.Join(" ", arr));

// BT2_3
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// int x = int.Parse(Console.ReadLine());
//
// bool found = false;
//
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] == x)
//     {
//         Console.Write(i + " ");
//         found = true;
//     }
// }
// if (!found)
// {
//     Console.WriteLine("Khong ton tai");
// }

//BT3_1
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// int k = int.Parse(Console.ReadLine());
//
// for (int i = k; i < n - 1; i++)
// {
//     arr[i] = arr[i + 1];
// }
// n--;
//
//
// for (int i = 0; i < n; i++)
// {
//     Console.Write(arr[i] + " ");
// }

// BT3_2
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// int v = int.Parse(Console.ReadLine());
// int k = int.Parse(Console.ReadLine());
//
// int[] newArr = new int[n + 1];
//
// for (int i = 0; i < k; i++)
// {
//     newArr[i] = arr[i];
// }
//
// newArr[k] = v;
//
// for (int i = k; i < n; i++)
// {
//     newArr[i + 1] = arr[i];
// }
//
// arr = newArr;
// n++;
//
// Console.WriteLine("Mang sau khi chen:");
// for (int i = 0; i < n; i++)
// {
//     Console.Write(arr[i] + " ");
// }
// Console.WriteLine();


// BT3_3
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
//
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Tan suat xuat hien:");
//
// for (int i = 0; i < n; i++)
// {
//     bool daXet = false;
//
//     for (int j = 0; j < i; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             daXet = true;
//             break;
//         }
//     }
//     if (!daXet)
//     {
//         int dem = 0;
//
//         for (int j = 0; j < n; j++)
//         {
//             if (arr[i] == arr[j])
//                 dem++;
//         }
//
//         Console.WriteLine($"{arr[i]}: {dem}");
//     }
// }

