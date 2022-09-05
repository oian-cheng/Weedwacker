// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeAvatarRewardEventNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeAvatarRewardEventNotify.proto</summary>
  public static partial class HomeAvatarRewardEventNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeAvatarRewardEventNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeAvatarRewardEventNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFIb21lQXZhdGFyUmV3YXJkRXZlbnROb3RpZnkucHJvdG8aH0hvbWVBdmF0",
            "YXJSZXdhcmRFdmVudEluZm8ucHJvdG8imwEKG0hvbWVBdmF0YXJSZXdhcmRF",
            "dmVudE5vdGlmeRIYChBpc19ldmVudF90cmlnZ2VyGAQgASgIEjAKDHJld2Fy",
            "ZF9ldmVudBgCIAEoCzIaLkhvbWVBdmF0YXJSZXdhcmRFdmVudEluZm8SMAoM",
            "cGVuZGluZ19saXN0GAggAygLMhouSG9tZUF2YXRhclJld2FyZEV2ZW50SW5m",
            "b0IaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeAvatarRewardEventNotify), global::Weedwacker.Server.Proto.HomeAvatarRewardEventNotify.Parser, new[]{ "IsEventTrigger", "RewardEvent", "PendingList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4852
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class HomeAvatarRewardEventNotify : pb::IMessage<HomeAvatarRewardEventNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeAvatarRewardEventNotify> _parser = new pb::MessageParser<HomeAvatarRewardEventNotify>(() => new HomeAvatarRewardEventNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeAvatarRewardEventNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeAvatarRewardEventNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarRewardEventNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarRewardEventNotify(HomeAvatarRewardEventNotify other) : this() {
      isEventTrigger_ = other.isEventTrigger_;
      rewardEvent_ = other.rewardEvent_ != null ? other.rewardEvent_.Clone() : null;
      pendingList_ = other.pendingList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarRewardEventNotify Clone() {
      return new HomeAvatarRewardEventNotify(this);
    }

    /// <summary>Field number for the "is_event_trigger" field.</summary>
    public const int IsEventTriggerFieldNumber = 4;
    private bool isEventTrigger_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEventTrigger {
      get { return isEventTrigger_; }
      set {
        isEventTrigger_ = value;
      }
    }

    /// <summary>Field number for the "reward_event" field.</summary>
    public const int RewardEventFieldNumber = 2;
    private global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo rewardEvent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo RewardEvent {
      get { return rewardEvent_; }
      set {
        rewardEvent_ = value;
      }
    }

    /// <summary>Field number for the "pending_list" field.</summary>
    public const int PendingListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo> _repeated_pendingList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo> pendingList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo> PendingList {
      get { return pendingList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeAvatarRewardEventNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeAvatarRewardEventNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsEventTrigger != other.IsEventTrigger) return false;
      if (!object.Equals(RewardEvent, other.RewardEvent)) return false;
      if(!pendingList_.Equals(other.pendingList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsEventTrigger != false) hash ^= IsEventTrigger.GetHashCode();
      if (rewardEvent_ != null) hash ^= RewardEvent.GetHashCode();
      hash ^= pendingList_.GetHashCode();
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
      if (rewardEvent_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RewardEvent);
      }
      if (IsEventTrigger != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsEventTrigger);
      }
      pendingList_.WriteTo(output, _repeated_pendingList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (rewardEvent_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RewardEvent);
      }
      if (IsEventTrigger != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsEventTrigger);
      }
      pendingList_.WriteTo(ref output, _repeated_pendingList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsEventTrigger != false) {
        size += 1 + 1;
      }
      if (rewardEvent_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RewardEvent);
      }
      size += pendingList_.CalculateSize(_repeated_pendingList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeAvatarRewardEventNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsEventTrigger != false) {
        IsEventTrigger = other.IsEventTrigger;
      }
      if (other.rewardEvent_ != null) {
        if (rewardEvent_ == null) {
          RewardEvent = new global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo();
        }
        RewardEvent.MergeFrom(other.RewardEvent);
      }
      pendingList_.Add(other.pendingList_);
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
            if (rewardEvent_ == null) {
              RewardEvent = new global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo();
            }
            input.ReadMessage(RewardEvent);
            break;
          }
          case 32: {
            IsEventTrigger = input.ReadBool();
            break;
          }
          case 66: {
            pendingList_.AddEntriesFrom(input, _repeated_pendingList_codec);
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
            if (rewardEvent_ == null) {
              RewardEvent = new global::Weedwacker.Server.Proto.HomeAvatarRewardEventInfo();
            }
            input.ReadMessage(RewardEvent);
            break;
          }
          case 32: {
            IsEventTrigger = input.ReadBool();
            break;
          }
          case 66: {
            pendingList_.AddEntriesFrom(ref input, _repeated_pendingList_codec);
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
