using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.
using UnityEngine.UI;

public class boxCol : MonoBehaviour
{

    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public GameObject win;


    public GameObject pickup;
    public GameObject pickup2;
    public GameObject pickup3;

    public GameObject walking;
    public GameObject combat;
    public GameObject combat2;
    public GameObject combat3;

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
            Destroy(enemy);     
        
        }
        if (collision.collider.gameObject == enemy2)
        {
            walking.SetActive(false);
            combat2.SetActive(true);
            Destroy(enemy2);
        }
        if (collision.collider.gameObject == enemy3)
        {
            walking.SetActive(false);
            combat3.SetActive(true);
            Destroy(enemy3);
        }
       

        if (collision.collider.gameObject == win)
        {

            SceneManager.LoadScene(2);


        }


    }
}


