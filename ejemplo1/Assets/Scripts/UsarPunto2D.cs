using System.Collections.Generic;
using UnityEngine;
using PakagePersona;

public class UsarPunto2D : MonoBehaviour
{
    List<Punto2D> listaPuntos = new List<Punto2D>();

    void Start()
    {
        // Inicializar puntos de ejemplo
        Punto2D p1 = new Punto2D(1.5, 2.3);
        Punto2D p2 = new Punto2D(4.7, 8.1);
        listaPuntos.Add(p1);
        listaPuntos.Add(p2);

        // Mostrar puntos en la consola
        for (int i = 0; i < listaPuntos.Count; i++)
        {
            Debug.Log($"Punto {i + 1}: ({listaPuntos[i].GetX()}, {listaPuntos[i].GetY()})");
        }
    }
}