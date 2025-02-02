// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlossomBriefInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BlossomBriefInfo.proto</summary>
  public static partial class BlossomBriefInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BlossomBriefInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlossomBriefInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZCbG9zc29tQnJpZWZJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvGgxWZWN0b3IucHJvdG8i+AEKEEJsb3Nzb21CcmllZklu",
            "Zm8SNAoDcG9zGAcgASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90by5WZWN0b3ISFwoPaXNfZ3VpZGVfb3BlbmVkGA8gASgIEhEKCXJld2Fy",
            "ZF9pZBgDIAEoDRINCgVyZXNpbhgFIAEoDRIPCgdjaXR5X2lkGAggASgNEhYK",
            "DmNpcmNsZV9jYW1wX2lkGAogASgNEg0KBXN0YXRlGAsgASgNEhUKDW1vbnN0",
            "ZXJfbGV2ZWwYASABKA0SEAoIc2NlbmVfaWQYBCABKA0SEgoKcmVmcmVzaF9p",
            "ZBgOIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BlossomBriefInfo), global::Weedwacker.Shared.Network.Proto.BlossomBriefInfo.Parser, new[]{ "Pos", "IsGuideOpened", "RewardId", "Resin", "CityId", "CircleCampId", "State", "MonsterLevel", "SceneId", "RefreshId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BlossomBriefInfo : pb::IMessage<BlossomBriefInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlossomBriefInfo> _parser = new pb::MessageParser<BlossomBriefInfo>(() => new BlossomBriefInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlossomBriefInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BlossomBriefInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomBriefInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomBriefInfo(BlossomBriefInfo other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      isGuideOpened_ = other.isGuideOpened_;
      rewardId_ = other.rewardId_;
      resin_ = other.resin_;
      cityId_ = other.cityId_;
      circleCampId_ = other.circleCampId_;
      state_ = other.state_;
      monsterLevel_ = other.monsterLevel_;
      sceneId_ = other.sceneId_;
      refreshId_ = other.refreshId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlossomBriefInfo Clone() {
      return new BlossomBriefInfo(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "is_guide_opened" field.</summary>
    public const int IsGuideOpenedFieldNumber = 15;
    private bool isGuideOpened_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGuideOpened {
      get { return isGuideOpened_; }
      set {
        isGuideOpened_ = value;
      }
    }

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 3;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    /// <summary>Field number for the "resin" field.</summary>
    public const int ResinFieldNumber = 5;
    private uint resin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Resin {
      get { return resin_; }
      set {
        resin_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 8;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
    }

    /// <summary>Field number for the "circle_camp_id" field.</summary>
    public const int CircleCampIdFieldNumber = 10;
    private uint circleCampId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CircleCampId {
      get { return circleCampId_; }
      set {
        circleCampId_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 11;
    private uint state_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "monster_level" field.</summary>
    public const int MonsterLevelFieldNumber = 1;
    private uint monsterLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterLevel {
      get { return monsterLevel_; }
      set {
        monsterLevel_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 4;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "refresh_id" field.</summary>
    public const int RefreshIdFieldNumber = 14;
    private uint refreshId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RefreshId {
      get { return refreshId_; }
      set {
        refreshId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlossomBriefInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlossomBriefInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (IsGuideOpened != other.IsGuideOpened) return false;
      if (RewardId != other.RewardId) return false;
      if (Resin != other.Resin) return false;
      if (CityId != other.CityId) return false;
      if (CircleCampId != other.CircleCampId) return false;
      if (State != other.State) return false;
      if (MonsterLevel != other.MonsterLevel) return false;
      if (SceneId != other.SceneId) return false;
      if (RefreshId != other.RefreshId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (IsGuideOpened != false) hash ^= IsGuideOpened.GetHashCode();
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
      if (Resin != 0) hash ^= Resin.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
      if (CircleCampId != 0) hash ^= CircleCampId.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (MonsterLevel != 0) hash ^= MonsterLevel.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (RefreshId != 0) hash ^= RefreshId.GetHashCode();
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
      if (MonsterLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MonsterLevel);
      }
      if (RewardId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RewardId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      if (Resin != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Resin);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (CityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityId);
      }
      if (CircleCampId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CircleCampId);
      }
      if (State != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(State);
      }
      if (RefreshId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RefreshId);
      }
      if (IsGuideOpened != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsGuideOpened);
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
      if (MonsterLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MonsterLevel);
      }
      if (RewardId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RewardId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      if (Resin != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Resin);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (CityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityId);
      }
      if (CircleCampId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CircleCampId);
      }
      if (State != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(State);
      }
      if (RefreshId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RefreshId);
      }
      if (IsGuideOpened != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsGuideOpened);
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
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (IsGuideOpened != false) {
        size += 1 + 1;
      }
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (Resin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Resin);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (CircleCampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CircleCampId);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
      }
      if (MonsterLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterLevel);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (RefreshId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RefreshId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlossomBriefInfo other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.IsGuideOpened != false) {
        IsGuideOpened = other.IsGuideOpened;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
      }
      if (other.Resin != 0) {
        Resin = other.Resin;
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
      }
      if (other.CircleCampId != 0) {
        CircleCampId = other.CircleCampId;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.MonsterLevel != 0) {
        MonsterLevel = other.MonsterLevel;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.RefreshId != 0) {
        RefreshId = other.RefreshId;
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
            MonsterLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 40: {
            Resin = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 64: {
            CityId = input.ReadUInt32();
            break;
          }
          case 80: {
            CircleCampId = input.ReadUInt32();
            break;
          }
          case 88: {
            State = input.ReadUInt32();
            break;
          }
          case 112: {
            RefreshId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsGuideOpened = input.ReadBool();
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
            MonsterLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 40: {
            Resin = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 64: {
            CityId = input.ReadUInt32();
            break;
          }
          case 80: {
            CircleCampId = input.ReadUInt32();
            break;
          }
          case 88: {
            State = input.ReadUInt32();
            break;
          }
          case 112: {
            RefreshId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsGuideOpened = input.ReadBool();
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
