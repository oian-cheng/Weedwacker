// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerCookReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerCookReq.proto</summary>
  public static partial class PlayerCookReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerCookReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerCookReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQbGF5ZXJDb29rUmVxLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvInMKDVBsYXllckNvb2tSZXESEQoJcmVjaXBlX2lkGAEgASgN",
            "EhsKE1VuazMzMDBfTkRQSE5OT0ZFQkwYBSABKA0SGwoTVW5rMzMwMF9KUElD",
            "TElETElFQxgHIAEoDRIVCg1hc3Npc3RfYXZhdGFyGAwgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerCookReq), global::Weedwacker.Shared.Network.Proto.PlayerCookReq.Parser, new[]{ "RecipeId", "Unk3300NDPHNNOFEBL", "Unk3300JPICLIDLIEC", "AssistAvatar" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 105;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerCookReq : pb::IMessage<PlayerCookReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerCookReq> _parser = new pb::MessageParser<PlayerCookReq>(() => new PlayerCookReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerCookReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerCookReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCookReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCookReq(PlayerCookReq other) : this() {
      recipeId_ = other.recipeId_;
      unk3300NDPHNNOFEBL_ = other.unk3300NDPHNNOFEBL_;
      unk3300JPICLIDLIEC_ = other.unk3300JPICLIDLIEC_;
      assistAvatar_ = other.assistAvatar_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCookReq Clone() {
      return new PlayerCookReq(this);
    }

    /// <summary>Field number for the "recipe_id" field.</summary>
    public const int RecipeIdFieldNumber = 1;
    private uint recipeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RecipeId {
      get { return recipeId_; }
      set {
        recipeId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NDPHNNOFEBL" field.</summary>
    public const int Unk3300NDPHNNOFEBLFieldNumber = 5;
    private uint unk3300NDPHNNOFEBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NDPHNNOFEBL {
      get { return unk3300NDPHNNOFEBL_; }
      set {
        unk3300NDPHNNOFEBL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JPICLIDLIEC" field.</summary>
    public const int Unk3300JPICLIDLIECFieldNumber = 7;
    private uint unk3300JPICLIDLIEC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JPICLIDLIEC {
      get { return unk3300JPICLIDLIEC_; }
      set {
        unk3300JPICLIDLIEC_ = value;
      }
    }

    /// <summary>Field number for the "assist_avatar" field.</summary>
    public const int AssistAvatarFieldNumber = 12;
    private uint assistAvatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistAvatar {
      get { return assistAvatar_; }
      set {
        assistAvatar_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerCookReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerCookReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RecipeId != other.RecipeId) return false;
      if (Unk3300NDPHNNOFEBL != other.Unk3300NDPHNNOFEBL) return false;
      if (Unk3300JPICLIDLIEC != other.Unk3300JPICLIDLIEC) return false;
      if (AssistAvatar != other.AssistAvatar) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RecipeId != 0) hash ^= RecipeId.GetHashCode();
      if (Unk3300NDPHNNOFEBL != 0) hash ^= Unk3300NDPHNNOFEBL.GetHashCode();
      if (Unk3300JPICLIDLIEC != 0) hash ^= Unk3300JPICLIDLIEC.GetHashCode();
      if (AssistAvatar != 0) hash ^= AssistAvatar.GetHashCode();
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
      if (RecipeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RecipeId);
      }
      if (Unk3300NDPHNNOFEBL != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300NDPHNNOFEBL);
      }
      if (Unk3300JPICLIDLIEC != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300JPICLIDLIEC);
      }
      if (AssistAvatar != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AssistAvatar);
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
      if (RecipeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RecipeId);
      }
      if (Unk3300NDPHNNOFEBL != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300NDPHNNOFEBL);
      }
      if (Unk3300JPICLIDLIEC != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300JPICLIDLIEC);
      }
      if (AssistAvatar != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AssistAvatar);
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
      if (RecipeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RecipeId);
      }
      if (Unk3300NDPHNNOFEBL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NDPHNNOFEBL);
      }
      if (Unk3300JPICLIDLIEC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JPICLIDLIEC);
      }
      if (AssistAvatar != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistAvatar);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerCookReq other) {
      if (other == null) {
        return;
      }
      if (other.RecipeId != 0) {
        RecipeId = other.RecipeId;
      }
      if (other.Unk3300NDPHNNOFEBL != 0) {
        Unk3300NDPHNNOFEBL = other.Unk3300NDPHNNOFEBL;
      }
      if (other.Unk3300JPICLIDLIEC != 0) {
        Unk3300JPICLIDLIEC = other.Unk3300JPICLIDLIEC;
      }
      if (other.AssistAvatar != 0) {
        AssistAvatar = other.AssistAvatar;
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
            RecipeId = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300NDPHNNOFEBL = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300JPICLIDLIEC = input.ReadUInt32();
            break;
          }
          case 96: {
            AssistAvatar = input.ReadUInt32();
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
            RecipeId = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300NDPHNNOFEBL = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300JPICLIDLIEC = input.ReadUInt32();
            break;
          }
          case 96: {
            AssistAvatar = input.ReadUInt32();
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
