using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 2번과 4번 위치의 프라이팬의 움직임을 담당하는 클래스
public class panController24 : MonoBehaviour
{
    Rigidbody rb;

    // speed 
    public float speed = 1.3f;

    // 프라이팬이 움직이는 시간 
    private float lastSpawnTime = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 시간이 4 이하이면
        if (lastSpawnTime < 4)
        {
            // 위쪽(y축)으로 5 * speed의 속도로 움직임
            rb.velocity = new Vector3(0, 2 * speed, 0);
        }
        // 시간이 5 이상이 되면
        else if (lastSpawnTime >= 5)
        {
            // 아래쪽(-y축)으로 300만큼 가속도를 부여함
            rb.AddForce(1, -300, 1);
        }

        // 시간 늘리기 
        lastSpawnTime += Time.deltaTime;

    }

    // 프라이팬이 plane(바닥)과 부딪힌 경우 시간을 0으로 지정해 Update함수 안에서 반복되도록 함
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grill")
        {
            lastSpawnTime = 0;
        }
    }
}
