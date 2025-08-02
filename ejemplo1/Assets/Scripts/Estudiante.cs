using System;
using UnityEngine;
namespace PakagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {
        private string carreraEstudante;
        private string codigoEstudiante;

        public Estudiante()
        {
        }

        public Estudiante(string carreraEstudante, string codigoEstudiante, string nameP, string mailP, string dirP)
        : base(nameP, mailP, dirP)
        {

            this.carreraEstudante = carreraEstudante;
            this.codigoEstudiante = codigoEstudiante;
        }

        public string CarreraEstudante { get => carreraEstudante; set => carreraEstudante = value; }
        public string CodigoEstudiante { get => codigoEstudiante; set => codigoEstudiante = value; }
    }



}
