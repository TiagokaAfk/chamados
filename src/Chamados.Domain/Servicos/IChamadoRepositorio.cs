namespace Chamados.Domain;

// Contrato de armazenamento. Hoje em memória; no Módulo 7, Entity Framework Core.
public interface IChamadoRepositorio
{
    Task<Chamado?> ObterAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<Chamado>> ListarAsync(CancellationToken cancellationToken = default);
    Task AdicionarAsync(Chamado chamado, CancellationToken cancellationToken = default);
    Task AtualizarAsync(Chamado chamado, CancellationToken cancellationToken = default);
}