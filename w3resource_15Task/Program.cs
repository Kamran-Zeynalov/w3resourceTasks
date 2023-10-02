namespace w3resource_15Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. Write a program in C# Sharp to create a blank file on the disk.

            string fileName = "Kamkam.txt";
            //try
            //{
            //    using FileStream fs = File.Create(fileName);
            //    Console.WriteLine($"Blank file '{fileName}' created successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 2. Write a program in C# Sharp to remove a file from the disk.

            //try
            //{
            //    File.Delete(fileName);
            //    Console.WriteLine($"File '{fileName}' has been deleted successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 3. Write a C# Sharp program to create a blank file on the disk if the same file already exists.


            //if (!File.Exists(fileName))
            //{
            //    try
            //    {
            //        using FileStream fs = File.Create(fileName);
            //        Console.WriteLine($"Blank file '{fileName}' created successfully.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"File '{fileName}' already exists.");
            //}

            //// 4. Write a program in C# Sharp to create a file and add some text.
            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(fileName))
            //    {
            //        sw.WriteLine("Hello, world!");
            //        sw.WriteLine("This is some sample text.");
            //        sw.WriteLine("You can add more lines as needed.");
            //    }

            //    Console.WriteLine($"Text has been written to '{fileName}' successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 5. Write a C# Sharp program to create a text file and read it.

            //CreateTextFile(fileName);


            //// 6. Write a program in C# Sharp to create a file and write an array of strings to the file.

            //     string[] stringArray = new string[]
            //{
            //     "Hello, world!",
            //     "line 2",
            //     "line 3",
            //     "add more lines"
            //};

            //     try
            //     {
            //         File.WriteAllLines(fileName, stringArray);

            //         Console.WriteLine($"Array of strings has been written to '{fileName}' successfully.");
            //     }
            //     catch (Exception ex)
            //     {
            //         Console.WriteLine($"Error: {ex.Message}");
            //     }

            //// 7. Write a C# Sharp program to create and write some lines of text into a file. This does not contain a given string on a line.

            //string excludedString = "excludeMe";
            //try
            //{
            //    using (StreamWriter sw = new(fileName))
            //    {
            //        sw.WriteLine("This is a sample line.");
            //        sw.WriteLine("Another line without the excluded string.");
            //        sw.WriteLine("This line contains the excluded string: excludeMe");
            //        sw.WriteLine("One more line without it.");
            //    }

            //    Console.WriteLine($"Text has been written to '{fileName}' successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //ReadTextFile(fileName, excludedString);

            //// 8. Write a program in C# Sharp to append some text to an existing file.

            //try
            //{
            //    using (StreamWriter sw = File.AppendText(fileName))
            //    {
            //        sw.WriteLine("This is some additional text.");
            //        sw.WriteLine("You can add more lines as needed.");
            //    }

            //    Console.WriteLine($"Text has been appended to '{fileName}' successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 9. Write a program in C# Sharp to create and copy the file to another name and display the content.



            //string originalFileName = "originalFile.txt";
            //string copiedFileName = "copiedFile.txt";

            //try
            //{
            //    using (StreamWriter sw = new(originalFileName))
            //    {
            //        sw.WriteLine("This is the content of the original file.");
            //        sw.WriteLine("You can add more lines as needed.");
            //    }

            //    Console.WriteLine($"Original file '{originalFileName}' has been created.");

            //    File.Copy(originalFileName, copiedFileName);

            //    Console.WriteLine($"File '{originalFileName}' has been copied to '{copiedFileName}'.");

            //    DisplayFileContent(copiedFileName);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            //// 10. Write a C# Sharp program to create a file and move it into the same directory with another name.

            //string originalFileName = "originalFile.txt";
            //string newFileName = "renamedFile.txt";
            //try
            //{
            //    using (FileStream fs = File.Create(originalFileName))
            //    {
            //        Console.WriteLine($"Original file '{originalFileName}' has been created.");
            //    }

            //    File.Move(originalFileName, newFileName);

            //    Console.WriteLine($"File '{originalFileName}' has been moved to '{newFileName}'.");

            //    if (File.Exists(newFileName))
            //    {
            //        DisplayFileContent(newFileName);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"New file '{newFileName}' does not exist.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 11. Write a C# Sharp program to read the first line of a file.

            //try
            //{
            //    using StreamReader sr = new(fileName);
            //    string firstLine = sr.ReadLine();

            //    if (firstLine != null)
            //    {
            //        Console.WriteLine($"First line of '{fileName}':");
            //        Console.WriteLine(firstLine);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The file '{fileName}' is empty.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 12. Write a program in C# Sharp to create and read the last line of a file.

            //CreateTextFile(fileName);
            //ReadLastLineOfFile(fileName);

            //// 13. Write a program in C# Sharp to read a specific line from a file.

            //int lineIndex = 3;

            //try
            //{
            //    string line = ReadSpecificLineFromFile(fileName, lineIndex);

            //    if (line != null)
            //    {
            //        Console.WriteLine($"Line {lineIndex} from '{fileName}':");
            //        Console.WriteLine(line);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Line {lineIndex} does not exist in '{fileName}'.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}

            //// 14. Write a C# Sharp program to create and read the last n lines of a file.

            //int n = 3;
            //CreateTextFile(fileName);
            //ReadLastNLinesOfFile(fileName, n);

            //// 15. Write a program in C# Sharp to count the number of lines in a file.

            try
            {
                int lineCount = CountLinesInFile(fileName);

                Console.WriteLine($"Number of lines in '{fileName}': {lineCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void CreateTextFile(string fileName)
        {
            try
            {
                using (StreamWriter sw = new(fileName))
                {
                    sw.WriteLine("Hello, world!");
                    sw.WriteLine("This is some sample text.");
                    sw.WriteLine("You can add more lines as needed.");
                }

                Console.WriteLine($"Text has been written to '{fileName}' successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while creating the file: {ex.Message}");
            }
        }
        static void ReadTextFile(string fileName)
        {
            try
            {
                using StreamReader sr = new(fileName);
                Console.WriteLine($"Reading content from '{fileName}':");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading the file: {ex.Message}");
            }
        }
        static void ReadTextFile(string fileName, string excludedString)
        {
            try
            {
                using StreamReader sr = new(fileName);
                Console.WriteLine($"Reading content from '{fileName}':");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Contains(excludedString))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading the file: {ex.Message}");
            }
        }
        static void DisplayFileContent(string fileName)
        {
            try
            {
                using StreamReader sr = new(fileName);
                Console.WriteLine($"Content of '{fileName}':");

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while reading the file: {ex.Message}");
            }
        }
        static void ReadLastLineOfFile(string fileName)
        {
            try
            {
                string lastLine = File.ReadLines(fileName).LastOrDefault();

                if (lastLine != null)
                {
                    Console.WriteLine($"Last line of '{fileName}':");
                    Console.WriteLine(lastLine);
                }
                else
                {
                    Console.WriteLine($"The file '{fileName}' is empty.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static string ReadSpecificLineFromFile(string fileName, int lineIndex)
        {
            try
            {
                var lines = File.ReadLines(fileName);

                string line = lines.ElementAtOrDefault(lineIndex - 1);

                return line;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        static void ReadLastNLinesOfFile(string fileName, int n)
        {
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(fileName));

                int lineCount = lines.Count;

                if (lineCount >= n)
                {
                    List<string> lastNLines = lines.GetRange(lineCount - n, n);

                    Console.WriteLine($"Last {n} lines of '{fileName}':");

                    foreach (string line in lastNLines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"The file '{fileName}' contains fewer than {n} lines.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static int CountLinesInFile(string fileName)
        {
            try
            {
                var lines = File.ReadLines(fileName);

                int lineCount = lines.Count();

                return lineCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
        }

    }
}