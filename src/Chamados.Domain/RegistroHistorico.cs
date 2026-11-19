namespace Chamados.Domain;

// Uma transição de status já ocorrida. Imutável: o passado não muda.
public sealed record RegistroHistorico(
    StatusChamado De,
    StatusChamado Para,
    DateTimeOffset Em,
    string? Observacao);