using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigging : MonoBehaviour
{
    GameObject mouse;

    // Start is called before the first frame update
    void Start()
    {
        mouse = GameObject.Find("XR Origin");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mouse.transform.position + new Vector3(0f, -0.5f, -6f);
    }
}

