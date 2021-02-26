using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int health = 3;

    private void Start()
    {
        health = 3;
    }

    void Update()
    {
        GetComponent<Text>().text = health.ToString();
    }
}