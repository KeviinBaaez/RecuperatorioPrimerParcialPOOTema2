using System.Text;

namespace Ejercicio01.Entidades
{
    public class Cilindro
    {
        private readonly int radio;
        private readonly int altura;
        private double diametro;

        public Cilindro(int Radio, int Altura)
        {
            if(Radio <= 0 || Altura <= 0)
            {
                throw new ArgumentException("Valor no valido..");
            }
            else
            {
                radio = Radio;
                altura = Altura;
                diametro = CalcularDiametro(radio);
            }
        }

        private double CalcularDiametro(int radio)
        {
            return diametro = radio * 2;
        }

        public int GetRadio() => radio;

        public int GetAltura() => altura;
        public double GetDiametro() => diametro;

        public double InformarArea()
        {
            var area = 2 * Math.PI * radio * (radio + altura);
            return area;
        }
        public double InformarVolumen()
        {
            var volumen = Math.PI * Math.Pow(radio, 2) * altura;
            return volumen;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Radio: {GetRadio()}");
            sb.AppendLine($"Altura: {GetAltura()}");
            sb.AppendLine($"Diametro: {GetDiametro()}");
            sb.AppendLine($"Area: {InformarArea()}");
            sb.AppendLine($"Volumen: {InformarVolumen()}");
            return sb.ToString();
        }
    }
}
