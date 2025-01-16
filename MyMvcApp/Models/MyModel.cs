using System;

namespace MyMvcApp.Models
{
    public class MyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Created Date: {CreatedDate}");
        }
    }
}
