using System;

namespace PentaWork.Xrm.Scheduler.Proxies
{
    public class LabelAttribute : Attribute
    {
        public LabelAttribute(string label)
        {
            Label = label;
        }
        public string Label { get; }
    }
    public class RelationAttribute : Attribute { }
}

