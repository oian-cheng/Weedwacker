// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LifeStateChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LifeStateChangeNotify.proto</summary>
  public static partial class LifeStateChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for LifeStateChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LifeStateChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtMaWZlU3RhdGVDaGFuZ2VOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aE1BsYXllckRpZVR5cGUucHJvdG8aEFNlcnZl",
            "ckJ1ZmYucHJvdG8ikAIKFUxpZmVTdGF0ZUNoYW5nZU5vdGlmeRIZChFtb3Zl",
            "X3JlbGlhYmxlX3NlcRgHIAEoDRIRCgllbnRpdHlfaWQYCCABKA0SEgoKbGlm",
            "ZV9zdGF0ZRgKIAEoDRJFChBzZXJ2ZXJfYnVmZl9saXN0GA8gAygLMisuV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5TZXJ2ZXJCdWZmEhgKEHNv",
            "dXJjZV9lbnRpdHlfaWQYCyABKA0SQAoIZGllX3R5cGUYBCABKA4yLi5XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlBsYXllckRpZVR5cGUSEgoK",
            "YXR0YWNrX3RhZxgNIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.PlayerDieTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ServerBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LifeStateChangeNotify), global::Weedwacker.Shared.Network.Proto.LifeStateChangeNotify.Parser, new[]{ "MoveReliableSeq", "EntityId", "LifeState", "ServerBuffList", "SourceEntityId", "DieType", "AttackTag" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1230;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class LifeStateChangeNotify : pb::IMessage<LifeStateChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LifeStateChangeNotify> _parser = new pb::MessageParser<LifeStateChangeNotify>(() => new LifeStateChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LifeStateChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LifeStateChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeStateChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeStateChangeNotify(LifeStateChangeNotify other) : this() {
      moveReliableSeq_ = other.moveReliableSeq_;
      entityId_ = other.entityId_;
      lifeState_ = other.lifeState_;
      serverBuffList_ = other.serverBuffList_.Clone();
      sourceEntityId_ = other.sourceEntityId_;
      dieType_ = other.dieType_;
      attackTag_ = other.attackTag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LifeStateChangeNotify Clone() {
      return new LifeStateChangeNotify(this);
    }

    /// <summary>Field number for the "move_reliable_seq" field.</summary>
    public const int MoveReliableSeqFieldNumber = 7;
    private uint moveReliableSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MoveReliableSeq {
      get { return moveReliableSeq_; }
      set {
        moveReliableSeq_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 8;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "life_state" field.</summary>
    public const int LifeStateFieldNumber = 10;
    private uint lifeState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LifeState {
      get { return lifeState_; }
      set {
        lifeState_ = value;
      }
    }

    /// <summary>Field number for the "server_buff_list" field.</summary>
    public const int ServerBuffListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ServerBuff> _repeated_serverBuffList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.ServerBuff.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ServerBuff> serverBuffList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ServerBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ServerBuff> ServerBuffList {
      get { return serverBuffList_; }
    }

    /// <summary>Field number for the "source_entity_id" field.</summary>
    public const int SourceEntityIdFieldNumber = 11;
    private uint sourceEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceEntityId {
      get { return sourceEntityId_; }
      set {
        sourceEntityId_ = value;
      }
    }

    /// <summary>Field number for the "die_type" field.</summary>
    public const int DieTypeFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.PlayerDieType dieType_ = global::Weedwacker.Shared.Network.Proto.PlayerDieType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PlayerDieType DieType {
      get { return dieType_; }
      set {
        dieType_ = value;
      }
    }

    /// <summary>Field number for the "attack_tag" field.</summary>
    public const int AttackTagFieldNumber = 13;
    private string attackTag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AttackTag {
      get { return attackTag_; }
      set {
        attackTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LifeStateChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LifeStateChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MoveReliableSeq != other.MoveReliableSeq) return false;
      if (EntityId != other.EntityId) return false;
      if (LifeState != other.LifeState) return false;
      if(!serverBuffList_.Equals(other.serverBuffList_)) return false;
      if (SourceEntityId != other.SourceEntityId) return false;
      if (DieType != other.DieType) return false;
      if (AttackTag != other.AttackTag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MoveReliableSeq != 0) hash ^= MoveReliableSeq.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (LifeState != 0) hash ^= LifeState.GetHashCode();
      hash ^= serverBuffList_.GetHashCode();
      if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) hash ^= DieType.GetHashCode();
      if (AttackTag.Length != 0) hash ^= AttackTag.GetHashCode();
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
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) DieType);
      }
      if (MoveReliableSeq != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MoveReliableSeq);
      }
      if (EntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntityId);
      }
      if (LifeState != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LifeState);
      }
      if (SourceEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SourceEntityId);
      }
      if (AttackTag.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(AttackTag);
      }
      serverBuffList_.WriteTo(output, _repeated_serverBuffList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) DieType);
      }
      if (MoveReliableSeq != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MoveReliableSeq);
      }
      if (EntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntityId);
      }
      if (LifeState != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LifeState);
      }
      if (SourceEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SourceEntityId);
      }
      if (AttackTag.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(AttackTag);
      }
      serverBuffList_.WriteTo(ref output, _repeated_serverBuffList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MoveReliableSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MoveReliableSeq);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (LifeState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeState);
      }
      size += serverBuffList_.CalculateSize(_repeated_serverBuffList_codec);
      if (SourceEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
      }
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DieType);
      }
      if (AttackTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AttackTag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LifeStateChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.MoveReliableSeq != 0) {
        MoveReliableSeq = other.MoveReliableSeq;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.LifeState != 0) {
        LifeState = other.LifeState;
      }
      serverBuffList_.Add(other.serverBuffList_);
      if (other.SourceEntityId != 0) {
        SourceEntityId = other.SourceEntityId;
      }
      if (other.DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        DieType = other.DieType;
      }
      if (other.AttackTag.Length != 0) {
        AttackTag = other.AttackTag;
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
          case 32: {
            DieType = (global::Weedwacker.Shared.Network.Proto.PlayerDieType) input.ReadEnum();
            break;
          }
          case 56: {
            MoveReliableSeq = input.ReadUInt32();
            break;
          }
          case 64: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 80: {
            LifeState = input.ReadUInt32();
            break;
          }
          case 88: {
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 106: {
            AttackTag = input.ReadString();
            break;
          }
          case 122: {
            serverBuffList_.AddEntriesFrom(input, _repeated_serverBuffList_codec);
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
          case 32: {
            DieType = (global::Weedwacker.Shared.Network.Proto.PlayerDieType) input.ReadEnum();
            break;
          }
          case 56: {
            MoveReliableSeq = input.ReadUInt32();
            break;
          }
          case 64: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 80: {
            LifeState = input.ReadUInt32();
            break;
          }
          case 88: {
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 106: {
            AttackTag = input.ReadString();
            break;
          }
          case 122: {
            serverBuffList_.AddEntriesFrom(ref input, _repeated_serverBuffList_codec);
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
