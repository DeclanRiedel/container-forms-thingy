namespace ContainerInspectionApp.Models
{
    public class Container
    {
        public int Id { get; set; }
        public string ContainerId { get; set; } = string.Empty;
        public string ContainerType { get; set; } = string.Empty;
        public string ExtraInfo { get; set; } = string.Empty;
        public bool IsDamaged { get; set; }
        public DateTime TimeAdded { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public DateTime? ManufactureDate { get; set; }
        public decimal Weight { get; set; }
    }
}