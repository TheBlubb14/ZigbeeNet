//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Receive Packet Explicit ".
    /// When a device configured with explicit API Rx Indicator (AO = 1) receives an RF packet, it
    /// sends it out the serial interface using this message type. The Cluster ID and endpoints must
    /// be used to identify the type of transaction that occurred. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeReceivePacketExplicitEvent : XBeeFrame, IXBeeEvent
    {
        
        /// <summary>
        /// Response field
        /// MSB first, LSB last. The sender's 64-bit address. Set to 0xFFFFFFFFFFFFFFFF (unknown
        /// 64-bit address) if the sender's 64-bit address is unknown. 
        /// </summary>
        private IeeeAddress _ieeeAddress;
        
        /// <summary>
        /// Response field
        /// The sender's 16-bit address.
        /// </summary>
        private int _networkAddress;
        
        /// <summary>
        /// Response field
        /// Endpoint of the source that initiates transmission. The default value is shown when
        /// Transmit Request frame - 0x10 is used to send data from the source. Non-defaults are shown if
        /// Explicit Addressing Command frame - 0x11 is used to send data from the source, or if a
        /// non-default value was used, otherwise the default value remains. 
        /// </summary>
        private int _sourceEndpoint;
        
        /// <summary>
        /// Response field
        /// Endpoint of the destination that the message is addressed to. The default value is shown when
        /// Transmit Request frame - 0x10 is used to send data from the source. Non-defaults are shown if
        /// Explicit Addressing Command frame - 0x11 is used to send data from the source, or if a
        /// non-default value was used, otherwise the default value remains. 
        /// </summary>
        private int _destinationEndpoint;
        
        /// <summary>
        /// Response field
        /// The Cluster ID that the frame is addressed to. The default value is shown when Transmit
        /// Request frame - 0x10 is used to send data from the source. Non-defaults are shown if Explicit
        /// Addressing Command frame - 0x11 is used to send data from the source, or if a non-default value
        /// was used, otherwise the default value remains. 
        /// </summary>
        private int _clusterId;
        
        /// <summary>
        /// Response field
        /// The Profile ID that the fame is addressed to. 
        /// </summary>
        private int _profileId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private ReceiveOptions _receiveOptions;
        
        /// <summary>
        /// Response field
        /// The RF data that the device receives.
        /// </summary>
        private int[] _data;
        
        /// <summary>
        ///  MSB first, LSB last. The sender's 64-bit address. Set to 0xFFFFFFFFFFFFFFFF (unknown
        /// 64-bit address) if the sender's 64-bit address is unknown. 
        /// Return the ieeeAddress as <see cref="IeeeAddress"/>
        /// </summary>
        public IeeeAddress GetIeeeAddress()
        {
            return _ieeeAddress;
        }
        
        /// <summary>
        ///  The sender's 16-bit address.
        /// Return the networkAddress as <see cref="System.Int32"/>
        /// </summary>
        public int GetNetworkAddress()
        {
            return _networkAddress;
        }
        
        /// <summary>
        ///  Endpoint of the source that initiates transmission. The default value is shown when
        /// Transmit Request frame - 0x10 is used to send data from the source. Non-defaults are shown if
        /// Explicit Addressing Command frame - 0x11 is used to send data from the source, or if a
        /// non-default value was used, otherwise the default value remains. 
        /// Return the sourceEndpoint as <see cref="System.Int32"/>
        /// </summary>
        public int GetSourceEndpoint()
        {
            return _sourceEndpoint;
        }
        
        /// <summary>
        ///  Endpoint of the destination that the message is addressed to. The default value is shown when
        /// Transmit Request frame - 0x10 is used to send data from the source. Non-defaults are shown if
        /// Explicit Addressing Command frame - 0x11 is used to send data from the source, or if a
        /// non-default value was used, otherwise the default value remains. 
        /// Return the destinationEndpoint as <see cref="System.Int32"/>
        /// </summary>
        public int GetDestinationEndpoint()
        {
            return _destinationEndpoint;
        }
        
        /// <summary>
        ///  The Cluster ID that the frame is addressed to. The default value is shown when Transmit
        /// Request frame - 0x10 is used to send data from the source. Non-defaults are shown if Explicit
        /// Addressing Command frame - 0x11 is used to send data from the source, or if a non-default value
        /// was used, otherwise the default value remains. 
        /// Return the clusterId as <see cref="System.Int32"/>
        /// </summary>
        public int GetClusterId()
        {
            return _clusterId;
        }
        
        /// <summary>
        ///  The Profile ID that the fame is addressed to. 
        /// Return the profileId as <see cref="System.Int32"/>
        /// </summary>
        public int GetProfileId()
        {
            return _profileId;
        }
        
        /// <summary>
        ///  Return the receiveOptions as <see cref="ReceiveOptions"/>
        /// </summary>
        public ReceiveOptions GetReceiveOptions()
        {
            return _receiveOptions;
        }
        
        /// <summary>
        ///  The RF data that the device receives.
        /// Return the data as <see cref="System.Int32"/>
        /// </summary>
        public int[] GetData()
        {
            return _data;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            InitializeDeserializer(incomingData);
            _ieeeAddress = DeserializeIeeeAddress();
            _networkAddress = DeserializeInt16();
            _sourceEndpoint = DeserializeInt8();
            _destinationEndpoint = DeserializeInt8();
            _clusterId = DeserializeInt16();
            _profileId = DeserializeInt16();
            _receiveOptions = DeserializeReceiveOptions();
            _data = DeserializeData();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(840);
            builder.Append("XBeeReceivePacketExplicitEvent [ieeeAddress=");
            builder.Append(_ieeeAddress);
            builder.Append(", networkAddress=");
            builder.Append(_networkAddress);
            builder.Append(", sourceEndpoint=");
            builder.Append(_sourceEndpoint);
            builder.Append(", destinationEndpoint=");
            builder.Append(_destinationEndpoint);
            builder.Append(", clusterId=");
            builder.Append(_clusterId);
            builder.Append(", profileId=");
            builder.Append(_profileId);
            builder.Append(", receiveOptions=");
            builder.Append(_receiveOptions);
            builder.Append(", data=");
            if (_data == null)
            {
                builder.Append("null");
            }
            else
            {
                for (int cnt = 0
                ; cnt < _data.Length; cnt++
                )
                {
                    if (cnt > 0)
                    {
                        builder.Append(' ');
                    }
                    builder.Append(string.Format("0x{0:X2}", _data[cnt]));
                }
            }
            builder.Append(']');
            return builder.ToString();
        }
    }
}
