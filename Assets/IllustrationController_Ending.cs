using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IllustrationController_Ending : MonoBehaviour
{
    public GameObject start01;
    public GameObject start02;
    //public GameObject racing03;

    public AudioSource audiosource;
    public AudioClip racing2;

    // Start is called before the first frame update
    void Start()
    {
        start02.SetActive(false);
        // racing03.SetActive(false);
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
        Destroy(start01);
        //racing02.SetActive(true);
        sound();

        //racing02
        yield return new WaitForSeconds(5.0f);
        Destroy(start02);
        SceneManager.LoadScene("TITLE");


    }

    private void sound()
    {
        start02.SetActive(true);
        racing2Sound();
    }

    private void racing2Sound()
    {
        audiosource.PlayOneShot(racing2);
    }
}
