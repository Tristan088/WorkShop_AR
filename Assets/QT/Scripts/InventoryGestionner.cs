using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGestionner : MonoBehaviour
{
    public GameObject armeTemplate;
    public GameObject armureTemplate;
    public GameObject accesoireTemplate;
    public GameObject autreTemplate;

    public void GetInventory()
    {
        //recharger l'inventaire
        if(WordSettings.Instance.inventory.Count > 0)
        {
            for(int i = 0; i < 4; i++)
            {
                if(WordSettings.Instance.inventory[i].myName == "Weapons")
                {
                    for(int j = 0; j < WordSettings.Instance.inventory[i].items.Count; j++)
                    {
                        AddItem(armeTemplate, WordSettings.Instance.inventory[i].items[j].myName, WordSettings.Instance.inventory[i].myName, WordSettings.Instance.inventory[i].items[j].bonusStat);
                    }
                }
                else if (WordSettings.Instance.inventory[i].myName == "Armors")
                {
                    for (int j = 0; j < WordSettings.Instance.inventory[i].items.Count; j++)
                    {
                        AddItem(armureTemplate, WordSettings.Instance.inventory[i].items[j].myName, WordSettings.Instance.inventory[i].myName, WordSettings.Instance.inventory[i].items[j].bonusStat);
                    }
                }
                else if (WordSettings.Instance.inventory[i].myName == "Accesory")
                {
                    for (int j = 0; j < WordSettings.Instance.inventory[i].items.Count; j++)
                    {
                        AddItem(accesoireTemplate, WordSettings.Instance.inventory[i].items[j].myName, WordSettings.Instance.inventory[i].myName, WordSettings.Instance.inventory[i].items[j].bonusStat);
                    }
                }
                else if (WordSettings.Instance.inventory[i].myName == "Other")
                {
                    for (int j = 0; j < WordSettings.Instance.inventory[i].items.Count; j++)
                    {
                        AddItem(autreTemplate, WordSettings.Instance.inventory[i].items[j].myName, WordSettings.Instance.inventory[i].myName, WordSettings.Instance.inventory[i].items[j].bonusStat);
                    }
                }
            }
        }
    }

    public void AddItem(GameObject itemTemplate, string itemName, string itemType, List<int> itemStats)
    {
        GameObject newItem = Instantiate(itemTemplate) as GameObject;
        newItem.SetActive(true);

        newItem.GetComponent<ItemGestionnary>().SetItem(itemName, itemType, itemStats);
        newItem.transform.SetParent(itemTemplate.transform.parent, false);
    }
}