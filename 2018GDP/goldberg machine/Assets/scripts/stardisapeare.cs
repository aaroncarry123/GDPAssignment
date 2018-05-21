using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stardisapeare : MonoBehaviour {


    public AudioSource sound;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Contains("star"))
        {
            sound.Play();
            Destroy(col.gameObject);
            
   
        }
        
    }
}