// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionAssistInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ExpeditionAssistInfo.proto</summary>
  public static partial class ExpeditionAssistInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ExpeditionAssistInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpeditionAssistInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFeHBlZGl0aW9uQXNzaXN0SW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byJ/ChRFeHBlZGl0aW9uQXNzaXN0SW5mbxIYChB0",
            "YXJnZXRfbmlja19uYW1lGAEgASgJEhIKCmNvc3R1bWVfaWQYByABKA0SEwoL",
            "YXNzaXN0X3RpbWUYDCABKA0SEQoJYXZhdGFyX2lkGAUgASgNEhEKCW9ubGlu",
            "ZV9pZBgNIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ExpeditionAssistInfo), global::Weedwacker.Shared.Network.Proto.ExpeditionAssistInfo.Parser, new[]{ "TargetNickName", "CostumeId", "AssistTime", "AvatarId", "OnlineId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExpeditionAssistInfo : pb::IMessage<ExpeditionAssistInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExpeditionAssistInfo> _parser = new pb::MessageParser<ExpeditionAssistInfo>(() => new ExpeditionAssistInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExpeditionAssistInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ExpeditionAssistInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionAssistInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionAssistInfo(ExpeditionAssistInfo other) : this() {
      targetNickName_ = other.targetNickName_;
      costumeId_ = other.costumeId_;
      assistTime_ = other.assistTime_;
      avatarId_ = other.avatarId_;
      onlineId_ = other.onlineId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExpeditionAssistInfo Clone() {
      return new ExpeditionAssistInfo(this);
    }

    /// <summary>Field number for the "target_nick_name" field.</summary>
    public const int TargetNickNameFieldNumber = 1;
    private string targetNickName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetNickName {
      get { return targetNickName_; }
      set {
        targetNickName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "costume_id" field.</summary>
    public const int CostumeIdFieldNumber = 7;
    private uint costumeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostumeId {
      get { return costumeId_; }
      set {
        costumeId_ = value;
      }
    }

    /// <summary>Field number for the "assist_time" field.</summary>
    public const int AssistTimeFieldNumber = 12;
    private uint assistTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistTime {
      get { return assistTime_; }
      set {
        assistTime_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 5;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "online_id" field.</summary>
    public const int OnlineIdFieldNumber = 13;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExpeditionAssistInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExpeditionAssistInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetNickName != other.TargetNickName) return false;
      if (CostumeId != other.CostumeId) return false;
      if (AssistTime != other.AssistTime) return false;
      if (AvatarId != other.AvatarId) return false;
      if (OnlineId != other.OnlineId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetNickName.Length != 0) hash ^= TargetNickName.GetHashCode();
      if (CostumeId != 0) hash ^= CostumeId.GetHashCode();
      if (AssistTime != 0) hash ^= AssistTime.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
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
      if (TargetNickName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TargetNickName);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AvatarId);
      }
      if (CostumeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CostumeId);
      }
      if (AssistTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AssistTime);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(OnlineId);
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
      if (TargetNickName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TargetNickName);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AvatarId);
      }
      if (CostumeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CostumeId);
      }
      if (AssistTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AssistTime);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(OnlineId);
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
      if (TargetNickName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetNickName);
      }
      if (CostumeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostumeId);
      }
      if (AssistTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistTime);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExpeditionAssistInfo other) {
      if (other == null) {
        return;
      }
      if (other.TargetNickName.Length != 0) {
        TargetNickName = other.TargetNickName;
      }
      if (other.CostumeId != 0) {
        CostumeId = other.CostumeId;
      }
      if (other.AssistTime != 0) {
        AssistTime = other.AssistTime;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
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
          case 10: {
            TargetNickName = input.ReadString();
            break;
          }
          case 40: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 56: {
            CostumeId = input.ReadUInt32();
            break;
          }
          case 96: {
            AssistTime = input.ReadUInt32();
            break;
          }
          case 106: {
            OnlineId = input.ReadString();
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
          case 10: {
            TargetNickName = input.ReadString();
            break;
          }
          case 40: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 56: {
            CostumeId = input.ReadUInt32();
            break;
          }
          case 96: {
            AssistTime = input.ReadUInt32();
            break;
          }
          case 106: {
            OnlineId = input.ReadString();
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
