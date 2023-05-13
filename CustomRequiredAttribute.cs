using System;
using System.Reflection;

namespace ChargoonInternship
{
    public class CustomRequiredAttribute : Attribute
    {
        private string ErrorMessage { get; set; }

        public CustomRequiredAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public void PrintError()
        {
            Console.Error.WriteLine(ErrorMessage);
            
        }
    }

    public static class RequiredExtension
    {
        public static void PrintError<T>(this T _type)
        {
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                var attr = prop.GetCustomAttribute<CustomRequiredAttribute>();
                if (attr != null && prop.GetValue(_type) == null) {
                    attr.PrintError();
                }
                
            }
        }
    }
}

