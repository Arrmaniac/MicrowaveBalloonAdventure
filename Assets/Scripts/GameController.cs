using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     	
	}

    private void OnMouseDown()
    {
        GameObject go = (GameObject)Instantiate(Resources.Load("Controller"));

        float x = Input.GetAxis("x");
        float y = Input.GetAxis("y");
        go.transform.position = new Vector3(x, y, 0);
    }

    private void OnMouseUp()
    {

    }
}
