using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorElectronica
{
    class Bandas
    {
        private int valor;
        private System.Drawing.Color color { get; set; }
        private double multiplicador;
        private double tolerancia { get; set; }

        public Bandas()
        {
        }

        public Bandas(int valor,System.Drawing.Color color, double multiplicador, double tolerancia)
        {
            this.valor = valor;
            this.color = color;
            this.multiplicador = multiplicador;
            this.tolerancia = tolerancia;
        }

        public void SetValor(int valor) {
            this.valor = valor;
        }

        public int GetValor()
        {
            return this.valor;
        }
        public void SetColor(System.Drawing.Color color) {
            this.color = color;
        }
        public System.Drawing.Color GetColor()
        {
            return this.color;
        }

        public void SetMultiplicador(double multiplicador)
        {
            this.multiplicador = multiplicador;
        }
        public double GetMultiplicador()
        {
            return this.multiplicador;
        }

        public void SetTolerancia(double tolerancia)
        {
            this.tolerancia = tolerancia;
        }
        public double GetTolerancia()
        {
            return this.tolerancia;
        }
        public override String ToString()
        {
            return "Color: " + color + "\nValor: " + valor + "\nMultiplicador: " + multiplicador + "\nTolerancia: " + tolerancia;
        }
    }

}
