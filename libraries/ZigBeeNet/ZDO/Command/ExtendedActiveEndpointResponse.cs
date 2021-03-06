using System;
using System.Text;
using ZigBeeNet.Transaction;
using ZigBeeNet.ZCL;
using ZigBeeNet.ZCL.Protocol;

namespace ZigBeeNet.ZDO.Command
{
    /// <summary>
    /// Extended Active Endpoint Response value object class.
    /// 
    /// The Extended_Active_EP_rsp is generated by a remote device in response to an
    /// Extended_Active_EP_req directed to the remote device. This command shall be
    /// unicast to the originator of the Extended_Active_EP_req command.
    /// 
    /// </summary>
    public class ExtendedActiveEndpointResponse : ZdoResponse
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ExtendedActiveEndpointResponse()
        {
            ClusterId = 0x801E;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("ExtendedActiveEndpointResponse [")
                   .Append(base.ToString())
                   .Append(']');

            return builder.ToString();
        }

    }
}
