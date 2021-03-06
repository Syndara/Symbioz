


















// Generated on 06/04/2015 18:44:29
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.DofusProtocol.Types;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Messages
{

public class HouseGuildNoneMessage : Message
{

public const ushort Id = 5701;
public override ushort MessageId
{
    get { return Id; }
}

public uint houseId;
        

public HouseGuildNoneMessage()
{
}

public HouseGuildNoneMessage(uint houseId)
        {
            this.houseId = houseId;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

writer.WriteVarUhInt(houseId);
            

}

public override void Deserialize(ICustomDataInput reader)
{

houseId = reader.ReadVarUhInt();
            if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            

}


}


}