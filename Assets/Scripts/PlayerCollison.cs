using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollison : MonoBehaviour
{
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = originalPosition;
        originalPosition = new Vector3(9, 0.5f, 18);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Pared")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Pared1")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Pared2")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Pared3")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Pared4")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Pared5")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Puerta")
        {
            SceneManager.LoadScene("Ganaste");
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Base")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Enemigo")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Enemigo1")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Enemigo2")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Obstaculo")
        {
            gameObject.transform.position = originalPosition;
        }
        if (col.gameObject.name == "Enemigo4")
        {
            gameObject.transform.position = originalPosition;
        }
       
    }
}
