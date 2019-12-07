using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 28/11/2019 

public class Agente : MonoBehaviour
{

    [SerializeField]
    protected float velocidad;
    [SerializeField]
    protected float freno;
    [SerializeField]
    protected Transform destinox;


    protected void ConfigurarDestino(Transform d)
    {
        Vector3 destinoFinal = new Vector3(d.position.x, this.transform.position.y, d.position.z);
        ConfiguracionFreno(destinoFinal, freno);

        transform.LookAt(destinoFinal);

        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }

    protected void ConfiguracionFreno(Vector3 d, float f)
    {

        float velocidadLocal = 1;
        float distancia = Vector3.Distance(transform.position, d);

        if (distancia < f)
        {
            velocidad = 0;
            return (true);
        }

        else
        {
            velocidad = velocidadLocal;
            return (false);
        }
    }
}
