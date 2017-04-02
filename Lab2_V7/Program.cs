using System;
using System.Collections.Generic;

namespace Lab2_V7
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,Student> students = new SortedList<int,Student>();
          
            int countV = 0;
            int countO = 0;
            int countP1 = 0;
            int count = 0;
            bool continueProgram = false;
            do
            {
                continueProgram = false;
                string timeName;
                int timeV;
                int timeO;
                Console.WriteLine("BBeDiTb IM9I CTyDeHTa:");
                timeName = Console.ReadLine();
                Console.WriteLine("BBeDiTb KiJIbKiCTb IIpoIIyWeHuX roDuH:");
                timeV = int.Parse(Console.ReadLine());
                Console.WriteLine("BBeDiTb KiJIbKiCTb oIIpaBDaHuX roDuH:");
                timeO = int.Parse(Console.ReadLine());
                students.Add(count,new Student(timeName, timeV, timeO));
                count++;
                Console.WriteLine("Bu xo4ete IIpoDoB)I(uTu?(Y/N)");
                string otvet = Console.ReadLine();
                if (otvet == "Y") continueProgram = true;
            }
            while (continueProgram);
            foreach (var t in students)
            {
                Console.WriteLine("Name: {0}\n IIpoIIyCK: {1}\n OIIPaBDaHo: {2}\n V 4aC: {3}\n V BiDCoTKu: {4}\n", t.Value.name, t.Value.v, t.Value.o, t.Value.p1, t.Value.p2);
                countV += t.Value.v;
                countO += t.Value.o;
                countP1 += t.Value.p1;
            }
            Console.WriteLine("BCbOro IIPoIIyWeHO 6e3 BuIIpaBDaHb: {0}\n BCboro oIIPaBDaHo: {1}\n BCboro IIpoIIyWeHo: {2}\n",countV,countO,countP1);
            Console.ReadKey();
        }
    }
}
