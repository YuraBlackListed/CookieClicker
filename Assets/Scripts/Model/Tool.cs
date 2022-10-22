namespace Model
{
    public enum ToolType
    {
        Manual,
        Automatic
    }
    
    public class Tool
    {
        public float Modifier { get; private set; }
        public float BaseValue { get; private set; }
        
        private ToolType toolType;

        public Tool(float modifier, float baseValue, ToolType newToolType)
        {
            Modifier = modifier;
            BaseValue = baseValue;
            toolType = newToolType;
        }

        public void IncreaseBaseValue(float newValue)
        {
            BaseValue += newValue;
        }

        public void IncreaseModifier(float newMultiplier)
        {
            Modifier *= newMultiplier;
        }

        public float GetValue() => BaseValue * Modifier;

        public bool IsAutomatic => toolType == ToolType.Automatic;

        public bool IsManual => toolType == ToolType.Manual;
    }
}