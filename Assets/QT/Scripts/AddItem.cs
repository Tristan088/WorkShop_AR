using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    public GameObject itemTemplate;

    public Text itemName;
    public string itemType;

    public void AddNewItem()
    {
        GameObject newItem = Instantiate(itemTemplate) as GameObject;
        newItem.SetActive(true);

        newItem.GetComponent<ItemGestionnary>().SetName(itemName.text, itemType);
        newItem.transform.SetParent(itemTemplate.transform.parent, false);
    }
}
