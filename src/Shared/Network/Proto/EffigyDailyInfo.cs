// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyDailyInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EffigyDailyInfo.proto</summary>
  public static partial class EffigyDailyInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyDailyInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyDailyInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFZmZpZ3lEYWlseUluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8iyQEKD0VmZmlneURhaWx5SW5mbxIiChppc19maXJzdF9w",
            "YXNzX3Jld2FyZF90YWtlbhgHIAEoCBIbChNVbmszMzAwX05OSElDQ0dFTEhQ",
            "GAIgASgNEhsKE1VuazMzMDBfTkVCQ0RBTEVGRUMYCyABKA0SGwoTY2hhbGxl",
            "bmdlX21heF9zY29yZRgMIAEoDRISCgpiZWdpbl90aW1lGAggASgNEhQKDGNo",
            "YWxsZW5nZV9pZBgGIAEoDRIRCglkYXlfaW5kZXgYCSABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo), global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo.Parser, new[]{ "IsFirstPassRewardTaken", "Unk3300NNHICCGELHP", "Unk3300NEBCDALEFEC", "ChallengeMaxScore", "BeginTime", "ChallengeId", "DayIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyDailyInfo : pb::IMessage<EffigyDailyInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyDailyInfo> _parser = new pb::MessageParser<EffigyDailyInfo>(() => new EffigyDailyInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyDailyInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EffigyDailyInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyDailyInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyDailyInfo(EffigyDailyInfo other) : this() {
      isFirstPassRewardTaken_ = other.isFirstPassRewardTaken_;
      unk3300NNHICCGELHP_ = other.unk3300NNHICCGELHP_;
      unk3300NEBCDALEFEC_ = other.unk3300NEBCDALEFEC_;
      challengeMaxScore_ = other.challengeMaxScore_;
      beginTime_ = other.beginTime_;
      challengeId_ = other.challengeId_;
      dayIndex_ = other.dayIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyDailyInfo Clone() {
      return new EffigyDailyInfo(this);
    }

    /// <summary>Field number for the "is_first_pass_reward_taken" field.</summary>
    public const int IsFirstPassRewardTakenFieldNumber = 7;
    private bool isFirstPassRewardTaken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstPassRewardTaken {
      get { return isFirstPassRewardTaken_; }
      set {
        isFirstPassRewardTaken_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NNHICCGELHP" field.</summary>
    public const int Unk3300NNHICCGELHPFieldNumber = 2;
    private uint unk3300NNHICCGELHP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NNHICCGELHP {
      get { return unk3300NNHICCGELHP_; }
      set {
        unk3300NNHICCGELHP_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NEBCDALEFEC" field.</summary>
    public const int Unk3300NEBCDALEFECFieldNumber = 11;
    private uint unk3300NEBCDALEFEC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NEBCDALEFEC {
      get { return unk3300NEBCDALEFEC_; }
      set {
        unk3300NEBCDALEFEC_ = value;
      }
    }

    /// <summary>Field number for the "challenge_max_score" field.</summary>
    public const int ChallengeMaxScoreFieldNumber = 12;
    private uint challengeMaxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeMaxScore {
      get { return challengeMaxScore_; }
      set {
        challengeMaxScore_ = value;
      }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 8;
    private uint beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 6;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "day_index" field.</summary>
    public const int DayIndexFieldNumber = 9;
    private uint dayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DayIndex {
      get { return dayIndex_; }
      set {
        dayIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EffigyDailyInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyDailyInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFirstPassRewardTaken != other.IsFirstPassRewardTaken) return false;
      if (Unk3300NNHICCGELHP != other.Unk3300NNHICCGELHP) return false;
      if (Unk3300NEBCDALEFEC != other.Unk3300NEBCDALEFEC) return false;
      if (ChallengeMaxScore != other.ChallengeMaxScore) return false;
      if (BeginTime != other.BeginTime) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (DayIndex != other.DayIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFirstPassRewardTaken != false) hash ^= IsFirstPassRewardTaken.GetHashCode();
      if (Unk3300NNHICCGELHP != 0) hash ^= Unk3300NNHICCGELHP.GetHashCode();
      if (Unk3300NEBCDALEFEC != 0) hash ^= Unk3300NEBCDALEFEC.GetHashCode();
      if (ChallengeMaxScore != 0) hash ^= ChallengeMaxScore.GetHashCode();
      if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (DayIndex != 0) hash ^= DayIndex.GetHashCode();
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
      if (Unk3300NNHICCGELHP != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300NNHICCGELHP);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ChallengeId);
      }
      if (IsFirstPassRewardTaken != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFirstPassRewardTaken);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BeginTime);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DayIndex);
      }
      if (Unk3300NEBCDALEFEC != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300NEBCDALEFEC);
      }
      if (ChallengeMaxScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeMaxScore);
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
      if (Unk3300NNHICCGELHP != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300NNHICCGELHP);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ChallengeId);
      }
      if (IsFirstPassRewardTaken != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFirstPassRewardTaken);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BeginTime);
      }
      if (DayIndex != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(DayIndex);
      }
      if (Unk3300NEBCDALEFEC != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300NEBCDALEFEC);
      }
      if (ChallengeMaxScore != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ChallengeMaxScore);
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
      if (IsFirstPassRewardTaken != false) {
        size += 1 + 1;
      }
      if (Unk3300NNHICCGELHP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NNHICCGELHP);
      }
      if (Unk3300NEBCDALEFEC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NEBCDALEFEC);
      }
      if (ChallengeMaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeMaxScore);
      }
      if (BeginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (DayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DayIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EffigyDailyInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsFirstPassRewardTaken != false) {
        IsFirstPassRewardTaken = other.IsFirstPassRewardTaken;
      }
      if (other.Unk3300NNHICCGELHP != 0) {
        Unk3300NNHICCGELHP = other.Unk3300NNHICCGELHP;
      }
      if (other.Unk3300NEBCDALEFEC != 0) {
        Unk3300NEBCDALEFEC = other.Unk3300NEBCDALEFEC;
      }
      if (other.ChallengeMaxScore != 0) {
        ChallengeMaxScore = other.ChallengeMaxScore;
      }
      if (other.BeginTime != 0) {
        BeginTime = other.BeginTime;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.DayIndex != 0) {
        DayIndex = other.DayIndex;
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
            Unk3300NNHICCGELHP = input.ReadUInt32();
            break;
          }
          case 48: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFirstPassRewardTaken = input.ReadBool();
            break;
          }
          case 64: {
            BeginTime = input.ReadUInt32();
            break;
          }
          case 72: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300NEBCDALEFEC = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeMaxScore = input.ReadUInt32();
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
            Unk3300NNHICCGELHP = input.ReadUInt32();
            break;
          }
          case 48: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFirstPassRewardTaken = input.ReadBool();
            break;
          }
          case 64: {
            BeginTime = input.ReadUInt32();
            break;
          }
          case 72: {
            DayIndex = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300NEBCDALEFEC = input.ReadUInt32();
            break;
          }
          case 96: {
            ChallengeMaxScore = input.ReadUInt32();
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
