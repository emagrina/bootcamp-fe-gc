using System;
namespace ex01.Clases
{
	public class Cuenta
	{
        private string titular;
        private double cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public override string ToString()
        {
            return $"Titular: {titular}\nCantidad: {cantidad}";
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad -= cantidad;
                if (this.cantidad < 0)
                {
                    this.cantidad = 0;
                }
            }
        }
    }
}

