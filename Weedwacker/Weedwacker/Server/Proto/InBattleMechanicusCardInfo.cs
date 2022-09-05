// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusCardInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from InBattleMechanicusCardInfo.proto</summary>
  public static partial class InBattleMechanicusCardInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleMechanicusCardInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleMechanicusCardInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBJbkJhdHRsZU1lY2hhbmljdXNDYXJkSW5mby5wcm90bxoqSW5CYXR0bGVN",
            "ZWNoYW5pY3VzQ2FyZENoYWxsZW5nZVN0YXRlLnByb3RvIsIBChpJbkJhdHRs",
            "ZU1lY2hhbmljdXNDYXJkSW5mbxIWCg5yYW5kX2VmZmVjdF9pZBgMIAEoDRIR",
            "CgllbmRfcm91bmQYAyABKA0SPgoPY2hhbGxlbmdlX3N0YXRlGAUgASgOMiUu",
            "SW5CYXR0bGVNZWNoYW5pY3VzQ2FyZENoYWxsZW5nZVN0YXRlEhMKC2Nvc3Rf",
            "cG9pbnRzGAEgASgNEg8KB2NhcmRfaWQYCyABKA0SEwoLYmVnaW5fcm91bmQY",
            "CCABKA1CGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo), global::Weedwacker.Server.Proto.InBattleMechanicusCardInfo.Parser, new[]{ "RandEffectId", "EndRound", "ChallengeState", "CostPoints", "CardId", "BeginRound" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleMechanicusCardInfo : pb::IMessage<InBattleMechanicusCardInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleMechanicusCardInfo> _parser = new pb::MessageParser<InBattleMechanicusCardInfo>(() => new InBattleMechanicusCardInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleMechanicusCardInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.InBattleMechanicusCardInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusCardInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusCardInfo(InBattleMechanicusCardInfo other) : this() {
      randEffectId_ = other.randEffectId_;
      endRound_ = other.endRound_;
      challengeState_ = other.challengeState_;
      costPoints_ = other.costPoints_;
      cardId_ = other.cardId_;
      beginRound_ = other.beginRound_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusCardInfo Clone() {
      return new InBattleMechanicusCardInfo(this);
    }

    /// <summary>Field number for the "rand_effect_id" field.</summary>
    public const int RandEffectIdFieldNumber = 12;
    private uint randEffectId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RandEffectId {
      get { return randEffectId_; }
      set {
        randEffectId_ = value;
      }
    }

    /// <summary>Field number for the "end_round" field.</summary>
    public const int EndRoundFieldNumber = 3;
    private uint endRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndRound {
      get { return endRound_; }
      set {
        endRound_ = value;
      }
    }

    /// <summary>Field number for the "challenge_state" field.</summary>
    public const int ChallengeStateFieldNumber = 5;
    private global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState challengeState_ = global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState ChallengeState {
      get { return challengeState_; }
      set {
        challengeState_ = value;
      }
    }

    /// <summary>Field number for the "cost_points" field.</summary>
    public const int CostPointsFieldNumber = 1;
    private uint costPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostPoints {
      get { return costPoints_; }
      set {
        costPoints_ = value;
      }
    }

    /// <summary>Field number for the "card_id" field.</summary>
    public const int CardIdFieldNumber = 11;
    private uint cardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardId {
      get { return cardId_; }
      set {
        cardId_ = value;
      }
    }

    /// <summary>Field number for the "begin_round" field.</summary>
    public const int BeginRoundFieldNumber = 8;
    private uint beginRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginRound {
      get { return beginRound_; }
      set {
        beginRound_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleMechanicusCardInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleMechanicusCardInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RandEffectId != other.RandEffectId) return false;
      if (EndRound != other.EndRound) return false;
      if (ChallengeState != other.ChallengeState) return false;
      if (CostPoints != other.CostPoints) return false;
      if (CardId != other.CardId) return false;
      if (BeginRound != other.BeginRound) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RandEffectId != 0) hash ^= RandEffectId.GetHashCode();
      if (EndRound != 0) hash ^= EndRound.GetHashCode();
      if (ChallengeState != global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState.None) hash ^= ChallengeState.GetHashCode();
      if (CostPoints != 0) hash ^= CostPoints.GetHashCode();
      if (CardId != 0) hash ^= CardId.GetHashCode();
      if (BeginRound != 0) hash ^= BeginRound.GetHashCode();
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
      if (CostPoints != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CostPoints);
      }
      if (EndRound != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EndRound);
      }
      if (ChallengeState != global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ChallengeState);
      }
      if (BeginRound != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BeginRound);
      }
      if (CardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CardId);
      }
      if (RandEffectId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RandEffectId);
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
      if (CostPoints != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CostPoints);
      }
      if (EndRound != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EndRound);
      }
      if (ChallengeState != global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ChallengeState);
      }
      if (BeginRound != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BeginRound);
      }
      if (CardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CardId);
      }
      if (RandEffectId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(RandEffectId);
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
      if (RandEffectId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RandEffectId);
      }
      if (EndRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndRound);
      }
      if (ChallengeState != global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChallengeState);
      }
      if (CostPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostPoints);
      }
      if (CardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
      }
      if (BeginRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginRound);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleMechanicusCardInfo other) {
      if (other == null) {
        return;
      }
      if (other.RandEffectId != 0) {
        RandEffectId = other.RandEffectId;
      }
      if (other.EndRound != 0) {
        EndRound = other.EndRound;
      }
      if (other.ChallengeState != global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState.None) {
        ChallengeState = other.ChallengeState;
      }
      if (other.CostPoints != 0) {
        CostPoints = other.CostPoints;
      }
      if (other.CardId != 0) {
        CardId = other.CardId;
      }
      if (other.BeginRound != 0) {
        BeginRound = other.BeginRound;
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
            CostPoints = input.ReadUInt32();
            break;
          }
          case 24: {
            EndRound = input.ReadUInt32();
            break;
          }
          case 40: {
            ChallengeState = (global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState) input.ReadEnum();
            break;
          }
          case 64: {
            BeginRound = input.ReadUInt32();
            break;
          }
          case 88: {
            CardId = input.ReadUInt32();
            break;
          }
          case 96: {
            RandEffectId = input.ReadUInt32();
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
            CostPoints = input.ReadUInt32();
            break;
          }
          case 24: {
            EndRound = input.ReadUInt32();
            break;
          }
          case 40: {
            ChallengeState = (global::Weedwacker.Server.Proto.InBattleMechanicusCardChallengeState) input.ReadEnum();
            break;
          }
          case 64: {
            BeginRound = input.ReadUInt32();
            break;
          }
          case 88: {
            CardId = input.ReadUInt32();
            break;
          }
          case 96: {
            RandEffectId = input.ReadUInt32();
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
