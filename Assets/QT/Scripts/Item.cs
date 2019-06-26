using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string myName;
    public List<int> bonusStat = new List<int>(20);

    public Item(string newName, List<int> newStats)
    {
        myName = newName;
        bonusStat = newStats;
    }
}