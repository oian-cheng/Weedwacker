// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CreateGadgetReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CreateGadgetReason.proto</summary>
  public static partial class CreateGadgetReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for CreateGadgetReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CreateGadgetReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDcmVhdGVHYWRnZXRSZWFzb24ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8qkwEKEkNyZWF0ZUdhZGdldFJlYXNvbhIdChlDUkVB",
            "VEVfR0FER0VUX1JFQVNPTl9OT05FEAASHwobQ1JFQVRFX0dBREdFVF9SRUFT",
            "T05fUExBWUVSEAESIAocQ1JFQVRFX0dBREdFVF9SRUFTT05fTUlTU0lPThAC",
            "EhsKF0NSRUFURV9HQURHRVRfUkVBU09OX0dNEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.CreateGadgetReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CreateGadgetReason {
    [pbr::OriginalName("CREATE_GADGET_REASON_NONE")] None = 0,
    [pbr::OriginalName("CREATE_GADGET_REASON_PLAYER")] Player = 1,
    [pbr::OriginalName("CREATE_GADGET_REASON_MISSION")] Mission = 2,
    [pbr::OriginalName("CREATE_GADGET_REASON_GM")] Gm = 3,
  }

  #endregion

}

#endregion Designer generated code
