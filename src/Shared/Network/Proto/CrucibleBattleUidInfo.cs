// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrucibleBattleUidInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CrucibleBattleUidInfo.proto</summary>
  public static partial class CrucibleBattleUidInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CrucibleBattleUidInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrucibleBattleUidInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtDcnVjaWJsZUJhdHRsZVVpZEluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aFFByb2ZpbGVQaWN0dXJlLnByb3RvIqEBChVD",
            "cnVjaWJsZUJhdHRsZVVpZEluZm8SSAoPcHJvZmlsZV9waWN0dXJlGAggASgL",
            "Mi8uV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Qcm9maWxlUGlj",
            "dHVyZRILCgN1aWQYDiABKA0SDAoEaWNvbhgEIAEoDRIRCglvbmxpbmVfaWQY",
            "DSABKAkSEAoIbmlja25hbWUYAyABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CrucibleBattleUidInfo), global::Weedwacker.Shared.Network.Proto.CrucibleBattleUidInfo.Parser, new[]{ "ProfilePicture", "Uid", "Icon", "OnlineId", "Nickname" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CrucibleBattleUidInfo : pb::IMessage<CrucibleBattleUidInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CrucibleBattleUidInfo> _parser = new pb::MessageParser<CrucibleBattleUidInfo>(() => new CrucibleBattleUidInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CrucibleBattleUidInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CrucibleBattleUidInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrucibleBattleUidInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrucibleBattleUidInfo(CrucibleBattleUidInfo other) : this() {
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      uid_ = other.uid_;
      icon_ = other.icon_;
      onlineId_ = other.onlineId_;
      nickname_ = other.nickname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrucibleBattleUidInfo Clone() {
      return new CrucibleBattleUidInfo(this);
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 14;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "icon" field.</summary>
    public const int IconFieldNumber = 4;
    private uint icon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Icon {
      get { return icon_; }
      set {
        icon_ = value;
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

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 3;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CrucibleBattleUidInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CrucibleBattleUidInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Uid != other.Uid) return false;
      if (Icon != other.Icon) return false;
      if (OnlineId != other.OnlineId) return false;
      if (Nickname != other.Nickname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Icon != 0) hash ^= Icon.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (Icon != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Icon);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ProfilePicture);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(OnlineId);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Nickname);
      }
      if (Icon != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Icon);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ProfilePicture);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(OnlineId);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
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
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Icon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Icon);
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CrucibleBattleUidInfo other) {
      if (other == null) {
        return;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Icon != 0) {
        Icon = other.Icon;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
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
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            Icon = input.ReadUInt32();
            break;
          }
          case 66: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 106: {
            OnlineId = input.ReadString();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
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
          case 26: {
            Nickname = input.ReadString();
            break;
          }
          case 32: {
            Icon = input.ReadUInt32();
            break;
          }
          case 66: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 106: {
            OnlineId = input.ReadString();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
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
