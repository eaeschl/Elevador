namespace Elevador.Models
{
    public class Elevador
    {
        
        //Definição de variaveis
        public int AndarAtual { get; set; }
        public int TotalAndares  { get; set; }
        public int CapacidadeElevador { get; set; }
        public int QuantidadePessoas  { get; set; }

        
        public void Iniciar()  //Definimos valores iniciais. 
        {
           AndarAtual = 0; //O Elevador inicia no terreo (Andar 0)
           CapacidadeElevador = 8; //A capacidade do elevador é de 8 pessoas
           TotalAndares = 10;  // O predio tem 10 andares
           QuantidadePessoas = 0; //Iniciamos sem pessoas no elevador
        }
        public void Entrar()

        {
            if (CapacidadeElevador > QuantidadePessoas)  //Verifica não ter mais pessoas da capacidade do elevador
                QuantidadePessoas ++;  // Incrementa a quantidade de pessoas no elevador
                    
        }
        public void Sair()
        {
            if (QuantidadePessoas > 0)  //Verifica ter pelo menos uma pessoa no elevador
                QuantidadePessoas --; //Tira uma pessoa do elevador
        }
        public void Descer()
        {
            if (AndarAtual > 0)  //Verifica se temos pelo menos uma andar para descer 
                AndarAtual --; // Desce um andar
        }
    }
}
