using System;

namespace PentaWork.Xrm.Scheduler.Tests.Codeactivities.Proxies
{
    public class LabelAttribute : Attribute
    {
        public LabelAttribute(string label)
        {
            Label = label;
        }
        public string Label { get; }
    }
}

