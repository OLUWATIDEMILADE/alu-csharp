using System;

namespace InventoryLibrary
{

    /// <summary>
    /// Item for Inventory Library inheriting from BaseClass
    /// </summary>

    public class Item : BaseClass
    {
        string name;
        string description;
        float price;
        list<string> tags = new list<string>("Item");
    }
}