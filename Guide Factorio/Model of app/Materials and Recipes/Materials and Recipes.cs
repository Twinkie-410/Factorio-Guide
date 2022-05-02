namespace Factorio_guide__WPF
{
    public class MaterialsAndRecipes
    {
        public Recipe Recipe { get; set; }
        public TotalRaw TotalRaw { get; set; }
        public RequiredTechnologies RequiredTechnologies { get; set; }
        public ProducedBy ProducedBy { get; set; }
    }

    public enum ProducedBy
    {
    }

    public enum RequiredTechnologies
    {
    }
}