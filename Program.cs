using System;
public class Lesson
{
    static void Main(string[] args)
    {
        Sort();
        
//too big space 

    }


    //public enum orderBy
    //{
    //    Asc = + 1,
    //    Desc = - 1,


    //}
//try to avoid the commented code

    public static void Sort()
    {
        sortAlgoritmTypes a = new();
        int[] array = new int[10] { 56, 1, 99, 67, 89, 23, 44, 12, 78, 34 };
        a.selectionSort(array);
        a.bubbleSort(array);
        a.printArray(array);
        a.insertionSort(array);
        //orderBy = orderBy.Asc | orderBy.Desc;
        //Console.WriteLine(orderBy);

        
//too big space 

    }
   
    public class sortAlgoritmTypes
    {
        public void selectionSort(int[] array)
        {
            //Selection sort

            int n = 10;
            Console.WriteLine("Selection sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Sorted selection array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        // bubble sort
        public void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        //void names should follow to Pascal notation, but variables names should follow to camel notation
        public void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        // insertion sort
        public void insertionSort(int[] array_1)
        {
            int n = array_1.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array_1[i];
                int j = i - 1;


                while (j >= 0 && array_1[j] > key)
                {
                    array_1[j + 1] = array_1[j];
                    j -= 1;
                }
                array_1[j + 1] = key;
            }

            n = array_1.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array_1[i] + " ");

            Console.Write("\n");

        }

    }

    

   //too big space 

}

//checked

