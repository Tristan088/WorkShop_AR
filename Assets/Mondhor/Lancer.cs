using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancer : MonoBehaviour
{
    public Transform dé;
    public bool locked = false;

    private void Start()
    {
            GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && locked == false)
        {
            GetComponent<Rigidbody>().AddForce(dé.forward * Random.Range(900, 1100));
            Debug.Log("ça applique une force");
            locked = true;
            GetComponent<Rigidbody>().useGravity = true;
        }

        if (locked == true)
        {
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
