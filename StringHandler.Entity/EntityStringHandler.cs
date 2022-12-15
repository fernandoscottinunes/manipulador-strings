using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandler.Entity
{
    public class EntityStringHandler
    {
        private int id;
        private string inputText;
        private string functionUsed;
        private string outputText;
        private string dateAndTime;

        public int Id { get => id; set => id = value; }
        public string InputText { get => inputText; set => inputText = value; }
        public string FunctionUsed { get => functionUsed; set => functionUsed = value; }
        public string OutputText { get => outputText; set => outputText = value; }
        public string DateAndTime { get => dateAndTime; set => dateAndTime = value; }

    }
}
