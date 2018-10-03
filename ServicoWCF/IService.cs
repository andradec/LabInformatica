using Dados;
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
        void Inserir(tb_laboratorio labInformatica);

        [OperationContract]
        List<tb_laboratorio> Listar();
    }
}
