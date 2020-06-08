using System;
using System.Collections.Generic;
using Lab7Task2.manager;
using Lab7Task2.models;

namespace Lab7Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithFile control = new WorkWithFile();
            List<HousingBureau> bureaux = new List<HousingBureau>();
            control.FileInformationRead(bureaux);
            sign:
            Console.WriteLine("1.Add a new information");
            Console.WriteLine("2.Edit existing information");
            Console.WriteLine("3.Destroy existing information");
            Console.WriteLine("4.Show the existing information");
            Console.WriteLine("5.Sort by debt");
            Console.WriteLine("6.Sort by houses and workers");
            Console.WriteLine("7.Exit");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    control.FileInformationWrite(bureaux);
                    goto sign;
                }
                case 2:
                {
                    control.FileInformationEdit(bureaux);
                    goto sign;
                }
                case 3:
                {
                    control.RemoveExistingInformation(bureaux);
                    goto sign;
                }
                case 4:
                {
                    foreach (HousingBureau informationUnit in bureaux)
                    {
                        Console.WriteLine(informationUnit);
                    }

                    Console.ReadLine();
                    goto sign;
                }
                case 5:
                {
                    CompareByDebt comparer = new CompareByDebt();
                    List<HousingBureau> listToSort = bureaux;
                    listToSort.Sort(comparer);
                    foreach (HousingBureau housingBureau in listToSort)
                    {
                        Console.WriteLine(housingBureau);
                    }

                    Console.ReadLine();
                    goto sign;
                }
                case 6:
                {
                    CompareByHousesAndWorkers comparer = new CompareByHousesAndWorkers();
                    List<HousingBureau> listToSort = bureaux;
                    listToSort.Sort(comparer);
                    foreach (HousingBureau housingBureau in listToSort)
                    {
                        Console.WriteLine(housingBureau);
                    }
                    Console.ReadLine();
                    goto sign;
                }
                case 7:
                {
                    return;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong number");
                }
            }
        }
    }
}