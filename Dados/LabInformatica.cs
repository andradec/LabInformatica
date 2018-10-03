
using System.Collections.Generic;
using System.Linq;

namespace Dados
{
    public class LabInformatica
    {
        public void Inserir(tb_laboratorio laboratorio)
        {
            var context = new XarlisDarwinEntities();
            context.tb_laboratorio.Add(laboratorio);
            context.SaveChanges();

        }

        public List<tb_laboratorio> Listar()
        {
            var context = new XarlisDarwinEntities();
            return context.tb_laboratorio.ToList();
        }

    }
}
