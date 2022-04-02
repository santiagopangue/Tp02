using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text miTexto;

    void Start()
    {
        if (edadUsuario >= 18)
        {
            miTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            miTexto.text = "Es menor de edad";
            Debug.Log("Es menor de edad");
        }
    }

}
