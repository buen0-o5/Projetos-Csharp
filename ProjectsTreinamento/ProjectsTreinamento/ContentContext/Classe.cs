using ProjectsTreinamento.ContentContext.Enums;
using ProjectsTreinamento.ConxtetCompartilhado;

namespace ProjectsTreinamento.ContentContext
{
    public class Classe : Base //Lecture
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }
    }
}