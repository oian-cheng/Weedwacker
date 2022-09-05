// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerStartMatchReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from PlayerStartMatchReq.proto</summary>
  public static partial class PlayerStartMatchReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerStartMatchReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerStartMatchReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQbGF5ZXJTdGFydE1hdGNoUmVxLnByb3RvGg9NYXRjaFR5cGUucHJvdG8i",
            "rQEKE1BsYXllclN0YXJ0TWF0Y2hSZXESHgoKbWF0Y2hfdHlwZRgDIAEoDjIK",
            "Lk1hdGNoVHlwZRIiChptZWNoYW5pY3VzX2RpZmZpY3VsdF9sZXZlbBgMIAEo",
            "DRIYChBtYXRjaF9wYXJhbV9saXN0GAsgAygNEhIKCmR1bmdlb25faWQYASAB",
            "KA0SEgoKbXBfcGxheV9pZBgPIAEoDRIQCghtYXRjaF9pZBgGIAEoDUIaqgIX",
            "V2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.MatchTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.PlayerStartMatchReq), global::Weedwacker.Server.Proto.PlayerStartMatchReq.Parser, new[]{ "MatchType", "MechanicusDifficultLevel", "MatchParamList", "DungeonId", "MpPlayId", "MatchId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4176
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class PlayerStartMatchReq : pb::IMessage<PlayerStartMatchReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerStartMatchReq> _parser = new pb::MessageParser<PlayerStartMatchReq>(() => new PlayerStartMatchReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerStartMatchReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.PlayerStartMatchReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStartMatchReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStartMatchReq(PlayerStartMatchReq other) : this() {
      matchType_ = other.matchType_;
      mechanicusDifficultLevel_ = other.mechanicusDifficultLevel_;
      matchParamList_ = other.matchParamList_.Clone();
      dungeonId_ = other.dungeonId_;
      mpPlayId_ = other.mpPlayId_;
      matchId_ = other.matchId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerStartMatchReq Clone() {
      return new PlayerStartMatchReq(this);
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 3;
    private global::Weedwacker.Server.Proto.MatchType matchType_ = global::Weedwacker.Server.Proto.MatchType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.MatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_difficult_level" field.</summary>
    public const int MechanicusDifficultLevelFieldNumber = 12;
    private uint mechanicusDifficultLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusDifficultLevel {
      get { return mechanicusDifficultLevel_; }
      set {
        mechanicusDifficultLevel_ = value;
      }
    }

    /// <summary>Field number for the "match_param_list" field.</summary>
    public const int MatchParamListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_matchParamList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> matchParamList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MatchParamList {
      get { return matchParamList_; }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 1;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "mp_play_id" field.</summary>
    public const int MpPlayIdFieldNumber = 15;
    private uint mpPlayId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MpPlayId {
      get { return mpPlayId_; }
      set {
        mpPlayId_ = value;
      }
    }

    /// <summary>Field number for the "match_id" field.</summary>
    public const int MatchIdFieldNumber = 6;
    private uint matchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MatchId {
      get { return matchId_; }
      set {
        matchId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerStartMatchReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerStartMatchReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MatchType != other.MatchType) return false;
      if (MechanicusDifficultLevel != other.MechanicusDifficultLevel) return false;
      if(!matchParamList_.Equals(other.matchParamList_)) return false;
      if (DungeonId != other.DungeonId) return false;
      if (MpPlayId != other.MpPlayId) return false;
      if (MatchId != other.MatchId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MatchType != global::Weedwacker.Server.Proto.MatchType.None) hash ^= MatchType.GetHashCode();
      if (MechanicusDifficultLevel != 0) hash ^= MechanicusDifficultLevel.GetHashCode();
      hash ^= matchParamList_.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
      if (MatchId != 0) hash ^= MatchId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (DungeonId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DungeonId);
      }
      if (MatchType != global::Weedwacker.Server.Proto.MatchType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MatchType);
      }
      if (MatchId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MatchId);
      }
      matchParamList_.WriteTo(output, _repeated_matchParamList_codec);
      if (MechanicusDifficultLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MechanicusDifficultLevel);
      }
      if (MpPlayId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MpPlayId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (DungeonId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DungeonId);
      }
      if (MatchType != global::Weedwacker.Server.Proto.MatchType.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MatchType);
      }
      if (MatchId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(MatchId);
      }
      matchParamList_.WriteTo(ref output, _repeated_matchParamList_codec);
      if (MechanicusDifficultLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MechanicusDifficultLevel);
      }
      if (MpPlayId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MpPlayId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MatchType != global::Weedwacker.Server.Proto.MatchType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (MechanicusDifficultLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusDifficultLevel);
      }
      size += matchParamList_.CalculateSize(_repeated_matchParamList_codec);
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (MpPlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
      }
      if (MatchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerStartMatchReq other) {
      if (other == null) {
        return;
      }
      if (other.MatchType != global::Weedwacker.Server.Proto.MatchType.None) {
        MatchType = other.MatchType;
      }
      if (other.MechanicusDifficultLevel != 0) {
        MechanicusDifficultLevel = other.MechanicusDifficultLevel;
      }
      matchParamList_.Add(other.matchParamList_);
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.MpPlayId != 0) {
        MpPlayId = other.MpPlayId;
      }
      if (other.MatchId != 0) {
        MatchId = other.MatchId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 24: {
            MatchType = (global::Weedwacker.Server.Proto.MatchType) input.ReadEnum();
            break;
          }
          case 48: {
            MatchId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            matchParamList_.AddEntriesFrom(input, _repeated_matchParamList_codec);
            break;
          }
          case 96: {
            MechanicusDifficultLevel = input.ReadUInt32();
            break;
          }
          case 120: {
            MpPlayId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 24: {
            MatchType = (global::Weedwacker.Server.Proto.MatchType) input.ReadEnum();
            break;
          }
          case 48: {
            MatchId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            matchParamList_.AddEntriesFrom(ref input, _repeated_matchParamList_codec);
            break;
          }
          case 96: {
            MechanicusDifficultLevel = input.ReadUInt32();
            break;
          }
          case 120: {
            MpPlayId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
