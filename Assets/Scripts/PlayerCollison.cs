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
        if (col.gameObject.tag == "Muerte")
        {
            gameObject.transform.position = originalPosition;
            SceneManager.LoadScene("Perdiste");
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
            SceneManager.LoadScene("Perdiste");
        }
    }



}
