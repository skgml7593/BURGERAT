using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyLettuce : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
    GameObject lettuce;
    public static DestroyCheese Instance;
    public bool isDestroyed = false;

    public AudioSource audiosource;
    public AudioClip lettucesound;

    public GameObject LettuceTxt;

    void Awake()
    {
        //foodObject = GetComponent<>();
        this.lettuce = GameObject.Find("Lettuce_All");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyFoodLettuce);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DestroyFoodLettuce(XRBaseInteractor interactor)
    {
        LettuceSound();
        Destroy(lettuce);
        isDestroyed = true;
        LettuceTxt.SetActive(true);
        Destroy(LettuceTxt, 2f);
    }

    // »ç¿îµå
    private void LettuceSound()
    {
        audiosource.PlayOneShot(lettucesound);
    }
}
