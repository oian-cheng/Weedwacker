// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarExpeditionGetRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from AvatarExpeditionGetRewardRsp.proto</summary>
  public static partial class AvatarExpeditionGetRewardRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarExpeditionGetRewardRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarExpeditionGetRewardRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBdmF0YXJFeHBlZGl0aW9uR2V0UmV3YXJkUnNwLnByb3RvGhpBdmF0YXJF",
            "eHBlZGl0aW9uSW5mby5wcm90bxoPSXRlbVBhcmFtLnByb3RvIpsCChxBdmF0",
            "YXJFeHBlZGl0aW9uR2V0UmV3YXJkUnNwEicKE1VuazI3MDBfSEJLSE9CUEdD",
            "TEgYCSADKAsyCi5JdGVtUGFyYW0SHQoJaXRlbV9saXN0GAggAygLMgouSXRl",
            "bVBhcmFtElEKE2V4cGVkaXRpb25faW5mb19tYXAYDCADKAsyNC5BdmF0YXJF",
            "eHBlZGl0aW9uR2V0UmV3YXJkUnNwLkV4cGVkaXRpb25JbmZvTWFwRW50cnkS",
            "DwoHcmV0Y29kZRgCIAEoBRpPChZFeHBlZGl0aW9uSW5mb01hcEVudHJ5EgsK",
            "A2tleRgBIAEoBBIkCgV2YWx1ZRgCIAEoCzIVLkF2YXRhckV4cGVkaXRpb25J",
            "bmZvOgI4AUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.AvatarExpeditionInfoReflection.Descriptor, global::Weedwacker.Server.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.AvatarExpeditionGetRewardRsp), global::Weedwacker.Server.Proto.AvatarExpeditionGetRewardRsp.Parser, new[]{ "Unk2700HBKHOBPGCLH", "ItemList", "ExpeditionInfoMap", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1784
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class AvatarExpeditionGetRewardRsp : pb::IMessage<AvatarExpeditionGetRewardRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarExpeditionGetRewardRsp> _parser = new pb::MessageParser<AvatarExpeditionGetRewardRsp>(() => new AvatarExpeditionGetRewardRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarExpeditionGetRewardRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.AvatarExpeditionGetRewardRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExpeditionGetRewardRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExpeditionGetRewardRsp(AvatarExpeditionGetRewardRsp other) : this() {
      unk2700HBKHOBPGCLH_ = other.unk2700HBKHOBPGCLH_.Clone();
      itemList_ = other.itemList_.Clone();
      expeditionInfoMap_ = other.expeditionInfoMap_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExpeditionGetRewardRsp Clone() {
      return new AvatarExpeditionGetRewardRsp(this);
    }

    /// <summary>Field number for the "Unk2700_HBKHOBPGCLH" field.</summary>
    public const int Unk2700HBKHOBPGCLHFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemParam> _repeated_unk2700HBKHOBPGCLH_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Server.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> unk2700HBKHOBPGCLH_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> Unk2700HBKHOBPGCLH {
      get { return unk2700HBKHOBPGCLH_; }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemParam> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Server.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> itemList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "expedition_info_map" field.</summary>
    public const int ExpeditionInfoMapFieldNumber = 12;
    private static readonly pbc::MapField<ulong, global::Weedwacker.Server.Proto.AvatarExpeditionInfo>.Codec _map_expeditionInfoMap_codec
        = new pbc::MapField<ulong, global::Weedwacker.Server.Proto.AvatarExpeditionInfo>.Codec(pb::FieldCodec.ForUInt64(8, 0UL), pb::FieldCodec.ForMessage(18, global::Weedwacker.Server.Proto.AvatarExpeditionInfo.Parser), 98);
    private readonly pbc::MapField<ulong, global::Weedwacker.Server.Proto.AvatarExpeditionInfo> expeditionInfoMap_ = new pbc::MapField<ulong, global::Weedwacker.Server.Proto.AvatarExpeditionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<ulong, global::Weedwacker.Server.Proto.AvatarExpeditionInfo> ExpeditionInfoMap {
      get { return expeditionInfoMap_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarExpeditionGetRewardRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarExpeditionGetRewardRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700HBKHOBPGCLH_.Equals(other.unk2700HBKHOBPGCLH_)) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (!ExpeditionInfoMap.Equals(other.ExpeditionInfoMap)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700HBKHOBPGCLH_.GetHashCode();
      hash ^= itemList_.GetHashCode();
      hash ^= ExpeditionInfoMap.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      unk2700HBKHOBPGCLH_.WriteTo(output, _repeated_unk2700HBKHOBPGCLH_codec);
      expeditionInfoMap_.WriteTo(output, _map_expeditionInfoMap_codec);
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
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      unk2700HBKHOBPGCLH_.WriteTo(ref output, _repeated_unk2700HBKHOBPGCLH_codec);
      expeditionInfoMap_.WriteTo(ref output, _map_expeditionInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700HBKHOBPGCLH_.CalculateSize(_repeated_unk2700HBKHOBPGCLH_codec);
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      size += expeditionInfoMap_.CalculateSize(_map_expeditionInfoMap_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarExpeditionGetRewardRsp other) {
      if (other == null) {
        return;
      }
      unk2700HBKHOBPGCLH_.Add(other.unk2700HBKHOBPGCLH_);
      itemList_.Add(other.itemList_);
      expeditionInfoMap_.Add(other.expeditionInfoMap_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 16: {
            Retcode = input.ReadInt32();
            break;
          }
          case 66: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 74: {
            unk2700HBKHOBPGCLH_.AddEntriesFrom(input, _repeated_unk2700HBKHOBPGCLH_codec);
            break;
          }
          case 98: {
            expeditionInfoMap_.AddEntriesFrom(input, _map_expeditionInfoMap_codec);
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
          case 16: {
            Retcode = input.ReadInt32();
            break;
          }
          case 66: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 74: {
            unk2700HBKHOBPGCLH_.AddEntriesFrom(ref input, _repeated_unk2700HBKHOBPGCLH_codec);
            break;
          }
          case 98: {
            expeditionInfoMap_.AddEntriesFrom(ref input, _map_expeditionInfoMap_codec);
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
