using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    [Serializable]
    public class MessageObject
    {
        private byte[] data;
        private int formIdentifier;
        private int objectIdentifier;
        private int actionIdentifier;

        public MessageObject(byte[] data, int formIdentifier, int objectIdentifier, int actionIdentifier)
        {
            this.data = data;
            this.formIdentifier = formIdentifier;
            this.objectIdentifier = objectIdentifier;
            this.actionIdentifier = actionIdentifier;
        }
        public MessageObject()
        {

        }

        public byte[] Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int FormIdentifier
        {
            get
            {
                return formIdentifier;
            }

            set
            {
                formIdentifier = value;
            }
        }

        public int ObjectIdentifier
        {
            get
            {
                return objectIdentifier;
            }

            set
            {
                objectIdentifier = value;
            }
        }

        public int ActionIdentifier
        {
            get
            {
                return actionIdentifier;
            }

            set
            {
                actionIdentifier = value;
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return "Message Object ToString()";
        }
    }
}
