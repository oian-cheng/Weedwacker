// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientReconnectReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ClientReconnectReason.proto</summary>
  public static partial class ClientReconnectReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for ClientReconnectReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientReconnectReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDbGllbnRSZWNvbm5lY3RSZWFzb24ucHJvdG8qdAoVQ2xpZW50UmVjb25u",
            "ZWN0UmVhc29uEisKJ0NMSUVOVF9SRUNPTk5FQ1RfUkVBU09OX1JFQ09OTk5F",
            "Q1RfTk9ORRAAEi4KKkNMSUVOVF9SRUNPTk5FQ1RfUkVBU09OX1JFQ09OTk5F",
            "Q1RfUVVJVF9NUBABQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.ClientReconnectReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ClientReconnectReason {
    [pbr::OriginalName("CLIENT_RECONNECT_REASON_RECONNNECT_NONE")] ReconnnectNone = 0,
    [pbr::OriginalName("CLIENT_RECONNECT_REASON_RECONNNECT_QUIT_MP")] ReconnnectQuitMp = 1,
  }

  #endregion

}

#endregion Designer generated code
