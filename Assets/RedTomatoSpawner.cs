

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 토마토 스포너
public class RedTomatoSpawner : MonoBehaviour
{
    public GameObject TomatoPrefab;
    public Transform[] spawnPoint;

    public static double waitingTime;  // 대기 시간(다음 불 나오는 데까지 기다리는 시간)
    float timeAfterSpawn; // 게임진행 시간



    void Start()
    {
        timeAfterSpawn = 0;
        waitingTime = 4;
    }

    void Update()
    {
        Spawn();


    }

    void Spawn()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= waitingTime)
        {
            int spawnPos = Random.Range(0, spawnPoint.Length);

            GameObject tomato = Instantiate(TomatoPrefab, spawnPoint[spawnPos].position, spawnPoint[spawnPos].rotation);  // 위치, 회전값 설정

            timeAfterSpawn = 0;




        }

    }


}