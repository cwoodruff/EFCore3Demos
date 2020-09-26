﻿using System;
using System.Linq;
using System.Threading.Tasks;
using async.Model;
using Microsoft.EntityFrameworkCore;

namespace async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var db = new AdventureWorksContext())
            {
                var vendors =
                    from v in db.Vendor
                    where v.CreditRating > 1
                    select v;

                await foreach (var v in vendors.AsAsyncEnumerable())
                {
                    Console.WriteLine($"Found Vendor: {v.Name} {v.AccountNumber}");
                }
            }
        }
    }
}