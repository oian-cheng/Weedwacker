// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoinCollectGallerySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CoinCollectGallerySettleNotify.proto</summary>
  public static partial class CoinCollectGallerySettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CoinCollectGallerySettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoinCollectGallerySettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRDb2luQ29sbGVjdEdhbGxlcnlTZXR0bGVOb3RpZnkucHJvdG8SH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8ivwEKHkNvaW5Db2xsZWN0R2Fs",
            "bGVyeVNldHRsZU5vdGlmeRIQCghsZXZlbF9pZBgCIAEoDRIbChNVbmszMzAw",
            "X0RLQkpNTEpHTElCGA0gASgNEhsKE1VuazMzMDBfS0RIRE1PR0pETkwYDiAB",
            "KA0SHQoVbXVsdGlzdGFnZV9wbGF5X2luZGV4GAggASgNEhsKE1VuazMzMDBf",
            "Q1BMRFBDTUJIT0UYBiABKA0SFQoNaXNfbmV3X3JlY29yZBgPIAEoCGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CoinCollectGallerySettleNotify), global::Weedwacker.Shared.Network.Proto.CoinCollectGallerySettleNotify.Parser, new[]{ "LevelId", "Unk3300DKBJMLJGLIB", "Unk3300KDHDMOGJDNL", "MultistagePlayIndex", "Unk3300CPLDPCMBHOE", "IsNewRecord" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5546;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class CoinCollectGallerySettleNotify : pb::IMessage<CoinCollectGallerySettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CoinCollectGallerySettleNotify> _parser = new pb::MessageParser<CoinCollectGallerySettleNotify>(() => new CoinCollectGallerySettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CoinCollectGallerySettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CoinCollectGallerySettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoinCollectGallerySettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoinCollectGallerySettleNotify(CoinCollectGallerySettleNotify other) : this() {
      levelId_ = other.levelId_;
      unk3300DKBJMLJGLIB_ = other.unk3300DKBJMLJGLIB_;
      unk3300KDHDMOGJDNL_ = other.unk3300KDHDMOGJDNL_;
      multistagePlayIndex_ = other.multistagePlayIndex_;
      unk3300CPLDPCMBHOE_ = other.unk3300CPLDPCMBHOE_;
      isNewRecord_ = other.isNewRecord_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoinCollectGallerySettleNotify Clone() {
      return new CoinCollectGallerySettleNotify(this);
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 2;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DKBJMLJGLIB" field.</summary>
    public const int Unk3300DKBJMLJGLIBFieldNumber = 13;
    private uint unk3300DKBJMLJGLIB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DKBJMLJGLIB {
      get { return unk3300DKBJMLJGLIB_; }
      set {
        unk3300DKBJMLJGLIB_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KDHDMOGJDNL" field.</summary>
    public const int Unk3300KDHDMOGJDNLFieldNumber = 14;
    private uint unk3300KDHDMOGJDNL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KDHDMOGJDNL {
      get { return unk3300KDHDMOGJDNL_; }
      set {
        unk3300KDHDMOGJDNL_ = value;
      }
    }

    /// <summary>Field number for the "multistage_play_index" field.</summary>
    public const int MultistagePlayIndexFieldNumber = 8;
    private uint multistagePlayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MultistagePlayIndex {
      get { return multistagePlayIndex_; }
      set {
        multistagePlayIndex_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_CPLDPCMBHOE" field.</summary>
    public const int Unk3300CPLDPCMBHOEFieldNumber = 6;
    private uint unk3300CPLDPCMBHOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300CPLDPCMBHOE {
      get { return unk3300CPLDPCMBHOE_; }
      set {
        unk3300CPLDPCMBHOE_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 15;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CoinCollectGallerySettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CoinCollectGallerySettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LevelId != other.LevelId) return false;
      if (Unk3300DKBJMLJGLIB != other.Unk3300DKBJMLJGLIB) return false;
      if (Unk3300KDHDMOGJDNL != other.Unk3300KDHDMOGJDNL) return false;
      if (MultistagePlayIndex != other.MultistagePlayIndex) return false;
      if (Unk3300CPLDPCMBHOE != other.Unk3300CPLDPCMBHOE) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Unk3300DKBJMLJGLIB != 0) hash ^= Unk3300DKBJMLJGLIB.GetHashCode();
      if (Unk3300KDHDMOGJDNL != 0) hash ^= Unk3300KDHDMOGJDNL.GetHashCode();
      if (MultistagePlayIndex != 0) hash ^= MultistagePlayIndex.GetHashCode();
      if (Unk3300CPLDPCMBHOE != 0) hash ^= Unk3300CPLDPCMBHOE.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LevelId);
      }
      if (Unk3300CPLDPCMBHOE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300CPLDPCMBHOE);
      }
      if (MultistagePlayIndex != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MultistagePlayIndex);
      }
      if (Unk3300DKBJMLJGLIB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300DKBJMLJGLIB);
      }
      if (Unk3300KDHDMOGJDNL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300KDHDMOGJDNL);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsNewRecord);
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
      if (LevelId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LevelId);
      }
      if (Unk3300CPLDPCMBHOE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300CPLDPCMBHOE);
      }
      if (MultistagePlayIndex != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MultistagePlayIndex);
      }
      if (Unk3300DKBJMLJGLIB != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300DKBJMLJGLIB);
      }
      if (Unk3300KDHDMOGJDNL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300KDHDMOGJDNL);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsNewRecord);
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
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (Unk3300DKBJMLJGLIB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DKBJMLJGLIB);
      }
      if (Unk3300KDHDMOGJDNL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KDHDMOGJDNL);
      }
      if (MultistagePlayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MultistagePlayIndex);
      }
      if (Unk3300CPLDPCMBHOE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300CPLDPCMBHOE);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CoinCollectGallerySettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Unk3300DKBJMLJGLIB != 0) {
        Unk3300DKBJMLJGLIB = other.Unk3300DKBJMLJGLIB;
      }
      if (other.Unk3300KDHDMOGJDNL != 0) {
        Unk3300KDHDMOGJDNL = other.Unk3300KDHDMOGJDNL;
      }
      if (other.MultistagePlayIndex != 0) {
        MultistagePlayIndex = other.MultistagePlayIndex;
      }
      if (other.Unk3300CPLDPCMBHOE != 0) {
        Unk3300CPLDPCMBHOE = other.Unk3300CPLDPCMBHOE;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300CPLDPCMBHOE = input.ReadUInt32();
            break;
          }
          case 64: {
            MultistagePlayIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300DKBJMLJGLIB = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300KDHDMOGJDNL = input.ReadUInt32();
            break;
          }
          case 120: {
            IsNewRecord = input.ReadBool();
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300CPLDPCMBHOE = input.ReadUInt32();
            break;
          }
          case 64: {
            MultistagePlayIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300DKBJMLJGLIB = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300KDHDMOGJDNL = input.ReadUInt32();
            break;
          }
          case 120: {
            IsNewRecord = input.ReadBool();
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
