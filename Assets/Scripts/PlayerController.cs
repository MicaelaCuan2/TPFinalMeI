using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    public GameObject Timer;
    bool terminoCountdown;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 0.5f;
        terminoCountdown = Timer.GetComponent<TimeManager>().TerminoCountDown;
    }

    // Update is called once per frame
    void Update()
    {
        if (terminoCountdown)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(velocidad, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= new Vector3(velocidad, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= new Vector3(0, 0, velocidad);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 0, velocidad);
            }

            if (Input.GetKey(KeyCode.R))
            {
                transform.position += new Vector3(-14f, 0.5f, -17.1f);
            }
        }
        else
        {
            terminoCountdown = Timer.GetComponent<TimeManager>().TerminoCountDown;
        }
    }
}
