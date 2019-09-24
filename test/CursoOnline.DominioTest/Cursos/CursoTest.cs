using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoOnline.DominioTest.Cursos
{
    /* Eu, enquanto administrador, quero criar e editar cursos para que sejam abertas matriculas para o mesmo. "

        Critério de Aceite

        - Criar um curso com nome, carga horária, publico alvo e valor do curso
        - As opções para o publico alvo são: Estudante, Universitário, Empregado e Empreendedor.
        - Todos os campos do curso são obrigatórios.
    */

    public class CursoTest
    {
        [Fact]
        public void DeveCriarCurso()
        {

            var cursoEsperado = new
            {
                Nome = "Informática básica";
                CargaHoraria = 80;
                PublicoAlvo = "Estudantes";
                Valor = 950;
            };
        }


            var nome = "Informática básica";
            double cargaHoraria = 80;
            string publicoAlvo = "Estudantes";
            double valor = 950;
            var curso = new Curso(nome, cargaHoraria, publicoAlvo, valor);

            Assert.Equal(nome, curso.Nome);
            Assert.Equal(cargaHoraria, curso.CargaHoraria);
            Assert.Equal(publicoAlvo, curso.PublicoAlvo);
            Assert.Equal(valor, curso.Valor);

        }

    }

    public class Curso
    {
        
        public Curso(string nome, double cargaHoraria, string publicoAlvo, double valor)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;

        }

        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public string PublicoAlvo { get; private set; }
        public double Valor { get; private set; }



    }
}
