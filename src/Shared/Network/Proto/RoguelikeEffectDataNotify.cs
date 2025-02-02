// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeEffectDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RoguelikeEffectDataNotify.proto</summary>
  public static partial class RoguelikeEffectDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RoguelikeEffectDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoguelikeEffectDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2d1ZWxpa2VFZmZlY3REYXRhTm90aWZ5LnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvGhdSb2d1ZUVmZmVjdFJlY29yZC5wcm90",
            "byKqAQoZUm9ndWVsaWtlRWZmZWN0RGF0YU5vdGlmeRJFCgljYXJkX2xpc3QY",
            "AyADKAsyMi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlJvZ3Vl",
            "RWZmZWN0UmVjb3JkEkYKCmN1cnNlX2xpc3QYCCADKAsyMi5XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvLlJvZ3VlRWZmZWN0UmVjb3JkYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RogueEffectRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RoguelikeEffectDataNotify), global::Weedwacker.Shared.Network.Proto.RoguelikeEffectDataNotify.Parser, new[]{ "CardList", "CurseList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8544;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class RoguelikeEffectDataNotify : pb::IMessage<RoguelikeEffectDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoguelikeEffectDataNotify> _parser = new pb::MessageParser<RoguelikeEffectDataNotify>(() => new RoguelikeEffectDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoguelikeEffectDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RoguelikeEffectDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeEffectDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeEffectDataNotify(RoguelikeEffectDataNotify other) : this() {
      cardList_ = other.cardList_.Clone();
      curseList_ = other.curseList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeEffectDataNotify Clone() {
      return new RoguelikeEffectDataNotify(this);
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.RogueEffectRecord.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "curse_list" field.</summary>
    public const int CurseListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord> _repeated_curseList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.RogueEffectRecord.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord> curseList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueEffectRecord> CurseList {
      get { return curseList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoguelikeEffectDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoguelikeEffectDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cardList_.Equals(other.cardList_)) return false;
      if(!curseList_.Equals(other.curseList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cardList_.GetHashCode();
      hash ^= curseList_.GetHashCode();
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
      cardList_.WriteTo(output, _repeated_cardList_codec);
      curseList_.WriteTo(output, _repeated_curseList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      curseList_.WriteTo(ref output, _repeated_curseList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      size += curseList_.CalculateSize(_repeated_curseList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoguelikeEffectDataNotify other) {
      if (other == null) {
        return;
      }
      cardList_.Add(other.cardList_);
      curseList_.Add(other.curseList_);
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
          case 26: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 66: {
            curseList_.AddEntriesFrom(input, _repeated_curseList_codec);
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
          case 26: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 66: {
            curseList_.AddEntriesFrom(ref input, _repeated_curseList_codec);
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
