using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowGenerator : MonoBehaviour {

    public GameObject arrowPrefab;
    float span = -3.0f;
    float delte = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.delte += Time.deltaTime;
        if(this.delte>this.span){
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 20);
            go.transform.position = new Vector3(px, 7, 0);

        }



	}
}
