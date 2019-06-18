using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterOffsetMove : MonoBehaviour
{
    // Start is called before the first frame update
    Material _material;
    private float offset = 0;
    private float offset2 = 0;
    void Start()
    {
       _material = gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime/2;
        offset2 += Time.deltaTime/3;
        _material.SetTextureOffset("_DetailAlbedoMap", new Vector2(offset, 0f));
        _material.SetTextureOffset("_MainTex", new Vector2(-offset2, 0f));
    }
}
