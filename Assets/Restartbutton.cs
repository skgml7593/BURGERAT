using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Restartbutton : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
    GameObject restart;
    public static Restartbutton Instance;
    public bool isDestroyed = false;


    void Awake()
    {
        //foodObject = GetComponent<>();
        this.restart = GameObject.Find("restart");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(RestartbuttonButton);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartbuttonButton(XRBaseInteractor interactor)
    {
        Debug.Log("Restart");
        Destroy(restart);
        isDestroyed = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//ÀÚ±â¾À ·Îµå
    }

}

