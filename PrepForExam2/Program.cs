using System;
using System.Reflection;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            //Book book = new Book("Sherlock Holmes",2003,204);

            //Employee employee = new Employee(34,"Ahmet Suyeri",4000);

            //Department department = new Department(new Employee[] {employee,employee });

            //book.ToString();

            //Console.WriteLine("Departments Employees");
            //Console.WriteLine("---------------------");
            //foreach(Employee person in department.employees)
            //{
            //    Console.WriteLine(person.name_surname +" "+person.age+" "+person.wage);
            //}
            //Console.Write("Vize Noutunuz:");
            //int vize = int.Parse(Console.ReadLine());
            //Console.Write("Final Noutunuz:");
            //int final = int.Parse(Console.ReadLine());
            //if (final < 50 || (final*0.6+vize*0.4)<50) {
            //    Console.Write("Büte girmek zorunda kaldınız, Büt notunuz:");
            //    int but = int.Parse(Console.ReadLine());
            //    if (but>50 && (but * 0.6 + vize * 0.4) > 50)
            //    {
            //        Console.WriteLine("Başarıyla geçtiniz tebrikler.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kaldınız.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Başarıyla geçtiniz tebrikler.");
            //}

            InverseFactSum(4);

            int[] dizi = new int[4] {3,2,7,4};
            int[] dizi1 = new int[4] {5,7,23,1};

            for(int i = 0; i < 4; i++)
            {
                dizi[i] = dizi[i]%5 + dizi1[i]%5;
            }
            
            foreach(int i in dizi)
            {
                Console.Write(i+" ");
            }

            char[,] chardizisi = new char[15, 15];

            Random rand = new Random();
            for(int i = 0; i < chardizisi.GetLength(0); i++)
            {
                for (int j = 0; j < chardizisi.GetLength(1); j++)
                {
                    if (rand.NextDouble() > 0.5)
                    {
                        chardizisi[i, j] = 'S';
                    }
                    else
                    {
                        chardizisi[i, j] = 'O';
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < chardizisi.GetLength(0); i++)
            {
                for (int j = 0; j < chardizisi.GetLength(1); j++)
                {
                    Console.Write(chardizisi[i,j]+" ");
                }
                Console.WriteLine();
            }

            AsalCarp(100);

            Urun kulaklik = new Urun("Mei Rgb 0.7", 400);

            Console.WriteLine("{0} | {1} | {2}",kulaklik.Isim,kulaklik.Fiyat,kulaklik.Kdvli_Fiyat);
        }

        public static int factorial(int i)
        {
            if (i == 0 || i == 1)
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
        }

        public static void InverseFactSum(int i)
        {
            double result = 0;
            for(int j = 0; j < i; j++)
            {
                result = result + (1 / (double)factorial(j));
            }

            Console.WriteLine(result);
        }

        public static void AsalCarp(int a)
        {
            for(int i = 2; i < a; i++)
            {
                if (AsalMi(i))
                {
                    Console.WriteLine("{0} asal sayıdır.",i);
                }
            }
        }

        public static bool AsalMi(int a)
        {
            if (a == 2 || a==3 || a==5 || a==7)
            {
                return true;
            }
            int count = 0;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


    }

    class Urun
    {
        private string isim;
        private int fiyat;
        private double kdvli_fiyat;
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public int Fiyat
        {
            get { return fiyat; }
            set
            {
                fiyat= value<0 ? 1 : value;
            }
        }

        public double Kdvli_Fiyat
        {
            get { return kdvli_fiyat; }
            set { kdvli_fiyat = this.fiyat * 1.18; }
        }

        public Urun()
        {

        }

        public Urun(string isim, int fiyat)
        {
            this.Isim = isim;
            this.Fiyat = fiyat;
            Kdvli_Fiyat = Fiyat;
        }
    }

    

    //Composition (İçerme)
    class Pages
    {
        int page_count;

        public Pages()
        {
            this.page_count = 0;
        }

        public Pages(int page_count)
        {
            this.page_count=page_count;
        }

        public override string ToString()
        {
            return "Page Number:"+this.page_count;
        }
    }

    class Book
    {
        string name;
        int publish_date;
        public Pages pages;

        public Book()
        {

        }

        public Book(string name, int publish_date,int page_count)
        {
            this.name = name;
            this.publish_date = publish_date;
            this.pages = new Pages(page_count);
        }

        public void ToString()
        {
            Console.WriteLine("{0} | {1} | {2}",name,pages.ToString(),publish_date);
        }
    }
    //--------------------

    //Aggregation (Birleşme)
    class Employee
    {
        public int age;
        public string name_surname;
        public int wage;

        public Employee()
        {

        }

        public Employee(int age, string name_surname, int wage)
        {
            this.age = age;
            this.name_surname = name_surname;
            this.wage = wage;
        }
    }

    class Department
    {
        public Employee[] employees = new Employee[100];
        public Department()
        {

        }
        public Department(Employee[] employees)
        {
            this.employees = employees;
        }
    }
    //----------------------

}