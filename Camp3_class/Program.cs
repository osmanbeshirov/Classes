using System;

namespace Camp3_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();

            kurs1.Kursadi = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 30;

            Kurs kurs2 = new Kurs();

            kurs2.Kursadi = "Angular";
            kurs2.KursEgitmeni = "Osman Beshirov";
            kurs2.IzlenmeOrani = 30;


            Kurs kurs3 = new Kurs();
            kurs3.Kursadi = "PHP";
            kurs3.KursEgitmeni = "Trusik";
            kurs3.IzlenmeOrani = 60;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " " + kurs.KursEgitmeni);
            }

            Console.WriteLine("***************");

            Students student1 = new Students();
            student1.student_name = "Osman";
            student1.student_no = 3;
            student1.student_point = 94;

            Students student2 = new Students();
            student2.student_name = "Kenan";
            student2.student_no = 5;
            student2.student_point = 74;


            Students student3 = new Students();
            student3.student_name = "Amil";
            student3.student_no = 7;
            student3.student_point =  48;

            Students student4 = new Students();
            student4.student_name = "Arif";
            student4.student_no = 11;
            student4.student_point = 51;

            //int[] ballar = new int[] { student1.student_point, student2.student_point, student3.student_point };

            Students[] ogrenciler = new Students[] {student1,student2,student3,student4 };

            int pass_point = 51;

            foreach (var ogrenci in ogrenciler)
            {
                if (ogrenci.student_point >= pass_point)
                {
                    Console.WriteLine("Congrulations... " + "Is called: " + ogrenci.student_name + " Student number is: " + ogrenci.student_no + " ,is passed the exam, widht: " + ogrenci.student_point + "point");
                }

                else
                {
                    Console.WriteLine("Sorry :( " + "Is called: " + ogrenci.student_name + " Student number is: " + ogrenci.student_no + " ,is failed the exam, widht: " + ogrenci.student_point + "point");
                }
            }
        }
    }

    class Kurs
    {
        public string Kursadi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    class Students
    {
        public string student_name { get; set; }
        public int student_no { get; set; }
        public int student_point { get; set; }
    }
}
