using POO_CSharp_P31.Entities;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 450.00));
        list.Add(new Product("HD CASE", 80.90));

        //Fun<Product, string> func = NameUpper; ou //p.Name.ToUpper();

        List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }

    }

    //static string NameUpper(Product p)
    //{
    //    return p.Name = p.Name.ToUpper();
    //}
}