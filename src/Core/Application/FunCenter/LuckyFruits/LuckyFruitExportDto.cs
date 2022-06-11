namespace FSH.WebApi.Application.FunCenter.LuckyFruits;

public class LuckyFruitExportDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
}