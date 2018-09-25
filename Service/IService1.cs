using Dados;
using Entidade;
using System.Collections.Generic;
using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Inserir(Laboratorio labInformatica);

        [OperationContract]
        List<Laboratorio> Listar();

        //[OperationContract]
        //bool InserirAsync(Laboratorio labInformatica);
        //[OperationContract]
        //List<Laboratorio> ListarAsync();
    }
}
