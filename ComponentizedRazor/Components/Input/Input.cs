namespace ComponentizedRazor.Components.Input
{
    public class Input
    {
        public readonly Guid Id = Guid.NewGuid();
        public enumInputType Type { get; set; }
        public string PlaceHolder { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public string Name {  get; set; } = string.Empty;
        public bool isRequired { get; set; } = false;
    }

    public enum enumInputType
    {
        Text,
        Email,
        Password
    }
}
