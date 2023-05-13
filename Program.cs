using System;

namespace ChargoonInternship
{
    public class Program
    {
        static void Main()
        {
            var John = new MalePerson() { FirstName = "John" };
            John.PrintHonor();
            
            var AlexWithoutName = new MalePerson();
            AlexWithoutName.PrintError();

            var Sarah = new FemalePerson { FirstName = "Sarah" };
            Sarah.PrintHonor();

            Console.ReadLine();
        }
    }
    public class MalePerson
    {
        [AddHonorifics(honor:"Mr.")]
        [CustomRequired(errorMessage:"This field is Requierd!")]
        public string FirstName { get; set; }
    }

    public class FemalePerson {
        [AddHonorifics(honor:"Mrs.")]
        public string FirstName { get; set; }
    }
}
