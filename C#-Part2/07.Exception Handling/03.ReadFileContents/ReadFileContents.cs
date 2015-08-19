using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ReadFileContents
{
    public static void Main()
    {
        try
        {
            // Filename and path entering is hardcoded
            // Filename and path entering is hardcoded
            // Filename and path entering is hardcoded
            Console.WriteLine("Enter file path and name:");

            // string path = Console.ReadLine();
            string path = @"..\..\text.txt";
            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine("The text in the file is:");
            Console.WriteLine(text);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (DriveNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (PathTooLongException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught!\n{0}:{1}", ex.GetType().Name, ex.Message);
        }
    }
}