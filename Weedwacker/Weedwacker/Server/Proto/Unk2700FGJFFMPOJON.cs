// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_FGJFFMPOJON.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_FGJFFMPOJON.proto</summary>
  public static partial class Unk2700FGJFFMPOJONReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_FGJFFMPOJON.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700FGJFFMPOJONReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0ZHSkZGTVBPSk9OLnByb3RvGhRQcm9maWxlUGljdHVyZS5w",
            "cm90byL5AQoTVW5rMjcwMF9GR0pGRk1QT0pPThIQCghuaWNrbmFtZRgHIAEo",
            "CRITCgtyZW1hcmtfbmFtZRgDIAEoCRIoCg9wcm9maWxlX3BpY3R1cmUYCyAB",
            "KAsyDy5Qcm9maWxlUGljdHVyZRJJChNVbmsyNzAwX0lGQ05HSVBQT0FFGAkg",
            "AygLMiwuVW5rMjcwMF9GR0pGRk1QT0pPTi5VbmsyNzAwSUZDTkdJUFBPQUVF",
            "bnRyeRILCgN1aWQYCCABKA0aOQoXVW5rMjcwMElGQ05HSVBQT0FFRW50cnkS",
            "CwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIaqgIXV2VlZHdhY2tl",
            "ci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_FGJFFMPOJON), global::Weedwacker.Server.Proto.Unk2700_FGJFFMPOJON.Parser, new[]{ "Nickname", "RemarkName", "ProfilePicture", "Unk2700IFCNGIPPOAE", "Uid" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_FGJFFMPOJON : pb::IMessage<Unk2700_FGJFFMPOJON>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_FGJFFMPOJON> _parser = new pb::MessageParser<Unk2700_FGJFFMPOJON>(() => new Unk2700_FGJFFMPOJON());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_FGJFFMPOJON> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700FGJFFMPOJONReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_FGJFFMPOJON() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_FGJFFMPOJON(Unk2700_FGJFFMPOJON other) : this() {
      nickname_ = other.nickname_;
      remarkName_ = other.remarkName_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      unk2700IFCNGIPPOAE_ = other.unk2700IFCNGIPPOAE_.Clone();
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_FGJFFMPOJON Clone() {
      return new Unk2700_FGJFFMPOJON(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 7;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 3;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 11;
    private global::Weedwacker.Server.Proto.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_IFCNGIPPOAE" field.</summary>
    public const int Unk2700IFCNGIPPOAEFieldNumber = 9;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk2700IFCNGIPPOAE_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
    private readonly pbc::MapField<uint, uint> unk2700IFCNGIPPOAE_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk2700IFCNGIPPOAE {
      get { return unk2700IFCNGIPPOAE_; }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 8;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_FGJFFMPOJON);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_FGJFFMPOJON other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      if (RemarkName != other.RemarkName) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (!Unk2700IFCNGIPPOAE.Equals(other.Unk2700IFCNGIPPOAE)) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      hash ^= Unk2700IFCNGIPPOAE.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      if (RemarkName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RemarkName);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Uid);
      }
      unk2700IFCNGIPPOAE_.WriteTo(output, _map_unk2700IFCNGIPPOAE_codec);
      if (profilePicture_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ProfilePicture);
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
      if (RemarkName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RemarkName);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Uid);
      }
      unk2700IFCNGIPPOAE_.WriteTo(ref output, _map_unk2700IFCNGIPPOAE_codec);
      if (profilePicture_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(ProfilePicture);
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
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (RemarkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      size += unk2700IFCNGIPPOAE_.CalculateSize(_map_unk2700IFCNGIPPOAE_codec);
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_FGJFFMPOJON other) {
      if (other == null) {
        return;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::Weedwacker.Server.Proto.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      unk2700IFCNGIPPOAE_.Add(other.unk2700IFCNGIPPOAE_);
      if (other.Uid != 0) {
        Uid = other.Uid;
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
            RemarkName = input.ReadString();
            break;
          }
          case 58: {
            Nickname = input.ReadString();
            break;
          }
          case 64: {
            Uid = input.ReadUInt32();
            break;
          }
          case 74: {
            unk2700IFCNGIPPOAE_.AddEntriesFrom(input, _map_unk2700IFCNGIPPOAE_codec);
            break;
          }
          case 90: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Server.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
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
            RemarkName = input.ReadString();
            break;
          }
          case 58: {
            Nickname = input.ReadString();
            break;
          }
          case 64: {
            Uid = input.ReadUInt32();
            break;
          }
          case 74: {
            unk2700IFCNGIPPOAE_.AddEntriesFrom(ref input, _map_unk2700IFCNGIPPOAE_codec);
            break;
          }
          case 90: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Server.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
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
