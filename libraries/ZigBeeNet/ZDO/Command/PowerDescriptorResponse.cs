﻿using System;
using System.Collections.Generic;
using System.Text;
using ZigBeeNet.ZCL;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZDO.Field;

namespace ZigBeeNet.ZDO.Command
{
    /// <summary>
     /// Power Descriptor Response value object class.
     /// 
     /// The Power_Desc_rsp is generated by a remote device in response to a
     /// Power_Desc_req directed to the remote device. This command shall be unicast to
     /// the originator of the Power_Desc_req command.
     /// 
     /// Code is auto-generated. Modifications may be overwritten!
     /// </summary>
    public class PowerDescriptorResponse : ZdoResponse
    {
        /// <summary>
         /// NWKAddrOfInterest command message field.
         /// </summary>
        public ushort NwkAddrOfInterest { get; set; }

        /// <summary>
         /// PowerDescriptor command message field.
         /// </summary>
        public PowerDescriptor PowerDescriptor { get; set; }

        /// <summary>
         /// Default constructor.
         /// </summary>
        public PowerDescriptorResponse()
        {
            ClusterId = 0x8003;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            base.Serialize(serializer);

            serializer.Serialize(Status, ZclDataType.Get(DataType.ZDO_STATUS));
            serializer.Serialize(NwkAddrOfInterest, ZclDataType.Get(DataType.NWK_ADDRESS));
            serializer.Serialize(PowerDescriptor, ZclDataType.Get(DataType.POWER_DESCRIPTOR));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            base.Deserialize(deserializer);

            Status = (ZdoStatus)deserializer.Deserialize(ZclDataType.Get(DataType.ZDO_STATUS));
            if (Status != ZdoStatus.SUCCESS)
            {
                // Don't read the full response if we have an error
                return;
            }
            NwkAddrOfInterest = (ushort)deserializer.Deserialize(ZclDataType.Get(DataType.NWK_ADDRESS));
            PowerDescriptor = (PowerDescriptor)deserializer.Deserialize(ZclDataType.Get(DataType.POWER_DESCRIPTOR));
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder()
                .Append("PowerDescriptorResponse [")
                .Append(base.ToString())
                .Append(", status=")
                .Append(Status)
                .Append(", nwkAddrOfInterest=")
                .Append(NwkAddrOfInterest)
                .Append(", powerDescriptor=")
                .Append(PowerDescriptor)
                .Append(']');

            return builder.ToString();
        }
    }
}
