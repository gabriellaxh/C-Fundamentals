using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.PetClinic
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<Pet>();
            var clinics = new List<Clinic>();

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var info = Console.ReadLine().Split();

                try
                {
                    switch (info[0])
                    {
                        case "Create":
                            switch (info[1])
                            {
                                case "Pet":
                                    string nameP = info[2];
                                    int age = int.Parse(info[3]);
                                    string kind = info[4];
                                    pets.Add(new Pet(nameP, age, kind));
                                    break;

                                case "Clinic":
                                    string nameC = info[2];
                                    int rooms = int.Parse(info[3]);
                                    clinics.Add(new Clinic(nameC, rooms));
                                    break;
                            }
                            break;

                        case "Add":
                            string petName = info[1];
                            string clinicName = info[2];

                            var clinic = clinics.FirstOrDefault(x => x.Name == clinicName);
                            var pet = pets.FirstOrDefault(x => x.Name == petName);

                            clinic.AddPet(pet);
                            break;

                        case "Release":
                            string clinicName_ = info[1];
                            var clinic_ = clinics.FirstOrDefault(x => x.Name == clinicName_);

                            Console.WriteLine(clinic_.ReleasePet());
                            break;

                        case "HasEmptyRooms":
                            string clinicName__ = info[1];
                            var clinc__ = clinics.FirstOrDefault(x => x.Name == clinicName__);

                            Console.WriteLine(clinc__.HasEmptyRooms());
                            break;

                        case "Print":

                            if (info.Length == 3)
                            {
                                var clinicN = clinics.FirstOrDefault(x => x.Name == info[1]);
                                int roomNum = int.Parse(info[2]);

                                clinicN.Print(roomNum);
                            }

                            else
                            {
                                var clinicc = clinics.FirstOrDefault(x => x.Name == info[1]);

                                clinicc.Print();
                            }
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

