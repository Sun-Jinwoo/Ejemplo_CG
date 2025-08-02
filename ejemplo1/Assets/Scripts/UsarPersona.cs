using System.Collections.Generic;
using PakagePersona;
using UnityEngine;

public class UsarPersona : MonoBehaviour
{
    List<Estudiante> ListaE= new List<Estudiante>();
    // Start is called before the first frame update
    void Start()
    {
        Estudiante e1 = new Estudiante("ingenieriaMultimedia", "2025_1","Camilo","camilo@uao.edu.co","carrera 2323");
        Estudiante e2 = new Estudiante("ingenieriaMecatronica", "2025_2", "Jhon", "Jhon@uao.edu.co", "carrera 2623");
        ListaE.Add(e1);
        ListaE.Add(e2);

        for (int i = 0; i < ListaE.Count; i++)
        {
            Debug.Log(ListaE[i].NameP+""+ ListaE[i].CarreraEstudante);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
