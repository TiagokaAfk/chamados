namespace Chamados.Domain;

public sealed record NovoChamado(
    string Titulo,
    Prioridade Prioridade = Prioridade.Media,
    string? Descricao = null);