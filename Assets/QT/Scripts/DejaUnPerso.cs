using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DejaUnPerso : MonoBehaviour
{
    public GameObject dejaUnPerso;

    void Update()
    {
            //Debug.Log("bite");

        if (!WordSettings.Instance.PlayerExist())
        {
            //Debug.Log("bite");
            dejaUnPerso.SetActive(true);
        }
        else
        {
            dejaUnPerso.SetActive(false);
        }
    }
}
