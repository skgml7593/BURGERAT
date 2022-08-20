using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestroyCheese : MonoBehaviour
{
    XRGrabInteractable grabInteractable = null;
     GameObject cheese;
    public static DestroyCheese Instance;
    public bool isDestroyed = false;

    public AudioSource audiosource;
    public AudioClip cheeseSound;

    public GameObject CheeseTxt;

    void Awake()
    {
        //foodObject = GetComponent<>();


        this.cheese = GameObject.Find("Cheese");
        grabInteractable = GetComponent<XRGrabInteractable>();

        grabInteractable.onActivate.AddListener(DestroyFoodCheese);

        this.cheese.SetActive(true);



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DestroyFoodCheese(XRBaseInteractor interactor)
    {
        
        Debug.Log("Cheese");
        //this.cheese.SetActive(false);
        this.cheese.SetActive(false);
        // Destroy(this.cheese);
        isDestroyed = true;
        CheeseSound();
        CheeseTxt.SetActive(true);
        Destroy(CheeseTxt, 2f);
    }



    private void CheeseSound()
    {
        audiosource.PlayOneShot(cheeseSound);
    }
}
