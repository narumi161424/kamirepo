﻿using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

    public GameObject hpbar;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        //  on damage
        if (col.gameObject.tag == "Enemy")
        {
            hpbar.gameObject.SendMessage("onDamage", 10);
        }
    }
}
