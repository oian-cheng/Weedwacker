// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtRushMoveInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from EvtRushMoveInfo.proto</summary>
  public static partial class EvtRushMoveInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtRushMoveInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtRushMoveInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFdnRSdXNoTW92ZUluZm8ucHJvdG8aDFZlY3Rvci5wcm90byLlAQoPRXZ0",
            "UnVzaE1vdmVJbmZvEhcKD3N0YXRlX25hbWVfaGFzaBgLIAEoBRIcCgtydXNo",
            "X3RvX3BvcxgJIAEoCzIHLlZlY3RvchInChZydXNoX2F0dGFja190YXJnZXRf",
            "cG9zGAggASgLMgcuVmVjdG9yEhEKCWVudGl0eV9pZBgEIAEoDRISCgp0aW1l",
            "X3JhbmdlGA8gASgCEhkKCHZlbG9jaXR5GAYgASgLMgcuVmVjdG9yEhQKA3Bv",
            "cxgCIAEoCzIHLlZlY3RvchIaChJmYWNlX2FuZ2xlX2NvbXBhY3QYCiABKAVC",
            "GqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.EvtRushMoveInfo), global::Weedwacker.Server.Proto.EvtRushMoveInfo.Parser, new[]{ "StateNameHash", "RushToPos", "RushAttackTargetPos", "EntityId", "TimeRange", "Velocity", "Pos", "FaceAngleCompact" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtRushMoveInfo : pb::IMessage<EvtRushMoveInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtRushMoveInfo> _parser = new pb::MessageParser<EvtRushMoveInfo>(() => new EvtRushMoveInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtRushMoveInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.EvtRushMoveInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveInfo(EvtRushMoveInfo other) : this() {
      stateNameHash_ = other.stateNameHash_;
      rushToPos_ = other.rushToPos_ != null ? other.rushToPos_.Clone() : null;
      rushAttackTargetPos_ = other.rushAttackTargetPos_ != null ? other.rushAttackTargetPos_.Clone() : null;
      entityId_ = other.entityId_;
      timeRange_ = other.timeRange_;
      velocity_ = other.velocity_ != null ? other.velocity_.Clone() : null;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      faceAngleCompact_ = other.faceAngleCompact_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveInfo Clone() {
      return new EvtRushMoveInfo(this);
    }

    /// <summary>Field number for the "state_name_hash" field.</summary>
    public const int StateNameHashFieldNumber = 11;
    private int stateNameHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StateNameHash {
      get { return stateNameHash_; }
      set {
        stateNameHash_ = value;
      }
    }

    /// <summary>Field number for the "rush_to_pos" field.</summary>
    public const int RushToPosFieldNumber = 9;
    private global::Weedwacker.Server.Proto.Vector rushToPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector RushToPos {
      get { return rushToPos_; }
      set {
        rushToPos_ = value;
      }
    }

    /// <summary>Field number for the "rush_attack_target_pos" field.</summary>
    public const int RushAttackTargetPosFieldNumber = 8;
    private global::Weedwacker.Server.Proto.Vector rushAttackTargetPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector RushAttackTargetPos {
      get { return rushAttackTargetPos_; }
      set {
        rushAttackTargetPos_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "time_range" field.</summary>
    public const int TimeRangeFieldNumber = 15;
    private float timeRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TimeRange {
      get { return timeRange_; }
      set {
        timeRange_ = value;
      }
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 6;
    private global::Weedwacker.Server.Proto.Vector velocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector Velocity {
      get { return velocity_; }
      set {
        velocity_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 2;
    private global::Weedwacker.Server.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "face_angle_compact" field.</summary>
    public const int FaceAngleCompactFieldNumber = 10;
    private int faceAngleCompact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FaceAngleCompact {
      get { return faceAngleCompact_; }
      set {
        faceAngleCompact_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtRushMoveInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtRushMoveInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StateNameHash != other.StateNameHash) return false;
      if (!object.Equals(RushToPos, other.RushToPos)) return false;
      if (!object.Equals(RushAttackTargetPos, other.RushAttackTargetPos)) return false;
      if (EntityId != other.EntityId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TimeRange, other.TimeRange)) return false;
      if (!object.Equals(Velocity, other.Velocity)) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (FaceAngleCompact != other.FaceAngleCompact) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StateNameHash != 0) hash ^= StateNameHash.GetHashCode();
      if (rushToPos_ != null) hash ^= RushToPos.GetHashCode();
      if (rushAttackTargetPos_ != null) hash ^= RushAttackTargetPos.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (TimeRange != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TimeRange);
      if (velocity_ != null) hash ^= Velocity.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (FaceAngleCompact != 0) hash ^= FaceAngleCompact.GetHashCode();
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
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (velocity_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Velocity);
      }
      if (rushAttackTargetPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RushAttackTargetPos);
      }
      if (rushToPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RushToPos);
      }
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(FaceAngleCompact);
      }
      if (StateNameHash != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(StateNameHash);
      }
      if (TimeRange != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(TimeRange);
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
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (velocity_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Velocity);
      }
      if (rushAttackTargetPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(RushAttackTargetPos);
      }
      if (rushToPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RushToPos);
      }
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(FaceAngleCompact);
      }
      if (StateNameHash != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(StateNameHash);
      }
      if (TimeRange != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(TimeRange);
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
      if (StateNameHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StateNameHash);
      }
      if (rushToPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RushToPos);
      }
      if (rushAttackTargetPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RushAttackTargetPos);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (TimeRange != 0F) {
        size += 1 + 4;
      }
      if (velocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Velocity);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (FaceAngleCompact != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FaceAngleCompact);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtRushMoveInfo other) {
      if (other == null) {
        return;
      }
      if (other.StateNameHash != 0) {
        StateNameHash = other.StateNameHash;
      }
      if (other.rushToPos_ != null) {
        if (rushToPos_ == null) {
          RushToPos = new global::Weedwacker.Server.Proto.Vector();
        }
        RushToPos.MergeFrom(other.RushToPos);
      }
      if (other.rushAttackTargetPos_ != null) {
        if (rushAttackTargetPos_ == null) {
          RushAttackTargetPos = new global::Weedwacker.Server.Proto.Vector();
        }
        RushAttackTargetPos.MergeFrom(other.RushAttackTargetPos);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.TimeRange != 0F) {
        TimeRange = other.TimeRange;
      }
      if (other.velocity_ != null) {
        if (velocity_ == null) {
          Velocity = new global::Weedwacker.Server.Proto.Vector();
        }
        Velocity.MergeFrom(other.Velocity);
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Server.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.FaceAngleCompact != 0) {
        FaceAngleCompact = other.FaceAngleCompact;
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
          case 18: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (velocity_ == null) {
              Velocity = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 66: {
            if (rushAttackTargetPos_ == null) {
              RushAttackTargetPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(RushAttackTargetPos);
            break;
          }
          case 74: {
            if (rushToPos_ == null) {
              RushToPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(RushToPos);
            break;
          }
          case 80: {
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 88: {
            StateNameHash = input.ReadInt32();
            break;
          }
          case 125: {
            TimeRange = input.ReadFloat();
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
          case 18: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (velocity_ == null) {
              Velocity = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 66: {
            if (rushAttackTargetPos_ == null) {
              RushAttackTargetPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(RushAttackTargetPos);
            break;
          }
          case 74: {
            if (rushToPos_ == null) {
              RushToPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(RushToPos);
            break;
          }
          case 80: {
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 88: {
            StateNameHash = input.ReadInt32();
            break;
          }
          case 125: {
            TimeRange = input.ReadFloat();
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
