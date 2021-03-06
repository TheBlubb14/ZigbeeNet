using System;
using System.Text;
using ZigBeeNet.Transaction;
using ZigBeeNet.ZCL;
using ZigBeeNet.ZCL.Protocol;

namespace ZigBeeNet.ZDO.Command
{
    /// <summary>
    /// User Descriptor Conf value object class.
    /// 
    /// The User_Desc_conf is generated by a remote device in response to a
    /// User_Desc_set directed to the remote device. This command shall be unicast to
    /// the originator of the User_Desc_set command.
    /// 
/// </summary>

    public class UserDescriptorConf : ZdoResponse
    {
        /// <summary>
        /// Default constructor.
/// </summary>
        public UserDescriptorConf()
        {
            ClusterId = 0x8014;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("UserDescriptorConf [")
                   .Append(base.ToString())
                   .Append(']');

            return builder.ToString();
        }
    }
}
