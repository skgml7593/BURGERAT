using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeController : MonoBehaviour
{
    public Text TimeUI;
    float setTime = 5;
    PlayerController scrubbers;

    // Start is called before the first frame update
    void Start()
    {
        scrubbers = GameObject.Find("XR Origin").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        setTime -= Time.deltaTime;
        

        if (setTime <= 0)
        {
            if (scrubbers.scrubbers == false)
            {
                SceneManager.LoadScene("gameOver");
            }

            Destroy(TimeUI);
        }

        TimeUI.text = (int)setTime + "ÃÊ";

       

    }
}
