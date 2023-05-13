using System;
using System.Reflection;

namespace ChargoonInternship
{
    public class AddHonorificsAttribute : Attribute
    {
        public string Honor { get; }
        public AddHonorificsAttribute(string honor)
        {
            Honor = honor;
        }
    }
    public static class AddHonorExtension
    {
        public static void PrintHonor<T>(this T _type)
        {
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties) {
                var attr = prop.GetCustomAttribute<AddHonorificsAttribute>();
                if (attr != null && prop.GetValue(_type) != null) {
                    Console.WriteLine($"{attr.Honor}{prop.GetValue(_type)}");
                }
            }
        }
    }
}
