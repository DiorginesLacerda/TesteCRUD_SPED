using DocsBr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Models;
using TesteCRUD_SPED.Repositories;

namespace TesteCRUD_SPED.Services
{
    public class ParticipanteService
    {
        private ParticipanteRepository repository;

        public ParticipanteService(ParticipanteRepository repository)
        {
            this.repository = repository;
        }

        public void Add(ParticipanteModel model)
        {
            if (IsModelValid(model))
            {
                repository.Add(new PARTICIPANTE
                {
                    COD_PART = model.Cod_Part.ToString(),
                    NOME = model.Nome,
                    COD_PAIS = model.Pais.COD_PAIS,
                    CNPJ = model.CNPJ,
                    CPF = model.CPF,
                    IE = model.IE,
                    COD_MUN = model.Municipio.COD_MUNICIPIO,
                    SUFRAMA = model.SUFRAMA,
                    END = model.Endereco,
                    NUM = model.Numero.ToString(),
                    COMPL = model.Complemento,
                    BAIRRO = model.Bairro
                });
            }
        }

        public IList<PARTICIPANTE> GetAll()
        {
            return repository.GetAll();
        }

        public PARTICIPANTE FindById(string cod)
        {
            return repository.FindById(cod);
        }

        
        public bool IsModelValid(ParticipanteModel model)
        {
         /*
         Validações de tamanho de campo e de campos que são sempre obrigatórios são feitos diretamente na Classe Model
         */

            //valida se o Pais é Brasil
            if (model.Pais.COD_PAIS.Equals("1058"))
            {
                //Verifica se é pessoa Física
                if (model.TipoPessoa.Equals("Fisica"))
                {
                    //Verifica se o CNPJ está em branco
                    if (!String.IsNullOrEmpty(model.CNPJ))
                        throw new Exception("CNPJ apenas pode ser informado se for Pessoa Jurídica");

                    //verifica se o CPF está preenchido
                    if (String.IsNullOrEmpty(model.CPF))
                        throw new Exception("Necessário Informar o CPF");

                    //Valida se o CPF é Valido
                    CPF cpf = model.CPF;
                    if (!cpf.IsValid())
                        throw new Exception("CPF Inválido");

                    //Valida se IE está em Branco
                    if (!String.IsNullOrEmpty(model.IE))
                        throw new Exception("Incrição Estadual apenas pode ser informada se for Pessoa Jurídica");

                    //Valida de Suframa está em Branco
                    if (!String.IsNullOrEmpty(model.SUFRAMA))
                        throw new Exception("SUFRAMA apenas pode ser informado se for Pessoa Jurídica");
                }
                else // Pessoa Jurídica
                {
                    //Verifica se o CPF está em branco
                    if (!String.IsNullOrEmpty(model.CPF))
                        throw new Exception("CPF apenas pode ser informado se for Pessoa Fisica");

                    //verifica se o CNPJ está preenchido
                    if (String.IsNullOrEmpty(model.CNPJ))
                        throw new Exception("Necessário Informar o CNPJ");

                    //Valida se o CNPJ é Valido
                    CNPJ cnpj = model.CNPJ;
                    if (!cnpj.IsValid())
                        throw new Exception("CNPJ Inválido");

                    //Valida se IE está preencido
                    if (String.IsNullOrEmpty(model.IE) && !model.IsentoIE)
                        throw new Exception("Se não Isento, a Incrição Estadual deve ser informada");

                    //Valida IE
                    IE ie = new IE(model.IE, model.Estado.COD_ESTADO);
                    if(!ie.IsValid())
                        throw new Exception("Inscrição Estadual Inválida");

                    //Valida Suframa
                    // Verificar lógica para verificador de SUFRAMA
                }

                //Verifica se o Número está em Branco
                if (!String.IsNullOrEmpty(model.Numero.ToString()))
                    throw new Exception("Necessário Informar o Endereço");
                //Verifica se o Bairro está em Branco
                if (!String.IsNullOrEmpty(model.Bairro))
                    throw new Exception("Necessário Informar o Endereço");
            }
            else // Se o Pais Não For Brasil
            {
                //Valida se CNPJ está em branco
                if (!String.IsNullOrEmpty(model.CNPJ))
                    throw new Exception("CNPJ apenas pode ser informado se o Pais for Brasil");

                //Valida se o CPF está em branco
                if (!String.IsNullOrEmpty(model.CPF))
                    throw new Exception("CPF apenas pode ser informado se o Pais for Brasil");

                //Valida se a IE está em branco
                if (!String.IsNullOrEmpty(model.IE))
                    throw new Exception("IE apenas pode ser informado se o Pais for Brasil");

                //Valida Se o Codigo de Município está em Branco
                if (!String.IsNullOrEmpty(model.Municipio.COD_MUNICIPIO))
                    throw new Exception(
                        "Se o Pais não for Brasil, o Município Deve ser informado dentro do campo Endereço");

                //Valida SUFRAMA está em Branco
                if (!String.IsNullOrEmpty(model.SUFRAMA))
                    throw new Exception("SUFRAMA apenas pode ser informado se o Pais for Brasil");

                //Valida se o Número está em Branco
                if (!String.IsNullOrEmpty(model.Numero.ToString()))
                    throw new Exception(
                        "Se o Pais não for Brasil, o Número Deve ser informado dentro do campo Endereço");

                //Valida se o Complemento está em Branco
                if (!String.IsNullOrEmpty(model.Complemento))
                    throw new Exception(
                        "Se o Pais não for Brasil, o Complemento Deve ser informado dentro do campo Endereço");

                //Valida se o Bairro está em Branco
                if (!String.IsNullOrEmpty(model.Bairro))
                    throw new Exception(
                        "Se o Pais não for Brasil, o Bairro Deve ser informado dentro do campo Endereço");
            }
            return true;
        }
    }
}