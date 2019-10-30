using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019 

public class ListaArmas : MonoBehaviour
{
    public List<Armas> Armas;
    void Awake()
    {
        Armas.Add(new Armas(10, 40, "Rifle"));
        Armas.Add(new Armas(20, 50, "Espada"));
        Armas.Add(new Armas(60, 30, "Mazo"));
    }
}
