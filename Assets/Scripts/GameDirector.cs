using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour {

    GameObject hpgage;




	// Use this for initialization
	void Start () {

        this.hpgage = GameObject.Find("hpgage");


	}
	

    public void DecreaseHp(){
        this.hpgage.GetComponent<Image>().fillAmount -=0.1f;

    }

	// Update is called once per frame
	void Update () {
		
	}
}
