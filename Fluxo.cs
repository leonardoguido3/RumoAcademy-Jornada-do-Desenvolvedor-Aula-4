using ExemploTemplateConsole.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTemplateConsole
{
    public class Fluxo
    {
        //Modificação
        public void Executar()
        {
            // declarei uma variável do tipo pessoa
            // adicionei o nome da variavei como pessoa
            // inicializei usando o igual
            // recebendo o valor instanciado atraves do new
            // que o new instanciou a classe Pessoa
            // fiz com que a variavel pessoa tenha todos os atributos da classe
            Pessoa pessoa = new Pessoa();

            // quando eu coloco o nome da variavel que eu instanciei um objeto (classe)
            // atraves do "." consigo acessar e modificar os atributos que tem na classe
            // ou seja, o nome está dentro de class Pessoa
            // public string Nome { get; set; }
            pessoa.Nome = "Leonardo";

            // aqui converti uma data para datetime
            // vou informar uma data fake para fingir ser meu aniversario
            pessoa.Nascimento = DateTime.Parse("2020-01-01");

            TimeSpan tempoEntreDatas = DateTime.Now - pessoa.Nascimento;

            DateTime quantosAnosTem = new DateTime(tempoEntreDatas.Ticks);

            int quantidadeAnos = quantosAnosTem.Year - 1;

            if(quantidadeAnos < 18)
            {
                Console.WriteLine("Menor de idade");
            }
            else
            {
                Console.WriteLine("Maior de idade");
            }

        }
    }
}
