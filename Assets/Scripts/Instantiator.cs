using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public int numero;
    public GameObject objectToClone;
    GameObject clon;

    void Start()
    {
        //int num = 0;
        //while (num < numero)
        //{
        //    clon = Instantiate(objectToClone);
        //    num++;
        //}
        //Destroy(clon, 1);
        //A
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            int num = 0;
            while (num < numero)
            {
                clon = Instantiate(objectToClone);
                num++;
            }
            Destroy(clon, 2.5f);
        }
    }
}
