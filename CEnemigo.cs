using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 28/11/2019 

public class CEnemigo : MonoBehaviour
{
    public string id;
    public string nombre;
    public int vida;
    public int magia;

    EnemigoB enemigoB;
    Animator animMomia;

    void Start()
    {
        enemigoB = FindObjectOfType<EnemigoB>();
        BusquedaEnemigo(id);
    }
    private void BusquedaEnemigo(string id)
    {
        for (int i = 0; i < enemigoB.enemigo.Count; i++)
        {
            if (id == enemigoB.enemigo[i].nombre)
            {
                nombre = enemigoB.enemigo[i].nombre;
                vida = enemigoB.enemigo[i].vida;
                magia = enemigoB.enemigo[i].magia;
            }

        }
    }
    private void Update()
    {
        ConfigurarDestino(destino);

    }
}
