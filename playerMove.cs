using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nombre de desarrollador: Ocampo Coyole Aldo       Materia: Programación Orientada a Objetos    Fecha: 29/10/2019 

public class playerMove : MonoBehaviour
{

    public GameObject model;
    public string[] tipoAtaque;
    public bool movimientoAtaque;

    Animator anim;
    public int contador;
    public float velocidadWS;
    public float velocidadAD;
    public float velocidadRotacion;

    Quaternion targetModelRotation;

    void Start()
    {
        anim = GetComponent<Animator>();
        movimientoAtaque = false;
        contador = 0;
        targetModelRotation = Quaternion.Euler(0, 0, 0);
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            contador++;
            if (contador>=3)
            {
                contador = 0;
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movimientoAtaque = true;
        }
        else
        {
            movimientoAtaque = false;
        }

        if (movimientoAtaque==false)
        {
            anim.SetLayerWeight(0, 1);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 0);
            ControlMovimientoAtaque();
        }
        else if (movimientoAtaque==true)
        {
            anim.SetLayerWeight(0, 0);
            anim.SetLayerWeight(1, 0);
            anim.SetLayerWeight(2, 1);
            Ataque(contador, "contador");
        }
    }


    void ControlMovimiento()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");


        Vector3 direccion = new Vector3(horizontal * velocidadWS * Time.deltaTime, 0, vertical * velocidadWS * Time.deltaTime);

        transform.Translate(direccion);
        anim.SetFloat("VelocidadWS", vertical * velocidadWS);
        anim.SetFloat("velocidadAD", horizontal * velocidadAD);
        direccion.Normalize();

        if (direccion.z > 0)
        {
            targetModelRotation = Quaternion.Euler(0, 0, 0);
        }

        else if (direccion.z < 0)
        {
            targetModelRotation = Quaternion.Euler(0, 180, 0);
        }

        if (direccion.x > 0)
        {
            targetModelRotation = Quaternion.Euler(0, 90, 0);
        }

        if (direccion.x < 0)
        {
            targetModelRotation = Quaternion.Euler(0, 270, 0);
        }
    }


    void ControlMovimientoAtaque()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");


        Vector3 direccion = new Vector3(horizontal * velocidadWS * Time.deltaTime, 0, vertical * velocidadWS * Time.deltaTime);

        transform.Translate(direccion);
        anim.SetFloat("Velocidad", vertical * velocidadWS);
        anim.SetFloat("velocidadLateral", horizontal * velocidadAD);
        direccion.Normalize();
    }


    void Ataque(string tipoAtaque)
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool(tipoAtaque,true);
        }
        else
        {
            anim.SetBool(tipoAtaque, false);
        }
    }


     void Ataque (int contador, string contadorText)
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetInteger(contadorText, contador);          
        }
    }


    void CambioAtaque()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            contador++;
            if (contador > tipoAtaque.Length - 1)
            {
                contador = 0;
            }
        }
    }


    void ComboAtaque()
    {
        contador++;
        if (contador > tipoAtaque.Length - 1)
        {
            contador = 0;
        }
    }
}
