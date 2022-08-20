using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReferenece;
    [SerializeField] private float jumpForce = 500.0f;

    private Rigidbody _body;
    // private bool isGrounded => Physics.Raycast(new Vector2(transform.position.x, transform.position.y + 4.0f), Vector3.down, 2.0f);

    public GameObject game;
    GameObject obj1;
    //GameObject obj2;// 토마토 박스
    Vector3 pose;

    public AudioSource audiosource;
    public AudioClip jump;
    public AudioClip Yellowtomato;
    public AudioClip Redtomato;
    public AudioClip Trap1;
    public AudioClip Trap2;


    bool active;
    bool trap;
    public bool scrubbers = false;
    bool knife;

    // 토마토 개수 세기
    public static PlayerController Instance;
    public int score;
    public Text textScore;

    // 토마토 개수 세기
    public int life;
    public Text textLife;

    // 대사
    public Text traptxt;

    DestroyBread bread;

    public GameObject TomatoTxt;

    //public static int index;

    public static bool pattyFireDie;
    public static bool lettuceDie;

    public GameObject pattyDiet;
    public GameObject lettuceDiet;




    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReferenece.action.performed += OnJump;
        active = false;
        trap = false;
        obj1 = GameObject.Find("susemi");
        //obj2 = GameObject.Find("Box012");
        life = 5;

        // index = SceneManager.GetActiveScene().buildIndex;

        pattyFireDie = false;
        lettuceDie = false;


    }

    
    void Update()
    {
       
      
        if (trap == true)
        {
           
            transform.position =pose;
            Debug.Log(pose);
        }


    }
    private void OnJump(InputAction.CallbackContext obj)
    {
        /*
        if (!isGrounded)
        {
            return;
        }
        */

        if (active==false)
        {
            return;
        }

        _body.AddForce(Vector3.up * jumpForce);

        JumpSound();
    }

    



    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.CompareTag("Object"))
        {
            active = true;
           
        }

        if (collision.collider.CompareTag("Trap"))
        {
            // game.rb.isKinematic = false;
            _body.isKinematic = true;
            // pose = this.game.transform.position + new Vector3(0f, -0.1f, 0f);
            pose =  new Vector3(0.3f, 0.6f, 8.0f);
            trap = true;

            //game.SetActive(false);

            TrapSound1();

            
            //Invoke("sceneChange", 3);
            
        }
        if (collision.collider.CompareTag("Trap1"))
        {
           
            _body.isKinematic = true;
           pose = new Vector3(0.4f, 0.6f, 7.15f);
            trap = true;
            TrapSound2();

            


        }

        if (collision.collider.CompareTag("Trap2"))
        {

            _body.isKinematic = true;
            pose = new Vector3(1.55f, 0.6f, 7.15f);
            trap = true;
            TrapSound2();
            Debug.Log(transform.position);




        }

        if (collision.collider.CompareTag("Trap3"))
        {

            _body.isKinematic = true;
            pose = new Vector3(0.7f, 0.6f, 6.15f);
            trap = true;
            TrapSound2();
            Debug.Log(transform.position);




        }

        if (collision.collider.CompareTag("Scrubbers"))
        {


            //transform.position += new Vector3(0f, 0.1f, 0f);
            _body.isKinematic = true;
            obj1.transform.SetParent(game.transform, true);
            obj1.transform.position =transform.position;
            _body.isKinematic = false;
            scrubbers = true;

            //obj2.transform.eulerAngles=new Vector3(0, 10, 0);


            //timet = true;
        }

        if (collision.collider.CompareTag("yellowTomato"))
        {
            YellowTomatoHitSound();
             MinusLife();
            Destroy(collision.gameObject);
            Debug.Log("노랑 토마토~~~~~~~");
        }

        if (collision.collider.CompareTag("redTomato"))
        {
            RedTomatoGetSound();
            Destroy(collision.gameObject);
             AddScore();
        }
        if (collision.collider.CompareTag("Floor"))
        {
            SceneManager.LoadScene("gameOver02");

            //빵을 얻고 밧줄에서 추락한 경우
            if (bread.isDestroyed == true)
            {
                SceneManager.LoadScene("RacingIllustration");
            }

        }

        //수챗구멍에 닿은 경우
        if (collision.collider.CompareTag("RacingGoal"))
        {
            if (score == 5)
            {
                SceneManager.LoadScene("Ending");
            }
            else
                SceneManager.LoadScene("gameOver");


        }


    }

    private void OnCollisionExit(Collision collision)

    {

        if (collision.collider.CompareTag("Object"))
        {
            active =false;
         // 밑에서 트롤리를 지나가면 충돌 오류나서 점프 불가
        }


        

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Fire")
            SceneManager.LoadScene("gameOver");
             pattyFireDie = true;

        // 쉬울 것 같으면 프라이팬 추가

        if (col.gameObject.tag == "Knife")
            SceneManager.LoadScene("gameOver");
            lettuceDie = true;




    }

    //사운드
    private void JumpSound()
    {
        audiosource.PlayOneShot(jump);
    }

    private void YellowTomatoHitSound()
    {
        audiosource.PlayOneShot(Yellowtomato);
    }

    private void RedTomatoGetSound()
    {
        audiosource.PlayOneShot(Redtomato);
    }

    private void TrapSound1()
    {
        audiosource.PlayOneShot(Trap1);
    }

    private void TrapSound2()
    {
        audiosource.PlayOneShot(Trap2);
    }


    // 토마토 개수 세기
    public void AddScore()
    {
        score += 1;
        if (score >= 5)
        {
            score = 5;
            // or continue;
            TomatoTxt.SetActive(true);
            Destroy(TomatoTxt, 2f);
        }

        textScore.text = score.ToString()+"/5";
    }

    // 목숨 감소 처리
    public void MinusLife()
    {
        life -= 1;

        if (life <=0)
        {
            life=0;
            // or continue;
        }
        Debug.Log(life);
        textLife.text = life.ToString() + "/5";

        if (life == 0)
        {
            SceneManager.LoadScene("gameOver");
        }
    }

    // 씬 전환
    private void sceneChange()
    {
        SceneManager.LoadScene("gameOver");
    }

    void DieText()
    {
        if (GameOver.gotoPatty == true)
        {
            pattyDiet.SetActive(true);
            Destroy(pattyDiet, 3.0f);
        }
        if (GameOver.gotolettuce == true)
        {
            lettuceDiet.SetActive(true);
            Destroy(lettuceDiet, 3.0f);
        }
    }



}
