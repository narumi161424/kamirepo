using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {


    GameObject Player = null;



    // Use this for initialization
    void Start()
    {
        this.Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {


        //フレームごとに等速で落下させる
        transform.Translate(0, -1f, 0);

        //画面外に出たらオブジェクトを破棄する
        if (transform.position.y < -5.0f)
            Destroy(gameObject);


    }



    //当たり判定

    // Vector2 p1 = transform.position; //たまの中心座標
   // Vector2 p2 = this.Pleyer.transform.position; //プレイヤ中心座標
    //Vector2 dir = p1 - p2;

    //float d = dir.magnitude;
    //float r1 = 0.5f;   //球半径
    //float r2 = 1.0f;  //プレイヤ半径

    //if (d <  r1 + ｒ2 ){
        //監督スプリクトにプレイヤーと衝突したことを伝える
      //  gameobject director = GameDirector.find("GameDirector");
       // gameDirector.GetComponent<GameDirector>().DecreaseHp();
             
   
	

}
