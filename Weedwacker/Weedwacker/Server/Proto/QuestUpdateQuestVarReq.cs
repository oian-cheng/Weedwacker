// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestUpdateQuestVarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from QuestUpdateQuestVarReq.proto</summary>
  public static partial class QuestUpdateQuestVarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestUpdateQuestVarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestUpdateQuestVarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxRdWVzdFVwZGF0ZVF1ZXN0VmFyUmVxLnByb3RvGhBRdWVzdFZhck9wLnBy",
            "b3RvIokBChZRdWVzdFVwZGF0ZVF1ZXN0VmFyUmVxEhcKD3BhcmVudF9xdWVz",
            "dF9pZBgJIAEoDRImChFxdWVzdF92YXJfb3BfbGlzdBgEIAMoCzILLlF1ZXN0",
            "VmFyT3ASEAoIcXVlc3RfaWQYCyABKA0SHAoUcGFyZW50X3F1ZXN0X3Zhcl9z",
            "ZXEYASABKA1CGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.QuestVarOpReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.QuestUpdateQuestVarReq), global::Weedwacker.Server.Proto.QuestUpdateQuestVarReq.Parser, new[]{ "ParentQuestId", "QuestVarOpList", "QuestId", "ParentQuestVarSeq" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 447
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class QuestUpdateQuestVarReq : pb::IMessage<QuestUpdateQuestVarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestUpdateQuestVarReq> _parser = new pb::MessageParser<QuestUpdateQuestVarReq>(() => new QuestUpdateQuestVarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestUpdateQuestVarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.QuestUpdateQuestVarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarReq(QuestUpdateQuestVarReq other) : this() {
      parentQuestId_ = other.parentQuestId_;
      questVarOpList_ = other.questVarOpList_.Clone();
      questId_ = other.questId_;
      parentQuestVarSeq_ = other.parentQuestVarSeq_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarReq Clone() {
      return new QuestUpdateQuestVarReq(this);
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 9;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "quest_var_op_list" field.</summary>
    public const int QuestVarOpListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.QuestVarOp> _repeated_questVarOpList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Server.Proto.QuestVarOp.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.QuestVarOp> questVarOpList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.QuestVarOp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.QuestVarOp> QuestVarOpList {
      get { return questVarOpList_; }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 11;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_var_seq" field.</summary>
    public const int ParentQuestVarSeqFieldNumber = 1;
    private uint parentQuestVarSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestVarSeq {
      get { return parentQuestVarSeq_; }
      set {
        parentQuestVarSeq_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestUpdateQuestVarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestUpdateQuestVarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ParentQuestId != other.ParentQuestId) return false;
      if(!questVarOpList_.Equals(other.questVarOpList_)) return false;
      if (QuestId != other.QuestId) return false;
      if (ParentQuestVarSeq != other.ParentQuestVarSeq) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
      hash ^= questVarOpList_.GetHashCode();
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      if (ParentQuestVarSeq != 0) hash ^= ParentQuestVarSeq.GetHashCode();
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
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestVarSeq);
      }
      questVarOpList_.WriteTo(output, _repeated_questVarOpList_codec);
      if (ParentQuestId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(QuestId);
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
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestVarSeq);
      }
      questVarOpList_.WriteTo(ref output, _repeated_questVarOpList_codec);
      if (ParentQuestId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(QuestId);
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
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      size += questVarOpList_.CalculateSize(_repeated_questVarOpList_codec);
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      if (ParentQuestVarSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestVarSeq);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestUpdateQuestVarReq other) {
      if (other == null) {
        return;
      }
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
      }
      questVarOpList_.Add(other.questVarOpList_);
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      if (other.ParentQuestVarSeq != 0) {
        ParentQuestVarSeq = other.ParentQuestVarSeq;
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
            ParentQuestVarSeq = input.ReadUInt32();
            break;
          }
          case 34: {
            questVarOpList_.AddEntriesFrom(input, _repeated_questVarOpList_codec);
            break;
          }
          case 72: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 88: {
            QuestId = input.ReadUInt32();
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
            ParentQuestVarSeq = input.ReadUInt32();
            break;
          }
          case 34: {
            questVarOpList_.AddEntriesFrom(ref input, _repeated_questVarOpList_codec);
            break;
          }
          case 72: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 88: {
            QuestId = input.ReadUInt32();
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
