using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attck : MonoBehaviour {
    public GameObject tamaPrefab;
  

    public float offsetX;
    public float offsetY;

    void Update()
    {


        //攻撃する
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(transform.position.x + offsetX,
                                      transform.position.y + offsetY,
                                      transform.position.z);
            Instantiate(tamaPrefab,pos,Quaternion.identity);
        }
    }
}