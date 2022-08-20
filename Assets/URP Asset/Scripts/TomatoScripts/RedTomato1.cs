using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 대각선으로 이동하는 토마토 컨트롤러1
public class RedTomato1 : MonoBehaviour
{
    private Rigidbody rb;
    public float _speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Quaternion.Euler(0, 45, 0) * Vector3.back * _speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
