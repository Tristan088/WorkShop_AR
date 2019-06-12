using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    private int lvl;

    public Text lvlText;
    public Text nom;
    public Text prenom;
    public Text surnom;
    

    // Start is called before the first frame update
    void Start()
    {
        lvl = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LvlPlusUn()
    {
        
        lvl++;
        if (lvl > 30)
        {
            lvl = 30;
        }
        lvlText.text = lvl.ToString();
    }

    public void LvlMoinUn()
    {
        
        lvl--;
        if (lvl < 1)
        {
            lvl = 1;
        }
        lvlText.text = lvl.ToString();
    }

    public void ValidateNom()
    {
        WordSettings.Instance.prenom = prenom.text;
        WordSettings.Instance.nom = nom.text;
        WordSettings.Instance.surnom = surnom.text;
        WordSettings.Instance.lvl = lvl;

    }




}
