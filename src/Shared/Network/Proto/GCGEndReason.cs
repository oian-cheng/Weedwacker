// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGEndReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGEndReason.proto</summary>
  public static partial class GCGEndReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGEndReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGEndReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHQ0dFbmRSZWFzb24ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8q1gIKDEdDR0VuZFJlYXNvbhIaChZHQ0dfRU5EX1JFQVNPTl9E",
            "RUZBVUxUEAASFgoSR0NHX0VORF9SRUFTT05fRElFEAESHAoYR0NHX0VORF9S",
            "RUFTT05fU1VSUkVOREVSEAISHwobR0NHX0VORF9SRUFTT05fRElTQ09OTkVD",
            "VEVEEAMSHgoaR0NHX0VORF9SRUFTT05fUk9VTkRfTElNSVQQBBIVChFHQ0df",
            "RU5EX1JFQVNPTl9HTRAFEhwKGEdDR19FTkRfUkVBU09OX05PX1BMQVlFUhAG",
            "EhoKFkdDR19FTkRfUkVBU09OX0dJVkVfVVAQBxIfChtHQ0dfRU5EX1JFQVNP",
            "Tl9JTklUX1RJTUVPVVQQCBIZChVHQ0dfRU5EX1JFQVNPTl9FRkZFQ1QQCRIm",
            "CiJHQ0dfRU5EX1JFQVNPTl9VbmszMzAwX0lOQVBIS0FLS0hGEApiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GCGEndReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGEndReason {
    [pbr::OriginalName("GCG_END_REASON_DEFAULT")] Default = 0,
    [pbr::OriginalName("GCG_END_REASON_DIE")] Die = 1,
    [pbr::OriginalName("GCG_END_REASON_SURRENDER")] Surrender = 2,
    [pbr::OriginalName("GCG_END_REASON_DISCONNECTED")] Disconnected = 3,
    [pbr::OriginalName("GCG_END_REASON_ROUND_LIMIT")] RoundLimit = 4,
    [pbr::OriginalName("GCG_END_REASON_GM")] Gm = 5,
    [pbr::OriginalName("GCG_END_REASON_NO_PLAYER")] NoPlayer = 6,
    [pbr::OriginalName("GCG_END_REASON_GIVE_UP")] GiveUp = 7,
    [pbr::OriginalName("GCG_END_REASON_INIT_TIMEOUT")] InitTimeout = 8,
    [pbr::OriginalName("GCG_END_REASON_EFFECT")] Effect = 9,
    [pbr::OriginalName("GCG_END_REASON_Unk3300_INAPHKAKKHF")] Unk3300Inaphkakkhf = 10,
  }

  #endregion

}

#endregion Designer generated code
