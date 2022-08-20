using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class Mainbutton : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
    GameObject main;
    public static Mainbutton Instance;
    public bool isDestroyed = false;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.main = GameObject.Find("main");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(MainbuttonButton);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainbuttonButton(XRBaseInteractor interactor)
    {
        Debug.Log("Main");
        Destroy(main);
        isDestroyed = true;
        SceneManager.LoadScene("TITLE");
    }
}
