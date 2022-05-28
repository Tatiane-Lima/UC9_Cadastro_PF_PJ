using System;
using System.Threading;
using System.Collections.Generic; 

namespace encontroRemoto2Uc9
{
  class Program
{
    static void Main(string[] args)
{
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.BackgroundColor = ConsoleColor.Gray;
      Console.WriteLine(@$"
  
        =======================================
        |   Bem vindo ao sistema de cadastro  |
        |   Pessoa Física e Pessoa Jurídica!  |
        =======================================
        ");

      barraCarregamento("Iniciando");

      string? opcao;

      List<PessoaFisica> listapf = new List<PessoaFisica>();

      do 
      {
          Console.WriteLine(@$"
           ==================================   
          |     Digiti a opção desejada:     |
          |                                  |
          |    1 - Cadastrar Pessoa Física   |
          |    2 - Cadastrar Pessoa Jurídica |
          |----------------------------------|
          |    3 - Listar Pessoa Física      |
          |    4 - Listar Pessoa Jurídica    |
          |    5 - Remover PF                | 
          |    6 - Remover PJ                |
          |    0 - Sair                      |
           ==================================
              
           ");

          opcao = Console.ReadLine();
          switch (opcao){
   
          case "1":

          Endereco endPf = new Endereco ();
          Console.WriteLine( "Digite o Logradouro:");
          endPf.logradouro = Console.ReadLine();
          
          Console.WriteLine( "Digite o número:");
          endPf.numero = int.Parse(Console.ReadLine());

          Console.WriteLine( "Digite o complemento:");
          endPf.complemento = Console.ReadLine();
        
          string respostaComercial;
          bool validacao = true; 
        do{
            Console.WriteLine("O Endereço é Comercial? S/N?");
            respostaComercial = Console.ReadLine().ToUpper();

            if(respostaComercial == "S" || respostaComercial == "N"){
              validacao = false;
            }
            if(respostaComercial == "N"){
              endPf.enderecoComercial = true;
          }else{
              endPf.enderecoComercial = false;
              Console.WriteLine( "Resposta Inválida");
          }  
           }while(validacao);

          PessoaFisica novapf = new PessoaFisica();
          novapf.endereco = endPf;

          Console.WriteLine("Digite o nome");
          novapf.nome = Console.ReadLine ();

          Console.WriteLine("Digite o CPF");
          novapf.cpf = Console.ReadLine();

          Console.WriteLine( "Digite o seu rendimento mensal");
          novapf.rendimentos = float.Parse(Console.ReadLine());

          Console.WriteLine("Digite a data de nascimento (aa/mm/dd)");
          novapf.dataNascimento = DateTime.Parse(Console.ReadLine());

          PessoaFisica pf = new PessoaFisica();

          bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
          Console.WriteLine(idadeValida);

          if(idadeValida == true)
          {

              Console.WriteLine($"Cadastro Aprovado");
              listapf.Add(novapf);
              Console.WriteLine(novapf.PagarImposto(novapf.rendimentos));

          } else
          {

          Console.WriteLine($"Cadastro Reprovado");
          } 
          
         using (StreamWriter sw = new StreamWriter($"{novapf.nome}.txt"))
         {
              sw.Write($"{novapf.nome}");
         }

          break;
          
          case "2":
          PessoaJuridica pj = new PessoaJuridica();
          PessoaJuridica novapj = new PessoaJuridica();
          

          Endereco end2 = new Endereco();
          Console.WriteLine( "Digite o Logradouro");
          end2.logradouro = Console.ReadLine();

          Console.WriteLine( "Digite o número");
          end2.numero = int.Parse(Console.ReadLine());

          Console.WriteLine( "Digite o Complemento");
          end2.complemento = Console.ReadLine();
    
          novapj.endereco = end2;
          novapj.cnpj = "12345678910001";
          novapj.razaosocial = "Pessoa Jurídica";

          if (pj.ValidarCnpj(novapj.cnpj))

      {
          Console.WriteLine("CNPJ válido");

}
else {
  Console.WriteLine("CNPJ inválido");
}
   Thread.Sleep(500);
    break;

    case "3":

       // foreach (var cadaItem in listapf)
        //{
          //  Console.WriteLine($"Nome:{cadaItem.nome}, CPF: {cadaItem.cpf}, Logradouro: {cadaItem.endereco.logradouro}"); 
       // }

       using (StringReader sr = new StringReader("Tatiane.txt"))
       {
          string linha;

          while ((linha = sr.ReadLine()) != null)
          {
            Console.WriteLine($"{linha}");
          }
       }
       Console.WriteLine($"Aperte Enter para continuar");
       Console.ReadLine();

        break;

    case  "4":

        // Console.WriteLine("Digite o CPF para remover");
        // string cpf = Console.ReadLine();

        // PessoaFisica pessoaRetornada = listapf.Find(cadaItem => cadaItem.cpf == cpf);

        // if(pessoaRetornada != null){
        //     listapf.Remove(pessoaRetornada);
        //     Console.WriteLine("Pessoa Removida com Sucesso");
        // } else {
        //     Console.WriteLine("CPF não encontrado");
        // }

        break;

    case "5":

        Console.WriteLine("Digite CPF par remover");
        string cpfProcurado = Console.ReadLine();

        PessoaFisica pessoaFisicaRetornada = listapf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

        if(pessoaFisicaRetornada != null){
            listapf.Remove(pessoaFisicaRetornada);
            Console.WriteLine("Pessoa removida com sucesso");
        } else{
            Console.WriteLine("CPF não encontrado");
        }


        break;

    case "6":
        break; 
    
    case "0":
    Console.WriteLine($"Obrigada");
    Console.ForegroundColor = ConsoleColor.Blue; 
    {
      
    };
    Console.BackgroundColor = ConsoleColor.Gray;
     
    barraCarregamento("Finalizando");

    break;

    default:
    Console.WriteLine($"Opção Inválida");
    break;
    
  }

} while(opcao != "0");


   static void barraCarregamento(string textoCarregamento){

     Console.ResetColor();
     Console.ForegroundColor = ConsoleColor.Blue;
     Console.Write (textoCarregamento);
     Thread.Sleep(500);
       for (var contador = 0; contador < 10; contador ++){
         
       Console.Write(".");
       Thread.Sleep(200);
     }
      }
       }
        }
         }




    //Console.WriteLine(novapf.endereco.logradouro);
    //Console.WriteLine(novapf.endereco.numero);
  
    //Console.WriteLine($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero} ");
   
    
