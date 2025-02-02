// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityMoveInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EntityMoveInfo.proto</summary>
  public static partial class EntityMoveInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityMoveInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityMoveInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRFbnRpdHlNb3ZlSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90bxoQTW90aW9uSW5mby5wcm90byKkAQoORW50aXR5TW92ZUlu",
            "Zm8SEQoJZW50aXR5X2lkGAEgASgNEkAKC21vdGlvbl9pbmZvGAIgASgLMisu",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Nb3Rpb25JbmZvEhIK",
            "CnNjZW5lX3RpbWUYAyABKA0SFAoMcmVsaWFibGVfc2VxGAQgASgNEhMKC2lz",
            "X3JlbGlhYmxlGAUgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EntityMoveInfo), global::Weedwacker.Shared.Network.Proto.EntityMoveInfo.Parser, new[]{ "EntityId", "MotionInfo", "SceneTime", "ReliableSeq", "IsReliable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EntityMoveInfo : pb::IMessage<EntityMoveInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityMoveInfo> _parser = new pb::MessageParser<EntityMoveInfo>(() => new EntityMoveInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityMoveInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EntityMoveInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityMoveInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityMoveInfo(EntityMoveInfo other) : this() {
      entityId_ = other.entityId_;
      motionInfo_ = other.motionInfo_ != null ? other.motionInfo_.Clone() : null;
      sceneTime_ = other.sceneTime_;
      reliableSeq_ = other.reliableSeq_;
      isReliable_ = other.isReliable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityMoveInfo Clone() {
      return new EntityMoveInfo(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "motion_info" field.</summary>
    public const int MotionInfoFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.MotionInfo motionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MotionInfo MotionInfo {
      get { return motionInfo_; }
      set {
        motionInfo_ = value;
      }
    }

    /// <summary>Field number for the "scene_time" field.</summary>
    public const int SceneTimeFieldNumber = 3;
    private uint sceneTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneTime {
      get { return sceneTime_; }
      set {
        sceneTime_ = value;
      }
    }

    /// <summary>Field number for the "reliable_seq" field.</summary>
    public const int ReliableSeqFieldNumber = 4;
    private uint reliableSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReliableSeq {
      get { return reliableSeq_; }
      set {
        reliableSeq_ = value;
      }
    }

    /// <summary>Field number for the "is_reliable" field.</summary>
    public const int IsReliableFieldNumber = 5;
    private bool isReliable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsReliable {
      get { return isReliable_; }
      set {
        isReliable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityMoveInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityMoveInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(MotionInfo, other.MotionInfo)) return false;
      if (SceneTime != other.SceneTime) return false;
      if (ReliableSeq != other.ReliableSeq) return false;
      if (IsReliable != other.IsReliable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (motionInfo_ != null) hash ^= MotionInfo.GetHashCode();
      if (SceneTime != 0) hash ^= SceneTime.GetHashCode();
      if (ReliableSeq != 0) hash ^= ReliableSeq.GetHashCode();
      if (IsReliable != false) hash ^= IsReliable.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MotionInfo);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SceneTime);
      }
      if (ReliableSeq != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ReliableSeq);
      }
      if (IsReliable != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsReliable);
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MotionInfo);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SceneTime);
      }
      if (ReliableSeq != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ReliableSeq);
      }
      if (IsReliable != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsReliable);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (motionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MotionInfo);
      }
      if (SceneTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTime);
      }
      if (ReliableSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReliableSeq);
      }
      if (IsReliable != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityMoveInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.motionInfo_ != null) {
        if (motionInfo_ == null) {
          MotionInfo = new global::Weedwacker.Shared.Network.Proto.MotionInfo();
        }
        MotionInfo.MergeFrom(other.MotionInfo);
      }
      if (other.SceneTime != 0) {
        SceneTime = other.SceneTime;
      }
      if (other.ReliableSeq != 0) {
        ReliableSeq = other.ReliableSeq;
      }
      if (other.IsReliable != false) {
        IsReliable = other.IsReliable;
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (motionInfo_ == null) {
              MotionInfo = new global::Weedwacker.Shared.Network.Proto.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 24: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 32: {
            ReliableSeq = input.ReadUInt32();
            break;
          }
          case 40: {
            IsReliable = input.ReadBool();
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (motionInfo_ == null) {
              MotionInfo = new global::Weedwacker.Shared.Network.Proto.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 24: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 32: {
            ReliableSeq = input.ReadUInt32();
            break;
          }
          case 40: {
            IsReliable = input.ReadBool();
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
