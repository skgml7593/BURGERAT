using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chefController : MonoBehaviour
{
    int a = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > -3.6f) // 원래 0.2f
        {
            a = 1;
        }
        else if (transform.localPosition.x < -5.0f) //원래 0.0f
        {
            a = -1;
        }

        transform.Translate(Vector3.left * 0.3f * Time.deltaTime * a);
    }
}
