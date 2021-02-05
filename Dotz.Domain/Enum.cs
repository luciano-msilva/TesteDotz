using System;

namespace Dotz.Domain
{
    public enum ETipoMovimentacao
    {
        Credito = 1,
        Debito = 2
    }
    public enum ECategoriaProduto
    {
        Automotivo = 1,
        Eletronico = 2,
        LinhaBranca = 3,
        CamaMesaBanho = 4
    }
    public enum EStatusEntrega
    {
        SeparacaoEstoque = 1,
        PreparandoEnvio = 2,
        Transportadora = 3,
        Entregue = 4
    }
}
