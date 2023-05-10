using System;

namespace BeautyProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Beauty Products");
        }

    }
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class TogoOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}