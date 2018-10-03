using Dados;
using Entidade;
using ServicoWCF;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CadastroBusiness
    {
        public void Inserir(tb_laboratorio lab)
        {
            var service = new Service();

            try
            {
                service.Inserir(lab);

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }


        public List<tb_laboratorio> Listar()
        {
            var service = new Service();

            try
            {
                return service.Listar();

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

    }
}
