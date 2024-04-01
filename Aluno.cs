using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{
    public class Aluno
    {
        private static int matricula = 100000; // Declara uma variável static para controlar a próxima matrícula disponível
        public int Matricula //Propriedade pública somente de leitura para a matrícula do aluno
        {
            get{return matricula;}
            private set { matricula = value;} 
        }
        public string Nome{get; set;}
        public double P1{get; set;}
        public double P2{get; set;}
        public double Media {get; private set;} // Declara uma propriedade pública somente de leitura para a média do aluno com um método set privado.

        public Aluno(string nome, double p1, double p2) // Define um construtor que recebe o nome, a nota da primeira prova e a nota da segunda prova.
        {
            Matricula = ++matricula; // Atribui a próxima matrícula disponível ao aluno e incrementa a variável para a próxima matrícula.
            Nome = nome;
            P1 = p1;
            P2 = p2;
            CalcularMedia();
            MostrarAtributos();
        }
        private void CalcularMedia() // Método privado para calcular a média do aluno.
        {
            Media = (P1 + P2) / 2;
        }

        public void MostrarAtributos() // Método público para mostrar os atributos do aluno.
        {
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"P1: {P1}");
            Console.WriteLine($"P2: {P2}");
            Console.WriteLine($"Média: {Media}\n");
        }
    }
}