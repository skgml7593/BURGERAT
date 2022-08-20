using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MapController_tongro : MonoBehaviour
{
    [SerializeField] private InputActionReference UIReferenece;
    public GameObject map;
    bool click = false;

    public GameObject tongroPos;

    // Start is called before the first frame update
    void Start()
    {
        //UIReferenece.action.performed += ShowUI;
    }

    void Awake()
    {
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
        tongroPos.SetActive((!click));
        // cheesePos.SetActive((!click));
        // pattyPos.SetActive(false);
        //cheesePos.SetActive((!click)&&!(cheese.isDestroyed));
        // pattyPos.SetActive((!click) && (cheese.isDestroyed));


    }
}
