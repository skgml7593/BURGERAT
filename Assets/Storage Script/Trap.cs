using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Trap : MonoBehaviour
{
    Animator animator;
    bool trap = false;
    public static int index;

    public GameObject Text;

    void Start()
    {
      
        animator = GetComponent<Animator>();
        index = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isTrap", trap);

        if (GameOver.gotoStorage == true)
        {
            Text.SetActive(true);
            Destroy(Text, 3.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.CompareTag("Player"))
        {
            trap = true;
            StartCoroutine(WaitForIt());
        }
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("gameOver");

    }


}
