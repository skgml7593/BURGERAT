using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*public class raycast : MonoBehaviour
{
    RaycastHit hit; // 충돌 판정
    float MaxDistance = 150f; // ray가 나아갈 거리 설정
    //public LayerMask LayerMask;

    int mask1 = 1 << 8;
    int mask2 = 1 << 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            Debug.DrawRay(transform.position, transform.forward * MaxDistance, Color.red, 0.3f);
            if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance, mask1))
            {
                //hit.transform.GetComponent<SpriteRenderer>().color = Color.red;
                Debug.Log("");
            }         
            else if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance, mask2))
            {
                Debug.Log("아야!!!!!");
            }
       // }
    }
}*/

public class raycast : MonoBehaviour
{
    // See Order of Execution for Event Functions for information on FixedUpdate() and Update() related to physics queries
    void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 9;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
        //layerMask = ~layerMask;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("아야!");
            SceneManager.LoadScene("gameOver");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("");
        }
    }
}