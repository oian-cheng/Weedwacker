// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2800_NHEOHBNFHJD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2800_NHEOHBNFHJD.proto</summary>
  public static partial class Unk2800NHEOHBNFHJDReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2800_NHEOHBNFHJD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2800NHEOHBNFHJDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyODAwX05IRU9IQk5GSEpELnByb3RvGhlVbmsyODAwX0lPQkhCRkZB",
            "T05PLnByb3RvIn0KE1VuazI4MDBfTkhFT0hCTkZISkQSKQoLc2V0dGxlX2lu",
            "Zm8YCyABKAsyFC5VbmsyODAwX0lPQkhCRkZBT05PEhAKCHN0YWdlX2lkGAcg",
            "ASgNEhUKDWlzX25ld19yZWNvcmQYAiABKAgSEgoKZ2FsbGVyeV9pZBgBIAEo",
            "DUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2800IOBHBFFAONOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2800_NHEOHBNFHJD), global::Weedwacker.Server.Proto.Unk2800_NHEOHBNFHJD.Parser, new[]{ "SettleInfo", "StageId", "IsNewRecord", "GalleryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8870
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2800_NHEOHBNFHJD : pb::IMessage<Unk2800_NHEOHBNFHJD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2800_NHEOHBNFHJD> _parser = new pb::MessageParser<Unk2800_NHEOHBNFHJD>(() => new Unk2800_NHEOHBNFHJD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2800_NHEOHBNFHJD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2800NHEOHBNFHJDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_NHEOHBNFHJD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_NHEOHBNFHJD(Unk2800_NHEOHBNFHJD other) : this() {
      settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
      stageId_ = other.stageId_;
      isNewRecord_ = other.isNewRecord_;
      galleryId_ = other.galleryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_NHEOHBNFHJD Clone() {
      return new Unk2800_NHEOHBNFHJD(this);
    }

    /// <summary>Field number for the "settle_info" field.</summary>
    public const int SettleInfoFieldNumber = 11;
    private global::Weedwacker.Server.Proto.Unk2800_IOBHBFFAONO settleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk2800_IOBHBFFAONO SettleInfo {
      get { return settleInfo_; }
      set {
        settleInfo_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 7;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 2;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 1;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2800_NHEOHBNFHJD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2800_NHEOHBNFHJD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
      if (StageId != other.StageId) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (GalleryId != other.GalleryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
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
      if (GalleryId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GalleryId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsNewRecord);
      }
      if (StageId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SettleInfo);
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
      if (GalleryId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GalleryId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsNewRecord);
      }
      if (StageId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StageId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SettleInfo);
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
      if (settleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2800_NHEOHBNFHJD other) {
      if (other == null) {
        return;
      }
      if (other.settleInfo_ != null) {
        if (settleInfo_ == null) {
          SettleInfo = new global::Weedwacker.Server.Proto.Unk2800_IOBHBFFAONO();
        }
        SettleInfo.MergeFrom(other.SettleInfo);
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
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
            GalleryId = input.ReadUInt32();
            break;
          }
          case 16: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 56: {
            StageId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Server.Proto.Unk2800_IOBHBFFAONO();
            }
            input.ReadMessage(SettleInfo);
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
            GalleryId = input.ReadUInt32();
            break;
          }
          case 16: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 56: {
            StageId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Server.Proto.Unk2800_IOBHBFFAONO();
            }
            input.ReadMessage(SettleInfo);
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
