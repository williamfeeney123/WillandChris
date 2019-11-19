using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textShow : MonoBehaviour
{
    public Text attack;
    public Text heal;
    public Text defend;

    //This uses a "Dynamic" string, which means the UI component that calls it automatically passes it's value
    //as the name parameter.
    public void onClick()
    {

        attack.text = "You attacked the enemy for 10";
       

    }

    public void onClick2()
    {
        heal.text = "You heal yourself for 5 ";
       
    }

    public void onClick3()
    {
        defend.text = "You defend yourself";

    }
}