using System.Collections.Generic;
using System;

class List{

    public static List<int> CreatePrint(int size){
        
        if (size < 0){
            Console.WriteLine("Size cannot be negative");
            return null;
        } else {
            List<int> CacheList = new List<int>();
            for (int i = 0; i < size; i++){
                // Print the number followed by space, except for the last element
                if (i == size - 1) {
                    Console.Write(i);  // Last element, no trailing space
                } else {
                    Console.Write(i + " ");
                }
                CacheList.Add(i);
            }
            Console.WriteLine();  // Print a newline after the loop finishes
            return CacheList;
        }
    }
}
