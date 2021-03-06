﻿using ECommerce.Core.Service.Message.DomainEvent;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Catalogo.Domain.Events
{
    public class ProdutoAbaixoEstoqueEvent : DomainEvent
    {
        public int QuantidadeRestante { get; private set; }

        public ProdutoAbaixoEstoqueEvent(Guid _aggregateId, int _quantidadeRestante) : base(_aggregateId)
        {
            QuantidadeRestante = _quantidadeRestante;
        }
    }
}
