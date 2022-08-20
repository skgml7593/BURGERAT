using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// FireSpawner에 적용
// 불 생성 위치 배열에 저장 후 각 라인 내에서 위치는 랜덤으로 생성
public class FireSpawner : MonoBehaviour
{
    public GameObject firePrefab; // 생성할 불 담은 변수
    public Transform[] spawnPoint1;  // 1번 라인 불 생성 위치 담은 배열 변수
    public Transform[] spawnPoint2;  // 2번 라인 불 생성 위치 담은 배열 변수

    float waitingTime;  // 대기 시간(다음 불 나오는 데까지 기다리는 시간)
    float timeAfterSpawn; // 게임진행 시간

    // 불 생성 조건(불이 1,2번 라인에서 번갈아가며 생성되어야 함, 동시x)
    private bool yesFire1;
    private bool yesFire2;


    void Start()
    {
        yesFire1 = true; // 1번 라인에서 생성되어야 하는 상태
        yesFire2 = false;
        timeAfterSpawn = 0;
        waitingTime = 4f; // 다음 불 2초 후에 스폰
    }

    void Update()
    {
        if (yesFire1 == true && yesFire2 == false)
            Spawn1();

        if (yesFire1 == false && yesFire2 == true)
            Spawn2();

    }

    void Spawn1() // 1번 라인
    {
        timeAfterSpawn += Time.deltaTime;  // 게임 시간 더해줌

        if (timeAfterSpawn >= waitingTime)
        {
            int spawnPos1 = Random.Range(0, spawnPoint1.Length); // 1번 라인 배열 변수 중 랜덤으로 선택

            GameObject fire = Instantiate(firePrefab, spawnPoint1[spawnPos1].position, spawnPoint1[spawnPos1].rotation);  // 위치, 회전값 설정
            Destroy(fire, 1);  // 1초 후 불 사라짐

            timeAfterSpawn = 0;

            yesFire1 = false;
            yesFire2 = true;

        }

    }

    void Spawn2() // 2번 라인
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= waitingTime)
        {
            int spawnPos2 = Random.Range(0, spawnPoint2.Length); // 2번 라인 배열 변수 중 랜덤으로 선택
            GameObject fire2 = Instantiate(firePrefab, spawnPoint2[spawnPos2].position, spawnPoint2[spawnPos2].rotation);
            Destroy(fire2, 1); // 1초 후 불 사라짐

            timeAfterSpawn = 0;

            yesFire2 = false;
            yesFire1 = true;

        }

    }
}
