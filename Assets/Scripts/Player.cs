using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{




    bool isGrounded = false;
    public float jumpPower;
    public float moveSpeed;

    public GameObject flowObject;

 
    Rigidbody2D rigid2D;


    public AudioClip gemSound;
    public AudioClip jumpSound;
    Vector2 jumpForce;
    private Vector3 defalutScale = Vector3.one;


    public int m_hpMax; // HP の最大値
    public int m_hp; // HP
    public int m_damage;




    // ダメージを受ける関数
    // 敵とぶつかった時に呼び出される
    public void Damage(int m_damage)
    {
        // HP を減らす
        m_hp -= m_damage;

        // HP がまだある場合、ここで処理を終える
        if (0 < m_hp) return;

        // プレイヤーが死亡したので非表示にする

        gameObject.SetActive(false);
    }



    // Use this for initialization
    void Start()
    {
        jumpForce = new Vector2(0.0f, jumpPower);

    }



    // ゲーム開始時に呼び出される関数
    private void Awake()
    {
        m_hp = m_hpMax; // HP
    }

    // 向きを変える
    private void Turn(float inputValue)
    {
        if (inputValue > 0)
        {
            transform.localScale = defalutScale;
        }


        else if (inputValue < 0)
        {
        }
    }



    // Update is called once per frame
    void Update()
    {
        bool isJumping = false;

        //話す
        if (Input.GetKeyDown(KeyCode.Z))
        {
            flowObject.SetActive(true);
        }



        //移動キー
       
        //ジャンプ

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(jumpForce);
                gameObject.GetComponent<AudioSource>().PlayOneShot(jumpSound);
            
                isGrounded = false;
               

            }
        }

        bool isRight = Input.GetKey(KeyCode.RightArrow);
        bool isLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isAttack = Input.GetKey(KeyCode.Space);

        //左
        if ( isLeft )
        {
            Debug.Log("Left");
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * -1.0f * moveSpeed;
        }

        //右
        if ( isRight )
        {
            Debug.Log("Right");
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * moveSpeed;
        }

        //Zを押したらキャラに話しかけることができ、会話スタート

        if (Input.GetKeyDown(KeyCode.Z))
        {
            flowObject.SetActive(true);
        }

        //方向に合わせてキャラの見た目変化

        isJumping = !isGrounded;
        isRight = !isLeft;

        var animator = GetComponent<Animator>();
        animator.SetBool("is_Jumping", isJumping);
        animator.SetBool("_Right", isRight);
        animator.SetBool("_Left", isLeft);
        animator.SetBool("_Attack", isAttack);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 接地していないときは水平方向に移動する力を弱める
      //  var mult = isGrounded ? 1f : 0.1f;

        if (collision.gameObject.tag == "Door")
        {

            //シーン名を取得
            string sceneName = collision.gameObject.GetComponent<Door>().nextScenes;

            //シーンチェンジ
            SceneManager.LoadScene(sceneName);
        }

        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Talk")
        {
            // Fungusを呼ぶ
            //collision.gameObject.GetComponent<Talk>().startTalk();
        }
    }
}
   

    
