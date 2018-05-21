using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class returntomenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(wait());
        SceneManager.LoadScene("menu");
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        
    }
}
