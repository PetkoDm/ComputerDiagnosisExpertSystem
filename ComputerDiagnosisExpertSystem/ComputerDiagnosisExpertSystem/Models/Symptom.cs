namespace ComputerDiagnosisExpertSystem.Models
{
    public class Symptom
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Code} - {Description}";
        }
    }
}