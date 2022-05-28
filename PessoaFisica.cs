namespace encontroRemoto2Uc9
{
    public class PessoaFisica: Pessoas
    {
        public string? cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        public override double PagarImposto(float rendimentos){
            if (rendimentos <= 1500){
                return 0;
            }
            else if( rendimentos > 1500 && rendimentos <= 500){
                return rendimentos * .03;
            }
            else{
                return (rendimentos / 100) * 5;
            }
        }
       
        public bool ValidarDataNascimento(DateTime dataNasc){

            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays/ 365; 

            if (anos >= 18){

                return true;
            } 
            else{
                return false;
            }     
        }   
    } 
}    
