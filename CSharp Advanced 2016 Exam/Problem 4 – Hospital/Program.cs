using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4___Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            var departmentsAndRooms = new Dictionary<string, List<string>>();
            var doctorsAndPatients = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();
            while (input != "Output")
            {
                var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var department = line[0];

                var doctor = line[1] + " " + line[2];
                var patient = line[3];

                if (!departmentsAndRooms.ContainsKey(department))
                {
                    departmentsAndRooms[department] = new List<string>();
                }

                if (departmentsAndRooms[department].Count < 60)
                {
                    departmentsAndRooms[department].Add(patient);
                }

                if (!doctorsAndPatients.ContainsKey(doctor))
                {
                    doctorsAndPatients[doctor] = new List<string>();
                }
                if (!doctorsAndPatients[doctor].Contains(patient))
                {
                    doctorsAndPatients[doctor].Add(patient);
                }
                input = Console.ReadLine();
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                var formatToPrint = command.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (formatToPrint.Length == 1)
                {
                    foreach (var patient in departmentsAndRooms[formatToPrint[0]])
                    {
                        Console.WriteLine(patient);
                    }
                    command = Console.ReadLine();
                }
                else if (formatToPrint.Length == 2)
                {
                    int roomNum = 0;
                    string department = formatToPrint[0];

                    Int32.TryParse(formatToPrint[1], out roomNum);
                    if (roomNum != 0)
                    {
                        var patientsToSkip = 3 * (roomNum - 1);
                        foreach (var patient in departmentsAndRooms[department].Skip(patientsToSkip).Take(3).OrderBy(x => x))
                        {
                            Console.WriteLine(patient);
                        }
                        command = Console.ReadLine();
                    }
                    else
                    {
                        var name = formatToPrint[0] + " " + formatToPrint[1];

                        foreach (var patient in doctorsAndPatients[name].OrderBy(x => x))
                        {
                            Console.WriteLine(patient);
                        }
                        command = Console.ReadLine();
                    }
                }
            }


        }
    }
}
