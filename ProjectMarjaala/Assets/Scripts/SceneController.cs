using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    [SerializeField] GameObject blocksPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Instantiate(blocksPrefab, parentForBlocks.transform);
	}

    public void CreateNewBlock()
    {
        Debug.Log("Creating..");
        var newBlock = Instantiate(blocksPrefab);
        Destroy(newBlock, 5);
    }
}
