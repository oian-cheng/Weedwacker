// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MatchType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MatchType.proto</summary>
  public static partial class MatchTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MatchType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatchTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9NYXRjaFR5cGUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8qlwEKCU1hdGNoVHlwZRITCg9NQVRDSF9UWVBFX05PTkUQABIWChJN",
            "QVRDSF9UWVBFX0RVTkdFT04QARIWChJNQVRDSF9UWVBFX01QX1BMQVkQAhIZ",
            "ChVNQVRDSF9UWVBFX01FQ0hBTklDVVMQAxIWChJNQVRDSF9UWVBFX0dFTkVS",
            "QUwQBBISCg5NQVRDSF9UWVBFX0dDRxAFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.MatchType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MatchType {
    [pbr::OriginalName("MATCH_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MATCH_TYPE_DUNGEON")] Dungeon = 1,
    [pbr::OriginalName("MATCH_TYPE_MP_PLAY")] MpPlay = 2,
    [pbr::OriginalName("MATCH_TYPE_MECHANICUS")] Mechanicus = 3,
    [pbr::OriginalName("MATCH_TYPE_GENERAL")] General = 4,
    [pbr::OriginalName("MATCH_TYPE_GCG")] Gcg = 5,
  }

  #endregion

}

#endregion Designer generated code
