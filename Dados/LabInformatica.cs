using Entidade;
using System.Collections.Generic;
using System.Linq;

namespace Dados
{
    public class LabInformatica
    {
        public bool Inserir(Laboratorio laboratorio)
        {
            var context = new XarlisDarwinEntities();
            context.laboratorios.Add(laboratorio);
            int retorno = context.SaveChanges();

            return retorno == 1;
        }

        public List<Laboratorio> Listar()
        {
            var context = new XarlisDarwinEntities();
            return context.laboratorios.ToList();
        }

    }
}
