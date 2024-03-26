using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Sniff : MonoBehaviour
{

    Tilemap sniffLayer;
    private float alpha;
    private bool alphaUp;
    private float timer;
    private float maxTimer = 1.5f;
    private bool startTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        sniffLayer = GameObject.Find("Sniff Layer").GetComponent<Tilemap>();
        alpha = 0.0f;
        timer = maxTimer;
    }

    // Update is called once per frame
    void Update()
    {

        showScents();
        hideScent();

        if (Input.GetKeyDown(KeyCode.F))
        {
            startTimer = true;
        }
    }

    private void showScents()
    {
        if(timer > 0.0f && startTimer == true)
        {
            timer =  (timer - Time.deltaTime);

            if (alpha <= 1f)
            {
                alpha = (alpha + 0.005f);

            }



            sniffLayer.color = new Color(1f, 1f, 1f, alpha);
        }
        else if(timer <= 0)
         {
            startTimer = false;
        }

       // Debug.Log("Timer: " + timer + " Alpha: " + alpha + " StartTimer: " + startTimer);
    }

    private void hideScent()
    {
        if (startTimer == false)
        {        
            alpha = 0.0f;
            sniffLayer.color = new Color(1f, 1f, 1f, alpha);
            timer = maxTimer;
        }
    }

}
