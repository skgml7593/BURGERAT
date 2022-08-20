using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class DestroyStart : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
    GameObject start;
    public static DestroyStart Instance;
    public bool isDestroyed = false;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.start = GameObject.Find("start");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyStartButton);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DestroyStartButton(XRBaseInteractor interactor)
    {
        Debug.Log("start");
        Destroy(start);
        isDestroyed = true;
        SceneManager.LoadScene("Startillustration");
    }
}
