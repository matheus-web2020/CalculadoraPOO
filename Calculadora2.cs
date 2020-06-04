namespace CalculadoraPOO
{
    public class Calculadora2 : Calculadora
    {
        private string[] valores { get; set; }
        
        private float valor { get; set; }

        private float soma { get; set; }

        public void CalculoMedia(string txt){
            string[] valores = txt.Split(",");

        for(int i = 0; i < valores.Length; i++ ){
            valor = float.Parse(valores[i]);
            soma += valor;
        }
        resultado = soma / valores.Length;
        }

        public void EfetuarCalculos(string entradaDosDados){
            string[] entrar= entradaDosDados.Split(" ");

            num_1 = float.Parse(entrar[1]);
            num_2 = float.Parse(entrar[2]);
            operador = entrar[3];

            switch(operador){
                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "x":
                Multiplicar();
                break;

                case "/":
                Dividir();
                break;

                default:
                Somar();
                break;
            }

        }
    }
}