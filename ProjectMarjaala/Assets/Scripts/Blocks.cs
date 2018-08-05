using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var pos = new Vector2(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y);
        gameObject.transform.position = pos;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("blocks collided");
    }
}
