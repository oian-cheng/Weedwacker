// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DealAddFriendResultType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from DealAddFriendResultType.proto</summary>
  public static partial class DealAddFriendResultTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for DealAddFriendResultType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DealAddFriendResultTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EZWFsQWRkRnJpZW5kUmVzdWx0VHlwZS5wcm90byppChdEZWFsQWRkRnJp",
            "ZW5kUmVzdWx0VHlwZRImCiJERUFMX0FERF9GUklFTkRfUkVTVUxUX1RZUEVf",
            "UkVKRUNUEAASJgoiREVBTF9BRERfRlJJRU5EX1JFU1VMVF9UWVBFX0FDQ0VQ",
            "VBABQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.DealAddFriendResultType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DealAddFriendResultType {
    [pbr::OriginalName("DEAL_ADD_FRIEND_RESULT_TYPE_REJECT")] Reject = 0,
    [pbr::OriginalName("DEAL_ADD_FRIEND_RESULT_TYPE_ACCEPT")] Accept = 1,
  }

  #endregion

}

#endregion Designer generated code
