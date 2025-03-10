using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// This is the JSONStorage for the inventory management.
    /// </summary>
    public class JSONStorage
    {
        Dictionary<TKey, TValue> objects = new Dictionary<TKey, TValue>();

        /// <summary>This is the JSONStorage constructor.</summary>
        public Dictionary<TKey, TValue> All()
        {
            return(this.objects);
        }

        /// <summary>This is the New Method.</summary>
        public void New(object obj)
        {
            objects.Add(obj.name + "." + obj.id, obj);
        }

        /// <summary>This is the Save Method.</summary>
        public void Save()
        {
            string json_string = jsonSerializer.Serialize(objects);
            string file_path = @"../Storage/inventory_manager.json";
            using (StreamWriter sw = File.OpenWrite(file_path))
            {
                sw.WriteLine(json_string);
            }
        }

        /// <summary>This is the Load Method.</summary>
        public void Load()
        {
            string file_path = @"../Storage/inventory_manager.json";
            string json_string = File.ReadAllText(file_path);
            objects = JsonSerializer.deserialize(json_string);
        }
    }
}