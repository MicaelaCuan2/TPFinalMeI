using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollison : MonoBehaviour
{
    public Vector3 originalPosition;
    Rigidbody myrigidbody;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = originalPosition;
        originalPosition = new Vector3(3, 0.5f, 8);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pared")
        {
            gameObject.transform.position = originalPosition;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Base")
        {
            gameObject.transform.position = originalPosition;
            myrigidbody.velocity = Vector3.zero;
            myrigidbody.angularVelocity = Vector3.zero;
        }
        if (col.gameObject.name == "Enemigo")
        {
            gameObject.transform.position = originalPosition;
            myrigidbody.velocity = Vector3.zero;
            myrigidbody.angularVelocity = Vector3.zero;
        }
        if (col.gameObject.name == "Enemigo1")
        {
            gameObject.transform.position = originalPosition;
            myrigidbody.velocity = Vector3.zero;
            myrigidbody.angularVelocity = Vector3.zero;
        }
        if (col.gameObject.name == "Enemigo2")
        {
            gameObject.transform.position = originalPosition;
            myrigidbody.velocity = Vector3.zero;
            myrigidbody.angularVelocity = Vector3.zero;
        }
        if (col.gameObject.name == "Enemigo3")
        {
            gameObject.transform.position = originalPosition;
            myrigidbody.velocity = Vector3.zero;
            myrigidbody.angularVelocity = Vector3.zero;
        }
        if (col.gameObject.name == "Enemigo4")
        {
            gameObject.transform.position = originalPosition;
            myrigidbody.velocity = Vector3.zero;
            myrigidbody.angularVelocity = Vector3.zero;
        }
    }
}
