using UnityEngine;
using System.Collections;

public class Tama: MonoBehaviour
{
    const float MAXDISTANCE = 5;

    Vector3 originalPos;

	private void Start()
	{
        originalPos = transform.position;
	}

	void Update()
    {
        transform.Translate(0.2f, 0, 0);

        float distance =
            (originalPos - transform.position).magnitude;
        
        if (distance > MAXDISTANCE)
        {
            Destroy(gameObject);
        }

    }


}