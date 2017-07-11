Nuget

Nuget is the package manager for C#, and you can install packages just like you did with npm except now you will use the dotnet CLI.

For this exercise, we'll be using a ValueTuple which must be installed from Nuget. Here's the command you need to run inside your project directory.

dotnet add package System.ValueTuple
Transaction Tuples

Tuples are very lightweight types that you can define without the need of a class. They can be very useful when you need a simple object that can store multiple values but do not deem it necessary to create a custom type in your system.

Setup

mkdir -p ~/workspace/csharp/exercises/tuples && cd $_
dotnet new console
dotnet add package System.ValueTuple
dotnet restore
References

C# Tuple types
Basic C# tuples
Instructions

In Main method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
Add 5, or more, transactions to the list.
Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.
foreach ((string product, double amount, int quantity) t in transactions)
{
    // Logic goes here to look up quantity and amount in each transaction
}
Sample output

Items sold today: 23
Total revenue: $3011.76