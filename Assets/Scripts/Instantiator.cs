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
        int num = 0;
        while (num < numero)
        {
            clon = Instantiate(objectToClone);
            num++;
        }
        Destroy(clon, 1);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
