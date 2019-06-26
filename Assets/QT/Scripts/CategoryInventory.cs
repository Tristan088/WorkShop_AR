using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CategoryInventory
{
    public string myName;
    public List<Item> items;

    public CategoryInventory(string newName, List<Item> newItems)
    {
        myName = newName;
        items = newItems;
    }
}
