using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyBread: MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    private GameObject bread;
    public static DestroyBread Instance;
    public bool isDestroyed = false;

    public AudioSource audiosource;
    public AudioClip breadsound;

    public GameObject BreadTxt;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.bread = GameObject.Find("Bread");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyFood);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DestroyFood(XRBaseInteractor interactor)
    {
        BreadSound();
        Destroy(bread);
        isDestroyed = true;
        BreadTxt.SetActive(true);
        Destroy(BreadTxt, 2f);
    }


    // »ç¿îµå
    private void BreadSound()
    {
        audiosource.PlayOneShot(breadsound);
    }
}
