using Freelancer.Entities;
using Freelancer.Services;
using Freelancer.ValueObjects;
using Freelancer.Common;
using Freelancer.Abstract;


var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = "bob",
    LastName = "smith",
    PhoneNumber = "555-123-4567",
};

NotepadService notepadService = new();
notepadService.SaveToNotepad(anotherCustomerInstance);

string customerData = notepadService.GetOnNotepad("C:\\Users\\savcd\\source\\repos\\Freelancer\\Freelancer\\Database\\Customers.txt");

string[] splittedLines = customerData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new List<Customer>();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}








