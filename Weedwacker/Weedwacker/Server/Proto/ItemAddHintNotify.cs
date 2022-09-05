// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ItemAddHintNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ItemAddHintNotify.proto</summary>
  public static partial class ItemAddHintNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ItemAddHintNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemAddHintNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdJdGVtQWRkSGludE5vdGlmeS5wcm90bxoOSXRlbUhpbnQucHJvdG8aDFZl",
            "Y3Rvci5wcm90byKFAgoRSXRlbUFkZEhpbnROb3RpZnkSGQoRaXNfcG9zaXRp",
            "b25fdmFsaWQYDiABKAgSEAoIcXVlc3RfaWQYAyABKA0SDgoGcmVhc29uGAYg",
            "ASgNEh8KF2lzX2dlbmVyYWxfcmV3YXJkX2hpZGVuGA8gASgIEhwKCWl0ZW1f",
            "bGlzdBgKIAMoCzIJLkl0ZW1IaW50EiYKHmlzX3RyYW5zZmVyZWRfZnJvbV9h",
            "dmF0YXJfY2FyZBgMIAEoCBIZCghwb3NpdGlvbhgJIAEoCzIHLlZlY3RvchIx",
            "Ch5vdmVyZmxvd190cmFuc2Zvcm1lZF9pdGVtX2xpc3QYCCADKAsyCS5JdGVt",
            "SGludEIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ItemHintReflection.Descriptor, global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ItemAddHintNotify), global::Weedwacker.Server.Proto.ItemAddHintNotify.Parser, new[]{ "IsPositionValid", "QuestId", "Reason", "IsGeneralRewardHiden", "ItemList", "IsTransferedFromAvatarCard", "Position", "OverflowTransformedItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 607
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ItemAddHintNotify : pb::IMessage<ItemAddHintNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ItemAddHintNotify> _parser = new pb::MessageParser<ItemAddHintNotify>(() => new ItemAddHintNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ItemAddHintNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ItemAddHintNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemAddHintNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemAddHintNotify(ItemAddHintNotify other) : this() {
      isPositionValid_ = other.isPositionValid_;
      questId_ = other.questId_;
      reason_ = other.reason_;
      isGeneralRewardHiden_ = other.isGeneralRewardHiden_;
      itemList_ = other.itemList_.Clone();
      isTransferedFromAvatarCard_ = other.isTransferedFromAvatarCard_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      overflowTransformedItemList_ = other.overflowTransformedItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemAddHintNotify Clone() {
      return new ItemAddHintNotify(this);
    }

    /// <summary>Field number for the "is_position_valid" field.</summary>
    public const int IsPositionValidFieldNumber = 14;
    private bool isPositionValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPositionValid {
      get { return isPositionValid_; }
      set {
        isPositionValid_ = value;
      }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 3;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 6;
    private uint reason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "is_general_reward_hiden" field.</summary>
    public const int IsGeneralRewardHidenFieldNumber = 15;
    private bool isGeneralRewardHiden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGeneralRewardHiden {
      get { return isGeneralRewardHiden_; }
      set {
        isGeneralRewardHiden_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemHint> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Server.Proto.ItemHint.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemHint> itemList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemHint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemHint> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "is_transfered_from_avatar_card" field.</summary>
    public const int IsTransferedFromAvatarCardFieldNumber = 12;
    private bool isTransferedFromAvatarCard_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTransferedFromAvatarCard {
      get { return isTransferedFromAvatarCard_; }
      set {
        isTransferedFromAvatarCard_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 9;
    private global::Weedwacker.Server.Proto.Vector position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "overflow_transformed_item_list" field.</summary>
    public const int OverflowTransformedItemListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemHint> _repeated_overflowTransformedItemList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Server.Proto.ItemHint.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemHint> overflowTransformedItemList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemHint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemHint> OverflowTransformedItemList {
      get { return overflowTransformedItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ItemAddHintNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ItemAddHintNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsPositionValid != other.IsPositionValid) return false;
      if (QuestId != other.QuestId) return false;
      if (Reason != other.Reason) return false;
      if (IsGeneralRewardHiden != other.IsGeneralRewardHiden) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (IsTransferedFromAvatarCard != other.IsTransferedFromAvatarCard) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if(!overflowTransformedItemList_.Equals(other.overflowTransformedItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsPositionValid != false) hash ^= IsPositionValid.GetHashCode();
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      if (Reason != 0) hash ^= Reason.GetHashCode();
      if (IsGeneralRewardHiden != false) hash ^= IsGeneralRewardHiden.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (IsTransferedFromAvatarCard != false) hash ^= IsTransferedFromAvatarCard.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      hash ^= overflowTransformedItemList_.GetHashCode();
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
      if (QuestId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(QuestId);
      }
      if (Reason != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Reason);
      }
      overflowTransformedItemList_.WriteTo(output, _repeated_overflowTransformedItemList_codec);
      if (position_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Position);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (IsTransferedFromAvatarCard != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsTransferedFromAvatarCard);
      }
      if (IsPositionValid != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsPositionValid);
      }
      if (IsGeneralRewardHiden != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsGeneralRewardHiden);
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
      if (QuestId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(QuestId);
      }
      if (Reason != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Reason);
      }
      overflowTransformedItemList_.WriteTo(ref output, _repeated_overflowTransformedItemList_codec);
      if (position_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Position);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (IsTransferedFromAvatarCard != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsTransferedFromAvatarCard);
      }
      if (IsPositionValid != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsPositionValid);
      }
      if (IsGeneralRewardHiden != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsGeneralRewardHiden);
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
      if (IsPositionValid != false) {
        size += 1 + 1;
      }
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      if (Reason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Reason);
      }
      if (IsGeneralRewardHiden != false) {
        size += 1 + 1;
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (IsTransferedFromAvatarCard != false) {
        size += 1 + 1;
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      size += overflowTransformedItemList_.CalculateSize(_repeated_overflowTransformedItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ItemAddHintNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsPositionValid != false) {
        IsPositionValid = other.IsPositionValid;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      if (other.Reason != 0) {
        Reason = other.Reason;
      }
      if (other.IsGeneralRewardHiden != false) {
        IsGeneralRewardHiden = other.IsGeneralRewardHiden;
      }
      itemList_.Add(other.itemList_);
      if (other.IsTransferedFromAvatarCard != false) {
        IsTransferedFromAvatarCard = other.IsTransferedFromAvatarCard;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Weedwacker.Server.Proto.Vector();
        }
        Position.MergeFrom(other.Position);
      }
      overflowTransformedItemList_.Add(other.overflowTransformedItemList_);
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
          case 24: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 48: {
            Reason = input.ReadUInt32();
            break;
          }
          case 66: {
            overflowTransformedItemList_.AddEntriesFrom(input, _repeated_overflowTransformedItemList_codec);
            break;
          }
          case 74: {
            if (position_ == null) {
              Position = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 82: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 96: {
            IsTransferedFromAvatarCard = input.ReadBool();
            break;
          }
          case 112: {
            IsPositionValid = input.ReadBool();
            break;
          }
          case 120: {
            IsGeneralRewardHiden = input.ReadBool();
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
          case 24: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 48: {
            Reason = input.ReadUInt32();
            break;
          }
          case 66: {
            overflowTransformedItemList_.AddEntriesFrom(ref input, _repeated_overflowTransformedItemList_codec);
            break;
          }
          case 74: {
            if (position_ == null) {
              Position = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
          case 82: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 96: {
            IsTransferedFromAvatarCard = input.ReadBool();
            break;
          }
          case 112: {
            IsPositionValid = input.ReadBool();
            break;
          }
          case 120: {
            IsGeneralRewardHiden = input.ReadBool();
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
