using Bogus;
using WebApplication1.Models;

namespace WebApplication1.Classes
{
    public class BogusOperations
    {
        public static List<Customer> Customers(int count = 1)
        {
            var fakePerson = new Faker<Customer>()
                .RuleFor(c => c.Name, f => f.Company.CompanyName())
                .RuleFor(c => c.Id, f  => Guid.NewGuid());

            return fakePerson.Generate(count);

        }
    }
}
