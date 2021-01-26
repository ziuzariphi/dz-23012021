using System;

namespace DzApp
{
    class Program
    {
        static void Main()
        {
            //DZ-1

            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = A + 1; i < B; i ++){
                s += i;
            }
            Console.WriteLine(s);

            int A1 = Convert.ToInt32(Console.ReadLine());
            int B1 = Convert.ToInt32(Console.ReadLine());
            for (int i = A1; i <= B1; i ++){
                if (i % 2 != 0){
                    Console.WriteLine(i);
                }
            }

            System.Console.Write("\n");
            for(int l = 0; l < 2; l ++){
                for (int i = 0; i < 5; i ++){
                    System.Console.Write("* ");
                }
                System.Console.Write("\n");
            }
            System.Console.Write("\n");

            int r = 1;
            while (r < 4){
                for(int i = 0; i < r; i ++){
                    System.Console.Write("* ");
                }
                System.Console.Write("\n");
                r ++; 
            }
            System.Console.Write("\n");
            
            int t = 3, d = 2;
            while (t > 0){
                for (int i = 0; i < t; i ++){
                    System.Console.Write("* ");
                }
                System.Console.Write("\n");
                for (int i = 0; i < t - d; i ++){
                    System.Console.Write(" ");
                }
                d -= 2;
                t --;
            }
            System.Console.Write("\n");

            for(int i = 0; i < 3; i ++){
                if (i % 2 == 0){
                    System.Console.Write("    *");
                }
                else{
                    for(int x = 0; x < 2; x ++){
                        System.Console.Write("  * ");
                    }
                }
                System.Console.Write("\n");
            }
            System.Console.Write("\n");

            int p = Convert.ToInt32(Console.ReadLine());
            int s1 = 1000, k = 0;
            while(s1 <= 1100){
                s1 += p;
                k ++;
            }
            Console.WriteLine(k + " " + s1);

            //DZ-2

            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int s2 = 0, maxi = -13876, mini = 13876;
            for (int i = 0; i < n; i ++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if(arr[i] > maxi){
                    maxi = arr[i];
                }
                if(arr[i] < mini){
                    mini = arr[i];
                }
                s2 += arr[i];
            }
            System.Console.WriteLine(maxi + " " + mini + " " + s2 + " " + (s2 / n));
            for (int i = 0; i < n; i ++){
                if(arr[i] % 2 != 0){
                    System.Console.WriteLine(arr[i]);
                }            
            }

            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n1];
            for (int i = 0; i < n1; i ++){
                array[i] = Convert.ToInt32(Console.ReadLine());            
            }
            for (int i = n1 - 1; i >= 0; i --){
                System.Console.WriteLine(array[i]);;
            }

            int N = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[N];
            int count = Convert.ToInt32(Console.ReadLine());
            int index = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[count];
            for(int i = 0; i < N; i ++){
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < N; i ++){
                Console.WriteLine(a[i]);
            }
            System.Console.WriteLine("\n");
            int j = 0;
            for(int i = index; i < N; i ++){
                b[j] = a[i];
                j ++;
            }
            for(int z = 0; z < j; z ++){
                System.Console.WriteLine(b[z]);
            }
            if((N - index) < count){
                for (int i = 0; i < (count - j); i ++){
                    System.Console.WriteLine(1);
                }
            }
        }
    }
}
