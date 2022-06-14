using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollison : MonoBehaviour
{
    AudioSource source;
    public AudioClip Dead, Win;
    public Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = originalPosition;
        originalPosition = new Vector3(9, 0.5f, 18);
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Muerte")
        {
            gameObject.transform.position = originalPosition;
            source.clip = Dead;
            source.Play();
            SceneManager.LoadScene("Perdiste");
        }
        if (col.gameObject.name == "Puerta")
        {
            source.clip = Win;
            source.Play();
            SceneManager.LoadScene("Ganaste");
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Base")
        {
            gameObject.transform.position = originalPosition;
            source.clip = Dead;
            source.Play();
            SceneManager.LoadScene("Perdiste");
        }
    }



}
