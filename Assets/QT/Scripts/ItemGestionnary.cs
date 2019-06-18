using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGestionnary : MonoBehaviour
{
    public Text myName;
    public Text myType;
    public Text myInfo;

    public void SetName(string newName)
    {
        myName.text = newName;
    }
}
