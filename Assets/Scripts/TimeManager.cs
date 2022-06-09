using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txtTiempo;
    public Text txtTimeFloored;
    public Text txtCountDown;
    public GameObject txtCount;

    public float TimeToChange;
    public float waitTime;
    bool EstaActivado;
    int counter;

    void Start()
    {
        counter = 3;
        txtCountDown.text = counter.ToString();
    }

    void Update()
    {
        txtTiempo.text = Time.time.ToString();
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();

        if (TimeToChange < Time.time)
        {
            counter--;
            if (counter > 0)
            {
                txtCountDown.text = counter.ToString();
                TimeToChange += waitTime;
            }
            else if (counter < 0 && counter > -1)
            {
                txtCountDown.text = "GO!";
            }
        }

        if (Time.time > 7)
        {
            txtCount.SetActive(false);
        }
    }
}
