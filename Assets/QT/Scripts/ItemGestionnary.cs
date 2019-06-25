using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGestionnary : MonoBehaviour
{
    public Text myName;
    public string myTypeOfItem;
    
    public GameObject infoGiver_Template;
    public GameObject infoGiver;

    public GameObject _infoGiver_name;
    public Text infoGiver_name;

    public GameObject _infoGiver_delete;
    public Button infoGiver_delete;

    public GameObject _infoGiver_return;
    public Button infoGiver_return;

    public GameObject _infoGiver_DeleteDelete;

    public GameObject _infoGiver_DeleteYes;
    public Button infoGiver_DeleteYes;

    public GameObject _infoGiver_DeleteNo;
    public Button infoGiver_DeleteNo;

    public Text[] infoGiver_bonusStats = new Text[20];
    public Text[] infoGiver_bonusStatsChange = new Text[20];

    public List<int> bonusStats = new List<int>();

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(ShowItem);

        infoGiver = Instantiate(infoGiver_Template) as GameObject;
        infoGiver.name = "InfoGiver_" + myName.text;
        infoGiver.transform.SetParent(infoGiver_Template.transform.parent, false);

        _infoGiver_name = infoGiver.transform.GetChild(0).gameObject;
        infoGiver_name = _infoGiver_name.GetComponent<Text>();

        _infoGiver_delete = infoGiver.transform.GetChild(1).gameObject;
        infoGiver_delete = _infoGiver_delete.GetComponent<Button>();

        _infoGiver_return = infoGiver.transform.GetChild(3).gameObject;
        infoGiver_return = _infoGiver_return.GetComponent<Button>();

        _infoGiver_DeleteDelete = infoGiver.transform.GetChild(4).gameObject;

        _infoGiver_DeleteYes = _infoGiver_DeleteDelete.transform.GetChild(1).gameObject;
        infoGiver_DeleteYes = _infoGiver_DeleteYes.GetComponent<Button>();

        _infoGiver_DeleteNo = _infoGiver_DeleteDelete.transform.GetChild(2).gameObject;
        infoGiver_DeleteNo = _infoGiver_DeleteNo.GetComponent<Button>();

        infoGiver_delete.onClick.AddListener(VerrifDelete);
        infoGiver_DeleteNo.onClick.AddListener(PasDelete);
        infoGiver_DeleteYes.onClick.AddListener(DeleteItem);
        infoGiver_return.onClick.AddListener(StopShow);
        infoGiver_name.text = myName.text;

        gameObject.name = myName.text;

        for(int i = 0; i < 20; i++)
        {
            bonusStats.Add(0);
        }
    }

    public void SetName(string newName, string newType)
    {
        myName.text = newName;
        myTypeOfItem = newType;
    }

    public void SetItem(string newName, string newType, List<int> stats)
    {
        myName.text = newName;
        myTypeOfItem = newType;

        for (int i = 0; i < 20; i++)
        {
            bonusStats.Add(stats[i]);
        }
    }

    public void ShowItem()
    {
        infoGiver.SetActive(true);
        for(int i = 0; i < 20; i++)
        {
            infoGiver_bonusStats[i].text = bonusStats[i].ToString();
            infoGiver_bonusStatsChange[i].text = infoGiver_bonusStats[i].text;
        }
        
    }

    public void StopShow()
    {
        for (int i = 0; i < 20; i++)
        {
            bonusStats[i] = int.Parse(infoGiver_bonusStatsChange[i].text);
            infoGiver_bonusStatsChange[i].text = "0";
        }

        if (myTypeOfItem == "Weapons")
        {
            WordSettings.Instance.MAJWeapon(gameObject);
        }

        _infoGiver_DeleteDelete.SetActive(false);
        infoGiver.SetActive(false);
    }

    public void VerrifDelete()
    {
        _infoGiver_DeleteDelete.SetActive(!_infoGiver_DeleteDelete.activeSelf);
    }

    public void PasDelete()
    {
        _infoGiver_DeleteDelete.SetActive(false);
    }

    public void DeleteItem()
    {
        if(myTypeOfItem == "Weapons")
        {
            WordSettings.Instance.DeleteWeapon(gameObject);
        }

        for (int i = 0; i < 20; i++)
        {
            infoGiver_bonusStatsChange[i].text = "0";
        }
        infoGiver.SetActive(false);
        this.gameObject.SetActive(false);
    }
}