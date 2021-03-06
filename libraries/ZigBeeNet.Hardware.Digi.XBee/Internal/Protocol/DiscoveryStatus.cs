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
    /// Class to implement the XBee Enumeration <b>DiscoveryStatus</b>
    /// </summary>
    public enum DiscoveryStatus
    {
        
        /// <summary>
        /// Default unknown value
        /// </summary>
        UNKNOWN = -1,
        
        /// <summary>
        ///  [0] 
        /// </summary>
        NO_DISCOVERY_OVERHEAD = 0x0000,
        
        /// <summary>
        ///  [1] 
        /// </summary>
        ADDRESS_DISCOVERY = 0x0001,
        
        /// <summary>
        ///  [2] 
        /// </summary>
        ROUTE_DISCOVERY = 0x0002,
        
        /// <summary>
        ///  [3] 
        /// </summary>
        ADDRESS_AND_ROUTE = 0x0003,
        
        /// <summary>
        ///  [64] 
        /// </summary>
        EXTENDED_TIMEOUT_DISCOVERY = 0x0040,
    }
}
