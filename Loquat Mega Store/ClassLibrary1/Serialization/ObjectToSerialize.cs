using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoquatMegaStore.Serialization
{
    using LoquatMegaStore.ShoppingSystem;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable()]
    public class ObjectToSerialize : ISerializable
    {
        private List<User> users;

        public List<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        public ObjectToSerialize()
        {
        }

        public ObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.users = (List<User>)info.GetValue("Users", typeof(List<User>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Users", this.users);
        }
    }
}
