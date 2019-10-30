using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019

public class CrearArmas : MonoBehaviour
{
    public string Id;
    public string nombre;
    public int vidautil;
    public int daño;
    ListaArmas lArmas;


    void Start()
    {
        lArmas = FindObjectOfType<ListaArmas>();
        BusquedaArmas(Id);
    }


    private void BusquedaArmas(string id)
    {
        for (int i = 0; i < lArmas.Armas.Count; i++)
        {
            if (id == lArmas.Armas[i].nombre)
                nombre = lArmas.Armas[i].nombre;
            vidautil = lArmas.Armas[i].vidautil;
                daño = lArmas.Armas[i].daño;
        }
    }
}
