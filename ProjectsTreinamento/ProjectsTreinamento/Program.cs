using ProjectsTreinamento.ContentContext;
using ProjectsTreinamento.ContextAssinatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsTreinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //var curso = new Curso();
            //curso.Nivel = ContentContext.Enums.EConteudoNivel.Avancado;
            //Console.WriteLine(curso.Nivel);

            //var carreira = new Carreira();
            //carreira.Itens.Add(new ItemCarreira()); //criando um novo objeto paraadicionar item a carreira
            //Console.WriteLine(carreira.TotalCurso);

            //Adicionando um Artigo
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo sobre OPP","Oritacao-objeto")); //criando um novo objeto
            artigos.Add(new Artigo("Artigo sobre C#", "C#")); //criando um novo objeto
            artigos.Add(new Artigo("Artigo sobre ASP.NET", "ASP.NET")); //criando um novo objeto
            //foreach (var artigo in artigos)
            //{
            //    Console.WriteLine(artigo.Id);
            //    Console.WriteLine(artigo.Titulo);
            //    Console.WriteLine(artigo.Url);
            //    Console.WriteLine("------------------------------------------");
            //}

            //Adicionando um Curso
            var cursos = new List<Curso>();
            var cursosOOP = new Curso("Fundamentos OOP", "Fundamento-oop");
            var cursosCsharp = new Curso("Fundamentos C#", "Fundamento-C#");
            var cursosAspNet = new Curso("Fundamentos ASP.NET", "Fundamento-ASP.NET");
            //Adicionado curso a lista
            cursos.Add(cursosOOP);
            cursos.Add(cursosCsharp);
            cursos.Add(cursosAspNet);


            //Adicionando carreira

            var carreiras = new List<Carreira>();
            var carreiradotnet = new Carreira("Especialista .Net", "Especialista-dotnet");
            carreiras.Add(carreiradotnet);

            var carreiraItem1 = new ItemCarreira(1,"Comece por aqui", "", cursosOOP);
            carreiradotnet.Itens.Add(carreiraItem1);
            var carreiraItem3 = new ItemCarreira(3, "Aprenda OOP", "", null);
            carreiradotnet.Itens.Add(carreiraItem3);
            var carreiraItem2 = new ItemCarreira(2, "Aprenda .NET", "", cursosAspNet);
            carreiradotnet.Itens.Add(carreiraItem2);

            
            foreach (var carreira in carreiras)
            {
                Console.WriteLine(carreira.Titulo);
                foreach(var item in carreira.Itens.OrderBy(x => x.Ordem))
                {
                    Console.WriteLine($"{item.Ordem}-{item.Titulo}");
                    Console.WriteLine(item.Curso?.Titulo);
                    Console.WriteLine(item.Curso?.Nivel);

                    //Notificacao
                    foreach(var notificacao in item.Notificacoes)
                    {
                        Console.WriteLine($"{notificacao.Propriedade} - {notificacao.Mensagem}");
                    }

                }
            }

            //foreach (var curso in cursos)
            //{
            //    Console.WriteLine(curso.Id);
            //    Console.WriteLine(curso.Titulo);
            //    Console.WriteLine(curso.Url);
            //    Console.WriteLine("------------------------------------------");
            //}


            var pagamento = new PagamentoAssinatura();
            var aluno = new Aluno();

            //aluno.Assinaturas.Add(pagamento);
            aluno.CrearAssinatura(pagamento);
            Console.ReadKey();






        }
    }
}
