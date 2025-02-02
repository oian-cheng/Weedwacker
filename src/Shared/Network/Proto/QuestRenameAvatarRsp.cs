// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestRenameAvatarRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from QuestRenameAvatarRsp.proto</summary>
  public static partial class QuestRenameAvatarRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestRenameAvatarRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestRenameAvatarRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpRdWVzdFJlbmFtZUF2YXRhclJzcC5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byJhChRRdWVzdFJlbmFtZUF2YXRhclJzcBIPCgdy",
            "ZXRjb2RlGAsgASgFEhAKCGlzX2NoZWNrGAQgASgIEhEKCXJlbmFtZV9pZBgP",
            "IAEoDRITCgthdmF0YXJfbmFtZRgIIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.QuestRenameAvatarRsp), global::Weedwacker.Shared.Network.Proto.QuestRenameAvatarRsp.Parser, new[]{ "Retcode", "IsCheck", "RenameId", "AvatarName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 485;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class QuestRenameAvatarRsp : pb::IMessage<QuestRenameAvatarRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestRenameAvatarRsp> _parser = new pb::MessageParser<QuestRenameAvatarRsp>(() => new QuestRenameAvatarRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestRenameAvatarRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.QuestRenameAvatarRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestRenameAvatarRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestRenameAvatarRsp(QuestRenameAvatarRsp other) : this() {
      retcode_ = other.retcode_;
      isCheck_ = other.isCheck_;
      renameId_ = other.renameId_;
      avatarName_ = other.avatarName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestRenameAvatarRsp Clone() {
      return new QuestRenameAvatarRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "is_check" field.</summary>
    public const int IsCheckFieldNumber = 4;
    private bool isCheck_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCheck {
      get { return isCheck_; }
      set {
        isCheck_ = value;
      }
    }

    /// <summary>Field number for the "rename_id" field.</summary>
    public const int RenameIdFieldNumber = 15;
    private uint renameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RenameId {
      get { return renameId_; }
      set {
        renameId_ = value;
      }
    }

    /// <summary>Field number for the "avatar_name" field.</summary>
    public const int AvatarNameFieldNumber = 8;
    private string avatarName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AvatarName {
      get { return avatarName_; }
      set {
        avatarName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestRenameAvatarRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestRenameAvatarRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (IsCheck != other.IsCheck) return false;
      if (RenameId != other.RenameId) return false;
      if (AvatarName != other.AvatarName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (IsCheck != false) hash ^= IsCheck.GetHashCode();
      if (RenameId != 0) hash ^= RenameId.GetHashCode();
      if (AvatarName.Length != 0) hash ^= AvatarName.GetHashCode();
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
      if (IsCheck != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCheck);
      }
      if (AvatarName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(AvatarName);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (RenameId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RenameId);
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
      if (IsCheck != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCheck);
      }
      if (AvatarName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(AvatarName);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (RenameId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RenameId);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (IsCheck != false) {
        size += 1 + 1;
      }
      if (RenameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RenameId);
      }
      if (AvatarName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestRenameAvatarRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.IsCheck != false) {
        IsCheck = other.IsCheck;
      }
      if (other.RenameId != 0) {
        RenameId = other.RenameId;
      }
      if (other.AvatarName.Length != 0) {
        AvatarName = other.AvatarName;
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
            IsCheck = input.ReadBool();
            break;
          }
          case 66: {
            AvatarName = input.ReadString();
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            RenameId = input.ReadUInt32();
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
            IsCheck = input.ReadBool();
            break;
          }
          case 66: {
            AvatarName = input.ReadString();
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            RenameId = input.ReadUInt32();
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
