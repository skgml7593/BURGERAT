using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class MapController : MonoBehaviour
{
    [SerializeField] private InputActionReference MapReferenece;
    public GameObject map;
    bool click = false;

    
    DestroyPatty patty;
    DestroyLettuce lettuce;
    DestroyBread bread;

    public GameObject pattyPos;
    public GameObject lettucePos;
    public GameObject BreadPos;
    public GameObject TomatoPos;

    // Start is called before the first frame update
    void Start()
    {
        patty = GameObject.Find("Patty1").GetComponent<DestroyPatty>();
        lettuce = GameObject.Find("Lettuce_All").GetComponent<DestroyLettuce>();
        bread = GameObject.Find("Bread").GetComponent<DestroyBread>();
        
        MapReferenece.action.performed += ShowMap;
    }

    void Awake()
    {
        map.SetActive(false);

       
    }

    // Update is called once per frame
    void Update()
    {
       // map.SetActive(false);

    }

    private void ShowMap(InputAction.CallbackContext obj)
    {
        if (click == true)
        {
            click = false;
        }
        else if (click == false)
        {
            click = true;
        }
  
        map.SetActive(!click);
        lettucePos.SetActive((!click) && (patty.isDestroyed));
        BreadPos.SetActive((!click) && (lettuce.isDestroyed) && (patty.isDestroyed));
        TomatoPos.SetActive((!click) && (lettuce.isDestroyed) && (patty.isDestroyed)&&(bread.isDestroyed));

        if (patty.isDestroyed==true)
        {
            pattyPos.SetActive(click);
        }

        if (lettuce.isDestroyed == true)
        {
            lettucePos.SetActive(click);
        }

        if (bread.isDestroyed == true)
        {
            BreadPos.SetActive(click);
        }


    }
}
