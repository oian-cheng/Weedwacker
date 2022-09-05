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
namespace Weedwacker.Server.Proto {

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
            "ChZBdmF0YXJVcGdyYWRlUnNwLnByb3RvItYCChBBdmF0YXJVcGdyYWRlUnNw",
            "EhEKCWN1cl9sZXZlbBgGIAEoDRIRCglvbGRfbGV2ZWwYDSABKA0SQgoSb2xk",
            "X2ZpZ2h0X3Byb3BfbWFwGAogAygLMiYuQXZhdGFyVXBncmFkZVJzcC5PbGRG",
            "aWdodFByb3BNYXBFbnRyeRIPCgdyZXRjb2RlGAEgASgFEkIKEmN1cl9maWdo",
            "dF9wcm9wX21hcBgEIAMoCzImLkF2YXRhclVwZ3JhZGVSc3AuQ3VyRmlnaHRQ",
            "cm9wTWFwRW50cnkSEwoLYXZhdGFyX2d1aWQYDyABKAQaNgoUT2xkRmlnaHRQ",
            "cm9wTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgCOgI4ARo2",
            "ChRDdXJGaWdodFByb3BNYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY",
            "AiABKAI6AjgBQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.AvatarUpgradeRsp), global::Weedwacker.Server.Proto.AvatarUpgradeRsp.Parser, new[]{ "CurLevel", "OldLevel", "OldFightPropMap", "Retcode", "CurFightPropMap", "AvatarGuid" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1701
  /// EnetChannelId: 0
  /// EnetIsReliable: true
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
      get { return global::Weedwacker.Server.Proto.AvatarUpgradeRspReflection.Descriptor.MessageTypes[0]; }
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
      curLevel_ = other.curLevel_;
      oldLevel_ = other.oldLevel_;
      oldFightPropMap_ = other.oldFightPropMap_.Clone();
      retcode_ = other.retcode_;
      curFightPropMap_ = other.curFightPropMap_.Clone();
      avatarGuid_ = other.avatarGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp Clone() {
      return new AvatarUpgradeRsp(this);
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 6;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_level" field.</summary>
    public const int OldLevelFieldNumber = 13;
    private uint oldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldLevel {
      get { return oldLevel_; }
      set {
        oldLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_fight_prop_map" field.</summary>
    public const int OldFightPropMapFieldNumber = 10;
    private static readonly pbc::MapField<uint, float>.Codec _map_oldFightPropMap_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 82);
    private readonly pbc::MapField<uint, float> oldFightPropMap_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> OldFightPropMap {
      get { return oldFightPropMap_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cur_fight_prop_map" field.</summary>
    public const int CurFightPropMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, float>.Codec _map_curFightPropMap_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 34);
    private readonly pbc::MapField<uint, float> curFightPropMap_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> CurFightPropMap {
      get { return curFightPropMap_; }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 15;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
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
      if (CurLevel != other.CurLevel) return false;
      if (OldLevel != other.OldLevel) return false;
      if (!OldFightPropMap.Equals(other.OldFightPropMap)) return false;
      if (Retcode != other.Retcode) return false;
      if (!CurFightPropMap.Equals(other.CurFightPropMap)) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      if (OldLevel != 0) hash ^= OldLevel.GetHashCode();
      hash ^= OldFightPropMap.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= CurFightPropMap.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      curFightPropMap_.WriteTo(output, _map_curFightPropMap_codec);
      if (CurLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurLevel);
      }
      oldFightPropMap_.WriteTo(output, _map_oldFightPropMap_codec);
      if (OldLevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(120);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      curFightPropMap_.WriteTo(ref output, _map_curFightPropMap_codec);
      if (CurLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurLevel);
      }
      oldFightPropMap_.WriteTo(ref output, _map_oldFightPropMap_codec);
      if (OldLevel != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(120);
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
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      if (OldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldLevel);
      }
      size += oldFightPropMap_.CalculateSize(_map_oldFightPropMap_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += curFightPropMap_.CalculateSize(_map_curFightPropMap_codec);
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
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
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      if (other.OldLevel != 0) {
        OldLevel = other.OldLevel;
      }
      oldFightPropMap_.Add(other.oldFightPropMap_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      curFightPropMap_.Add(other.curFightPropMap_);
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 34: {
            curFightPropMap_.AddEntriesFrom(input, _map_curFightPropMap_codec);
            break;
          }
          case 48: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 82: {
            oldFightPropMap_.AddEntriesFrom(input, _map_oldFightPropMap_codec);
            break;
          }
          case 104: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 120: {
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
          case 8: {
            Retcode = input.ReadInt32();
            break;
          }
          case 34: {
            curFightPropMap_.AddEntriesFrom(ref input, _map_curFightPropMap_codec);
            break;
          }
          case 48: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 82: {
            oldFightPropMap_.AddEntriesFrom(ref input, _map_oldFightPropMap_codec);
            break;
          }
          case 104: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 120: {
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
