// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeSceneArrangementInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeSceneArrangementInfo.proto</summary>
  public static partial class HomeSceneArrangementInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeSceneArrangementInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeSceneArrangementInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ib21lU2NlbmVBcnJhbmdlbWVudEluZm8ucHJvdG8SH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8aHkhvbWVCbG9ja0FycmFuZ2VtZW50SW5m",
            "by5wcm90bxoXSG9tZUZ1cm5pdHVyZURhdGEucHJvdG8aDFZlY3Rvci5wcm90",
            "byL9BAoYSG9tZVNjZW5lQXJyYW5nZW1lbnRJbmZvEhUKDWNvbWZvcnRfdmFs",
            "dWUYBiABKA0SXgobYmxvY2tfYXJyYW5nZW1lbnRfaW5mb19saXN0GAEgAygL",
            "MjkuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Ib21lQmxvY2tB",
            "cnJhbmdlbWVudEluZm8SFwoPaXNfc2V0X2Jvcm5fcG9zGAQgASgIEjoKCWRq",
            "aW5uX3BvcxgOIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG8uVmVjdG9yEjkKCGJvcm5fcm90GAogASgLMicuV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90by5WZWN0b3ISDgoGYmdtX2lkGAUgASgNEjkKCGJv",
            "cm5fcG9zGAsgASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5WZWN0b3ISTwoTVW5rMzMwMF9HQ0hOQU1IQlBIRxgCIAMoCzIyLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSG9tZUZ1cm5pdHVyZURhdGES",
            "RgoKbWFpbl9ob3VzZRgPIAEoCzIyLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8uSG9tZUZ1cm5pdHVyZURhdGESEAoIc2NlbmVfaWQYCCABKA0S",
            "TwoTVW5rMzMwMF9IUENIUE9ETkJQSBgJIAMoCzIyLldlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8uSG9tZUZ1cm5pdHVyZURhdGESEwoLdG1wX3Zl",
            "cnNpb24YAyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HomeFurnitureDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo), global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo.Parser, new[]{ "ComfortValue", "BlockArrangementInfoList", "IsSetBornPos", "DjinnPos", "BornRot", "BgmId", "BornPos", "Unk3300GCHNAMHBPHG", "MainHouse", "SceneId", "Unk3300HPCHPODNBPH", "TmpVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeSceneArrangementInfo : pb::IMessage<HomeSceneArrangementInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeSceneArrangementInfo> _parser = new pb::MessageParser<HomeSceneArrangementInfo>(() => new HomeSceneArrangementInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeSceneArrangementInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementInfo(HomeSceneArrangementInfo other) : this() {
      comfortValue_ = other.comfortValue_;
      blockArrangementInfoList_ = other.blockArrangementInfoList_.Clone();
      isSetBornPos_ = other.isSetBornPos_;
      djinnPos_ = other.djinnPos_ != null ? other.djinnPos_.Clone() : null;
      bornRot_ = other.bornRot_ != null ? other.bornRot_.Clone() : null;
      bgmId_ = other.bgmId_;
      bornPos_ = other.bornPos_ != null ? other.bornPos_.Clone() : null;
      unk3300GCHNAMHBPHG_ = other.unk3300GCHNAMHBPHG_.Clone();
      mainHouse_ = other.mainHouse_ != null ? other.mainHouse_.Clone() : null;
      sceneId_ = other.sceneId_;
      unk3300HPCHPODNBPH_ = other.unk3300HPCHPODNBPH_.Clone();
      tmpVersion_ = other.tmpVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementInfo Clone() {
      return new HomeSceneArrangementInfo(this);
    }

    /// <summary>Field number for the "comfort_value" field.</summary>
    public const int ComfortValueFieldNumber = 6;
    private uint comfortValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComfortValue {
      get { return comfortValue_; }
      set {
        comfortValue_ = value;
      }
    }

    /// <summary>Field number for the "block_arrangement_info_list" field.</summary>
    public const int BlockArrangementInfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo> _repeated_blockArrangementInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo> blockArrangementInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementInfo> BlockArrangementInfoList {
      get { return blockArrangementInfoList_; }
    }

    /// <summary>Field number for the "is_set_born_pos" field.</summary>
    public const int IsSetBornPosFieldNumber = 4;
    private bool isSetBornPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSetBornPos {
      get { return isSetBornPos_; }
      set {
        isSetBornPos_ = value;
      }
    }

    /// <summary>Field number for the "djinn_pos" field.</summary>
    public const int DjinnPosFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.Vector djinnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector DjinnPos {
      get { return djinnPos_; }
      set {
        djinnPos_ = value;
      }
    }

    /// <summary>Field number for the "born_rot" field.</summary>
    public const int BornRotFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.Vector bornRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector BornRot {
      get { return bornRot_; }
      set {
        bornRot_ = value;
      }
    }

    /// <summary>Field number for the "bgm_id" field.</summary>
    public const int BgmIdFieldNumber = 5;
    private uint bgmId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BgmId {
      get { return bgmId_; }
      set {
        bgmId_ = value;
      }
    }

    /// <summary>Field number for the "born_pos" field.</summary>
    public const int BornPosFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.Vector bornPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector BornPos {
      get { return bornPos_; }
      set {
        bornPos_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GCHNAMHBPHG" field.</summary>
    public const int Unk3300GCHNAMHBPHGFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> _repeated_unk3300GCHNAMHBPHG_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> unk3300GCHNAMHBPHG_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> Unk3300GCHNAMHBPHG {
      get { return unk3300GCHNAMHBPHG_; }
    }

    /// <summary>Field number for the "main_house" field.</summary>
    public const int MainHouseFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.HomeFurnitureData mainHouse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeFurnitureData MainHouse {
      get { return mainHouse_; }
      set {
        mainHouse_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 8;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HPCHPODNBPH" field.</summary>
    public const int Unk3300HPCHPODNBPHFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> _repeated_unk3300HPCHPODNBPH_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> unk3300HPCHPODNBPH_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeFurnitureData> Unk3300HPCHPODNBPH {
      get { return unk3300HPCHPODNBPH_; }
    }

    /// <summary>Field number for the "tmp_version" field.</summary>
    public const int TmpVersionFieldNumber = 3;
    private uint tmpVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TmpVersion {
      get { return tmpVersion_; }
      set {
        tmpVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeSceneArrangementInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeSceneArrangementInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ComfortValue != other.ComfortValue) return false;
      if(!blockArrangementInfoList_.Equals(other.blockArrangementInfoList_)) return false;
      if (IsSetBornPos != other.IsSetBornPos) return false;
      if (!object.Equals(DjinnPos, other.DjinnPos)) return false;
      if (!object.Equals(BornRot, other.BornRot)) return false;
      if (BgmId != other.BgmId) return false;
      if (!object.Equals(BornPos, other.BornPos)) return false;
      if(!unk3300GCHNAMHBPHG_.Equals(other.unk3300GCHNAMHBPHG_)) return false;
      if (!object.Equals(MainHouse, other.MainHouse)) return false;
      if (SceneId != other.SceneId) return false;
      if(!unk3300HPCHPODNBPH_.Equals(other.unk3300HPCHPODNBPH_)) return false;
      if (TmpVersion != other.TmpVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ComfortValue != 0) hash ^= ComfortValue.GetHashCode();
      hash ^= blockArrangementInfoList_.GetHashCode();
      if (IsSetBornPos != false) hash ^= IsSetBornPos.GetHashCode();
      if (djinnPos_ != null) hash ^= DjinnPos.GetHashCode();
      if (bornRot_ != null) hash ^= BornRot.GetHashCode();
      if (BgmId != 0) hash ^= BgmId.GetHashCode();
      if (bornPos_ != null) hash ^= BornPos.GetHashCode();
      hash ^= unk3300GCHNAMHBPHG_.GetHashCode();
      if (mainHouse_ != null) hash ^= MainHouse.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      hash ^= unk3300HPCHPODNBPH_.GetHashCode();
      if (TmpVersion != 0) hash ^= TmpVersion.GetHashCode();
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
      blockArrangementInfoList_.WriteTo(output, _repeated_blockArrangementInfoList_codec);
      unk3300GCHNAMHBPHG_.WriteTo(output, _repeated_unk3300GCHNAMHBPHG_codec);
      if (TmpVersion != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TmpVersion);
      }
      if (IsSetBornPos != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsSetBornPos);
      }
      if (BgmId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BgmId);
      }
      if (ComfortValue != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ComfortValue);
      }
      if (SceneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SceneId);
      }
      unk3300HPCHPODNBPH_.WriteTo(output, _repeated_unk3300HPCHPODNBPH_codec);
      if (bornRot_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(BornRot);
      }
      if (bornPos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BornPos);
      }
      if (djinnPos_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(DjinnPos);
      }
      if (mainHouse_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MainHouse);
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
      blockArrangementInfoList_.WriteTo(ref output, _repeated_blockArrangementInfoList_codec);
      unk3300GCHNAMHBPHG_.WriteTo(ref output, _repeated_unk3300GCHNAMHBPHG_codec);
      if (TmpVersion != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TmpVersion);
      }
      if (IsSetBornPos != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsSetBornPos);
      }
      if (BgmId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BgmId);
      }
      if (ComfortValue != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ComfortValue);
      }
      if (SceneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SceneId);
      }
      unk3300HPCHPODNBPH_.WriteTo(ref output, _repeated_unk3300HPCHPODNBPH_codec);
      if (bornRot_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(BornRot);
      }
      if (bornPos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BornPos);
      }
      if (djinnPos_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(DjinnPos);
      }
      if (mainHouse_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MainHouse);
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
      if (ComfortValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComfortValue);
      }
      size += blockArrangementInfoList_.CalculateSize(_repeated_blockArrangementInfoList_codec);
      if (IsSetBornPos != false) {
        size += 1 + 1;
      }
      if (djinnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DjinnPos);
      }
      if (bornRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BornRot);
      }
      if (BgmId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BgmId);
      }
      if (bornPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BornPos);
      }
      size += unk3300GCHNAMHBPHG_.CalculateSize(_repeated_unk3300GCHNAMHBPHG_codec);
      if (mainHouse_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MainHouse);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      size += unk3300HPCHPODNBPH_.CalculateSize(_repeated_unk3300HPCHPODNBPH_codec);
      if (TmpVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TmpVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeSceneArrangementInfo other) {
      if (other == null) {
        return;
      }
      if (other.ComfortValue != 0) {
        ComfortValue = other.ComfortValue;
      }
      blockArrangementInfoList_.Add(other.blockArrangementInfoList_);
      if (other.IsSetBornPos != false) {
        IsSetBornPos = other.IsSetBornPos;
      }
      if (other.djinnPos_ != null) {
        if (djinnPos_ == null) {
          DjinnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        DjinnPos.MergeFrom(other.DjinnPos);
      }
      if (other.bornRot_ != null) {
        if (bornRot_ == null) {
          BornRot = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        BornRot.MergeFrom(other.BornRot);
      }
      if (other.BgmId != 0) {
        BgmId = other.BgmId;
      }
      if (other.bornPos_ != null) {
        if (bornPos_ == null) {
          BornPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        BornPos.MergeFrom(other.BornPos);
      }
      unk3300GCHNAMHBPHG_.Add(other.unk3300GCHNAMHBPHG_);
      if (other.mainHouse_ != null) {
        if (mainHouse_ == null) {
          MainHouse = new global::Weedwacker.Shared.Network.Proto.HomeFurnitureData();
        }
        MainHouse.MergeFrom(other.MainHouse);
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      unk3300HPCHPODNBPH_.Add(other.unk3300HPCHPODNBPH_);
      if (other.TmpVersion != 0) {
        TmpVersion = other.TmpVersion;
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
            blockArrangementInfoList_.AddEntriesFrom(input, _repeated_blockArrangementInfoList_codec);
            break;
          }
          case 18: {
            unk3300GCHNAMHBPHG_.AddEntriesFrom(input, _repeated_unk3300GCHNAMHBPHG_codec);
            break;
          }
          case 24: {
            TmpVersion = input.ReadUInt32();
            break;
          }
          case 32: {
            IsSetBornPos = input.ReadBool();
            break;
          }
          case 40: {
            BgmId = input.ReadUInt32();
            break;
          }
          case 48: {
            ComfortValue = input.ReadUInt32();
            break;
          }
          case 64: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 74: {
            unk3300HPCHPODNBPH_.AddEntriesFrom(input, _repeated_unk3300HPCHPODNBPH_codec);
            break;
          }
          case 82: {
            if (bornRot_ == null) {
              BornRot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(BornRot);
            break;
          }
          case 90: {
            if (bornPos_ == null) {
              BornPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(BornPos);
            break;
          }
          case 114: {
            if (djinnPos_ == null) {
              DjinnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 122: {
            if (mainHouse_ == null) {
              MainHouse = new global::Weedwacker.Shared.Network.Proto.HomeFurnitureData();
            }
            input.ReadMessage(MainHouse);
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
            blockArrangementInfoList_.AddEntriesFrom(ref input, _repeated_blockArrangementInfoList_codec);
            break;
          }
          case 18: {
            unk3300GCHNAMHBPHG_.AddEntriesFrom(ref input, _repeated_unk3300GCHNAMHBPHG_codec);
            break;
          }
          case 24: {
            TmpVersion = input.ReadUInt32();
            break;
          }
          case 32: {
            IsSetBornPos = input.ReadBool();
            break;
          }
          case 40: {
            BgmId = input.ReadUInt32();
            break;
          }
          case 48: {
            ComfortValue = input.ReadUInt32();
            break;
          }
          case 64: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 74: {
            unk3300HPCHPODNBPH_.AddEntriesFrom(ref input, _repeated_unk3300HPCHPODNBPH_codec);
            break;
          }
          case 82: {
            if (bornRot_ == null) {
              BornRot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(BornRot);
            break;
          }
          case 90: {
            if (bornPos_ == null) {
              BornPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(BornPos);
            break;
          }
          case 114: {
            if (djinnPos_ == null) {
              DjinnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 122: {
            if (mainHouse_ == null) {
              MainHouse = new global::Weedwacker.Shared.Network.Proto.HomeFurnitureData();
            }
            input.ReadMessage(MainHouse);
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
