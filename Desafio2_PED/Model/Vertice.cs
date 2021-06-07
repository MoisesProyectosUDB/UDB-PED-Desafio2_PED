
using System.Drawing;


namespace Desafio2_PED.Model
{
    class Vertice
    {
        public Point p { get; private set; } //metdo para dar o obtener valores de los puntos
        public string nombre { get; private set; } //Nombre del metodo
        public int index { get; set; } //Index

        public Vertice(Point p, string nombre, int index)
        {
            this.p = p;
            this.nombre = nombre;
            this.index = index;
        }
    }
}
