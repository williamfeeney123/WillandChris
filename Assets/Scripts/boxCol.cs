using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.
using UnityEngine.UI;

public class boxCol : MonoBehaviour
{
    public GameObject enemy;
    public GameObject walking;
    public GameObject combat;

    //Any Collider2D component will call this function on
    //any attached scripts when the collider enters a collision with another collider.
    //The gameobject must also have a RigidBody2D attached.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Test");
        if (collision.collider.gameObject == enemy)
        {
            walking.SetActive(false);
            combat.SetActive(true);
        
        }


    }
}


