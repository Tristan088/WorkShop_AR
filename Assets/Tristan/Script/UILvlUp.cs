using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILvlUp : MonoBehaviour
{

    public Text alert;
    public Text caracPoint;
    public Text[] carac;
    private int[] caracBefore;
    public GameObject oui;
    public GameObject non;
    public Button validate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartLvlUp()
    {
        caracBefore = new int[20];
        WordSettings.Instance.LvlUp();
        for(int i = 0; i<19; i++)
        {
            caracBefore[i] = WordSettings.Instance.caracLvlPoint[i];
        }
        ValidateStats();
        EnableValidate();
    }

    public void CaracPlusUn(int i)
    {
        if (WordSettings.Instance.caracPoint > 0)
        {
            WordSettings.Instance.caracLvlPoint[i]++;
            if (WordSettings.Instance.caracLvlPoint[i] + WordSettings.Instance.caracBase[i] > 20 && i !=0
                
                )
            {
                WordSettings.Instance.caracLvlPoint[i]--;
            }
            else
            {
                WordSettings.Instance.caracPoint--;
                ValidateStats();
            }

        }
        EnableValidate();
        
    }

    public void CaracMoinUn(int i)
    {
        WordSettings.Instance.caracLvlPoint[i]--;
        {
            if (WordSettings.Instance.caracLvlPoint[i] < caracBefore[i])
            {
                WordSettings.Instance.caracLvlPoint[i] = caracBefore[i];
            }
            else
            {
                WordSettings.Instance.caracPoint++;
                ValidateStats();
            }
        }
        EnableValidate();
        
    }

    public void ValidateStats()
    {

        WordSettings.Instance.UpdateCarac();
        UpdateCarac();
        caracPoint.text = WordSettings.Instance.caracPoint.ToString();
    }

    public void UpdateCarac()
    {
        for (int i = 0; i < carac.Length; i++)
        {
            carac[i].text = (WordSettings.Instance.carac[i] + WordSettings.Instance.caracMod[i]).ToString();
        }

    }

    public void alertDisplay()
    {
        if (WordSettings.Instance.lvl != 15)
        {
            alert.text = "Voulez vous passer level " + (WordSettings.Instance.lvl + 1) + "?";
        }
        else
        {
            alert.text = "Level max atteint !";
            oui.SetActive( false);
            non.GetComponentInChildren<Text>().text = "return";
        }
    }

    public void EnableValidate()
    {
        if (WordSettings.Instance.caracPoint == 0)
        {
            validate.interactable = true;
        }
        else
        {
            validate.interactable = false;
        }
    }
}
