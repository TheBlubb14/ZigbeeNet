﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.Commissioning;


namespace ZigBeeNet.ZCL.Clusters.Commissioning
{
    /// <summary>
    /// Save Startup Parameters Response value object class.
    /// <para>
    /// Cluster: Commissioning. Command is sent FROM the server.
    /// This command is a specific command used for the Commissioning cluster.
    /// </para>
    /// Code is auto-generated. Modifications may be overwritten!
    /// </summary>
    public class SaveStartupParametersResponse : ZclCommand
    {
        /// <summary>
        /// Status command message field.
        /// </summary>
        public byte Status { get; set; }


        /// <summary>
        /// Default constructor.
        /// </summary>
        public SaveStartupParametersResponse()
        {
            GenericCommand = false;
            ClusterId = 21;
            CommandId = 1;
            CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
        }

        internal override void Serialize(ZclFieldSerializer serializer)
        {
            serializer.Serialize(Status, ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        }

        internal override void Deserialize(ZclFieldDeserializer deserializer)
        {
            Status = deserializer.Deserialize<byte>(ZclDataType.Get(DataType.ENUMERATION_8_BIT));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("SaveStartupParametersResponse [");
            builder.Append(base.ToString());
            builder.Append(", Status=");
            builder.Append(Status);
            builder.Append(']');

            return builder.ToString();
        }
    }
}
