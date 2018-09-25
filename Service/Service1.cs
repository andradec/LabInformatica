using Dados;
using Entidade;
using System.Collections.Generic;

namespace Service
{
    public class Service1 : IService1
    {
        public bool Inserir(Laboratorio lab)
        {
            return new LabInformatica().Inserir(lab);
        }

        //public bool InserirAsync(Laboratorio labInformatica)
        //{
        //    throw new System.NotImplementedException();
        //}

        public List<Laboratorio> Listar()
         {
            return new LabInformatica().Listar();
        }

        //public List<Laboratorio> ListarAsync()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
