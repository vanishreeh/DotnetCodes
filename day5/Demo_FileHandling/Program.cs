namespace Demo_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region File I/o Classes
            //string path = @"D:\Cognixia Batch2025\Sample.txt";
            //// File.Create(path);
            //File.WriteAllText(path, "Writing to sample File");
            //System.Environment
            //Console.WriteLine($"Os is ::{Environment.OSVersion}");
            //Console.WriteLine($"Machine Name::{Environment.MachineName}");
            //Console.WriteLine($"Current Directory::{Environment.CurrentDirectory}");
            //Directory
            //string directoryPath = @"D:\Cognixia Batch2025\NewFolder";
            //try
            //{
            //    if (!Directory.Exists(directoryPath))
            //    {
            //        Directory.CreateDirectory(directoryPath);
            //        Console.WriteLine("Created Successfully");
            //    }
            //    else
            //    {
            //        Directory.Delete(directoryPath);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine(Directory.GetCurrentDirectory());
            #endregion
            #region File Exceptions Included
            //string filePath = "dummy.txt";
            //try
            //{
            //    string readContents=File.ReadAllText(filePath);
            //    Console.WriteLine(readContents);
            //}
            //catch (FileNotFoundException fnex)
            //{
            //    Console.WriteLine(fnex.Message);
            //}
            //catch (UnauthorizedAccessException)
            //{

            //}
            //catch(Exception ex)
            //{

            //}
            #endregion

            string filePath = "Database.txt";
            using (StreamWriter writer = new StreamWriter(filePath,true))
            {
                writer.WriteLine("Writing to my file");
            }
            //read from File
            using (StreamReader reader = new StreamReader(filePath))
            {
                string content=reader.ReadToEnd();
                Console.WriteLine(content);
            }






        }
    }
}
