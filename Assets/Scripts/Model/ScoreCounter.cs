using System.Collections.Generic;

namespace Model
{
    public class ScoreCounter
    {
        public float Score { get; private set; }
        
        private List<Tool> automaticTools;
        private List<Tool> manualTools;

        public ScoreCounter()
        {
            automaticTools = new List<Tool>();
            manualTools = new List<Tool>();

            Score = 0;
        }

        public void AddTool(Tool tool)
        {
            if(tool.IsAutomatic)
                automaticTools.Add(tool);
            if(tool.IsManual)
                manualTools.Add(tool);
        }

        public void Update(float deltaTime)
        {
            foreach (var tool in automaticTools)
            {
                Score += tool.GetValue() * deltaTime;
            }
        }

        public void ToolClicked(Tool tool)
        {
            Score += tool.GetValue();
        }
    }
}