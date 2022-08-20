using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverillustration : MonoBehaviour
{
    public GameObject dead01;
    public GameObject dead02;
    //public GameObject racing03;

   // public AudioSource audiosource;
   // public AudioClip racing2;

    // Start is called before the first frame update
    void Start()
    {
        dead02.SetActive(false);
        // racing03.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Change();
    }

    void Change()
    {
        StartCoroutine(ChangeProcess());
    }

    IEnumerator ChangeProcess()
    {
        //racing01
        yield return new WaitForSeconds(5.0f);
        Destroy(dead01);
        dead02.SetActive(true);
        //sound();

        //racing02
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("kitchen02");
        Destroy(dead02);
        //SceneManager.LoadScene("kitchen02");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    /*
    private void sound()
    {
        start02.SetActive(true);
        racing2Sound();
    }

    private void racing2Sound()
    {
        audiosource.PlayOneShot(racing2);
    }
    */
}
