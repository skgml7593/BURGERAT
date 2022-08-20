using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class HamBurgerController : MonoBehaviour
{
    [SerializeField] private InputActionReference UIReferenece;
    //public GameObject map;
    bool click = false;


    DestroyPatty destroyPatty;
    DestroyLettuce destroyLettuce;
    DestroyBread destroyBread;

    public GameObject bb_up;
    public GameObject patty;
    public GameObject lettuce;
    public GameObject tomato;
    public GameObject hamburger;
    public GameObject bb_down;

    public GameObject w_cheese;
    public GameObject w_bb_up;
    public GameObject w_patty;
    public GameObject w_lettuce;
    public GameObject w_tomato;
    public GameObject w_hamburger;
    public GameObject w_bb_down;

    // Start is called before the first frame update
    void Start()
    {
        
        hamburger.SetActive(true);
        bb_up.SetActive(false);
        patty.SetActive(false);
        lettuce.SetActive(false);
        tomato.SetActive(false);
        bb_down.SetActive(false);
        w_cheese.SetActive(true);
        w_bb_up.SetActive(true);
        w_patty.SetActive(true);
        w_lettuce.SetActive(true);
        w_tomato.SetActive(true);
        w_bb_down.SetActive(true);
        //w_hamburger.SetActive(false);

        destroyPatty = GameObject.Find("Patty1").GetComponent<DestroyPatty>();
        destroyLettuce = GameObject.Find("Lettuce_All").GetComponent<DestroyLettuce>();
        destroyBread = GameObject.Find("Bread").GetComponent<DestroyBread>();

       // map.SetActive(false);
        UIReferenece.action.performed += ShowUI;
        w_hamburger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void ShowUI(InputAction.CallbackContext obj)
    {
        if (click == true)
        {
            click = false;
        }
        else if (click == false)
        {
            click = true;
        }

        //map.SetActive(!click);
       

        if (destroyPatty.isDestroyed == true)
        {
            // pattyPos.SetActive(click);
            patty.SetActive(true);
            //w_patty.SetActive(false);
            
        }

        if (destroyLettuce.isDestroyed == true)
        {
            lettuce.SetActive(true);
            w_lettuce.SetActive(false);
        }

        if (destroyBread.isDestroyed == true)
        {
            bb_up.SetActive(true);
            bb_down.SetActive(true);
            w_bb_up.SetActive(false);
            w_bb_down.SetActive(false);
        }

        w_hamburger.SetActive(!click);

    }
}
