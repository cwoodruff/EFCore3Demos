using System;
using from_sql.Model;
using Microsoft.EntityFrameworkCore;

namespace from_sql
{
    class Program
    {
        static void Main()
        {
            using var db = new AdventureWorksContext();

            var searchLastName = "Smith";

            var people =
                db.Person.FromSqlInterpolated(
                    //$"SELECT [BusinessEntityID],[PersonType],[NameStyle],[Title],[FirstName],[MiddleName],[LastName],[Suffix],[EmailPromotion],[AdditionalContactInfo],[Demographics],[rowguid],[ModifiedDate] FROM [Person].[Person] WHERE LastName = {searchLastName}");
                    $"SELECT * FROM [Person].[Person] WHERE LastName = {searchLastName}");
            
            foreach (var person in people)
            {
                Console.WriteLine($"Found Person: {person.FirstName} {person.LastName}");
            }
        }
    }
}