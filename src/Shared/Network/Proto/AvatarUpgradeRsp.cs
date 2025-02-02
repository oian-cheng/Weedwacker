// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarUpgradeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarUpgradeRsp.proto</summary>
  public static partial class AvatarUpgradeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarUpgradeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarUpgradeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZBdmF0YXJVcGdyYWRlUnNwLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvIqQDChBBdmF0YXJVcGdyYWRlUnNwEg8KB3JldGNvZGUY",
            "CCABKAUSEwoLYXZhdGFyX2d1aWQYDiABKAQSEQoJY3VyX2xldmVsGAkgASgN",
            "EmYKE1VuazMzMDBfT0lNUEZDRENER0EYDSADKAsySS5XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvLkF2YXRhclVwZ3JhZGVSc3AuVW5rMzMwME9J",
            "TVBGQ0RDREdBRW50cnkSZgoTVW5rMzMwMF9CRk5ISE5LT0xCSBgGIAMoCzJJ",
            "LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uQXZhdGFyVXBncmFk",
            "ZVJzcC5VbmszMzAwQkZOSEhOS09MQkhFbnRyeRIRCglvbGRfbGV2ZWwYDCAB",
            "KA0aOQoXVW5rMzMwME9JTVBGQ0RDREdBRW50cnkSCwoDa2V5GAEgASgNEg0K",
            "BXZhbHVlGAIgASgCOgI4ARo5ChdVbmszMzAwQkZOSEhOS09MQkhFbnRyeRIL",
            "CgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAI6AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarUpgradeRsp), global::Weedwacker.Shared.Network.Proto.AvatarUpgradeRsp.Parser, new[]{ "Retcode", "AvatarGuid", "CurLevel", "Unk3300OIMPFCDCDGA", "Unk3300BFNHHNKOLBH", "OldLevel" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1792;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AvatarUpgradeRsp : pb::IMessage<AvatarUpgradeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarUpgradeRsp> _parser = new pb::MessageParser<AvatarUpgradeRsp>(() => new AvatarUpgradeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarUpgradeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarUpgradeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp(AvatarUpgradeRsp other) : this() {
      retcode_ = other.retcode_;
      avatarGuid_ = other.avatarGuid_;
      curLevel_ = other.curLevel_;
      unk3300OIMPFCDCDGA_ = other.unk3300OIMPFCDCDGA_.Clone();
      unk3300BFNHHNKOLBH_ = other.unk3300BFNHHNKOLBH_.Clone();
      oldLevel_ = other.oldLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp Clone() {
      return new AvatarUpgradeRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 14;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 9;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OIMPFCDCDGA" field.</summary>
    public const int Unk3300OIMPFCDCDGAFieldNumber = 13;
    private static readonly pbc::MapField<uint, float>.Codec _map_unk3300OIMPFCDCDGA_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 106);
    private readonly pbc::MapField<uint, float> unk3300OIMPFCDCDGA_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> Unk3300OIMPFCDCDGA {
      get { return unk3300OIMPFCDCDGA_; }
    }

    /// <summary>Field number for the "Unk3300_BFNHHNKOLBH" field.</summary>
    public const int Unk3300BFNHHNKOLBHFieldNumber = 6;
    private static readonly pbc::MapField<uint, float>.Codec _map_unk3300BFNHHNKOLBH_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 50);
    private readonly pbc::MapField<uint, float> unk3300BFNHHNKOLBH_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> Unk3300BFNHHNKOLBH {
      get { return unk3300BFNHHNKOLBH_; }
    }

    /// <summary>Field number for the "old_level" field.</summary>
    public const int OldLevelFieldNumber = 12;
    private uint oldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldLevel {
      get { return oldLevel_; }
      set {
        oldLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarUpgradeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarUpgradeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      if (CurLevel != other.CurLevel) return false;
      if (!Unk3300OIMPFCDCDGA.Equals(other.Unk3300OIMPFCDCDGA)) return false;
      if (!Unk3300BFNHHNKOLBH.Equals(other.Unk3300BFNHHNKOLBH)) return false;
      if (OldLevel != other.OldLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      hash ^= Unk3300OIMPFCDCDGA.GetHashCode();
      hash ^= Unk3300BFNHHNKOLBH.GetHashCode();
      if (OldLevel != 0) hash ^= OldLevel.GetHashCode();
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
      unk3300BFNHHNKOLBH_.WriteTo(output, _map_unk3300BFNHHNKOLBH_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurLevel);
      }
      if (OldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OldLevel);
      }
      unk3300OIMPFCDCDGA_.WriteTo(output, _map_unk3300OIMPFCDCDGA_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(AvatarGuid);
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
      unk3300BFNHHNKOLBH_.WriteTo(ref output, _map_unk3300BFNHHNKOLBH_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurLevel);
      }
      if (OldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OldLevel);
      }
      unk3300OIMPFCDCDGA_.WriteTo(ref output, _map_unk3300OIMPFCDCDGA_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(AvatarGuid);
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
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      size += unk3300OIMPFCDCDGA_.CalculateSize(_map_unk3300OIMPFCDCDGA_codec);
      size += unk3300BFNHHNKOLBH_.CalculateSize(_map_unk3300BFNHHNKOLBH_codec);
      if (OldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarUpgradeRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      unk3300OIMPFCDCDGA_.Add(other.unk3300OIMPFCDCDGA_);
      unk3300BFNHHNKOLBH_.Add(other.unk3300BFNHHNKOLBH_);
      if (other.OldLevel != 0) {
        OldLevel = other.OldLevel;
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
          case 50: {
            unk3300BFNHHNKOLBH_.AddEntriesFrom(input, _map_unk3300BFNHHNKOLBH_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 106: {
            unk3300OIMPFCDCDGA_.AddEntriesFrom(input, _map_unk3300OIMPFCDCDGA_codec);
            break;
          }
          case 112: {
            AvatarGuid = input.ReadUInt64();
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
          case 50: {
            unk3300BFNHHNKOLBH_.AddEntriesFrom(ref input, _map_unk3300BFNHHNKOLBH_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 106: {
            unk3300OIMPFCDCDGA_.AddEntriesFrom(ref input, _map_unk3300OIMPFCDCDGA_codec);
            break;
          }
          case 112: {
            AvatarGuid = input.ReadUInt64();
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
