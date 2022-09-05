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
namespace Weedwacker.Server.Proto {

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
            "Ch5Ib21lU2NlbmVBcnJhbmdlbWVudEluZm8ucHJvdG8aHkhvbWVCbG9ja0Fy",
            "cmFuZ2VtZW50SW5mby5wcm90bxoXSG9tZUZ1cm5pdHVyZURhdGEucHJvdG8a",
            "DFZlY3Rvci5wcm90byKXAwoYSG9tZVNjZW5lQXJyYW5nZW1lbnRJbmZvEhkK",
            "CGJvcm5fcm90GAQgASgLMgcuVmVjdG9yEhkKCGJvcm5fcG9zGAEgASgLMgcu",
            "VmVjdG9yEiYKCnN0YWlyX2xpc3QYCyADKAsyEi5Ib21lRnVybml0dXJlRGF0",
            "YRIlCglkb29yX2xpc3QYDSADKAsyEi5Ib21lRnVybml0dXJlRGF0YRIXCg9p",
            "c19zZXRfYm9ybl9wb3MYCiABKAgSPgobYmxvY2tfYXJyYW5nZW1lbnRfaW5m",
            "b19saXN0GAggAygLMhkuSG9tZUJsb2NrQXJyYW5nZW1lbnRJbmZvEhAKCHNj",
            "ZW5lX2lkGAIgASgNEhsKE1VuazI3MDBfQkpIQU1LS0VDRUkYDCABKA0SGgoJ",
            "ZGppbm5fcG9zGAkgASgLMgcuVmVjdG9yEiYKCm1haW5faG91c2UYDiABKAsy",
            "Ei5Ib21lRnVybml0dXJlRGF0YRIVCg1jb21mb3J0X3ZhbHVlGAcgASgNEhMK",
            "C3RtcF92ZXJzaW9uGAUgASgNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.HomeBlockArrangementInfoReflection.Descriptor, global::Weedwacker.Server.Proto.HomeFurnitureDataReflection.Descriptor, global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeSceneArrangementInfo), global::Weedwacker.Server.Proto.HomeSceneArrangementInfo.Parser, new[]{ "BornRot", "BornPos", "StairList", "DoorList", "IsSetBornPos", "BlockArrangementInfoList", "SceneId", "Unk2700BJHAMKKECEI", "DjinnPos", "MainHouse", "ComfortValue", "TmpVersion" }, null, null, null, null)
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
      get { return global::Weedwacker.Server.Proto.HomeSceneArrangementInfoReflection.Descriptor.MessageTypes[0]; }
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
      bornRot_ = other.bornRot_ != null ? other.bornRot_.Clone() : null;
      bornPos_ = other.bornPos_ != null ? other.bornPos_.Clone() : null;
      stairList_ = other.stairList_.Clone();
      doorList_ = other.doorList_.Clone();
      isSetBornPos_ = other.isSetBornPos_;
      blockArrangementInfoList_ = other.blockArrangementInfoList_.Clone();
      sceneId_ = other.sceneId_;
      unk2700BJHAMKKECEI_ = other.unk2700BJHAMKKECEI_;
      djinnPos_ = other.djinnPos_ != null ? other.djinnPos_.Clone() : null;
      mainHouse_ = other.mainHouse_ != null ? other.mainHouse_.Clone() : null;
      comfortValue_ = other.comfortValue_;
      tmpVersion_ = other.tmpVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementInfo Clone() {
      return new HomeSceneArrangementInfo(this);
    }

    /// <summary>Field number for the "born_rot" field.</summary>
    public const int BornRotFieldNumber = 4;
    private global::Weedwacker.Server.Proto.Vector bornRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector BornRot {
      get { return bornRot_; }
      set {
        bornRot_ = value;
      }
    }

    /// <summary>Field number for the "born_pos" field.</summary>
    public const int BornPosFieldNumber = 1;
    private global::Weedwacker.Server.Proto.Vector bornPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector BornPos {
      get { return bornPos_; }
      set {
        bornPos_ = value;
      }
    }

    /// <summary>Field number for the "stair_list" field.</summary>
    public const int StairListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.HomeFurnitureData> _repeated_stairList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Server.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData> stairList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData> StairList {
      get { return stairList_; }
    }

    /// <summary>Field number for the "door_list" field.</summary>
    public const int DoorListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.HomeFurnitureData> _repeated_doorList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Server.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData> doorList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData> DoorList {
      get { return doorList_; }
    }

    /// <summary>Field number for the "is_set_born_pos" field.</summary>
    public const int IsSetBornPosFieldNumber = 10;
    private bool isSetBornPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSetBornPos {
      get { return isSetBornPos_; }
      set {
        isSetBornPos_ = value;
      }
    }

