// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheckAddItemExceedLimitNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from CheckAddItemExceedLimitNotify.proto</summary>
  public static partial class CheckAddItemExceedLimitNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CheckAddItemExceedLimitNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckAddItemExceedLimitNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDaGVja0FkZEl0ZW1FeGNlZWRMaW1pdE5vdGlmeS5wcm90byL5AgodQ2hl",
            "Y2tBZGRJdGVtRXhjZWVkTGltaXROb3RpZnkSDwoHaXNfZHJvcBgFIAEoCBIf",
            "ChdleGNlZWRlZF9pdGVtX3R5cGVfbGlzdBgKIAMoDRIaChJleGNlZWRlZF9p",
            "dGVtX2xpc3QYDCADKA0SRwoIbXNnX3R5cGUYBCABKA4yNS5DaGVja0FkZEl0",
            "ZW1FeGNlZWRMaW1pdE5vdGlmeS5JdGVtRXhjZWVkTGltaXRNc2dUeXBlIsAB",
            "ChZJdGVtRXhjZWVkTGltaXRNc2dUeXBlEiYKIklURU1fRVhDRUVEX0xJTUlU",
            "X01TR19UWVBFX0RFRkFVTFQQABIjCh9JVEVNX0VYQ0VFRF9MSU1JVF9NU0df",
            "VFlQRV9URVhUEAESJQohSVRFTV9FWENFRURfTElNSVRfTVNHX1RZUEVfRElB",
            "TE9HEAISMgouSVRFTV9FWENFRURfTElNSVRfTVNHX1RZUEVfVW5rMjcwMF9C",
            "T05MR0VFRUJCRhADQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify), global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Parser, new[]{ "IsDrop", "ExceededItemTypeList", "ExceededItemList", "MsgType" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 692
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class CheckAddItemExceedLimitNotify : pb::IMessage<CheckAddItemExceedLimitNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheckAddItemExceedLimitNotify> _parser = new pb::MessageParser<CheckAddItemExceedLimitNotify>(() => new CheckAddItemExceedLimitNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheckAddItemExceedLimitNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckAddItemExceedLimitNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckAddItemExceedLimitNotify(CheckAddItemExceedLimitNotify other) : this() {
      isDrop_ = other.isDrop_;
      exceededItemTypeList_ = other.exceededItemTypeList_.Clone();
      exceededItemList_ = other.exceededItemList_.Clone();
      msgType_ = other.msgType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckAddItemExceedLimitNotify Clone() {
      return new CheckAddItemExceedLimitNotify(this);
    }

    /// <summary>Field number for the "is_drop" field.</summary>
    public const int IsDropFieldNumber = 5;
    private bool isDrop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDrop {
      get { return isDrop_; }
      set {
        isDrop_ = value;
      }
    }

    /// <summary>Field number for the "exceeded_item_type_list" field.</summary>
    public const int ExceededItemTypeListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_exceededItemTypeList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> exceededItemTypeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExceededItemTypeList {
      get { return exceededItemTypeList_; }
    }

    /// <summary>Field number for the "exceeded_item_list" field.</summary>
    public const int ExceededItemListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_exceededItemList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> exceededItemList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExceededItemList {
      get { return exceededItemList_; }
    }

    /// <summary>Field number for the "msg_type" field.</summary>
    public const int MsgTypeFieldNumber = 4;
    private global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType msgType_ = global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType MsgType {
      get { return msgType_; }
      set {
        msgType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheckAddItemExceedLimitNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheckAddItemExceedLimitNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsDrop != other.IsDrop) return false;
      if(!exceededItemTypeList_.Equals(other.exceededItemTypeList_)) return false;
      if(!exceededItemList_.Equals(other.exceededItemList_)) return false;
      if (MsgType != other.MsgType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsDrop != false) hash ^= IsDrop.GetHashCode();
      hash ^= exceededItemTypeList_.GetHashCode();
      hash ^= exceededItemList_.GetHashCode();
      if (MsgType != global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.Default) hash ^= MsgType.GetHashCode();
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
      if (MsgType != global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) MsgType);
      }
      if (IsDrop != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDrop);
      }
      exceededItemTypeList_.WriteTo(output, _repeated_exceededItemTypeList_codec);
      exceededItemList_.WriteTo(output, _repeated_exceededItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MsgType != global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) MsgType);
      }
      if (IsDrop != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDrop);
      }
      exceededItemTypeList_.WriteTo(ref output, _repeated_exceededItemTypeList_codec);
      exceededItemList_.WriteTo(ref output, _repeated_exceededItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsDrop != false) {
        size += 1 + 1;
      }
      size += exceededItemTypeList_.CalculateSize(_repeated_exceededItemTypeList_codec);
      size += exceededItemList_.CalculateSize(_repeated_exceededItemList_codec);
      if (MsgType != global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MsgType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheckAddItemExceedLimitNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsDrop != false) {
        IsDrop = other.IsDrop;
      }
      exceededItemTypeList_.Add(other.exceededItemTypeList_);
      exceededItemList_.Add(other.exceededItemList_);
      if (other.MsgType != global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.Default) {
        MsgType = other.MsgType;
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
            MsgType = (global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType) input.ReadEnum();
            break;
          }
          case 40: {
            IsDrop = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            exceededItemTypeList_.AddEntriesFrom(input, _repeated_exceededItemTypeList_codec);
            break;
          }
          case 98:
          case 96: {
            exceededItemList_.AddEntriesFrom(input, _repeated_exceededItemList_codec);
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
            MsgType = (global::Weedwacker.Server.Proto.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType) input.ReadEnum();
            break;
          }
          case 40: {
            IsDrop = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            exceededItemTypeList_.AddEntriesFrom(ref input, _repeated_exceededItemTypeList_codec);
            break;
          }
          case 98:
          case 96: {
            exceededItemList_.AddEntriesFrom(ref input, _repeated_exceededItemList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CheckAddItemExceedLimitNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ItemExceedLimitMsgType {
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_TYPE_DEFAULT")] Default = 0,
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_TYPE_TEXT")] Text = 1,
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_TYPE_DIALOG")] Dialog = 2,
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_TYPE_Unk2700_BONLGEEEBBF")] Unk2700Bonlgeeebbf = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
