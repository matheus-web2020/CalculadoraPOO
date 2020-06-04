namespace CalculadoraPOO
{
    public class Calculadora
    {
        public float num_1 { get; set; }

        public float num_2 { get; set; }

        public string operador{ get; set; }

        public float resultado { get; set; }
        
        public void Somar(){
            resultado = num_1 + num_2;
            resultado = 0;
        }

        public void Subtrair(){
            resultado = num_1 - num_2;
            resultado = 0;
        }

        public void Multiplicar(){
            resultado = num_1 * num_2;
            resultado = 0;
        }

        public void Dividir(){
            resultado = num_1 / num_2;
            resultado = 0;
        }
    }
}