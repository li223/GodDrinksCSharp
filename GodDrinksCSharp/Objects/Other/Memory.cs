using System.Collections.Generic;

namespace GodDrinksCSharp.Objects
{
    public class Memory
    {
        public List<string> KnownTopics = new List<string>();
        private bool CanErase = true;
        public bool IsErasable() => this.CanErase;
        public bool TakeExam(string item) => this.KnownTopics.Contains(item);
    }
}
