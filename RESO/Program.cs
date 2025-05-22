using Microsoft.EntityFrameworkCore;
using RESO.Data;
using RESO.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        var orderBillDetails = new AppDbContext().Set<GetBill>()
            .FromSqlInterpolated($"select * from GetOrderBill({1})");
        foreach (var item in orderBillDetails)
        {
            Console.WriteLine($"************************************************************************ \n" +
                $"                       Bill_Of_Order                            \n" +
                $"----------------------------------------------------------------------  \n" +
                $"{item} \n" +
                $"************************************************************************ \n");
        }
        Console.ReadKey();
    }
}