// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterTrialAvatarActivityDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EnterTrialAvatarActivityDungeonReq.proto</summary>
  public static partial class EnterTrialAvatarActivityDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterTrialAvatarActivityDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterTrialAvatarActivityDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihFbnRlclRyaWFsQXZhdGFyQWN0aXZpdHlEdW5nZW9uUmVxLnByb3RvEh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvInAKIkVudGVyVHJpYWxB",
            "dmF0YXJBY3Rpdml0eUR1bmdlb25SZXESFgoOZW50ZXJfcG9pbnRfaWQYByAB",
            "KA0SEwoLYWN0aXZpdHlfaWQYASABKA0SHQoVdHJpYWxfYXZhdGFyX2luZGV4",
            "X2lkGAUgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EnterTrialAvatarActivityDungeonReq), global::Weedwacker.Shared.Network.Proto.EnterTrialAvatarActivityDungeonReq.Parser, new[]{ "EnterPointId", "ActivityId", "TrialAvatarIndexId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2142;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class EnterTrialAvatarActivityDungeonReq : pb::IMessage<EnterTrialAvatarActivityDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterTrialAvatarActivityDungeonReq> _parser = new pb::MessageParser<EnterTrialAvatarActivityDungeonReq>(() => new EnterTrialAvatarActivityDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterTrialAvatarActivityDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EnterTrialAvatarActivityDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterTrialAvatarActivityDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterTrialAvatarActivityDungeonReq(EnterTrialAvatarActivityDungeonReq other) : this() {
      enterPointId_ = other.enterPointId_;
      activityId_ = other.activityId_;
      trialAvatarIndexId_ = other.trialAvatarIndexId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterTrialAvatarActivityDungeonReq Clone() {
      return new EnterTrialAvatarActivityDungeonReq(this);
    }

    /// <summary>Field number for the "enter_point_id" field.</summary>
    public const int EnterPointIdFieldNumber = 7;
    private uint enterPointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterPointId {
      get { return enterPointId_; }
      set {
        enterPointId_ = value;
      }
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 1;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    /// <summary>Field number for the "trial_avatar_index_id" field.</summary>
    public const int TrialAvatarIndexIdFieldNumber = 5;
    private uint trialAvatarIndexId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TrialAvatarIndexId {
      get { return trialAvatarIndexId_; }
      set {
        trialAvatarIndexId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterTrialAvatarActivityDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterTrialAvatarActivityDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnterPointId != other.EnterPointId) return false;
      if (ActivityId != other.ActivityId) return false;
      if (TrialAvatarIndexId != other.TrialAvatarIndexId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EnterPointId != 0) hash ^= EnterPointId.GetHashCode();
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
      if (TrialAvatarIndexId != 0) hash ^= TrialAvatarIndexId.GetHashCode();
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
      if (ActivityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ActivityId);
      }
      if (TrialAvatarIndexId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TrialAvatarIndexId);
      }
      if (EnterPointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterPointId);
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
      if (ActivityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ActivityId);
      }
      if (TrialAvatarIndexId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TrialAvatarIndexId);
      }
      if (EnterPointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterPointId);
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
      if (EnterPointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterPointId);
      }
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      if (TrialAvatarIndexId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialAvatarIndexId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterTrialAvatarActivityDungeonReq other) {
      if (other == null) {
        return;
      }
      if (other.EnterPointId != 0) {
        EnterPointId = other.EnterPointId;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
      }
      if (other.TrialAvatarIndexId != 0) {
        TrialAvatarIndexId = other.TrialAvatarIndexId;
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
            ActivityId = input.ReadUInt32();
            break;
          }
          case 40: {
            TrialAvatarIndexId = input.ReadUInt32();
            break;
          }
          case 56: {
            EnterPointId = input.ReadUInt32();
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
            ActivityId = input.ReadUInt32();
            break;
          }
          case 40: {
            TrialAvatarIndexId = input.ReadUInt32();
            break;
          }
          case 56: {
            EnterPointId = input.ReadUInt32();
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
