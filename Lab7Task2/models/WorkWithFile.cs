using System;
using System.Collections.Generic;
using System.IO;

namespace Lab7Task2.models
{
    public class WorkWithFile
    {
        public void FileInformationRead(List<HousingBureau> bureaux)
        {
            string reader;
            string[] stringArray;
            using (StreamReader streamReader = new StreamReader("Bureaux.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    reader = streamReader.ReadLine();
                    if (reader != "" && reader != " ")
                    {
                        stringArray = reader.Split(" | ");
                        bureaux.Add(new HousingBureau(stringArray[0], stringArray[1], stringArray[2],
                            int.Parse(stringArray[3]), int.Parse(stringArray[4]), int.Parse(stringArray[5])));
                    }
                }
            }
        }

        public void FileInformationWrite(List<HousingBureau> bureaux)
        {
            using (StreamWriter bureauInformationWriter = new StreamWriter("Bureaux.txt"))
            {
                Console.WriteLine("Type department name: ");
                string departmentName = Console.ReadLine();
                Console.WriteLine("Type address");
                string address = Console.ReadLine();
                Console.WriteLine("Type chief surname");
                string chiefSurname = Console.ReadLine();
                Console.WriteLine("Type buildings amount");
                int buildingsAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Type amount of workers");
                int workersAmount = int.Parse(Console.ReadLine());
                Console.WriteLine("Type debt");
                int debt = int.Parse(Console.ReadLine());
                HousingBureau bureauInformationToAdd = new HousingBureau(departmentName, address, chiefSurname,
                    buildingsAmount, workersAmount, debt);
                bureaux.Add(bureauInformationToAdd);
                foreach (HousingBureau lecture in bureaux)
                {
                    bureauInformationWriter.WriteLine(lecture.ToString());
                }
            }
        }
        public void FileInformationEdit(List<HousingBureau> bureaux)
        {
            for (int i = 0; i < bureaux.Count; i++)
            {
                Console.WriteLine(i+1+"."+bureaux[i]);
            }
            Console.WriteLine("Type the number of student you want to edit");
            int number = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Select action:");
            Console.WriteLine("1.Edit department name");
            Console.WriteLine("2.Edit address");
            Console.WriteLine("3.Edit chief surname");
            Console.WriteLine("4.Edit building amount");
            Console.WriteLine("5.Edit amount of workers");
            Console.WriteLine("6.Edit debt");
            Console.WriteLine("7.Edit all parameters");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    Console.WriteLine("Type new department name");
                    bureaux[number].name=Console.ReadLine();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Type new address");
                    bureaux[number].address=Console.ReadLine();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Type new chief surname");
                    bureaux[number].chiefSurname=Console.ReadLine();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Type houses amount");
                    bureaux[number].buildingAmount=int.Parse(Console.ReadLine());
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Type new amount of workers");
                    bureaux[number].workerAmount=int.Parse(Console.ReadLine());
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Type new amount of debt");
                    bureaux[number].personDebt=int.Parse(Console.ReadLine());
                    break;
                }
                case 7:
                {
                    Console.WriteLine("Type new department name");
                    bureaux[number].name=Console.ReadLine();
                    Console.WriteLine("Type new address");
                    bureaux[number].address=Console.ReadLine();
                    Console.WriteLine("Type new chief surname");
                    bureaux[number].chiefSurname=Console.ReadLine();
                    Console.WriteLine("Type houses amount");
                    bureaux[number].buildingAmount=int.Parse(Console.ReadLine());
                    Console.WriteLine("Type new amount of workers");
                    bureaux[number].workerAmount=int.Parse(Console.ReadLine());
                    Console.WriteLine("Type new amount of debt");
                    bureaux[number].personDebt=int.Parse(Console.ReadLine());
                    break;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }
            File.WriteAllText("Bureaux.txt",String.Empty);
            using (StreamWriter sw=new StreamWriter("Bureaux.txt")){
            
                foreach (HousingBureau bureau in bureaux)
                {
                    sw.WriteLine(bureau.ToString());
                }
            } 
        }
        public void RemoveExistingInformation(List<HousingBureau> bureaux)
        {
            for (int i = 0; i < bureaux.Count; i++)
            {
                Console.WriteLine(i+1+"."+bureaux[i]);
            }
            Console.WriteLine("Type the number of information you want to remove");
            int number = int.Parse(Console.ReadLine())-1;
            bureaux.RemoveAt(number);
            File.WriteAllText("Bureaux.txt",String.Empty);
            using (StreamWriter sw=new StreamWriter("Bureaux.txt"))
            {
                foreach (HousingBureau bureau in bureaux)
                {
                    sw.WriteLine(bureau.ToString());
                }
            }
        }
    }
}