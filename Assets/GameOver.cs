using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //Trap trap;

   // public GameObject CheeseDieTxt;

    public static bool gotoStorage;
    public static bool gotoPatty;
    public static bool gotolettuce;

    // Start is called before the first frame update
    void Start()
    {
        gotoStorage = false;
        gotoPatty = false;
        gotolettuce = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //이전 씬의 인덱스가 2인 경우에(즉 창고에서 죽은 경우)
        if (Trap.index == 2)
        {
            StartCoroutine(GoBackToStorage());
            Trap.index = 0;
            gotoStorage = true;
        }
        if (RacingIndex.index == 7)
        {
            StartCoroutine(GoBackToRacing());
            RacingIndex.index = 0;
        }
        if (KitchenIndex.index == 4)
        {
            StartCoroutine(GoBackToKitchen());
            RacingIndex.index = 0;

            if (PlayerController.pattyFireDie == true)
            {
                gotoPatty = true;
            }
            else if (PlayerController.lettuceDie == true)
            {
                gotolettuce = true;
            }
        }

    }

    IEnumerator GoBackToStorage()
    {
        yield return new WaitForSeconds(3.0f);
        
        //Destroy(CheeseDieTxt, 10f);
        SceneManager.LoadScene("storage");
       // CheeseDieTxt.SetActive(true);


    }

    IEnumerator GoBackToRacing()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("racing");

    }

    IEnumerator GoBackToKitchen()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("kitchen02");

    }
}
