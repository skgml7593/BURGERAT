using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class DestroyTutorial : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
    GameObject tutorial;
    public static DestroyTutorial Instance;
    public bool isDestroyed = false;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.tutorial = GameObject.Find("tutorial");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyTutorialButton);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DestroyTutorialButton(XRBaseInteractor interactor)
    {
        //Debug.Log("start");
        Destroy(tutorial);
        isDestroyed = true;
        SceneManager.LoadScene("tutorial");
    }
}
