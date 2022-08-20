using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyPatty : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    private GameObject patty1;
    public static DestroyPatty Instance;
    public bool isDestroyed = false;

    public AudioSource audiosource;
    public AudioClip pattysound;

    public GameObject PattyTxt;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.patty1 = GameObject.Find("Patty1");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyFood1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DestroyFood1(XRBaseInteractor interactor)
    {
        PattySound();
        Destroy(patty1);
        isDestroyed = true;
        PattyTxt.SetActive(true);
        Destroy(PattyTxt, 2f);
    }

    // »ç¿îµå
    private void PattySound()
    {
        audiosource.PlayOneShot(pattysound);
    }
}
