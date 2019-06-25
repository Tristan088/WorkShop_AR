using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheetUI : MonoBehaviour
{
    public Text infoPlayer;
    public Text hP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        infoPlayer.text = "" + WordSettings.Instance.nom + " " + WordSettings.Instance.prenom + "\n" + WordSettings.Instance.surnom + "\nLvL : " + WordSettings.Instance.lvl;
        hP.text = WordSettings.Instance.hpCurrent.ToString() + "/" + WordSettings.Instance.hpMax;
    }
}
