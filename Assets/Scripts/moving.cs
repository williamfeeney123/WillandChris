using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

    [SerializeField] private LayerMask PlatformsLayerMask;
    public float speed;
    public Animator Animator;



    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;
            Animator.SetFloat("speed", Mathf.Abs(speed));
            transform.eulerAngles = new Vector3(0, 0, 0);

        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;
            Animator.SetFloat("speed", Mathf.Abs(speed));
            transform.eulerAngles = new Vector3(0, 180, 0);

        }

       else if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed, 0f) * Time.deltaTime;
            Animator.SetBool("move", true);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0f, -speed, 0f) * Time.deltaTime;
            Animator.SetBool("move2", true);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }


        else
        {
            //idle
            Animator.SetFloat("speed", 0f);
            Animator.SetBool("move", false);
            Animator.SetBool("move2", false);
        }


    }


    }