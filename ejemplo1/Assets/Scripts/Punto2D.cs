using System;
using UnityEngine;

namespace PakagePersona
{
    [System.Serializable]
    public class Punto2D
    {
        [SerializeField]
        private double x;
        [SerializeField]
        private double y;

        // Constructor
        public Punto2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Getters
        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        // Setters
        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }
    }
}