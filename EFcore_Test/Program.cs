using EFcore_Test;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        //transaction
        //using(var context=new AppDbContext())
        //  {
        //      using(var transaction = context.Database.BeginTransaction())
        //      {

        //       var from  = context.Wallets.Single(x => x.Id == 1);
        //          var to = context.Wallets.Single(x => x.Id == 51);
        //          var amout = 300m;
        //          from.Balance -= amout;
        //          to.Balance += amout;
        //          context.SaveChanges();
        //          transaction.Commit();

        //      }
        //      Console.WriteLine("trans succesfully ");
        //  }

        //quries
        //using (var context = new AppDbContext())
        //{
        //    var selection = context.Wallets.Where(x => x.Balance <= 5000);
        //   foreach(var item in selection)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //Update data
        //using(var context =new AppDbContext())
        //{
        //    var updatedWallet = context.Wallets.FirstOrDefault(x => x.Id == 4);
        //    updatedWallet.Holder = "Abdo Shady";
        //    context.SaveChanges();
        //}
        //Remove data
        //using(var context =new AppDbContext())
        //    {
        //        var removedWallet = context.Wallets.Where(x=>x.Holder== "Abdo Shady");
        //        context.Wallets.RemoveRange(removedWallet);
        //        context.SaveChanges();
        //        Console.WriteLine("removed wallet succesfully");

        //    }

        //insert data
        //Console.Write("Enter the Name Holder: ");
        //var nameHolder = Console.ReadLine();
        //Console.Write("Enter the amount of Balance: ");
        //var amountOfBalnce =Convert.ToDecimal( Console.ReadLine());
        //var wallet = new Wallet()
        //{
        //    Holder = nameHolder,
        //    Balance = amountOfBalnce
        //};
        //using(var context =new AppDbContext()) {
        //    context.Wallets.Add(wallet);
        //    context.SaveChanges();
        //    Console.WriteLine("wallet added succesfully");

        //}




        //get data by id 

        //char check = default;
        //while (check != 'n')
        //{
        //    try
        //    {
        //        Console.Write("Search with Id :");
        //        var input = Convert.ToInt32(Console.ReadLine());
        //        using (var context = new AppDbContext())
        //        {
        //            var item = context.
        //                Wallets.
        //                FirstOrDefault(x => x.Id == input);
        //            Console.WriteLine(item);
        //        }


        //        while (true)
        //        {
        //            Console.Write("Again ? (Y) or (N) : ");
        //            var againInput = Console.ReadLine()?.ToLower();

        //            if (string.IsNullOrWhiteSpace(againInput) || againInput.Length != 1)
        //            {
        //                Console.WriteLine(" Error: Please enter exactly one character.");
        //                continue;
        //            }

        //            check = againInput[0];

        //            if (check != 'y' && check != 'n')
        //            {
        //                Console.WriteLine("Invalid choice. Only Y or N are allowed.");
        //                continue;
        //            }
        //            else
        //            {

        //                break;
        //            }

        //        }
        //    }

        //    catch (Exception e)
        //    {
        //        Console.WriteLine("invalid input");
        //        Console.WriteLine(e.Message);


        //    }
        //    }
        //************************************************
        // get all data

        //using (var context = new AppDbContext())
        //{
        //    foreach (var item in context.Wallets)
        //    {
        //        Console.WriteLine(item);

        //    }

        //}
        Console.ReadKey();
    }
}
