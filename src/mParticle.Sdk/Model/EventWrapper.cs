using System.Runtime.Serialization;

namespace mParticle.Model
{
    [DataContract]    
    internal class EventWrapper
    {
         [DataMember(Name = "data", EmitDefaultValue = false)]
        internal BaseEvent BaseEvent;

        [DataMember(Name = "event_type", EmitDefaultValue = false)]        
        internal EventType EventType;
        internal EventWrapper(BaseEvent baseEvent) 
        {
            BaseEvent = baseEvent;
            EventType = baseEvent.EventType;
        }
    }
}