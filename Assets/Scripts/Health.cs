using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image HealthBar;
    public float Hp;

    private void Update()
    {
        Hp -= Time.deltaTime;

        HealthBar.fillAmount = Hp;
    }
}