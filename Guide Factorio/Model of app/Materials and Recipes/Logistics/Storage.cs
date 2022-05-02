namespace Factorio_guide__WPF
{
    public class Storage : Logistics
    {
        public int StorageSize { get; set; }
        public int Health { get; set; }
        public const int StackSize = 50;
        public Dimensions Dimensions { get; set; }
    }
}