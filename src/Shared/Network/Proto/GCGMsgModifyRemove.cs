// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgModifyRemove.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMsgModifyRemove.proto</summary>
  public static partial class GCGMsgModifyRemoveReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgModifyRemove.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgModifyRemoveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHQ0dNc2dNb2RpZnlSZW1vdmUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8aD0dDR1JlYXNvbi5wcm90byKYAQoSR0NHTXNnTW9k",
            "aWZ5UmVtb3ZlEhcKD293bmVyX2NhcmRfZ3VpZBgHIAEoDRI6CgZyZWFzb24Y",
            "AyABKA4yKi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkdDR1Jl",
            "YXNvbhIVCg1jb250cm9sbGVyX2lkGA4gASgNEhYKDmNhcmRfZ3VpZF9saXN0",
            "GA0gAygNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMsgModifyRemove), global::Weedwacker.Shared.Network.Proto.GCGMsgModifyRemove.Parser, new[]{ "OwnerCardGuid", "Reason", "ControllerId", "CardGuidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgModifyRemove : pb::IMessage<GCGMsgModifyRemove>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgModifyRemove> _parser = new pb::MessageParser<GCGMsgModifyRemove>(() => new GCGMsgModifyRemove());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgModifyRemove> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMsgModifyRemoveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyRemove() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyRemove(GCGMsgModifyRemove other) : this() {
      ownerCardGuid_ = other.ownerCardGuid_;
      reason_ = other.reason_;
      controllerId_ = other.controllerId_;
      cardGuidList_ = other.cardGuidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyRemove Clone() {
      return new GCGMsgModifyRemove(this);
    }

    /// <summary>Field number for the "owner_card_guid" field.</summary>
    public const int OwnerCardGuidFieldNumber = 7;
    private uint ownerCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerCardGuid {
      get { return ownerCardGuid_; }
      set {
        ownerCardGuid_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.GCGReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 14;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "card_guid_list" field.</summary>
    public const int CardGuidListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardGuidList {
      get { return cardGuidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgModifyRemove);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgModifyRemove other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerCardGuid != other.OwnerCardGuid) return false;
      if (Reason != other.Reason) return false;
      if (ControllerId != other.ControllerId) return false;
      if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerCardGuid != 0) hash ^= OwnerCardGuid.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) hash ^= Reason.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      hash ^= cardGuidList_.GetHashCode();
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OwnerCardGuid);
      }
      cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ControllerId);
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OwnerCardGuid);
      }
      cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ControllerId);
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
      if (OwnerCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerCardGuid);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgModifyRemove other) {
      if (other == null) {
        return;
      }
      if (other.OwnerCardGuid != 0) {
        OwnerCardGuid = other.OwnerCardGuid;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        Reason = other.Reason;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      cardGuidList_.Add(other.cardGuidList_);
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
          case 24: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
            break;
          }
          case 56: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
            break;
          }
          case 112: {
            ControllerId = input.ReadUInt32();
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
          case 24: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
            break;
          }
          case 56: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
            break;
          }
          case 112: {
            ControllerId = input.ReadUInt32();
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
