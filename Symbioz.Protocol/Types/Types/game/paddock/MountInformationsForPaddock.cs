


















// Generated on 06/04/2015 18:45:36
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class MountInformationsForPaddock
{

public const short Id = 184;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte modelId;
        public string name;
        public string ownerName;
        

public MountInformationsForPaddock()
{
}

public MountInformationsForPaddock(sbyte modelId, string name, string ownerName)
        {
            this.modelId = modelId;
            this.name = name;
            this.ownerName = ownerName;
        }
        

public virtual void Serialize(ICustomDataOutput writer)
{

writer.WriteSByte(modelId);
            writer.WriteUTF(name);
            writer.WriteUTF(ownerName);
            

}

public virtual void Deserialize(ICustomDataInput reader)
{

modelId = reader.ReadSByte();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            name = reader.ReadUTF();
            ownerName = reader.ReadUTF();
            

}


}


}