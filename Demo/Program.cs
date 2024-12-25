namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //int.TryParse(Console.ReadLine(), out int n);
            //int[,] matrix = new int[n, n];
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            matrix[i, j] = 1;
            //        else
            //            matrix[i, j] = 0;
            //    }
            //}

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region 2-	Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numArray = { 7, 78, 65, 1, 85, 41 };
            //int sum = 0;
            //foreach (int item in numArray)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 3- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] firstArr = new int[size];
            //int[] secondArr = new int[size];
            //int[] merge = new int[size * 2];
            //for (int i = 0; i < firstArr.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out firstArr[i]);
            //}

            //for (int i = 0; i < secondArr.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out secondArr[i]);
            //}

            //for (int i = 0; i < firstArr.Length; i++)
            //{
            //    merge[i] = firstArr[i];
            //}

            //for (int i = 0; i < secondArr.Length; i++)
            //{
            //    merge[i + size] = secondArr[i];
            //}

            //Array.Sort(merge);

            //foreach (int x in merge)
            //{
            //    Console.Write($"{x} ");
            //}
            #endregion

            #region 4-	 Write a program in C# Sharp to count the frequency of each element of an array.
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse (Console.ReadLine(), out arr [i]);
            //}
            //bool[] prev = new bool[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (prev[i])
            //        continue;
            //    int count = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            prev[j] = true;
            //        }
            //    }
            //    Console.WriteLine($"{arr[i]}: {count}");
            //}
            #endregion

            #region 5-	Write a program in C# Sharp to find maximum and minimum element in an array
            #region Minimum
            ////min
            //int[] arr = { 1, 54, 4, 5, 6, 7, 2, 89, 45, 42, 41, 65, 4 };
            //int min = arr[0];
            //foreach (int i in arr)
            //{
            //    if (i < min)
            //    {
            //        min = i;
            //    }
            //}
            //Console.WriteLine(min);

            #endregion

            #region Maximum
            //max
            //int[] arr = { 1, 54, 4, 5, 6, 7, 2, 89, 45, 42, 41, 65, 4 };
            //int max = arr[0];
            //foreach (int i in arr)
            //{
            //    if (i > max)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine(max);
            #endregion
            #endregion

            #region 6- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = { 6, 1, 5, 2, 4, 3 };
            //int largest = arr[0];
            //int secondLargest = arr[1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        largest = arr[i];
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > secondLargest && arr[i] < largest)
            //    {
            //        secondLargest = arr[i];
            //    }
            //}

            //Console.WriteLine(secondLargest);
            #endregion

            //7 && 8
            #region 7- Consider an Array of Integer values with size N, having values as    
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];
            //Console.WriteLine("Array Elements:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int maxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = arr.Length - 1; j >= 0; j--)
            //    {
            //        if (arr[j] == arr[i])
            //        {
            //            int distance = j - i - 1;
            //            maxDistance = Math.Max(maxDistance, distance);

            //        }
            //    }
            //}
            //Console.WriteLine(maxDistance);
            #endregion

            #region 9- Given a list of space separated words, reverse the order of the words.
            //Console.Write("Input: ");
            //string term = Console.ReadLine();
            //Console.Write("Output: ");
            //string[] splitTerm = term.Split(' ');
            //Array.Reverse(splitTerm);
            //foreach (string s in splitTerm) 
            //    Console.Write($"{s} ");
            #endregion

            #region 10-	 Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //Console.Write("Enter size Number: ");
            //int.TryParse(Console.ReadLine(), out int size);
            ////Console.Write("Enter col Number: ");
            ////int.TryParse(Console.ReadLine(), out int col);
            //int[,] firstMultiArray = new int[size, size];
            //for (int i = 0; i < firstMultiArray.GetLength(0) ; i++)
            //{
            //    for (int j = 0; j < firstMultiArray.GetLength(1);)
            //    {
            //        j = int.TryParse(Console.ReadLine(), out firstMultiArray[i,j]) ? ++j : j;
            //    }
            //}

            //int[,] secondMultiArray = new int[size, size];
            //Array.Copy(firstMultiArray, secondMultiArray, firstMultiArray.Length);

            //for (int i = 0; i < secondMultiArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < secondMultiArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{secondMultiArray[i,j]} ");
            //    }
            //}
            #endregion

            #region 11-	Write a Program to Print One Dimensional Array in Reverse Order
            //int[] num = { 1, 2, 3, 4, 5};
            //Array.Reverse(num);
            //foreach (int item in num)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion
        }
    }
}
