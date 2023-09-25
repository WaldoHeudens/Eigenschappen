using Eigenschappen;

Console.WriteLine("Geef een aantal studenten in");
Console.WriteLine("   Een lege naam beëindigt de loop");

string naam, opleiding;
List<Student> studenten = new List<Student>();
Student.Volgnummer = 1825;

do
{
    Console.Write("Geef de naam van de student:");
    naam = Console.ReadLine();
    if (naam != "")
    {
        Console.Write("Geef de naam van de opleiding:");
        opleiding = Console.ReadLine();
        studenten.Add(new Student(naam, opleiding));
    }
}
while (naam != "");

foreach (Student student in studenten)
    Console.WriteLine(student.ToString());