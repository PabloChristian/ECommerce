﻿using ECommerce.Core.Service.DomainObject;
using ECommerce.Core.Service.DomainObject.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Catalogo.Domain
{
    public class SubCategoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        // EF Relation
        public ICollection<Produto> Produtos { get; set; }

        protected SubCategoria() { }

        public SubCategoria(string _nome, int _codigo)
        {
            Nome = _nome;
            Codigo = _codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacao.ValidarSeVazio(Nome, "O campo Nome do departamento não pode estar vazio");
            Validacao.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser 0");
        }
    }
}
