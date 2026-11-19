namespace Chamados.Domain;

public sealed record EstatisticasChamados(
    int Total,
    IReadOnlyDictionary<StatusChamado, int> PorStatus,
    IReadOnlyDictionary<Prioridade, int> PorPrioridade,
    TimeSpan? TempoMedioResolucao);