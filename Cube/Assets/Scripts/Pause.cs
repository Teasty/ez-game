using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public Transform canvas;
    //public SwipeController Controls;
    public GameObject cube;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            setPause();
        }
	}

    public void setPause(){
        if (canvas.gameObject.activeInHierarchy == false)
        {
            Time.timeScale = 0;
            cube.GetComponent<SwipeController>().enabled = false;
            canvas.gameObject.SetActive(true);
        }
        else
        {
            canvas.gameObject.SetActive(false);
            cube.GetComponent<SwipeController>().enabled = true;
            Time.timeScale = 1;
        } 
    }
}
