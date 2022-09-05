// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MultistagePlaySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from MultistagePlaySettleNotify.proto</summary>
  public static partial class MultistagePlaySettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MultistagePlaySettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultistagePlaySettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBNdWx0aXN0YWdlUGxheVNldHRsZU5vdGlmeS5wcm90bxodSW5CYXR0bGVD",
            "aGVzc1NldHRsZUluZm8ucHJvdG8aIkluQmF0dGxlTWVjaGFuaWN1c1NldHRs",
            "ZUluZm8ucHJvdG8aHElyb2RvcmlDaGVzc1NldHRsZUluZm8ucHJvdG8ihQIK",
            "Gk11bHRpc3RhZ2VQbGF5U2V0dGxlTm90aWZ5EhIKCnBsYXlfaW5kZXgYDiAB",
            "KA0SEAoIZ3JvdXBfaWQYBCABKA0SQAoWbWVjaGFuaWN1c19zZXR0bGVfaW5m",
            "bxj6CiABKAsyHS5JbkJhdHRsZU1lY2hhbmljdXNTZXR0bGVJbmZvSAASNgoR",
            "Y2hlc3Nfc2V0dGxlX2luZm8YgwogASgLMhguSW5CYXR0bGVDaGVzc1NldHRs",
            "ZUluZm9IABI9Chlpcm9kb3JpX2NoZXNzX3NldHRsZV9pbmZvGOQEIAEoCzIX",
            "Lklyb2RvcmlDaGVzc1NldHRsZUluZm9IAEIICgZkZXRhaWxCGqoCF1dlZWR3",
            "YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.InBattleChessSettleInfoReflection.Descriptor, global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfoReflection.Descriptor, global::Weedwacker.Server.Proto.IrodoriChessSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.MultistagePlaySettleNotify), global::Weedwacker.Server.Proto.MultistagePlaySettleNotify.Parser, new[]{ "PlayIndex", "GroupId", "MechanicusSettleInfo", "ChessSettleInfo", "IrodoriChessSettleInfo" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5313
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class MultistagePlaySettleNotify : pb::IMessage<MultistagePlaySettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultistagePlaySettleNotify> _parser = new pb::MessageParser<MultistagePlaySettleNotify>(() => new MultistagePlaySettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultistagePlaySettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.MultistagePlaySettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistagePlaySettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistagePlaySettleNotify(MultistagePlaySettleNotify other) : this() {
      playIndex_ = other.playIndex_;
      groupId_ = other.groupId_;
      switch (other.DetailCase) {
        case DetailOneofCase.MechanicusSettleInfo:
          MechanicusSettleInfo = other.MechanicusSettleInfo.Clone();
          break;
        case DetailOneofCase.ChessSettleInfo:
          ChessSettleInfo = other.ChessSettleInfo.Clone();
          break;
        case DetailOneofCase.IrodoriChessSettleInfo:
          IrodoriChessSettleInfo = other.IrodoriChessSettleInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultistagePlaySettleNotify Clone() {
      return new MultistagePlaySettleNotify(this);
    }

    /// <summary>Field number for the "play_index" field.</summary>
    public const int PlayIndexFieldNumber = 14;
    private uint playIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayIndex {
      get { return playIndex_; }
      set {
        playIndex_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 4;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_settle_info" field.</summary>
    public const int MechanicusSettleInfoFieldNumber = 1402;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo MechanicusSettleInfo {
      get { return detailCase_ == DetailOneofCase.MechanicusSettleInfo ? (global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.MechanicusSettleInfo;
      }
    }

    /// <summary>Field number for the "chess_settle_info" field.</summary>
    public const int ChessSettleInfoFieldNumber = 1283;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.InBattleChessSettleInfo ChessSettleInfo {
      get { return detailCase_ == DetailOneofCase.ChessSettleInfo ? (global::Weedwacker.Server.Proto.InBattleChessSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.ChessSettleInfo;
      }
    }

    /// <summary>Field number for the "irodori_chess_settle_info" field.</summary>
    public const int IrodoriChessSettleInfoFieldNumber = 612;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.IrodoriChessSettleInfo IrodoriChessSettleInfo {
      get { return detailCase_ == DetailOneofCase.IrodoriChessSettleInfo ? (global::Weedwacker.Server.Proto.IrodoriChessSettleInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.IrodoriChessSettleInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      MechanicusSettleInfo = 1402,
      ChessSettleInfo = 1283,
      IrodoriChessSettleInfo = 612,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultistagePlaySettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultistagePlaySettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayIndex != other.PlayIndex) return false;
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(MechanicusSettleInfo, other.MechanicusSettleInfo)) return false;
      if (!object.Equals(ChessSettleInfo, other.ChessSettleInfo)) return false;
      if (!object.Equals(IrodoriChessSettleInfo, other.IrodoriChessSettleInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) hash ^= MechanicusSettleInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) hash ^= ChessSettleInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) hash ^= IrodoriChessSettleInfo.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlayIndex);
      }
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
        output.WriteRawTag(162, 38);
        output.WriteMessage(IrodoriChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
        output.WriteRawTag(154, 80);
        output.WriteMessage(ChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
        output.WriteRawTag(210, 87);
        output.WriteMessage(MechanicusSettleInfo);
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
      if (GroupId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GroupId);
      }
      if (PlayIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlayIndex);
      }
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
        output.WriteRawTag(162, 38);
        output.WriteMessage(IrodoriChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
        output.WriteRawTag(154, 80);
        output.WriteMessage(ChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
        output.WriteRawTag(210, 87);
        output.WriteMessage(MechanicusSettleInfo);
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
      if (PlayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MechanicusSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ChessSettleInfo);
      }
      if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IrodoriChessSettleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MultistagePlaySettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.PlayIndex != 0) {
        PlayIndex = other.PlayIndex;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.MechanicusSettleInfo:
          if (MechanicusSettleInfo == null) {
            MechanicusSettleInfo = new global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo();
          }
          MechanicusSettleInfo.MergeFrom(other.MechanicusSettleInfo);
          break;
        case DetailOneofCase.ChessSettleInfo:
          if (ChessSettleInfo == null) {
            ChessSettleInfo = new global::Weedwacker.Server.Proto.InBattleChessSettleInfo();
          }
          ChessSettleInfo.MergeFrom(other.ChessSettleInfo);
          break;
        case DetailOneofCase.IrodoriChessSettleInfo:
          if (IrodoriChessSettleInfo == null) {
            IrodoriChessSettleInfo = new global::Weedwacker.Server.Proto.IrodoriChessSettleInfo();
          }
          IrodoriChessSettleInfo.MergeFrom(other.IrodoriChessSettleInfo);
          break;
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
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 112: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 4898: {
            global::Weedwacker.Server.Proto.IrodoriChessSettleInfo subBuilder = new global::Weedwacker.Server.Proto.IrodoriChessSettleInfo();
            if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
              subBuilder.MergeFrom(IrodoriChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            IrodoriChessSettleInfo = subBuilder;
            break;
          }
          case 10266: {
            global::Weedwacker.Server.Proto.InBattleChessSettleInfo subBuilder = new global::Weedwacker.Server.Proto.InBattleChessSettleInfo();
            if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
              subBuilder.MergeFrom(ChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            ChessSettleInfo = subBuilder;
            break;
          }
          case 11218: {
            global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo subBuilder = new global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo();
            if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
              subBuilder.MergeFrom(MechanicusSettleInfo);
            }
            input.ReadMessage(subBuilder);
            MechanicusSettleInfo = subBuilder;
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
          case 32: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 112: {
            PlayIndex = input.ReadUInt32();
            break;
          }
          case 4898: {
            global::Weedwacker.Server.Proto.IrodoriChessSettleInfo subBuilder = new global::Weedwacker.Server.Proto.IrodoriChessSettleInfo();
            if (detailCase_ == DetailOneofCase.IrodoriChessSettleInfo) {
              subBuilder.MergeFrom(IrodoriChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            IrodoriChessSettleInfo = subBuilder;
            break;
          }
          case 10266: {
            global::Weedwacker.Server.Proto.InBattleChessSettleInfo subBuilder = new global::Weedwacker.Server.Proto.InBattleChessSettleInfo();
            if (detailCase_ == DetailOneofCase.ChessSettleInfo) {
              subBuilder.MergeFrom(ChessSettleInfo);
            }
            input.ReadMessage(subBuilder);
            ChessSettleInfo = subBuilder;
            break;
          }
          case 11218: {
            global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo subBuilder = new global::Weedwacker.Server.Proto.InBattleMechanicusSettleInfo();
            if (detailCase_ == DetailOneofCase.MechanicusSettleInfo) {
              subBuilder.MergeFrom(MechanicusSettleInfo);
            }
            input.ReadMessage(subBuilder);
            MechanicusSettleInfo = subBuilder;
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
