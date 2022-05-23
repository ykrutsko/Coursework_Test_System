using System;

namespace NetCloneLib
{
    [Serializable]
    public class NetCloneUserAnswer
    {
        public int Id { get; set; }
        public bool IsChecked { get; set; }
        public NetCloneAnswer Answer { get; set; }
    }
}