using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyTomato : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    private GameObject tomato;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.tomato = GameObject.Find("Tomato_red");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyFood);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DestroyFood(XRBaseInteractor interactor)
    {
        Destroy(tomato);
    }
}