    /// <summary>Field number for the "block_arrangement_info_list" field.</summary>
    public const int BlockArrangementInfoListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.HomeBlockArrangementInfo> _repeated_blockArrangementInfoList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Server.Proto.HomeBlockArrangementInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeBlockArrangementInfo> blockArrangementInfoList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeBlockArrangementInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeBlockArrangementInfo> BlockArrangementInfoList {
      get { return blockArrangementInfoList_; }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_BJHAMKKECEI" field.</summary>
    public const int Unk2700BJHAMKKECEIFieldNumber = 12;
    private uint unk2700BJHAMKKECEI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700BJHAMKKECEI {
      get { return unk2700BJHAMKKECEI_; }
      set {
        unk2700BJHAMKKECEI_ = value;
      }
    }

    /// <summary>Field number for the "djinn_pos" field.</summary>
    public const int DjinnPosFieldNumber = 9;
    private global::Weedwacker.Server.Proto.Vector djinnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector DjinnPos {
      get { return djinnPos_; }
      set {
        djinnPos_ = value;
      }
    }

    /// <summary>Field number for the "main_house" field.</summary>
    public const int MainHouseFieldNumber = 14;
    private global::Weedwacker.Server.Proto.HomeFurnitureData mainHouse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.HomeFurnitureData MainHouse {
      get { return mainHouse_; }
      set {
        mainHouse_ = value;
      }
    }

    /// <summary>Field number for the "comfort_value" field.</summary>
    public const int ComfortValueFieldNumber = 7;
    private uint comfortValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ComfortValue {
      get { return comfortValue_; }
      set {
        comfortValue_ = value;
      }
    }

    /// <summary>Field number for the "tmp_version" field.</summary>
    public const int TmpVersionFieldNumber = 5;
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
      if (!object.Equals(BornRot, other.BornRot)) return false;
      if (!object.Equals(BornPos, other.BornPos)) return false;
      if(!stairList_.Equals(other.stairList_)) return false;
      if(!doorList_.Equals(other.doorList_)) return false;
      if (IsSetBornPos != other.IsSetBornPos) return false;
      if(!blockArrangementInfoList_.Equals(other.blockArrangementInfoList_)) return false;
      if (SceneId != other.SceneId) return false;
      if (Unk2700BJHAMKKECEI != other.Unk2700BJHAMKKECEI) return false;
      if (!object.Equals(DjinnPos, other.DjinnPos)) return false;
      if (!object.Equals(MainHouse, other.MainHouse)) return false;
      if (ComfortValue != other.ComfortValue) return false;
      if (TmpVersion != other.TmpVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (bornRot_ != null) hash ^= BornRot.GetHashCode();
      if (bornPos_ != null) hash ^= BornPos.GetHashCode();
      hash ^= stairList_.GetHashCode();
      hash ^= doorList_.GetHashCode();
      if (IsSetBornPos != false) hash ^= IsSetBornPos.GetHashCode();
      hash ^= blockArrangementInfoList_.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (Unk2700BJHAMKKECEI != 0) hash ^= Unk2700BJHAMKKECEI.GetHashCode();
      if (djinnPos_ != null) hash ^= DjinnPos.GetHashCode();
      if (mainHouse_ != null) hash ^= MainHouse.GetHashCode();
      if (ComfortValue != 0) hash ^= ComfortValue.GetHashCode();
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
      if (bornPos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BornPos);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (bornRot_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BornRot);
      }
      if (TmpVersion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TmpVersion);
      }
      if (ComfortValue != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ComfortValue);
      }
      blockArrangementInfoList_.WriteTo(output, _repeated_blockArrangementInfoList_codec);
      if (djinnPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DjinnPos);
      }
      if (IsSetBornPos != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSetBornPos);
      }
      stairList_.WriteTo(output, _repeated_stairList_codec);
      if (Unk2700BJHAMKKECEI != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk2700BJHAMKKECEI);
      }
      doorList_.WriteTo(output, _repeated_doorList_codec);
      if (mainHouse_ != null) {
        output.WriteRawTag(114);
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
      if (bornPos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BornPos);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (bornRot_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(BornRot);
      }
      if (TmpVersion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TmpVersion);
      }
      if (ComfortValue != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ComfortValue);
      }
      blockArrangementInfoList_.WriteTo(ref output, _repeated_blockArrangementInfoList_codec);
      if (djinnPos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(DjinnPos);
      }
      if (IsSetBornPos != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSetBornPos);
      }
      stairList_.WriteTo(ref output, _repeated_stairList_codec);
      if (Unk2700BJHAMKKECEI != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk2700BJHAMKKECEI);
      }
      doorList_.WriteTo(ref output, _repeated_doorList_codec);
      if (mainHouse_ != null) {
        output.WriteRawTag(114);
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
      if (bornRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BornRot);
      }
      if (bornPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BornPos);
      }
      size += stairList_.CalculateSize(_repeated_stairList_codec);
      size += doorList_.CalculateSize(_repeated_doorList_codec);
      if (IsSetBornPos != false) {
        size += 1 + 1;
      }
      size += blockArrangementInfoList_.CalculateSize(_repeated_blockArrangementInfoList_codec);
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (Unk2700BJHAMKKECEI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700BJHAMKKECEI);
      }
      if (djinnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DjinnPos);
      }
      if (mainHouse_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MainHouse);
      }
      if (ComfortValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ComfortValue);
      }
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
      if (other.bornRot_ != null) {
        if (bornRot_ == null) {
          BornRot = new global::Weedwacker.Server.Proto.Vector();
        }
        BornRot.MergeFrom(other.BornRot);
      }
      if (other.bornPos_ != null) {
        if (bornPos_ == null) {
          BornPos = new global::Weedwacker.Server.Proto.Vector();
        }
        BornPos.MergeFrom(other.BornPos);
      }
      stairList_.Add(other.stairList_);
      doorList_.Add(other.doorList_);
      if (other.IsSetBornPos != false) {
        IsSetBornPos = other.IsSetBornPos;
      }
      blockArrangementInfoList_.Add(other.blockArrangementInfoList_);
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.Unk2700BJHAMKKECEI != 0) {
        Unk2700BJHAMKKECEI = other.Unk2700BJHAMKKECEI;
      }
      if (other.djinnPos_ != null) {
        if (djinnPos_ == null) {
          DjinnPos = new global::Weedwacker.Server.Proto.Vector();
        }
        DjinnPos.MergeFrom(other.DjinnPos);
      }
      if (other.mainHouse_ != null) {
        if (mainHouse_ == null) {
          MainHouse = new global::Weedwacker.Server.Proto.HomeFurnitureData();
        }
        MainHouse.MergeFrom(other.MainHouse);
      }
      if (other.ComfortValue != 0) {
        ComfortValue = other.ComfortValue;
      }
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
            if (bornPos_ == null) {
              BornPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(BornPos);
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (bornRot_ == null) {
              BornRot = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(BornRot);
            break;
          }
          case 40: {
            TmpVersion = input.ReadUInt32();
            break;
          }
          case 56: {
            ComfortValue = input.ReadUInt32();
            break;
          }
          case 66: {
            blockArrangementInfoList_.AddEntriesFrom(input, _repeated_blockArrangementInfoList_codec);
            break;
          }
          case 74: {
            if (djinnPos_ == null) {
              DjinnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 80: {
            IsSetBornPos = input.ReadBool();
            break;
          }
          case 90: {
            stairList_.AddEntriesFrom(input, _repeated_stairList_codec);
            break;
          }
          case 96: {
            Unk2700BJHAMKKECEI = input.ReadUInt32();
            break;
          }
          case 106: {
            doorList_.AddEntriesFrom(input, _repeated_doorList_codec);
            break;
          }
          case 114: {
            if (mainHouse_ == null) {
              MainHouse = new global::Weedwacker.Server.Proto.HomeFurnitureData();
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
            if (bornPos_ == null) {
              BornPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(BornPos);
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (bornRot_ == null) {
              BornRot = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(BornRot);
            break;
          }
          case 40: {
            TmpVersion = input.ReadUInt32();
            break;
          }
          case 56: {
            ComfortValue = input.ReadUInt32();
            break;
          }
          case 66: {
            blockArrangementInfoList_.AddEntriesFrom(ref input, _repeated_blockArrangementInfoList_codec);
            break;
          }
          case 74: {
            if (djinnPos_ == null) {
              DjinnPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DjinnPos);
            break;
          }
          case 80: {
            IsSetBornPos = input.ReadBool();
            break;
          }
          case 90: {
            stairList_.AddEntriesFrom(ref input, _repeated_stairList_codec);
            break;
          }
          case 96: {
            Unk2700BJHAMKKECEI = input.ReadUInt32();
            break;
          }
          case 106: {
            doorList_.AddEntriesFrom(ref input, _repeated_doorList_codec);
            break;
          }
          case 114: {
            if (mainHouse_ == null) {
              MainHouse = new global::Weedwacker.Server.Proto.HomeFurnitureData();
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
