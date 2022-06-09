using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount;
    Text txtCloneAmount;
    GameObject clon;

    void Start()
    {
        cloneAmount = int.Parse(txtCloneAmount.text);
        int counter = 0;
        for (int i = counter; i < cloneAmount; i++)
        {
            Instantiate(objectToClone).transform.position += new Vector3(0, 2, 0);
            Destroy(clon, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
