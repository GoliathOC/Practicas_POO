using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019 

public class EnemigoB : MonoBehaviour
{
    public List<Enemy> enemigo;

    void Awake()
    {
        enemigo.Add(new Enemy(100, 400, "Abejón"));
        enemigo.Add(new Enemy(200, 500, "Momia"));
        enemigo.Add(new Enemy(100, 300, "Hongo"));
    }
}
