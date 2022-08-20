using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip grill;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)

    //{

    //    if (collision.collider.CompareTag("Grill"))
    //    {
    //        Sound();
    //    }
    //}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Grill")
            Sound();
    }

    private void Sound()
    {
        audiosource.PlayOneShot(grill);
    }


}
