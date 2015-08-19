using System;

// 2. Print Company Information
//
//    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//    Write a program that reads the information about a company and its manager and prints it back on the console.
public class PrintCompanyInformation
{
    public static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, age, managerPhoneNumber);       
    }
}