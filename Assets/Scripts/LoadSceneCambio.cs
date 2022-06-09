using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneCambio : MonoBehaviour
{
    public GameObject Boton;
    public void CambioDeEscena()
    {
        SceneManager.LoadScene("Level1");
    }
}
