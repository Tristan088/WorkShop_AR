using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGestionner : MonoBehaviour
{
    public GameObject armeTemplate;
    public GameObject armureTemplate;
    public GameObject accesoireTemplate;
    public GameObject autreTemplate;

    private void Update()
    {
        Debug.Log("inventaire count : " + WordSettings.Instance.inventory.Count);
        Debug.Log("weapons count : " + WordSettings.Instance.inventory["weapon"].Count);
    }

    public void GetInventory()
    {
        Debug.Log("je refait mon inventaire");
        Debug.Log("inventaire count : " + WordSettings.Instance.inventory.Count);

        if (WordSettings.Instance.inventory.Count != 0)
        {
            Debug.Log("j'ai de l' inventaire");

            if (WordSettings.Instance.inventory["weapon"].Count != 0)
            {
                Debug.Log("j'ai des armes");

                foreach (KeyValuePair<string, List<int>> item in WordSettings.Instance.inventory["weapon"])
                {
                    AddItem(armeTemplate, item.Key, "Weapons", item.Value);
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
