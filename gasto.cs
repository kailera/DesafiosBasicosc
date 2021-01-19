public class Program
{
	public static void Main()
	{
		float consumo = 12;                               // Definicao de variável;
    float resultado;                                  // Permite refletir alterações em todo o sistema;
                                                      // float permite as casas decimais;  
		                                                  // float permite as casas decimais 
                                                        
		int[]velocidade = new int [2];                    // Array que armazena velocidade e tempo como integer
		string data = Console.ReadLine();                 // recebe o arquivo em string com velocidade e tempo
		string[] register = data.Split(' ');              // Arrar que quebra a String com
		
		for(int i = 0; i < register.Length; i++){         //repeticao que pega cada registro e registra o inteiro convertido
			velocidade[i] = Convert.ToInt32(register[i]);
		}
		
		resultado = (velocidade[0] * velocidade[1]) / consumo; // calcula o gasto
		
	  Console.WriteLine(resultado.ToString("N3"));           // publica o gasto no console
		
	}
}
