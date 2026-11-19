namespace Chamados.Domain;

// Valores explícitos: a ordem (Baixa < Critica) faz parte do contrato.
public enum Prioridade
{
    Baixa = 1,
    Media = 2,
    Alta = 3,
    Critica = 4
}