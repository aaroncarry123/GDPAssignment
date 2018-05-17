using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public bool moved;
    public float speed;
    Vector3 pos;
    public float destination;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (moved && gameObject.transform.position.z <= destination)
        {
            pos = gameObject.transform.position;
            pos += Vector3.forward * Time.deltaTime * speed;
            gameObject.transform.position = pos;
        }
        if (moved && gameObject.transform.position.z >= destination)
        {
            if (gameObject.transform.eulerAngles.x <= 100)
            {
                gameObject.transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }

	}
    void OnTriggerEnter(Collider other)
    {

        if(moved == false)
        {
            moved = true;

        }
    }
}
