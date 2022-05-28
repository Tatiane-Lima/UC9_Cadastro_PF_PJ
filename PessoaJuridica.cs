namespace encontroRemoto2Uc9
{
    public class PessoaJuridica: Pessoas
    {
        public string? cnpj { get; set; }
        
        public string? razaosocial { get; set; }
        public override double PagarImposto(float rendimentos){
            if (rendimentos <= 5000){
                return rendimentos *.06;
            } 
            else if (rendimentos > 5000 && rendimentos <= 10000){
                return rendimentos * .08;
            }
            else{
                return (rendimentos / 100) * 10;
            }
        }
        public bool ValidarCnpj(string cnpj){
           
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length -6, 4) == "0001"){

                return true;
            } else{
                return  false;
        
    }}}}