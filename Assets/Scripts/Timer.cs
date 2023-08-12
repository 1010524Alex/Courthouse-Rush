using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    public float timer;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        double b = System.Math.Round(timer, 2); 
        text.text = timer.ToString();
        float min = Mathf.FloorToInt(timer / 60);
        float sec = Mathf.FloorToInt(timer % 60);
        text.text = string.Format("{00:00} : {1:00}", min, sec); 

        if (timer < 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    
}
