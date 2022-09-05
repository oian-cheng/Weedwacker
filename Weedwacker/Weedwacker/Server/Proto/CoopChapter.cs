// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoopChapter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from CoopChapter.proto</summary>
  public static partial class CoopChapterReflection {

    #region Descriptor
    /// <summary>File descriptor for CoopChapter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoopChapterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDb29wQ2hhcHRlci5wcm90bxoMQ29vcENnLnByb3RvGg9Db29wUG9pbnQu",
            "cHJvdG8aEENvb3BSZXdhcmQucHJvdG8i3AMKC0Nvb3BDaGFwdGVyEh0KDGNv",
            "b3BfY2dfbGlzdBgBIAMoCzIHLkNvb3BDZxIKCgJpZBgCIAEoDRIjCg9jb29w",
            "X3BvaW50X2xpc3QYCyADKAsyCi5Db29wUG9pbnQSGgoSZmluaXNoX2RpYWxv",
            "Z19saXN0GAogAygNEhoKEmZpbmlzaGVkX2VuZF9jb3VudBgOIAEoDRIXCg90",
            "b3RhbF9lbmRfY291bnQYByABKA0SJQoQY29vcF9yZXdhcmRfbGlzdBgFIAMo",
            "CzILLkNvb3BSZXdhcmQSGAoQbG9ja19yZWFzb25fbGlzdBgMIAMoDRIhCgVz",
            "dGF0ZRgEIAEoDjISLkNvb3BDaGFwdGVyLlN0YXRlEjgKD3NlZW5fZW5kaW5n",
            "X21hcBgJIAMoCzIfLkNvb3BDaGFwdGVyLlNlZW5FbmRpbmdNYXBFbnRyeRo0",
            "ChJTZWVuRW5kaW5nTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg",
            "ASgNOgI4ASJYCgVTdGF0ZRIPCgtTVEFURV9DTE9TRRAAEhcKE1NUQVRFX0NP",
            "TkRfTk9UX01FRVQQARITCg9TVEFURV9DT05EX01FRVQQAhIQCgxTVEFURV9B",
            "Q0NFUFQQA0IaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.CoopCgReflection.Descriptor, global::Weedwacker.Server.Proto.CoopPointReflection.Descriptor, global::Weedwacker.Server.Proto.CoopRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.CoopChapter), global::Weedwacker.Server.Proto.CoopChapter.Parser, new[]{ "CoopCgList", "Id", "CoopPointList", "FinishDialogList", "FinishedEndCount", "TotalEndCount", "CoopRewardList", "LockReasonList", "State", "SeenEndingMap" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.CoopChapter.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CoopChapter : pb::IMessage<CoopChapter>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CoopChapter> _parser = new pb::MessageParser<CoopChapter>(() => new CoopChapter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CoopChapter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.CoopChapterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopChapter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopChapter(CoopChapter other) : this() {
      coopCgList_ = other.coopCgList_.Clone();
      id_ = other.id_;
      coopPointList_ = other.coopPointList_.Clone();
      finishDialogList_ = other.finishDialogList_.Clone();
      finishedEndCount_ = other.finishedEndCount_;
      totalEndCount_ = other.totalEndCount_;
      coopRewardList_ = other.coopRewardList_.Clone();
      lockReasonList_ = other.lockReasonList_.Clone();
      state_ = other.state_;
      seenEndingMap_ = other.seenEndingMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopChapter Clone() {
      return new CoopChapter(this);
    }

    /// <summary>Field number for the "coop_cg_list" field.</summary>
    public const int CoopCgListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.CoopCg> _repeated_coopCgList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Server.Proto.CoopCg.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopCg> coopCgList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopCg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopCg> CoopCgList {
      get { return coopCgList_; }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "coop_point_list" field.</summary>
    public const int CoopPointListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.CoopPoint> _repeated_coopPointList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Server.Proto.CoopPoint.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopPoint> coopPointList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopPoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopPoint> CoopPointList {
      get { return coopPointList_; }
    }

    /// <summary>Field number for the "finish_dialog_list" field.</summary>
    public const int FinishDialogListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_finishDialogList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> finishDialogList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishDialogList {
      get { return finishDialogList_; }
    }

    /// <summary>Field number for the "finished_end_count" field.</summary>
    public const int FinishedEndCountFieldNumber = 14;
    private uint finishedEndCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishedEndCount {
      get { return finishedEndCount_; }
      set {
        finishedEndCount_ = value;
      }
    }

    /// <summary>Field number for the "total_end_count" field.</summary>
    public const int TotalEndCountFieldNumber = 7;
    private uint totalEndCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalEndCount {
      get { return totalEndCount_; }
      set {
        totalEndCount_ = value;
      }
    }

    /// <summary>Field number for the "coop_reward_list" field.</summary>
    public const int CoopRewardListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.CoopReward> _repeated_coopRewardList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Server.Proto.CoopReward.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopReward> coopRewardList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopReward>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.CoopReward> CoopRewardList {
      get { return coopRewardList_; }
    }

    /// <summary>Field number for the "lock_reason_list" field.</summary>
    public const int LockReasonListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_lockReasonList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> lockReasonList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LockReasonList {
      get { return lockReasonList_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Weedwacker.Server.Proto.CoopChapter.Types.State state_ = global::Weedwacker.Server.Proto.CoopChapter.Types.State.Close;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.CoopChapter.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "seen_ending_map" field.</summary>
    public const int SeenEndingMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, uint>.Codec _map_seenEndingMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 74);
    private readonly pbc::MapField<uint, uint> seenEndingMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SeenEndingMap {
      get { return seenEndingMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CoopChapter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CoopChapter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!coopCgList_.Equals(other.coopCgList_)) return false;
      if (Id != other.Id) return false;
      if(!coopPointList_.Equals(other.coopPointList_)) return false;
      if(!finishDialogList_.Equals(other.finishDialogList_)) return false;
      if (FinishedEndCount != other.FinishedEndCount) return false;
      if (TotalEndCount != other.TotalEndCount) return false;
      if(!coopRewardList_.Equals(other.coopRewardList_)) return false;
      if(!lockReasonList_.Equals(other.lockReasonList_)) return false;
      if (State != other.State) return false;
      if (!SeenEndingMap.Equals(other.SeenEndingMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= coopCgList_.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= coopPointList_.GetHashCode();
      hash ^= finishDialogList_.GetHashCode();
      if (FinishedEndCount != 0) hash ^= FinishedEndCount.GetHashCode();
      if (TotalEndCount != 0) hash ^= TotalEndCount.GetHashCode();
      hash ^= coopRewardList_.GetHashCode();
      hash ^= lockReasonList_.GetHashCode();
      if (State != global::Weedwacker.Server.Proto.CoopChapter.Types.State.Close) hash ^= State.GetHashCode();
      hash ^= SeenEndingMap.GetHashCode();
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
      coopCgList_.WriteTo(output, _repeated_coopCgList_codec);
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (State != global::Weedwacker.Server.Proto.CoopChapter.Types.State.Close) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      coopRewardList_.WriteTo(output, _repeated_coopRewardList_codec);
      if (TotalEndCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TotalEndCount);
      }
      seenEndingMap_.WriteTo(output, _map_seenEndingMap_codec);
      finishDialogList_.WriteTo(output, _repeated_finishDialogList_codec);
      coopPointList_.WriteTo(output, _repeated_coopPointList_codec);
      lockReasonList_.WriteTo(output, _repeated_lockReasonList_codec);
      if (FinishedEndCount != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinishedEndCount);
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
      coopCgList_.WriteTo(ref output, _repeated_coopCgList_codec);
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (State != global::Weedwacker.Server.Proto.CoopChapter.Types.State.Close) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      coopRewardList_.WriteTo(ref output, _repeated_coopRewardList_codec);
      if (TotalEndCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TotalEndCount);
      }
      seenEndingMap_.WriteTo(ref output, _map_seenEndingMap_codec);
      finishDialogList_.WriteTo(ref output, _repeated_finishDialogList_codec);
      coopPointList_.WriteTo(ref output, _repeated_coopPointList_codec);
      lockReasonList_.WriteTo(ref output, _repeated_lockReasonList_codec);
      if (FinishedEndCount != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinishedEndCount);
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
      size += coopCgList_.CalculateSize(_repeated_coopCgList_codec);
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += coopPointList_.CalculateSize(_repeated_coopPointList_codec);
      size += finishDialogList_.CalculateSize(_repeated_finishDialogList_codec);
      if (FinishedEndCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishedEndCount);
      }
      if (TotalEndCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalEndCount);
      }
      size += coopRewardList_.CalculateSize(_repeated_coopRewardList_codec);
      size += lockReasonList_.CalculateSize(_repeated_lockReasonList_codec);
      if (State != global::Weedwacker.Server.Proto.CoopChapter.Types.State.Close) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      size += seenEndingMap_.CalculateSize(_map_seenEndingMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CoopChapter other) {
      if (other == null) {
        return;
      }
      coopCgList_.Add(other.coopCgList_);
      if (other.Id != 0) {
        Id = other.Id;
      }
      coopPointList_.Add(other.coopPointList_);
      finishDialogList_.Add(other.finishDialogList_);
      if (other.FinishedEndCount != 0) {
        FinishedEndCount = other.FinishedEndCount;
      }
      if (other.TotalEndCount != 0) {
        TotalEndCount = other.TotalEndCount;
      }
      coopRewardList_.Add(other.coopRewardList_);
      lockReasonList_.Add(other.lockReasonList_);
      if (other.State != global::Weedwacker.Server.Proto.CoopChapter.Types.State.Close) {
        State = other.State;
      }
      seenEndingMap_.Add(other.seenEndingMap_);
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
            coopCgList_.AddEntriesFrom(input, _repeated_coopCgList_codec);
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 32: {
            State = (global::Weedwacker.Server.Proto.CoopChapter.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            coopRewardList_.AddEntriesFrom(input, _repeated_coopRewardList_codec);
            break;
          }
          case 56: {
            TotalEndCount = input.ReadUInt32();
            break;
          }
          case 74: {
            seenEndingMap_.AddEntriesFrom(input, _map_seenEndingMap_codec);
            break;
          }
          case 82:
          case 80: {
            finishDialogList_.AddEntriesFrom(input, _repeated_finishDialogList_codec);
            break;
          }
          case 90: {
            coopPointList_.AddEntriesFrom(input, _repeated_coopPointList_codec);
            break;
          }
          case 98:
          case 96: {
            lockReasonList_.AddEntriesFrom(input, _repeated_lockReasonList_codec);
            break;
          }
          case 112: {
            FinishedEndCount = input.ReadUInt32();
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
            coopCgList_.AddEntriesFrom(ref input, _repeated_coopCgList_codec);
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 32: {
            State = (global::Weedwacker.Server.Proto.CoopChapter.Types.State) input.ReadEnum();
            break;
          }
          case 42: {
            coopRewardList_.AddEntriesFrom(ref input, _repeated_coopRewardList_codec);
            break;
          }
          case 56: {
            TotalEndCount = input.ReadUInt32();
            break;
          }
          case 74: {
            seenEndingMap_.AddEntriesFrom(ref input, _map_seenEndingMap_codec);
            break;
          }
          case 82:
          case 80: {
            finishDialogList_.AddEntriesFrom(ref input, _repeated_finishDialogList_codec);
            break;
          }
          case 90: {
            coopPointList_.AddEntriesFrom(ref input, _repeated_coopPointList_codec);
            break;
          }
          case 98:
          case 96: {
            lockReasonList_.AddEntriesFrom(ref input, _repeated_lockReasonList_codec);
            break;
          }
          case 112: {
            FinishedEndCount = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CoopChapter message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum State {
        [pbr::OriginalName("STATE_CLOSE")] Close = 0,
        [pbr::OriginalName("STATE_COND_NOT_MEET")] CondNotMeet = 1,
        [pbr::OriginalName("STATE_COND_MEET")] CondMeet = 2,
        [pbr::OriginalName("STATE_ACCEPT")] Accept = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
