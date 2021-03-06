


















// Generated on 06/04/2015 18:44:41
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class FriendAddedMessage : Message
{

public const ushort Id = 5599;
public override ushort MessageId
{
    get { return Id; }
}

public Types.FriendInformations friendAdded;
        

public FriendAddedMessage()
{
}

public FriendAddedMessage(Types.FriendInformations friendAdded)
        {
            this.friendAdded = friendAdded;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteShort(friendAdded.TypeId);
            friendAdded.Serialize(writer);
            

}

public override void Deserialize(ICustomDataInput reader)
{

friendAdded = Types.ProtocolTypeManager.GetInstance<Types.FriendInformations>(reader.ReadShort());
            friendAdded.Deserialize(reader);
            

}


}


}