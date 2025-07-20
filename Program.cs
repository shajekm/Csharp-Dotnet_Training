using Enumerations;
using System;

order order = new order(1, "Sample Order", DateTime.Now, OrderStatus.Pending);  
Console.WriteLine($"Order ID: {order.OrderId}");
Console.WriteLine($"Order Name: {order.OrderName}");
Console.WriteLine($"Order Date: {order.OrderDate}");
Console.WriteLine($"Order Status: {order.Status}");


// Enum example
Day today = Day.Wednesday;
Console.WriteLine($"Today from Enum is: {today}");

Day today1 = (Day)DateTime.Now.DayOfWeek;
Console.WriteLine($"But actually today is: {today1}");

OrderStatus Ordersts = OrderStatus.Processing ;
Console.WriteLine($"Order status is: {Ordersts}");

// using pipe with Flag enum
BitwiseOrdSts Ordersts1 = BitwiseOrdSts.Processing | BitwiseOrdSts.Completed ;
Console.WriteLine($"Bit wise order is : {Ordersts1}");


//Test for If loop 
Console.Write("Enter a number between 1-3 to find the matching month : ");
String input = Console.ReadLine();
Console.WriteLine($"{input}");

if (int.TryParse(input, out int monthNum) && monthNum >= 1 && monthNum <= 12)
    {
        Month3 selectedMonth = (Month3)monthNum;
        Console.WriteLine($"Month name: {selectedMonth}");
    }
else
    {
        Console.WriteLine("Invalid month number.");
    }

//Working on Arrays 
int [] array1 = [ 10,20,30,40,50];

for (int i=0; i < array1.Length; i++)
        {

    Console.WriteLine($"Displaying Array {i} : {array1[i]}");
        }

string[] fruits = ["Apple", "Banana", "Orange"];

foreach (string fruit in fruits)
{
    Console.WriteLine($"The fruits I like are {fruit}");
}

//Constructor and destructor
car car = new car();
Console.WriteLine("Creating a car object using default constructor.");

car car1 = new car("Toyota", "Camry", 2020);
Console.WriteLine("Creating a car object using parameterized constructor.");
car1.DisplayInfo();

temp temp = new temp();
Console.WriteLine("Creating a temp object using destructor.");

Console.ReadLine();

public class car
    {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public car()
    {
        Console.WriteLine("car constructor created");
    }
    public car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Make: {Make}, Model: {Model}, Year: {Year}");
    }
}

public class order : IDisposable
{
    public int OrderId { get; set; }
    public string OrderName { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }

    public order(int orderId, string orderName, DateTime orderDate, OrderStatus status)
    {
        OrderId = orderId;
        OrderName = orderName;
        OrderDate = orderDate;
        Status = status;
    }
    
    public order()
    {
    } 


    public void Dispose()
    {
        // Clean up resources if necessary
        Console.WriteLine("Disposing order resources.");
        GC.SuppressFinalize(this);
    }
}

public class temp : IDisposable
{
    public void Dispose()
    {
        // Clean up resources if necessary
        Console.WriteLine("Disposing temp resources.");
        GC.SuppressFinalize(this);
    }
}



class Temp1
{
    // Destructor
    ~Temp1()
    {
        Console.WriteLine("Object destroyed");
    }
}