// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonBriefMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonBriefMuipData.proto</summary>
  public static partial class CustomDungeonBriefMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonBriefMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonBriefMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBDdXN0b21EdW5nZW9uQnJpZWZNdWlwRGF0YS5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90bxojQ3VzdG9tRHVuZ2VvbkFic3RyYWN0",
            "TXVpcERhdGEucHJvdG8aIkN1c3RvbUR1bmdlb25TZXR0aW5nTXVpcERhdGEu",
            "cHJvdG8aIUN1c3RvbUR1bmdlb25Tb2NpYWxNdWlwRGF0YS5wcm90byLiAgoa",
            "Q3VzdG9tRHVuZ2VvbkJyaWVmTXVpcERhdGESFAoMZHVuZ2Vvbl9ndWlkGAEg",
            "ASgEEhIKCmR1bmdlb25faWQYAiABKA0SGAoQY3JlYXRvcl9uaWNrbmFtZRgD",
            "IAEoCRIQCgh0YWdfbGlzdBgEIAMoDRJOCgdzZXR0aW5nGAUgASgLMj0uV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5DdXN0b21EdW5nZW9uU2V0",
            "dGluZ011aXBEYXRhElAKCGFic3RyYWN0GAYgASgLMj4uV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90by5DdXN0b21EdW5nZW9uQWJzdHJhY3RNdWlw",
            "RGF0YRJMCgZzb2NpYWwYByABKAsyPC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvLkN1c3RvbUR1bmdlb25Tb2NpYWxNdWlwRGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingMuipDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialMuipDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonBriefMuipData), global::Weedwacker.Shared.Network.Proto.CustomDungeonBriefMuipData.Parser, new[]{ "DungeonGuid", "DungeonId", "CreatorNickname", "TagList", "Setting", "Abstract", "Social" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonBriefMuipData : pb::IMessage<CustomDungeonBriefMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonBriefMuipData> _parser = new pb::MessageParser<CustomDungeonBriefMuipData>(() => new CustomDungeonBriefMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonBriefMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonBriefMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBriefMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBriefMuipData(CustomDungeonBriefMuipData other) : this() {
      dungeonGuid_ = other.dungeonGuid_;
      dungeonId_ = other.dungeonId_;
      creatorNickname_ = other.creatorNickname_;
      tagList_ = other.tagList_.Clone();
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      abstract_ = other.abstract_ != null ? other.abstract_.Clone() : null;
      social_ = other.social_ != null ? other.social_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBriefMuipData Clone() {
      return new CustomDungeonBriefMuipData(this);
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 1;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 2;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "creator_nickname" field.</summary>
    public const int CreatorNicknameFieldNumber = 3;
    private string creatorNickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CreatorNickname {
      get { return creatorNickname_; }
      set {
        creatorNickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TagList {
      get { return tagList_; }
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingMuipData setting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingMuipData Setting {
      get { return setting_; }
      set {
        setting_ = value;
      }
    }

    /// <summary>Field number for the "abstract" field.</summary>
    public const int AbstractFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData abstract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData Abstract {
      get { return abstract_; }
      set {
        abstract_ = value;
      }
    }

    /// <summary>Field number for the "social" field.</summary>
    public const int SocialFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialMuipData social_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialMuipData Social {
      get { return social_; }
      set {
        social_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonBriefMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonBriefMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DungeonGuid != other.DungeonGuid) return false;
      if (DungeonId != other.DungeonId) return false;
      if (CreatorNickname != other.CreatorNickname) return false;
      if(!tagList_.Equals(other.tagList_)) return false;
      if (!object.Equals(Setting, other.Setting)) return false;
      if (!object.Equals(Abstract, other.Abstract)) return false;
      if (!object.Equals(Social, other.Social)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (CreatorNickname.Length != 0) hash ^= CreatorNickname.GetHashCode();
      hash ^= tagList_.GetHashCode();
      if (setting_ != null) hash ^= Setting.GetHashCode();
      if (abstract_ != null) hash ^= Abstract.GetHashCode();
      if (social_ != null) hash ^= Social.GetHashCode();
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
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DungeonGuid);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonId);
      }
      if (CreatorNickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CreatorNickname);
      }
      tagList_.WriteTo(output, _repeated_tagList_codec);
      if (setting_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Setting);
      }
      if (abstract_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Abstract);
      }
      if (social_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Social);
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
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DungeonGuid);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonId);
      }
      if (CreatorNickname.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CreatorNickname);
      }
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (setting_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Setting);
      }
      if (abstract_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Abstract);
      }
      if (social_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Social);
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
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (CreatorNickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreatorNickname);
      }
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      if (abstract_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Abstract);
      }
      if (social_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Social);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonBriefMuipData other) {
      if (other == null) {
        return;
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.CreatorNickname.Length != 0) {
        CreatorNickname = other.CreatorNickname;
      }
      tagList_.Add(other.tagList_);
      if (other.setting_ != null) {
        if (setting_ == null) {
          Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingMuipData();
        }
        Setting.MergeFrom(other.Setting);
      }
      if (other.abstract_ != null) {
        if (abstract_ == null) {
          Abstract = new global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData();
        }
        Abstract.MergeFrom(other.Abstract);
      }
      if (other.social_ != null) {
        if (social_ == null) {
          Social = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialMuipData();
        }
        Social.MergeFrom(other.Social);
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
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 16: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 26: {
            CreatorNickname = input.ReadString();
            break;
          }
          case 34:
          case 32: {
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
            break;
          }
          case 42: {
            if (setting_ == null) {
              Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingMuipData();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 50: {
            if (abstract_ == null) {
              Abstract = new global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 58: {
            if (social_ == null) {
              Social = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialMuipData();
            }
            input.ReadMessage(Social);
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
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 16: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 26: {
            CreatorNickname = input.ReadString();
            break;
          }
          case 34:
          case 32: {
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
            break;
          }
          case 42: {
            if (setting_ == null) {
              Setting = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSettingMuipData();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 50: {
            if (abstract_ == null) {
              Abstract = new global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 58: {
            if (social_ == null) {
              Social = new global::Weedwacker.Shared.Network.Proto.CustomDungeonSocialMuipData();
            }
            input.ReadMessage(Social);
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
