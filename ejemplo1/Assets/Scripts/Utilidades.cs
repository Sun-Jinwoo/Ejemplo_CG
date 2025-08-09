using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using PakagePersona;

namespace PakagePersona
{
    // Clase contenedora para la lista de estudiantes
    [System.Serializable]
    public class EstudianteList
    {
        public List<Estudiante> estudiantes;
    }

    // Clase contenedora para la lista de puntos
    [System.Serializable]
    public class Punto2DList
    {
        public List<Punto2D> puntos;
    }

    public static class Utilidades
    {
        // Método para guardar una lista de estudiantes en un archivo JSON
        public static void GuardarEstudiantesComoJson(List<Estudiante> estudiantes, string nombreArchivo)
        {
            try
            {
                EstudianteList lista = new EstudianteList { estudiantes = estudiantes };
                string json = JsonUtility.ToJson(lista, true);
                string folderPath = Application.streamingAssetsPath;
                //string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
                File.WriteAllText(folderPath, json);
                Debug.Log($"Archivo JSON de estudiantes guardado en: {folderPath}");
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error al guardar estudiantes en JSON: {ex.Message}");
            }
        }

        // Método para guardar una lista de Punto2D en un archivo JSON
        public static void GuardarPuntosComoJson(List<Punto2D> puntos, string nombreArchivo)
        {
            try
            {
                Punto2DList lista = new Punto2DList { puntos = puntos };
                string json = JsonUtility.ToJson(lista, true);
                string folderPath = Application.streamingAssetsPath;
                //string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
                File.WriteAllText(folderPath, json);
                Debug.Log($"Archivo JSON de puntos guardado en: {folderPath}");
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error al guardar puntos en JSON: {ex.Message}");
            }
        }
    }
}