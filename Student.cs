
namespace Eigenschappen
{
    internal class Student
    {
        // Definieer een statische eigenschap "Volgnummer" met expliciete get en set accessors
        public static int Volgnummer { get { volgnummer++; return volgnummer; } set { volgnummer = value; } }
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Opleiding { get; set; }

        private static int volgnummer = 0;


        public Student()
        {
            Id = Volgnummer;
        }

        public Student(string naam, string opleiding)
        {
            Id = Volgnummer;  // Ken het volgende "volgnummer" toe aan Id
            Naam = naam;
            Opleiding = opleiding;
        }

        public override string ToString()
        {

            return "Id: " + Id + "; Naam: " + Naam + ";  Opleiding: " + Opleiding;
        }
    }
}
