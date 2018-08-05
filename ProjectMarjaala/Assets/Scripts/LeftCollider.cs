using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCollider : MonoBehaviour {

    [SerializeField] GameObject sceneController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision took place. deleting the collided object.");
        Destroy(collision.collider.gameObject, 1);
        //sceneController.GetComponent<SceneController>().CreateNewBlock();
    }
}
