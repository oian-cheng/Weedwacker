// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DraftGuestReplyTwiceConfirmNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from DraftGuestReplyTwiceConfirmNotify.proto</summary>
  public static partial class DraftGuestReplyTwiceConfirmNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DraftGuestReplyTwiceConfirmNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DraftGuestReplyTwiceConfirmNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidEcmFmdEd1ZXN0UmVwbHlUd2ljZUNvbmZpcm1Ob3RpZnkucHJvdG8iWgoh",
            "RHJhZnRHdWVzdFJlcGx5VHdpY2VDb25maXJtTm90aWZ5EhAKCGlzX2FncmVl",
            "GA4gASgIEhAKCGRyYWZ0X2lkGA8gASgNEhEKCWd1ZXN0X3VpZBgHIAEoDUIa",
            "qgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.DraftGuestReplyTwiceConfirmNotify), global::Weedwacker.Server.Proto.DraftGuestReplyTwiceConfirmNotify.Parser, new[]{ "IsAgree", "DraftId", "GuestUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5497
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DraftGuestReplyTwiceConfirmNotify : pb::IMessage<DraftGuestReplyTwiceConfirmNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DraftGuestReplyTwiceConfirmNotify> _parser = new pb::MessageParser<DraftGuestReplyTwiceConfirmNotify>(() => new DraftGuestReplyTwiceConfirmNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DraftGuestReplyTwiceConfirmNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.DraftGuestReplyTwiceConfirmNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyTwiceConfirmNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyTwiceConfirmNotify(DraftGuestReplyTwiceConfirmNotify other) : this() {
      isAgree_ = other.isAgree_;
      draftId_ = other.draftId_;
      guestUid_ = other.guestUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyTwiceConfirmNotify Clone() {
      return new DraftGuestReplyTwiceConfirmNotify(this);
    }

    /// <summary>Field number for the "is_agree" field.</summary>
    public const int IsAgreeFieldNumber = 14;
    private bool isAgree_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAgree {
      get { return isAgree_; }
      set {
        isAgree_ = value;
      }
    }

    /// <summary>Field number for the "draft_id" field.</summary>
    public const int DraftIdFieldNumber = 15;
    private uint draftId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DraftId {
      get { return draftId_; }
      set {
        draftId_ = value;
      }
    }

    /// <summary>Field number for the "guest_uid" field.</summary>
    public const int GuestUidFieldNumber = 7;
    private uint guestUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GuestUid {
      get { return guestUid_; }
      set {
        guestUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DraftGuestReplyTwiceConfirmNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DraftGuestReplyTwiceConfirmNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAgree != other.IsAgree) return false;
      if (DraftId != other.DraftId) return false;
      if (GuestUid != other.GuestUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAgree != false) hash ^= IsAgree.GetHashCode();
      if (DraftId != 0) hash ^= DraftId.GetHashCode();
      if (GuestUid != 0) hash ^= GuestUid.GetHashCode();
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
      if (GuestUid != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GuestUid);
      }
      if (IsAgree != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsAgree);
      }
      if (DraftId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DraftId);
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
      if (GuestUid != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GuestUid);
      }
      if (IsAgree != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsAgree);
      }
      if (DraftId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DraftId);
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
      if (IsAgree != false) {
        size += 1 + 1;
      }
      if (DraftId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DraftId);
      }
      if (GuestUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GuestUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DraftGuestReplyTwiceConfirmNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsAgree != false) {
        IsAgree = other.IsAgree;
      }
      if (other.DraftId != 0) {
        DraftId = other.DraftId;
      }
      if (other.GuestUid != 0) {
        GuestUid = other.GuestUid;
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
          case 56: {
            GuestUid = input.ReadUInt32();
            break;
          }
          case 112: {
            IsAgree = input.ReadBool();
            break;
          }
          case 120: {
            DraftId = input.ReadUInt32();
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
          case 56: {
            GuestUid = input.ReadUInt32();
            break;
          }
          case 112: {
            IsAgree = input.ReadBool();
            break;
          }
          case 120: {
            DraftId = input.ReadUInt32();
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
