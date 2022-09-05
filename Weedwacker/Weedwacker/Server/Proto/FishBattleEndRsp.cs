// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishBattleEndRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from FishBattleEndRsp.proto</summary>
  public static partial class FishBattleEndRspReflection {

    #region Descriptor
    /// <summary>File descriptor for FishBattleEndRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishBattleEndRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGaXNoQmF0dGxlRW5kUnNwLnByb3RvGhZGaXNoQmF0dGxlUmVzdWx0LnBy",
            "b3RvGg9JdGVtUGFyYW0ucHJvdG8iwAMKEEZpc2hCYXR0bGVFbmRSc3ASFQoN",
            "aXNfZ290X3Jld2FyZBgKIAEoCBIkChByZXdhcmRfaXRlbV9saXN0GAsgAygL",
            "MgouSXRlbVBhcmFtEiQKEHRhbGVudF9pdGVtX2xpc3QYDSADKAsyCi5JdGVt",
            "UGFyYW0SIgoOZHJvcF9pdGVtX2xpc3QYCSADKAsyCi5JdGVtUGFyYW0SDwoH",
            "cmV0Y29kZRgHIAEoBRI+ChBub19yZXdhcmRfcmVhc29uGA4gASgOMiQuRmlz",
            "aEJhdHRsZUVuZFJzcC5GaXNoTm9SZXdhcmRSZWFzb24SKAoNYmF0dGxlX3Jl",
            "c3VsdBgGIAEoDjIRLkZpc2hCYXR0bGVSZXN1bHQiqQEKEkZpc2hOb1Jld2Fy",
            "ZFJlYXNvbhIeChpGSVNIX05PX1JFV0FSRF9SRUFTT05fTk9ORRAAEigKJEZJ",
            "U0hfTk9fUkVXQVJEX1JFQVNPTl9BQ1RJVklUWV9MSU1JVBABEiMKH0ZJU0hf",
            "Tk9fUkVXQVJEX1JFQVNPTl9CQUdfTElNSVQQAhIkCiBGSVNIX05PX1JFV0FS",
            "RF9SRUFTT05fUE9PTF9MSU1JVBADQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.FishBattleResultReflection.Descriptor, global::Weedwacker.Server.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.FishBattleEndRsp), global::Weedwacker.Server.Proto.FishBattleEndRsp.Parser, new[]{ "IsGotReward", "RewardItemList", "TalentItemList", "DropItemList", "Retcode", "NoRewardReason", "BattleResult" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5842
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class FishBattleEndRsp : pb::IMessage<FishBattleEndRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishBattleEndRsp> _parser = new pb::MessageParser<FishBattleEndRsp>(() => new FishBattleEndRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishBattleEndRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.FishBattleEndRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishBattleEndRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishBattleEndRsp(FishBattleEndRsp other) : this() {
      isGotReward_ = other.isGotReward_;
      rewardItemList_ = other.rewardItemList_.Clone();
      talentItemList_ = other.talentItemList_.Clone();
      dropItemList_ = other.dropItemList_.Clone();
      retcode_ = other.retcode_;
      noRewardReason_ = other.noRewardReason_;
      battleResult_ = other.battleResult_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishBattleEndRsp Clone() {
      return new FishBattleEndRsp(this);
    }

    /// <summary>Field number for the "is_got_reward" field.</summary>
    public const int IsGotRewardFieldNumber = 10;
    private bool isGotReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGotReward {
      get { return isGotReward_; }
      set {
        isGotReward_ = value;
      }
    }

    /// <summary>Field number for the "reward_item_list" field.</summary>
    public const int RewardItemListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemParam> _repeated_rewardItemList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Server.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> rewardItemList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> RewardItemList {
      get { return rewardItemList_; }
    }

    /// <summary>Field number for the "talent_item_list" field.</summary>
    public const int TalentItemListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemParam> _repeated_talentItemList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Server.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> talentItemList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> TalentItemList {
      get { return talentItemList_; }
    }

    /// <summary>Field number for the "drop_item_list" field.</summary>
    public const int DropItemListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemParam> _repeated_dropItemList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Server.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> dropItemList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> DropItemList {
      get { return dropItemList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "no_reward_reason" field.</summary>
    public const int NoRewardReasonFieldNumber = 14;
    private global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason noRewardReason_ = global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason NoRewardReason {
      get { return noRewardReason_; }
      set {
        noRewardReason_ = value;
      }
    }

    /// <summary>Field number for the "battle_result" field.</summary>
    public const int BattleResultFieldNumber = 6;
    private global::Weedwacker.Server.Proto.FishBattleResult battleResult_ = global::Weedwacker.Server.Proto.FishBattleResult.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.FishBattleResult BattleResult {
      get { return battleResult_; }
      set {
        battleResult_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishBattleEndRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishBattleEndRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsGotReward != other.IsGotReward) return false;
      if(!rewardItemList_.Equals(other.rewardItemList_)) return false;
      if(!talentItemList_.Equals(other.talentItemList_)) return false;
      if(!dropItemList_.Equals(other.dropItemList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (NoRewardReason != other.NoRewardReason) return false;
      if (BattleResult != other.BattleResult) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsGotReward != false) hash ^= IsGotReward.GetHashCode();
      hash ^= rewardItemList_.GetHashCode();
      hash ^= talentItemList_.GetHashCode();
      hash ^= dropItemList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (NoRewardReason != global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason.None) hash ^= NoRewardReason.GetHashCode();
      if (BattleResult != global::Weedwacker.Server.Proto.FishBattleResult.None) hash ^= BattleResult.GetHashCode();
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
      if (BattleResult != global::Weedwacker.Server.Proto.FishBattleResult.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) BattleResult);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      dropItemList_.WriteTo(output, _repeated_dropItemList_codec);
      if (IsGotReward != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsGotReward);
      }
      rewardItemList_.WriteTo(output, _repeated_rewardItemList_codec);
      talentItemList_.WriteTo(output, _repeated_talentItemList_codec);
      if (NoRewardReason != global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) NoRewardReason);
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
      if (BattleResult != global::Weedwacker.Server.Proto.FishBattleResult.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) BattleResult);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      dropItemList_.WriteTo(ref output, _repeated_dropItemList_codec);
      if (IsGotReward != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsGotReward);
      }
      rewardItemList_.WriteTo(ref output, _repeated_rewardItemList_codec);
      talentItemList_.WriteTo(ref output, _repeated_talentItemList_codec);
      if (NoRewardReason != global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) NoRewardReason);
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
      if (IsGotReward != false) {
        size += 1 + 1;
      }
      size += rewardItemList_.CalculateSize(_repeated_rewardItemList_codec);
      size += talentItemList_.CalculateSize(_repeated_talentItemList_codec);
      size += dropItemList_.CalculateSize(_repeated_dropItemList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (NoRewardReason != global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NoRewardReason);
      }
      if (BattleResult != global::Weedwacker.Server.Proto.FishBattleResult.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BattleResult);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishBattleEndRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsGotReward != false) {
        IsGotReward = other.IsGotReward;
      }
      rewardItemList_.Add(other.rewardItemList_);
      talentItemList_.Add(other.talentItemList_);
      dropItemList_.Add(other.dropItemList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.NoRewardReason != global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason.None) {
        NoRewardReason = other.NoRewardReason;
      }
      if (other.BattleResult != global::Weedwacker.Server.Proto.FishBattleResult.None) {
        BattleResult = other.BattleResult;
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
          case 48: {
            BattleResult = (global::Weedwacker.Server.Proto.FishBattleResult) input.ReadEnum();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74: {
            dropItemList_.AddEntriesFrom(input, _repeated_dropItemList_codec);
            break;
          }
          case 80: {
            IsGotReward = input.ReadBool();
            break;
          }
          case 90: {
            rewardItemList_.AddEntriesFrom(input, _repeated_rewardItemList_codec);
            break;
          }
          case 106: {
            talentItemList_.AddEntriesFrom(input, _repeated_talentItemList_codec);
            break;
          }
          case 112: {
            NoRewardReason = (global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason) input.ReadEnum();
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
          case 48: {
            BattleResult = (global::Weedwacker.Server.Proto.FishBattleResult) input.ReadEnum();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74: {
            dropItemList_.AddEntriesFrom(ref input, _repeated_dropItemList_codec);
            break;
          }
          case 80: {
            IsGotReward = input.ReadBool();
            break;
          }
          case 90: {
            rewardItemList_.AddEntriesFrom(ref input, _repeated_rewardItemList_codec);
            break;
          }
          case 106: {
            talentItemList_.AddEntriesFrom(ref input, _repeated_talentItemList_codec);
            break;
          }
          case 112: {
            NoRewardReason = (global::Weedwacker.Server.Proto.FishBattleEndRsp.Types.FishNoRewardReason) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the FishBattleEndRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum FishNoRewardReason {
        [pbr::OriginalName("FISH_NO_REWARD_REASON_NONE")] None = 0,
        [pbr::OriginalName("FISH_NO_REWARD_REASON_ACTIVITY_LIMIT")] ActivityLimit = 1,
        [pbr::OriginalName("FISH_NO_REWARD_REASON_BAG_LIMIT")] BagLimit = 2,
        [pbr::OriginalName("FISH_NO_REWARD_REASON_POOL_LIMIT")] PoolLimit = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
