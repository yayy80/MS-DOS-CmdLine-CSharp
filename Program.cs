using System;
using System.Collections.Generic;

namespace Win101
{
    public class OSMetadata
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public string CopyrightYear { get; set; }

        public OSMetadata(string name, string version, string copyrightYear)
        {
            this.Name = name;
            this.Version = version;
            this.CopyrightYear = copyrightYear;
        }
    }


    class MSDOS
    {
        private static string boot;
        private static string config;
        private static string drive;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MS-DOS");
            Console.WriteLine("Version 1.01");
            Console.WriteLine("Copyright Microsoft Corp 1981");
            Console.Write("C:\\>");
            string command = Console.ReadLine();
            if (command == "help")
            {
                Console.WriteLine("Commands: help, mount, boot, shutdown, reboot, sessionend, mdisk");
            }
            if (command == "mount")
            {
                bool found = false;
                while (!found)
                {
                    found = true;
                    Console.WriteLine("Please select a drive letter");
                    string drive = Console.ReadLine();
                    switch (drive)
                    {
                        case "C":
                            Console.WriteLine("Drive C is already in a floppy disk");
                            break;
                        case "A":
                        case "B":
                        case "D":
                        case "E":
                        case "F":
                        case "G":
                            Console.WriteLine("Please configure the drive with the command: mdisk");
                            break;
                        default:
                            found = false;
                            break;
                    }
                }
            }

            if (command == "boot")
            {
                Console.WriteLine("Booting onto mounted drive");
                Console.WriteLine("Please wait, this may take a few seconds");
                Console.WriteLine("Reading OS");
                Console.WriteLine("Loading");
                Console.WriteLine("Creating folder: MS-CONFIG");
                Console.WriteLine("Removing any newer styled folders NOTE: PLEASE TAKE BACKUPS OF THE DRIVE BEFORE PROCEEDING");
                Console.WriteLine("Done with configuration");
                Console.WriteLine("Booting");
                Console.WriteLine("Welcome to DOS");
                Console.WriteLine("Please select a disk to boot from, or stay in DOS");
                string disk = Console.ReadLine();
                if (disk == "DEFAULT")
                {
                    disk = "C";
                }

                Dictionary<string, OSMetadata> windowsVersions = new Dictionary<string, OSMetadata>() { { "A", new OSMetadata("Windows", "Version 1.01", "1985") }, 
                                                                                                { "B", new OSMetadata(name:"Windows", version: "Version 1.01", copyrightYear:"1985") },
                                                                                                { "C", new OSMetadata(copyrightYear:"1981", name:"MS-Dos", version: "Version 1.01") },
                                                                                                { "D", new OSMetadata("Windows", "Version 1.01", "1985") },
                                                                                                { "E", new OSMetadata("Windows", "Version 2.0", "1987") },
                                                                                                { "F", new OSMetadata("Windows", "Version 1.01", "1985") },
                                                                                                { "G", new OSMetadata("Windows", "Version 1.01", "1985") }};
                
                // how to use the dictionary
                //if (windowsVersions.ContainsKey("A"))
                //{
                //    Console.WriteLine(windowsVersions["A"]);
                //}
                
                if (windowsVersions.ContainsKey(disk))
                {
                    Console.WriteLine($"Booting from disk {disk}");
                    Console.WriteLine("Please wait, this may take a few seconds");
                    Console.WriteLine("Reading disk");
                    Console.WriteLine("Loading");
                    Console.WriteLine("Done");
                    Console.WriteLine($"Welcome to {windowsVersions[disk].Name}");
                    Console.WriteLine(windowsVersions[disk].Version);
                    Console.WriteLine($"Copyright Microsoft Corp {windowsVersions[disk].CopyrightYear}");
                    Console.Write($"{disk}:\\>");
                }
            }

            if (command == "shutdown")
            {
                Console.WriteLine("Shutting down");
                Console.WriteLine("Please wait, this may take a few seconds");
                Console.WriteLine("Done");
                Console.WriteLine("Goodbye");
            }
            if (command == "reboot")
            {
                Console.WriteLine("Rebooting");
                Console.WriteLine("Please wait, this may take a few seconds");
                Console.WriteLine("Done");
                Console.WriteLine("Welcome to MS-DOS");
                Console.WriteLine("Version 1.01");
                Console.WriteLine("Copyright Microsoft Corp 1981");
                Console.WriteLine("C:\\>");
            }
            if (command == "sessionend")
            {
                Console.WriteLine("Ending session");
                Console.WriteLine("Please wait, this may take a few seconds");
                Console.WriteLine("Done");
                Console.WriteLine("Goodbye");
                Console.WriteLine("DOS:\\>");
            }
            if (command == "mdisk")
            {
                Console.WriteLine("Please select a disk to configure");
                string disk = Console.ReadLine();
                if (disk == "A")
                {
                    Console.WriteLine("Select a system configuration file to edit:");
                    Console.WriteLine("1. boot.ini");
                    Console.WriteLine("2. config.sys");
                    Console.WriteLine("3. autoexec.bat");
                    Console.WriteLine("4. msdos.sys");
                    Console.WriteLine("5. io.sys");
                    Console.WriteLine("6. command.com");
                    if (config == "1")
                    {
                        Console.WriteLine("Please select a boot option");
                        Console.WriteLine("1. Year");
                        Console.WriteLine("2. Month");
                        Console.WriteLine("3. Day");
                        Console.WriteLine("4. Hour");
                        Console.WriteLine("5. Minute");
                        Console.WriteLine("6. Second");
                        Console.WriteLine("7. Safe Mode");
                        Console.WriteLine("8. Debug Mode");
                        Console.WriteLine("9. Command Prompt");
                        Console.WriteLine("10. DOS");
                        if (boot == "1")
                        {
                            Console.WriteLine("Please enter a year");
                            string year = Console.ReadLine();
                            Console.WriteLine("Year set to " + year);
                        }
                        if (boot == "2")
                        {
                            Console.WriteLine("Please enter a month");
                            string month = Console.ReadLine();
                            Console.WriteLine("Month set to " + month);
                        }
                        if (boot == "3")
                        {
                            Console.WriteLine("Please enter a day");
                            string day = Console.ReadLine();
                            Console.WriteLine("Day set to " + day);
                        }
                        if (boot == "4")
                        {
                            Console.WriteLine("Please enter an hour");
                            string hour = Console.ReadLine();
                            Console.WriteLine("Hour set to " + hour);
                        }
                        if (boot == "5")
                        {
                            Console.WriteLine("Please enter a minute");
                            string minute = Console.ReadLine();
                            Console.WriteLine("Minute set to " + minute);
                        }
                        if (boot == "6")
                        {
                            Console.WriteLine("Please enter a second");
                            string second = Console.ReadLine();
                            Console.WriteLine("Second set to " + second);
                        }
                        if (boot == "7")
                        {
                            Console.WriteLine("Safe Mode enabled");
                        }
                        if (boot == "8")
                        {
                            Console.WriteLine("Debug Mode enabled");
                        }
                        if (boot == "9")
                        {
                            Console.WriteLine("Command Prompt enabled");
                        }
                        if (boot == "10")
                        {
                            Console.WriteLine("DOS enabled");
                        }
                    }
                    if (config == "2")
                    {
                        Console.WriteLine("Please select an autoexec.bat option");
                        Console.WriteLine("1. Internet");
                        Console.WriteLine("2. Settings App");
                        Console.WriteLine("3. DOS Minecraft");
                    }
                    if (config == "3")
                    {
                        Console.WriteLine("Please select a config.sys option");
                        Console.WriteLine("1. Troubleshooting");
                        Console.WriteLine("2. Error list");
                    }
                    if (config == "4")
                    {
                        Console.WriteLine("Please select a msdos.sys option");
                        Console.WriteLine("1. Logoff");
                        Console.WriteLine("2. Shutdown");
                        Console.WriteLine("3. Reboot");
                        Console.WriteLine("4. Sessionend");
                    }
                    if (config == "5")
                    {
                        Console.WriteLine("Please select an io.sys option");
                        Console.WriteLine("1. Autoinf");
                        Console.WriteLine("2. Io");
                    }
                    if (config == "6")
                    {
                        Console.WriteLine("Please select a command.com option");
                        Console.WriteLine("1. Command Prompt");
                        Console.WriteLine("2. DOS");
                    }
                }
                if (disk == "B")
                {
                    Console.WriteLine("Select a system configuration file to edit:");
                    Console.WriteLine("1. boot.ini");
                    Console.WriteLine("2. config.sys");
                    Console.WriteLine("3. autoexec.bat");
                    Console.WriteLine("4. msdos.sys");
                    Console.WriteLine("5. io.sys");
                    Console.WriteLine("6. command.com");
                    if (config == "1")
                    {
                        Console.WriteLine("Please select a boot option");
                        Console.WriteLine("1. Year");
                        Console.WriteLine("2. Month");
                        Console.WriteLine("3. Day");
                        Console.WriteLine("4. Hour");
                        Console.WriteLine("5. Minute");
                        Console.WriteLine("6. Second");
                        Console.WriteLine("7. Safe Mode");
                        Console.WriteLine("8. Debug Mode");
                        Console.WriteLine("9. Command Prompt");
                        Console.WriteLine("10. DOS");
                        if (boot == "1")
                        {
                            Console.WriteLine("Please enter a year");
                            string year = Console.ReadLine();
                            Console.WriteLine("Year set to " + year);
                        }
                        if (boot == "2")
                        {
                            Console.WriteLine("Please enter a month");
                            string month = Console.ReadLine();
                            Console.WriteLine("Month set to " + month);
                        }
                        if (boot == "3")
                        {
                            Console.WriteLine("Please enter a day");
                            string day = Console.ReadLine();
                            Console.WriteLine("Day set to " + day);
                        }
                        if (boot == "4")
                        {
                            Console.WriteLine("Please enter an hour");
                            string hour = Console.ReadLine();
                            Console.WriteLine("Hour set to " + hour);
                        }
                        if (boot == "5")
                        {
                            Console.WriteLine("Please enter a minute");
                            string minute = Console.ReadLine();
                            Console.WriteLine("Minute set to " + minute);
                        }
                        if (boot == "6")
                        {
                            Console.WriteLine("Please enter a second");
                            string second = Console.ReadLine();
                            Console.WriteLine("Second set to " + second);
                        }
                        if (boot == "7")
                        {
                            Console.WriteLine("Safe Mode enabled");
                        }
                        if (boot == "8")
                        {
                            Console.WriteLine("Debug Mode enabled");
                        }
                        if (boot == "9")
                        {
                            Console.WriteLine("Command Prompt enabled");
                        }
                        if (boot == "10")
                        {
                            Console.WriteLine("DOS enabled");
                        }
                    }
                    if (config == "2")
                    {
                        Console.WriteLine("Please select an autoexec.bat option");
                        Console.WriteLine("1. Internet");
                        Console.WriteLine("2. Settings App");
                        Console.WriteLine("3. DOS Minecraft");
                    }
                    if (config == "3")
                    {
                        Console.WriteLine("Please select a config.sys option");
                        Console.WriteLine("1. Troubleshooting");
                        Console.WriteLine("2. Error list");
                    }
                    if (config == "4")
                    {
                        Console.WriteLine("Please select a msdos.sys option");
                        Console.WriteLine("1. Logoff");
                        Console.WriteLine("2. Shutdown");
                        Console.WriteLine("3. Reboot");
                        Console.WriteLine("4. Sessionend");
                    }
                    if (config == "5")
                    {
                        Console.WriteLine("Please select an io.sys option");
                        Console.WriteLine("1. Autoinf");
                        Console.WriteLine("2. Io");
                    }
                    if (config == "6")
                    {
                        Console.WriteLine("Please select a command.com option");
                        Console.WriteLine("1. Command Prompt");
                        Console.WriteLine("2. DOS");
                    }
                }
                if (disk == "C")
                {
                    Console.WriteLine("Error: This drive is configured already");
                }
                if (disk == "D")
                {
                    Console.WriteLine("E: This drive is configured already");
                }
                if (disk == "E")
                {
                    Console.WriteLine("Error: This drive is configured already");
                }
                if (disk == "F")
                {
                    Console.WriteLine("Error: This drive is configured already");
                }
                if (disk == "G")
                {
                    Console.WriteLine("Error: This drive is configured already");
                }
            }
        }
    }
}