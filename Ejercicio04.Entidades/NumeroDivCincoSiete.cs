using System.ComponentModel.DataAnnotations;

namespace Ejercicio04.Entidades
{
    public class NumeroDivCincoSiete
    {
        public int Valor { get; set; }

        public NumeroDivCincoSiete(int valor)
        {
            Valor = valor;
        }
        public bool Validar(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Numero no valido");
            }
            else
            {
                return true;
            }
        }

        public int Getvalor() => Valor;

        public override string ToString()
        {
            return $"{Valor}";
        }

        public static bool operator == (NumeroDivCincoSiete n1,NumeroDivCincoSiete n2)
        {
            if (n1 is null || n2 is null) return false;
            return n1.Valor == n2.Valor;
        }
        public static bool operator !=(NumeroDivCincoSiete n1, NumeroDivCincoSiete n2)
        {
            return !(n1 == n2);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is NumeroDivCincoSiete n))return false;
            return this.Valor == n.Valor;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                return hash * Valor.GetHashCode();
            }
        }
    }
}
