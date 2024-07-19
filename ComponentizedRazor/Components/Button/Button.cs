namespace ComponentizedRazor.Components.Button
{
    public class Button
    {
        public readonly Guid Id = Guid.NewGuid();
        public string Text { get; set; } = string.Empty;
        public enumButtonTypes Type { get; set; }
    }

    public enum enumButtonTypes
    {
        Submit
    }
}
