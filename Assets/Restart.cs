using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Restart : MonoBehaviour
{
    [SerializeField] private InputActionReference RestartReferenece;
    public GameObject restart;
    bool click = false;
    bool IsPause = false;
  


    // Start is called before the first frame update
    void Start()
    {

        RestartReferenece.action.performed += ShowRestart;
    }

    void Awake()
    {
        restart.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // map.SetActive(false);
        
    }

    private void ShowRestart(InputAction.CallbackContext obj)
    {
        if (click == true)
        {
            click = false;
         
        }
        else if (click == false)
        {
            click = true;
        }

        restart.SetActive(!click);



    }
}
