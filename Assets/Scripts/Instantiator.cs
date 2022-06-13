using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public int numero;
    public GameObject objectToClone;

    void Start()
    {
        int num = 0;
        while (num < numero)
        {
            Instantiate(objectToClone);
            num++;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
