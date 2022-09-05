// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtLightCoreMove.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from EvtLightCoreMove.proto</summary>
  public static partial class EvtLightCoreMoveReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtLightCoreMove.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtLightCoreMoveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZFdnRMaWdodENvcmVNb3ZlLnByb3RvGgxWZWN0b3IucHJvdG8ifQoQRXZ0",
            "TGlnaHRDb3JlTW92ZRIbCgp0YXJnZXRfcG9zGA8gASgLMgcuVmVjdG9yEhEK",
            "CWFjZWxlcmF0ZRgLIAEoAhIRCgllbnRpdHlfaWQYBSABKA0SFwoPbWF4X2Fi",
            "c29yYl90aW1lGAogASgCEg0KBXNwZWVkGA4gASgCQhqqAhdXZWVkd2Fja2Vy",
            "LlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.EvtLightCoreMove), global::Weedwacker.Server.Proto.EvtLightCoreMove.Parser, new[]{ "TargetPos", "Acelerate", "EntityId", "MaxAbsorbTime", "Speed" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtLightCoreMove : pb::IMessage<EvtLightCoreMove>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtLightCoreMove> _parser = new pb::MessageParser<EvtLightCoreMove>(() => new EvtLightCoreMove());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtLightCoreMove> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.EvtLightCoreMoveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtLightCoreMove() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtLightCoreMove(EvtLightCoreMove other) : this() {
      targetPos_ = other.targetPos_ != null ? other.targetPos_.Clone() : null;
      acelerate_ = other.acelerate_;
      entityId_ = other.entityId_;
      maxAbsorbTime_ = other.maxAbsorbTime_;
      speed_ = other.speed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtLightCoreMove Clone() {
      return new EvtLightCoreMove(this);
    }

    /// <summary>Field number for the "target_pos" field.</summary>
    public const int TargetPosFieldNumber = 15;
    private global::Weedwacker.Server.Proto.Vector targetPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector TargetPos {
      get { return targetPos_; }
      set {
        targetPos_ = value;
      }
    }

    /// <summary>Field number for the "acelerate" field.</summary>
    public const int AcelerateFieldNumber = 11;
    private float acelerate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Acelerate {
      get { return acelerate_; }
      set {
        acelerate_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 5;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "max_absorb_time" field.</summary>
    public const int MaxAbsorbTimeFieldNumber = 10;
    private float maxAbsorbTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MaxAbsorbTime {
      get { return maxAbsorbTime_; }
      set {
        maxAbsorbTime_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 14;
    private float speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtLightCoreMove);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtLightCoreMove other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TargetPos, other.TargetPos)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Acelerate, other.Acelerate)) return false;
      if (EntityId != other.EntityId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxAbsorbTime, other.MaxAbsorbTime)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (targetPos_ != null) hash ^= TargetPos.GetHashCode();
      if (Acelerate != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Acelerate);
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (MaxAbsorbTime != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxAbsorbTime);
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
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
        output.WriteRawTag(40);
        output.WriteUInt32(EntityId);
      }
      if (MaxAbsorbTime != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(MaxAbsorbTime);
      }
      if (Acelerate != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(Acelerate);
      }
      if (Speed != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Speed);
      }
      if (targetPos_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TargetPos);
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
        output.WriteRawTag(40);
        output.WriteUInt32(EntityId);
      }
      if (MaxAbsorbTime != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(MaxAbsorbTime);
      }
      if (Acelerate != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(Acelerate);
      }
      if (Speed != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Speed);
      }
      if (targetPos_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TargetPos);
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
      if (targetPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetPos);
      }
      if (Acelerate != 0F) {
        size += 1 + 4;
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (MaxAbsorbTime != 0F) {
        size += 1 + 4;
      }
      if (Speed != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtLightCoreMove other) {
      if (other == null) {
        return;
      }
      if (other.targetPos_ != null) {
        if (targetPos_ == null) {
          TargetPos = new global::Weedwacker.Server.Proto.Vector();
        }
        TargetPos.MergeFrom(other.TargetPos);
      }
      if (other.Acelerate != 0F) {
        Acelerate = other.Acelerate;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.MaxAbsorbTime != 0F) {
        MaxAbsorbTime = other.MaxAbsorbTime;
      }
      if (other.Speed != 0F) {
        Speed = other.Speed;
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
          case 40: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 85: {
            MaxAbsorbTime = input.ReadFloat();
            break;
          }
          case 93: {
            Acelerate = input.ReadFloat();
            break;
          }
          case 117: {
            Speed = input.ReadFloat();
            break;
          }
          case 122: {
            if (targetPos_ == null) {
              TargetPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(TargetPos);
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
          case 40: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 85: {
            MaxAbsorbTime = input.ReadFloat();
            break;
          }
          case 93: {
            Acelerate = input.ReadFloat();
            break;
          }
          case 117: {
            Speed = input.ReadFloat();
            break;
          }
          case 122: {
            if (targetPos_ == null) {
              TargetPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(TargetPos);
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
