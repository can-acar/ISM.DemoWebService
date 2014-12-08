using System;
using System.Runtime.Serialization;

namespace ISM.Demo.Models
{
    [DataContract]
    [Serializable]
    public class DemoModel
    {
        [DataMember]
        public string Test { get; set; }
    }
}
