using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019 

public class Enemy : MonoBehaviour
{
    public int vida;
    public int magia;
    public string nombre;

    public Enemy(int v, int m, string n)
    {
        this.nombre = n;
        this.vida = v;
        this.magia = m;
    }
}
