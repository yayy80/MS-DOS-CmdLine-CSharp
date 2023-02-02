using System;
using System.Collections.Generic;

namespace FileSystem
{
    class Files
    {       
 
        static void Main(string[] args)
        {   
            Console.WriteLine("Choose a type: Folder, File");
            string type = Console.ReadLine();
            if (type == "Folder")
            {
                Console.WriteLine("Enter a name for the folder");
                string name = Console.ReadLine();
                Folder folder = new Folder(name);
                Console.WriteLine("Folder created");
            }
            else if (type == "File")
            {
                Console.WriteLine("Enter a name for the file");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a content for the file");
                string content = Console.ReadLine();
                File file = new File(name, content);
                Console.WriteLine("File created");
                // Ask the user if they want to move a file to a folder
                Console.WriteLine("Do you want to move a file to a folder? (yes/no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Enter the path of the file");
                    string filePath = Console.ReadLine();
                    Console.WriteLine("Enter the path of the destination folder");
                    string destinationFolderPath = Console.ReadLine();
                    folder.AddFile(file);
                    Console.WriteLine("File moved");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                }
                // Ask the user if they want to move a folder to a folder
                Console.WriteLine("Do you want to move a folder to a folder? (yes/no)");
                string answew03 = Console.ReadLine();
                if (answer03 == "yes")
                {
                    Console.WriteLine("Enter the path of the folder");
                    string folderPath = Console.ReadLine();
                    Console.WriteLine("Enter the name of the destination folder");
                    string destinationFolderPath = Console.ReadLine();
                    folder.AddFolder(folder);
                    Console.WriteLine("Folder moved");
                }
                else if (answer03 == "no")
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                }
                // Ask the user if they want to delete a file
                Console.WriteLine("Do you want to delete a file? (yes/no)");
                string answer02 = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Enter the path of the file");
                    string filePath = Console.ReadLine();
                    file.DeleteFile(file);
                    Console.WriteLine("File deleted");
                }
                else if (answer02 == "no")
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                }
                // Ask the user if they want to delete a folder
                Console.WriteLine("Do you want to delete a folder? (yes/no)");
                string answer01 = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Enter the path of the folder");
                    string folderPath = Console.ReadLine();
                    bool deleteWorked = Folder.DeleteFolder(folderPath);
                    Console.WriteLine("Folder deleted");
                }
                else if (answer01 == "no")
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                }
                // Ask the user if they want to rename a file
                Console.WriteLine("Do you want to rename a file? (yes/no)");
                string answer3 = Console.ReadLine();
                if (answer3 == "yes")
                {
                    Console.WriteLine("Enter the path of the file");
                    string filePath = Console.ReadLine();
                    Console.WriteLine("Enter the new name of the file");
                    string newFileName = Console.ReadLine();
                    file.Rename(newFileName);
                    Console.WriteLine("File renamed");
                }
                else if (answer3 == "no")
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                }
                // Ask the user if they want to rename a folder
                Console.WriteLine("Do you want to rename a folder? (yes/no)");
                string answer1 = Console.ReadLine();
                if (answer1 == "yes")
                {
                    Console.WriteLine("Enter the path of the folder");
                    string folderPath = Console.ReadLine();
                    Console.WriteLine("Enter the new name of the folder");
                    string newFolderName = Console.ReadLine();
                    folder.Rename(newFolderName);
                    Console.WriteLine("Folder renamed");
                }
                else if (answer1 == "no")
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid answer");
                }
            // Make the code work by storing the files or folders in the folder: Storage
            // Store the files and folders created in the Storage folder
            // Store the files and folders deleted in the host computer Recycle Bin
        class Storage
        {
            public string Name { get; set; }
            public List<File> Files { get; set; }
            public List<Folder> Folders { get; set; }
            public Storage(string name)
            {
                Name = name;
                Files = new List<File>();
                Folders = new List<Folder>();
            }
            public void AddFile(File file)
            {
                Files.Add(file);
            }
            public void AddFolder(Folder folder)
            {
                Folders.Add(folder);
            }
            public void DeleteFile(File file)
            {
                Files.Remove(file);
            }
            public void DeleteFolder(Folder folder)
            {
                Folders.Remove(folder);
            }
        }