using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class HamBurgerController_storage : MonoBehaviour
{
    [SerializeField] private InputActionReference UIReferenece;
    //public GameObject map;
    bool click = false;

    DestroyCheese cheese;

    public GameObject w_cheese;
    public GameObject w_hamburger;


    // Start is called before the first frame update
    void Start()
    {
        cheese = GameObject.Find("Cheese").GetComponent<DestroyCheese>();

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


        if (cheese.isDestroyed == true)
        {
            // pattyPos.SetActive(click);
            w_cheese.SetActive(false);
        }


        w_hamburger.SetActive(!click);

    }
}
