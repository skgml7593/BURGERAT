using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToKitchen : MonoBehaviour
{
    void Update()
    {
        if (transform.localPosition.y < -3.7f)
            SceneManager.LoadScene("kitchen02");

    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Finish"))
            SceneManager.LoadScene("storage");
    }*/
}
