# UC9_Cadastro_PF_PJ
#Sistema de Cadastro de Clientes – ClientLab

Desenvolvimento do Sistema de Cadastro de Clientes customizado da empresa ClientLab. 

#**Features (funcionalidades)**
-	o sistema de clientes armazena os cadastros das pessoas físicas e jurídicas;
-	o cadastro das pessoas físicas é feito com os seguintes dados: nome, CPF e data de nascimento;
-	o cadastro das pessoas jurídicas é feito com os seguintes dados: nome, CNPJ e razão social;
-	ambos devem possuir um endereço e indicar se o endereço é comercial ou residencial;
-	o Sistema armazena os registros em arquivos;

#**Tecnologias utilizadas**

Back-End
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET](https://dotnet.microsoft.com/download)
 
Editor
- [Visual Studio Code](https://code.visualstudio.com/)

#**Organização do projeto**
-	Criamos a classe mãe Clientes e duas classes filhas a partir dela, PessoaFisica e PessoaJuridica;
-	Criamos a classe Endereco;
-	Adicionamos a classe PessoaFisica as propriedades de CPF e data de Nascimento e o método PagarImposto;
-	Adicionamos a clase PessoaJuridica as propriedades de CNPJ e razão social, e o método PagarImposto;

#**Pré-requisitos de instalação**
-	Windows 10 versão 1703 ou superior
-	Processador de 1,8 GHz ou mais rápido.
-	2 GB de RAM; 8 GB de RAM são recomendados (mínimo de 2,5 GB, se executado em uma máquina virtual

#**Execução da aplicação**
  **-	Clone o repositório**
  >git clone https://github.com/TatianeLima/UC9_Cadastro_PF_PJ.git

  **-	Entre no diretório**
  >cd encontroRemoto2Uc9
  
  **-	Execute o projeto**
  >dotnet run

#**Erros comuns**
-	Data de Nascimento: O usuário deve respeitar o formato indicado
-	CPF/CNPJ : Usuário deve digitar somente números, sem caracteres

#**Contribuidores**
-	Tatiane Lima
-	Professor Caique

