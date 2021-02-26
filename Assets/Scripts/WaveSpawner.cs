using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public static float waveTimer = 10f;
    

    void Update()
    {
        GetComponent<Text>().text = waveTimer.ToString();
        waveTimer -= Time.deltaTime;
    }
}
