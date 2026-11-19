namespace Chamados.Domain;

public sealed class TransicaoInvalidaException(Guid chamadoId, StatusChamado atual, StatusChamado pretendido)
    : InvalidOperationException($"O chamado {chamadoId} não pode passar de {atual} para {pretendido}.")
{
    public Guid ChamadoId { get; } = chamadoId;
    public StatusChamado Atual { get; } = atual;
    public StatusChamado Pretendido { get; } = pretendido;
}