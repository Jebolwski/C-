using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Sample
{
    class Class
    {
        static void Main(string[] args)
        {
            MyArrayList myArray = new MyArrayList();
            myArray.MyAdd("messi");
            myArray.MyAdd("penaldo");
            myArray.MySort();
            myArray.printArray();
            Console.WriteLine("================== Adding random 15 numbers");
            for (int i = 0; i < 15; i++)
            {
                Random rand=new Random();
                myArray.MyAdd(rand.Next(0,100));
            }
            myArray.printArray();

            Console.WriteLine("================== Reverse");
            myArray.MyReverse();
            myArray.printArray();
            Console.WriteLine("================== Insert 5 at 3");
            myArray.MyInsert(3, 5);
            myArray.printArray();
            Console.WriteLine("================== Sort");
            myArray.MySort();
            myArray.printArray();
            Console.WriteLine("================== Remove at 3");
            myArray.MyRemoveAt(3);
            myArray.printArray();
            Console.WriteLine("================== Clear");
            myArray.MyClear();
            myArray.printArray();
        }

    }

    class MyArrayList
    {
        private object[] array=new object[4];

        public MyArrayList()
        {
            for(int i=0;i<array.Length;i++)
            {
                array[i] = null;
            }
        }

        public object[] MyAdd(object x) { 
            if (MyCount()==array.Length)
            {
                object[] arr = new object[array.Length*2];
                for(int i = 0; i < array.Length; i++)
                {
                    arr[i] = array[i];
                }
                arr[array.Length] = x;
                array = arr;
            }
            else
            {
                array[MyCount()] = x;
            }
            return array;
        }
        
        public object[] MyRemoveAt(int x)
        {
            array[x] = null;
            for(int i = 0; i < array.Length-1;i++)
            {
                if (array[i] == null && array[i+1]!=null)
                {
                    array[i] = array[i + 1];
                    array[i + 1] = null;
                }
            }
            return array;
        }

        public object[] MyInsert(int index,object x)
        {
            if (array[index] == null)
            {
                array[index] = x;
                return array;
            }
            
            if (MyCount() == array.Length)
            {
                object[] arr = new object[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    arr[i] = array[i];
                }

                for(int i = arr.Length-2; i >=index; i--)
                {
                    arr[i + 1] = arr[i];
                }
                arr[index] = x;
                array = arr;
            }
            else
            {
                for (int i = array.Length - 2; i >= index; i--)
                {
                    array[i + 1] = array[i];
                }
                array[index] = x;
            }
            return array;
        }
        
        public int MyCount()
        {
            int x = MyCapacity();
            for(x = MyCapacity()-1; x>=0; x--)
            {
                if (array[x] != null)
                {
                    break;
                }
            }
            return x+1;
        }
        
        public int MyCapacity()
        {
            return array.Length;
        }
        
        public object[] MySort()
        {
            for (int i = 0; i < MyCount(); i++)
            {
                int min_index = i;
                for(int j = i; j < MyCount(); j++)
                {
                    object array_j = array[j];
                    object array_min = array[min_index];
                    try
                    {
                        if ((int)array[j] < (int)array_min) {
                            min_index = j;
                        }
                    }
                    catch {
                        int num_j=0;
                        int num_min = 0;

                        try
                        {
                            num_j = Convert.ToInt32(array[j].ToString()[0])-64;
                        }
                        catch
                        {
                            num_j = j;
                        }

                        try
                        {
                            num_min = Convert.ToInt32(array[min_index].ToString()[0])-64;
                        }
                        catch
                        {
                            num_min = j;
                        }

                        if (num_j < num_min)
                        {
                            min_index = j;
                        }
                    }
                }
                object temp = array[i];
                array[i] = array[min_index];
                array[min_index] = temp;
            }
            return array;
        }

        public object[] MyReverse()
        {
            for (int i = 0; i < MyCount()/2; i++)
            {
                object temp = array[i];
                array[i] = array[MyCount()-i-1];
                array[MyCount() - i - 1] = temp;
            }
            return array;
        }

        public object[] MyClear()
        {
            for(int i = 0; i < array.Length; i++) {
                array[i] = null;
            }
            return array;
        }

        public void printArray()
        {
            foreach(object obj in array)
            {
                if (obj == null)
                {
                    Console.Write("null, ");
                }
                else
                {
                    Console.Write(obj+", ");
                }
            }
            Console.WriteLine();
        }
    }
}
