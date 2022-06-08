using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonIniciar : MonoBehaviour
{
    public GameObject cartel;
    public GameObject Texto;
    public GameObject Boton;

    Text textoCartel;

    // Start is called before the first frame update
    void Start()
    {
        cartel.SetActive(true);
        Texto.SetActive(true);
        Boton.SetActive(true);
    }

    public void BotonInicio()
    {
        cartel.SetActive(false);
        Texto.SetActive(false);
        Boton.SetActive(false);
    }
}
