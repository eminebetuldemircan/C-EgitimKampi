﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}



            //int[] numbers = { 48, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 48, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}



            //int[] numbers = { 48, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            //List<int> Numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}



            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("****** C# Eğitim Kampı UYgulaması ******");
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("----------------------------");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var:");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------");

            ////Öğrenci isimlerini  ve not ortalamlarını saklaycak diziler 
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($" {i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;


            //    //Her öğrenci için 3 sınav notu girişi 
            //    for (int j = 0; j < 3; j++)
            //    {
                 
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz.
            //    }
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine("----------------------------");


            ////Öğrencilerin ortalaması ve geçip kalma durumları 
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]} ");

            //    Console.WriteLine();

            //    if (studentExamAvg[i] >=50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
            //    }
            //    Console.WriteLine("----------------------------");
            //}

            #endregion

            Console.Read();
        }
    }
}