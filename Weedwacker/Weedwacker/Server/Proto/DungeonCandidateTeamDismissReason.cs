// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonCandidateTeamDismissReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from DungeonCandidateTeamDismissReason.proto</summary>
  public static partial class DungeonCandidateTeamDismissReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonCandidateTeamDismissReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonCandidateTeamDismissReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidEdW5nZW9uQ2FuZGlkYXRlVGVhbURpc21pc3NSZWFzb24ucHJvdG8qyQEK",
            "IUR1bmdlb25DYW5kaWRhdGVUZWFtRGlzbWlzc1JlYXNvbhI1CjFEVU5HRU9O",
            "X0NBTkRJREFURV9URUFNX0RJU01JU1NfUkVBU09OX1RQRFJfTk9STUFMEAAS",
            "MgouRFVOR0VPTl9DQU5ESURBVEVfVEVBTV9ESVNNSVNTX1JFQVNPTl9UUERS",
            "X0RJRRABEjkKNURVTkdFT05fQ0FORElEQVRFX1RFQU1fRElTTUlTU19SRUFT",
            "T05fVFBEUl9ESVNDT05ORUNUEAJCGqoCF1dlZWR3YWNrZXIuU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Server.Proto.DungeonCandidateTeamDismissReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DungeonCandidateTeamDismissReason {
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_DISMISS_REASON_TPDR_NORMAL")] TpdrNormal = 0,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_DISMISS_REASON_TPDR_DIE")] TpdrDie = 1,
    [pbr::OriginalName("DUNGEON_CANDIDATE_TEAM_DISMISS_REASON_TPDR_DISCONNECT")] TpdrDisconnect = 2,
  }

  #endregion

}

#endregion Designer generated code
