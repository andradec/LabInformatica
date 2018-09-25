using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool Inserir(Laboratorio labInformatica);

        [OperationContract]
        List<Laboratorio> Listar();
    }
}
