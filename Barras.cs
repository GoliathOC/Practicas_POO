using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019 

public class Barras : MonoBehaviour
{
    public Slider[] barras;
    public int vida;
    Enemigo vidaEnemigo;


    void Start()
    {
        vidaEnemigo = GetComponentInParent<Enemigo>();
        StartCoroutine("AsignacionBarra");
    }


    void Update()
    {
        barras[0].value = vidaEnemigo.vida;
        if (vidaEnemigo.vida == 0)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }


    IEnumerator AsignacionVida()
    {
        yield return new WaitForSeconds(1);
        if (vidaEnemigo != null)
        {
            vida = vidaEnemigo.vida;
            barras[0].maxValue = vida;
            barras[0].value = barras[0].maxValue;
        }
    }


    IEnumerator AsignacionBarra()
    {
        yield return new WaitForSeconds(1);
        barras = new Slider[2];
        barras = GetComponentsInChildren<Slider>();
        vida = vidaEnemigo.vida;
        for (int i = 0; i < barras.Length; i++)
        {
            barras[i] = barras[i];
            if (i == 0)
            {
                barras[i].maxValue = vida;
                barras[i].value = barras[i].maxValue;
            }
        }
    }
}
