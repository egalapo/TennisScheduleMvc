using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisScheduleMvc.Models
{
    public class EventModel
    {
        public List<GameModel> Events { get; set; }
        public String type { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Event
        {

            private EventGame[] gameField;

            private string typeField;

            private string dateStartedField;

            private string dateEndedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("game")]
            public EventGame[] game
            {
                get
                {
                    return this.gameField;
                }
                set
                {
                    this.gameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DateStarted
            {
                get
                {
                    return this.dateStartedField;
                }
                set
                {
                    this.dateStartedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DateEnded
            {
                get
                {
                    return this.dateEndedField;
                }
                set
                {
                    this.dateEndedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EventGame
        {

            private EventGameGameStartTime gameStartTimeField;

            private EventGameGameEndTime gameEndTimeField;

            private EventGameSet setField;

            private EventGameMatch matchField;

            private byte numberField;

            /// <remarks/>
            public EventGameGameStartTime gameStartTime
            {
                get
                {
                    return this.gameStartTimeField;
                }
                set
                {
                    this.gameStartTimeField = value;
                }
            }

            /// <remarks/>
            public EventGameGameEndTime gameEndTime
            {
                get
                {
                    return this.gameEndTimeField;
                }
                set
                {
                    this.gameEndTimeField = value;
                }
            }

            /// <remarks/>
            public EventGameSet set
            {
                get
                {
                    return this.setField;
                }
                set
                {
                    this.setField = value;
                }
            }

            /// <remarks/>
            public EventGameMatch match
            {
                get
                {
                    return this.matchField;
                }
                set
                {
                    this.matchField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EventGameGameStartTime
        {

            private System.DateTime valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EventGameGameEndTime
        {

            private System.DateTime valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public System.DateTime value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EventGameSet
        {

            private byte numberField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte number
            {
                get
                {
                    return this.numberField;
                }
                set
                {
                    this.numberField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EventGameMatch
        {

            private byte idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }


    }
}