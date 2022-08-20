using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToTongro : MonoBehaviour
{
    GameObject Hole;
    bool isDestroyed = false;
    DestroyCheese destroyCheese;
    public GameObject hole;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Hole") && (isDestroyed == true))
        {
            SceneManager.LoadScene("tongro");
        }

       
            
    }

    void Awake()
    {
        destroyCheese = GameObject.Find("Cheese").GetComponent<DestroyCheese>();



    }

    void Update()
    {
        isDestroyed = destroyCheese.isDestroyed;
        Debug.Log(isDestroyed);
    }
}
