namespace exercicios_02
{
    public class aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public int RG;
        public bool bolsista;
        public double mediaFinal;
        public double valorDaMensalidade;
    
    public void mensalidadeBolsa (double valorDaMensalidade){
        if(bolsista==true){
            System.Console.WriteLine($"O aluno possuí uma bolsa no valor de {valorDaMensalidade * 0.8}\nTotalizando a mensalidade no valor de {valorDaMensalidade-(valorDaMensalidade * 0.8)} ");
        }else{
            System.Console.WriteLine("O aluno não possuí bolsa.");
        }
    }
    }
}