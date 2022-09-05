// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForceDragAvatarNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ForceDragAvatarNotify.proto</summary>
  public static partial class ForceDragAvatarNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ForceDragAvatarNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForceDragAvatarNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGb3JjZURyYWdBdmF0YXJOb3RpZnkucHJvdG8aEE1vdGlvbkluZm8ucHJv",
            "dG8iqgEKFUZvcmNlRHJhZ0F2YXRhck5vdGlmeRISCgpzY2VuZV90aW1lGAMg",
            "ASgNEhUKDWRlbHRhX3RpbWVfbXMYASABKAQSEQoJZW50aXR5X2lkGAIgASgN",
            "EiAKC21vdGlvbl9pbmZvGAogASgLMgsuTW90aW9uSW5mbxIWCg5pc19maXJz",
            "dF92YWxpZBgIIAEoCBIZChFsYXN0X21vdmVfdGltZV9tcxgMIAEoBEIaqgIX",
            "V2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ForceDragAvatarNotify), global::Weedwacker.Server.Proto.ForceDragAvatarNotify.Parser, new[]{ "SceneTime", "DeltaTimeMs", "EntityId", "MotionInfo", "IsFirstValid", "LastMoveTimeMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3235
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ForceDragAvatarNotify : pb::IMessage<ForceDragAvatarNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForceDragAvatarNotify> _parser = new pb::MessageParser<ForceDragAvatarNotify>(() => new ForceDragAvatarNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForceDragAvatarNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ForceDragAvatarNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForceDragAvatarNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForceDragAvatarNotify(ForceDragAvatarNotify other) : this() {
      sceneTime_ = other.sceneTime_;
      deltaTimeMs_ = other.deltaTimeMs_;
      entityId_ = other.entityId_;
      motionInfo_ = other.motionInfo_ != null ? other.motionInfo_.Clone() : null;
      isFirstValid_ = other.isFirstValid_;
      lastMoveTimeMs_ = other.lastMoveTimeMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForceDragAvatarNotify Clone() {
      return new ForceDragAvatarNotify(this);
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

    /// <summary>Field number for the "delta_time_ms" field.</summary>
    public const int DeltaTimeMsFieldNumber = 1;
    private ulong deltaTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DeltaTimeMs {
      get { return deltaTimeMs_; }
      set {
        deltaTimeMs_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
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
    public const int MotionInfoFieldNumber = 10;
    private global::Weedwacker.Server.Proto.MotionInfo motionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.MotionInfo MotionInfo {
      get { return motionInfo_; }
      set {
        motionInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_first_valid" field.</summary>
    public const int IsFirstValidFieldNumber = 8;
    private bool isFirstValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstValid {
      get { return isFirstValid_; }
      set {
        isFirstValid_ = value;
      }
    }

    /// <summary>Field number for the "last_move_time_ms" field.</summary>
    public const int LastMoveTimeMsFieldNumber = 12;
    private ulong lastMoveTimeMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong LastMoveTimeMs {
      get { return lastMoveTimeMs_; }
      set {
        lastMoveTimeMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ForceDragAvatarNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForceDragAvatarNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneTime != other.SceneTime) return false;
      if (DeltaTimeMs != other.DeltaTimeMs) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(MotionInfo, other.MotionInfo)) return false;
      if (IsFirstValid != other.IsFirstValid) return false;
      if (LastMoveTimeMs != other.LastMoveTimeMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneTime != 0) hash ^= SceneTime.GetHashCode();
      if (DeltaTimeMs != 0UL) hash ^= DeltaTimeMs.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (motionInfo_ != null) hash ^= MotionInfo.GetHashCode();
      if (IsFirstValid != false) hash ^= IsFirstValid.GetHashCode();
      if (LastMoveTimeMs != 0UL) hash ^= LastMoveTimeMs.GetHashCode();
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
      if (DeltaTimeMs != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DeltaTimeMs);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SceneTime);
      }
      if (IsFirstValid != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsFirstValid);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(MotionInfo);
      }
      if (LastMoveTimeMs != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(LastMoveTimeMs);
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
      if (DeltaTimeMs != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DeltaTimeMs);
      }
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SceneTime);
      }
      if (IsFirstValid != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsFirstValid);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(MotionInfo);
      }
      if (LastMoveTimeMs != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(LastMoveTimeMs);
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
      if (SceneTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTime);
      }
      if (DeltaTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DeltaTimeMs);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (motionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MotionInfo);
      }
      if (IsFirstValid != false) {
        size += 1 + 1;
      }
      if (LastMoveTimeMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LastMoveTimeMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ForceDragAvatarNotify other) {
      if (other == null) {
        return;
      }
      if (other.SceneTime != 0) {
        SceneTime = other.SceneTime;
      }
      if (other.DeltaTimeMs != 0UL) {
        DeltaTimeMs = other.DeltaTimeMs;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.motionInfo_ != null) {
        if (motionInfo_ == null) {
          MotionInfo = new global::Weedwacker.Server.Proto.MotionInfo();
        }
        MotionInfo.MergeFrom(other.MotionInfo);
      }
      if (other.IsFirstValid != false) {
        IsFirstValid = other.IsFirstValid;
      }
      if (other.LastMoveTimeMs != 0UL) {
        LastMoveTimeMs = other.LastMoveTimeMs;
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
            DeltaTimeMs = input.ReadUInt64();
            break;
          }
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 64: {
            IsFirstValid = input.ReadBool();
            break;
          }
          case 82: {
            if (motionInfo_ == null) {
              MotionInfo = new global::Weedwacker.Server.Proto.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 96: {
            LastMoveTimeMs = input.ReadUInt64();
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
            DeltaTimeMs = input.ReadUInt64();
            break;
          }
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 64: {
            IsFirstValid = input.ReadBool();
            break;
          }
          case 82: {
            if (motionInfo_ == null) {
              MotionInfo = new global::Weedwacker.Server.Proto.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 96: {
            LastMoveTimeMs = input.ReadUInt64();
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
