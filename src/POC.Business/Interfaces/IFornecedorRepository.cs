using POC.Business.Models;

namespace POC.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);

        Task<Fornecedor> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}