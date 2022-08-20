using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MapController_storage : MonoBehaviour
{
    [SerializeField] private InputActionReference UIReferenece;
    public GameObject map;
    bool click = false;

    DestroyCheese cheese;

    public GameObject cheesePos;
    public GameObject pattyPos;

    // Start is called before the first frame update
    void Start()
    {
        cheese = GameObject.Find("Cheese").GetComponent<DestroyCheese>();

         map.SetActive(false);
        UIReferenece.action.performed += ShowUI;
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


 

        map.SetActive(!click);
        cheesePos.SetActive((!click));
        pattyPos.SetActive(false);
        //cheesePos.SetActive((!click)&&!(cheese.isDestroyed));
        // pattyPos.SetActive((!click) && (cheese.isDestroyed));


    }
}
