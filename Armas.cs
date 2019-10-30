using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019 

public class Armas : MonoBehaviour
{
    public int daño;
    public int vidautil;
    public string nombre;

    public Armas(int v, int d, string n)
    {
        this.nombre = n;
        this.vidautil = v;
        this.daño = d;
    }
}
