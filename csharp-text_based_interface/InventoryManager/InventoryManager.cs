using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace InventoryManager
{
    class Program
    {
        public static void Main()
        {
            JSONStorage storageDevice = new JSONStorage();
            storageDevice.Load();

            List<string> classList = new List<string> { "item", "user", "inventory" };
            string prompt = "$ ";

            while (true)
            {
                DisplayCommands();
                Console.Write(prompt);
                string[] userSplit = Console.ReadLine().Split(' ');

                switch (userSplit[0].ToLower())
                {
                    case "classnames":
                        DisplayClassNames(classList);
                        break;

                    case "all":
                        if (userSplit.Length == 1)
                        {
                            DisplayAllObjects(storageDevice);
                        }
                        else
                        {
                            DisplayObjectsByClass(storageDevice, classList, userSplit[1]);
                        }
                        break;

                    case "create":
                        CreateObject(storageDevice, classList, userSplit);
                        break;

                    case "show":
                        ShowObject(storageDevice, classList, userSplit);
                        break;

                    case "update":
                        UpdateObject(storageDevice, classList, userSplit);
                        break;

                    case "delete":
                        DeleteObject(storageDevice, classList, userSplit);
                        break;

                    case "exit":
                        Console.WriteLine("Exiting the Inventory Manager.");
                        return;

                    default:
                        Console.WriteLine("Unknown command. Please try again.");
                        break;
                }
            }
        }

        static void DisplayCommands()
        {
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");
        }

        static void DisplayClassNames(List<string> classList)
        {
            foreach (string className in classList)
                Console.WriteLine(className);
        }

        static void DisplayAllObjects(JSONStorage storageDevice)
        {
            foreach (var obj in storageDevice.All())
                Console.WriteLine(obj.Value);
        }

        static void DisplayObjectsByClass(JSONStorage storageDevice, List<string> classList, string className)
        {
            if (!classList.Contains(className.ToLower()))
            {
                Console.WriteLine($"{className} is not a valid object type.");
                return;
            }

            foreach (var obj in storageDevice.All())
            {
                if (obj.Key.StartsWith(className.ToLower() + "."))
                    Console.WriteLine(obj.Value);
            }
        }

        static void CreateObject(JSONStorage storageDevice, List<string> classList, string[] userSplit)
        {
            if (userSplit.Length < 2)
            {
                Console.WriteLine("Object ClassName is missing.");
                return;
            }

            string className = userSplit[1].ToLower();
            if (!classList.Contains(className))
            {
                Console.WriteLine($"{className} is not a valid object type.");
                return;
            }

            var newObj = new { Name = className, Id = Guid.NewGuid().ToString() }; // Replace with actual object creation logic
            storageDevice.New(newObj);
            storageDevice.Save();
            Console.WriteLine($"Created new {className} with ID: {newObj.Id}");
        }

        static void ShowObject(JSONStorage storageDevice, List<string> classList, string[] userSplit)
        {
            if (userSplit.Length < 3)
            {
                Console.WriteLine("Usage: Show <ClassName> <object_id>");
                return;
            }

            string className = userSplit[1].ToLower();
            string id = userSplit[2];
            string key = $"{className}.{id}";

            if (!classList.Contains(className))
            {
                Console.WriteLine($"{className} is not a valid object type.");
                return;
            }

            if (storageDevice.All().TryGetValue(key, out var obj))
            {
                Console.WriteLine(obj);
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found.");
            }
        }

        static void UpdateObject(JSONStorage storageDevice, List<string> classList, string[] userSplit)
        {
            if (userSplit.Length < 3)
            {
                Console.WriteLine("Usage: Update <ClassName> <object_id>");
                return;
            }

            string className = userSplit[1].ToLower();
            string id = userSplit[2];
            string key = $"{className}.{id}";

            if (!classList.Contains(className))
            {
                Console.WriteLine($"{className} is not a valid object type.");
                return;
            }

            if (!storageDevice.All().TryGetValue(key, out var obj))
            {
                Console.WriteLine($"Object {id} could not be found.");
                return;
            }

            Console.Write("Enter property to update: ");
            string property = Console.ReadLine();
            Console.Write("Enter new value: ");
            string newValue = Console.ReadLine();

            // Assuming obj is a dynamic dictionary; update logic would vary for different structures
            ((dynamic)obj)[property] = newValue;
            storageDevice.Save();
            Console.WriteLine($"{className} {id} updated successfully.");
        }

        static void DeleteObject(JSONStorage storageDevice, List<string> classList, string[] userSplit)
        {
            if (userSplit.Length < 3)
            {
                Console.WriteLine("Usage: Delete <ClassName> <object_id>");
                return;
            }

            string className = userSplit[1].ToLower();
            string id = userSplit[2];
            string key = $"{className}.{id}";

            if (!classList.Contains(className))
            {
                Console.WriteLine($"{className} is not a valid object type.");
                return;
            }

            if (storageDevice.All().Remove(key))
            {
                storageDevice.Save();
                Console.WriteLine($"Object {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Object {id} could not be found.");
            }
        }
    }
}
