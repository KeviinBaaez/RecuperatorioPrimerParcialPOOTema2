using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public class RepositorioNumeros
    {
        private int cantidad;
        private NumeroDivCincoSiete[]? numeros;

        public int GetCantidad() => cantidad;

        public RepositorioNumeros(int Cantidad)
        {
            cantidad = Cantidad;
            numeros = new NumeroDivCincoSiete[Cantidad];
        }

        public RepositorioNumeros():this(5)
        {
            
        }

        public bool EstaCompleto() => numeros!.All(n => !(n is null));


        public bool Estavacio() => numeros!.All(n => n is null);

        public bool Existe(NumeroDivCincoSiete numero) => numeros!.Any(n => n == numero);

        public bool ValidarNumero(NumeroDivCincoSiete numero)
        {
            
            if(numero.Valor % 5 == 0 && numero.Valor % 7 == 0)
            {
                return true;
            }
            return false;
        } 

        public (bool, string) AgregarNumero(NumeroDivCincoSiete numeroAgregar)
        {
            if (EstaCompleto())
            {
                return (false, "No hay capacidad, para agregar un numero numero..");
            }
            if (!ValidarNumero(numeroAgregar))
            {
                return (false, "El numero no es valido..");
            }
            if (Existe(numeroAgregar))
            {
                return (false, "Numero Existente..");
            }
            for (int i = 0; i <= numeros!.Length; i++)
            {
                if (numeros[i] is null)
                {
                    numeros[i] = numeroAgregar;
                    return (true, $"Numero agregegado, Posicion: {i}");
                }
            }
            return (false, "No se pudo agregar");
        }

        public (bool, string) QuitarNumero(NumeroDivCincoSiete numeroQuitar)
        {
            if (Estavacio())
            {
                return (false, "No hay numeros");
            }
            if (!Existe(numeroQuitar))
            {
                return (false, "No existe el numero");
            }
            for (int i = 0; i <= numeros.Length; i++)
            {
                if (numeros[i].Equals(numeroQuitar))
                {
                    numeros[i] = null;
                    return (true, "Se quito el numero");
                }
            }
            return (false, "No se pudo quitar el numero");

        }

        public NumeroDivCincoSiete? AccederElemento(int index)
        {
            if (index < 0 || index > cantidad - 1)
            {
                throw new IndexOutOfRangeException("Indice fuera del rango");
            }
            return numeros![index];
        }

        public string MostrarNumeros()
        {
            string resultado = string.Empty;
            if (Estavacio())
            {
                resultado = "No hay elementos todavia";
            }
            else
            {
                for (int i = 0; i < numeros!.Length; i++)
                {
                    resultado += numeros[i] is null ? "Elemento nulo" : numeros[i].ToString();
                    resultado += "\n";
                }
            }
            return resultado;
        }


        public (bool, int) FormaParte(NumeroDivCincoSiete n)
        {
            if (Estavacio())
            {
                return (false, -1);
            }
            if (!Existe(n))
            {
                return (false, -1);
            }
            for (int i = 0; i < numeros!.Length; i++)
            {
                if (n.Equals(numeros[i]))
                {
                    return (true, i);
                }
            }
            return (false, -1);
        }


    }
}
