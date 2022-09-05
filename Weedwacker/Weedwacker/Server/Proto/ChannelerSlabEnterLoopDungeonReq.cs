// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabEnterLoopDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ChannelerSlabEnterLoopDungeonReq.proto</summary>
  public static partial class ChannelerSlabEnterLoopDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChannelerSlabEnterLoopDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelerSlabEnterLoopDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDaGFubmVsZXJTbGFiRW50ZXJMb29wRHVuZ2VvblJlcS5wcm90byJ9CiBD",
            "aGFubmVsZXJTbGFiRW50ZXJMb29wRHVuZ2VvblJlcRIQCghwb2ludF9pZBgJ",
            "IAEoDRIVCg1kdW5nZW9uX2luZGV4GAogASgNEhkKEWNvbmRpdGlvbl9pZF9s",
            "aXN0GAUgAygNEhUKDWRpZmZpY3VsdHlfaWQYDCABKA1CGqoCF1dlZWR3YWNr",
            "ZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ChannelerSlabEnterLoopDungeonReq), global::Weedwacker.Server.Proto.ChannelerSlabEnterLoopDungeonReq.Parser, new[]{ "PointId", "DungeonIndex", "ConditionIdList", "DifficultyId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8869
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class ChannelerSlabEnterLoopDungeonReq : pb::IMessage<ChannelerSlabEnterLoopDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelerSlabEnterLoopDungeonReq> _parser = new pb::MessageParser<ChannelerSlabEnterLoopDungeonReq>(() => new ChannelerSlabEnterLoopDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelerSlabEnterLoopDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ChannelerSlabEnterLoopDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabEnterLoopDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabEnterLoopDungeonReq(ChannelerSlabEnterLoopDungeonReq other) : this() {
      pointId_ = other.pointId_;
      dungeonIndex_ = other.dungeonIndex_;
      conditionIdList_ = other.conditionIdList_.Clone();
      difficultyId_ = other.difficultyId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelerSlabEnterLoopDungeonReq Clone() {
      return new ChannelerSlabEnterLoopDungeonReq(this);
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 9;
    private uint pointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointId {
      get { return pointId_; }
      set {
        pointId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_index" field.</summary>
    public const int DungeonIndexFieldNumber = 10;
    private uint dungeonIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonIndex {
      get { return dungeonIndex_; }
      set {
        dungeonIndex_ = value;
      }
    }

    /// <summary>Field number for the "condition_id_list" field.</summary>
    public const int ConditionIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_conditionIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> conditionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ConditionIdList {
      get { return conditionIdList_; }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 12;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelerSlabEnterLoopDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelerSlabEnterLoopDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PointId != other.PointId) return false;
      if (DungeonIndex != other.DungeonIndex) return false;
      if(!conditionIdList_.Equals(other.conditionIdList_)) return false;
      if (DifficultyId != other.DifficultyId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PointId != 0) hash ^= PointId.GetHashCode();
      if (DungeonIndex != 0) hash ^= DungeonIndex.GetHashCode();
      hash ^= conditionIdList_.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
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
      conditionIdList_.WriteTo(output, _repeated_conditionIdList_codec);
      if (PointId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PointId);
      }
      if (DungeonIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DungeonIndex);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DifficultyId);
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
      conditionIdList_.WriteTo(ref output, _repeated_conditionIdList_codec);
      if (PointId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PointId);
      }
      if (DungeonIndex != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DungeonIndex);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DifficultyId);
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
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      if (DungeonIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonIndex);
      }
      size += conditionIdList_.CalculateSize(_repeated_conditionIdList_codec);
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelerSlabEnterLoopDungeonReq other) {
      if (other == null) {
        return;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
      }
      if (other.DungeonIndex != 0) {
        DungeonIndex = other.DungeonIndex;
      }
      conditionIdList_.Add(other.conditionIdList_);
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
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
          case 42:
          case 40: {
            conditionIdList_.AddEntriesFrom(input, _repeated_conditionIdList_codec);
            break;
          }
          case 72: {
            PointId = input.ReadUInt32();
            break;
          }
          case 80: {
            DungeonIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            DifficultyId = input.ReadUInt32();
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
          case 42:
          case 40: {
            conditionIdList_.AddEntriesFrom(ref input, _repeated_conditionIdList_codec);
            break;
          }
          case 72: {
            PointId = input.ReadUInt32();
            break;
          }
          case 80: {
            DungeonIndex = input.ReadUInt32();
            break;
          }
          case 96: {
            DifficultyId = input.ReadUInt32();
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
