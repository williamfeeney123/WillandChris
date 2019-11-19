using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

    [SerializeField] private LayerMask PlatformsLayerMask;
    public float speed;
    


    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;


        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed, 0f) * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -speed, 0f) * Time.deltaTime;
        }





    }


    }