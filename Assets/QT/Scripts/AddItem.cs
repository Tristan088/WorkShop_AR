using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddItem : MonoBehaviour
{
    public GameObject itemTemplate;

    public Text itemName;

    public void AddNewItem()
    {
        GameObject newItem = Instantiate(itemTemplate) as GameObject;
        newItem.SetActive(true);

        newItem.GetComponent<ItemGestionnary>().SetName(itemName.text);
        newItem.transform.SetParent(itemTemplate.transform.parent, false);
    }
}
