// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_NNDKOICOGGH_ServerNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_NNDKOICOGGH_ServerNotify.proto</summary>
  public static partial class Unk2700NNDKOICOGGHServerNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_NNDKOICOGGH_ServerNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700NNDKOICOGGHServerNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZVbmsyNzAwX05OREtPSUNPR0dIX1NlcnZlck5vdGlmeS5wcm90byJkCiBV",
            "bmsyNzAwX05OREtPSUNPR0dIX1NlcnZlck5vdGlmeRISCgpnYWxsZXJ5X2lk",
            "GA0gASgNEhsKE1VuazI3MDBfSU5ETEZEQ09GREcYCyABKAgSDwoHYnVmZl9p",
            "ZBgOIAEoDUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_NNDKOICOGGH_ServerNotify), global::Weedwacker.Server.Proto.Unk2700_NNDKOICOGGH_ServerNotify.Parser, new[]{ "GalleryId", "Unk2700INDLFDCOFDG", "BuffId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5539
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_NNDKOICOGGH_ServerNotify : pb::IMessage<Unk2700_NNDKOICOGGH_ServerNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_NNDKOICOGGH_ServerNotify> _parser = new pb::MessageParser<Unk2700_NNDKOICOGGH_ServerNotify>(() => new Unk2700_NNDKOICOGGH_ServerNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_NNDKOICOGGH_ServerNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700NNDKOICOGGHServerNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NNDKOICOGGH_ServerNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NNDKOICOGGH_ServerNotify(Unk2700_NNDKOICOGGH_ServerNotify other) : this() {
      galleryId_ = other.galleryId_;
      unk2700INDLFDCOFDG_ = other.unk2700INDLFDCOFDG_;
      buffId_ = other.buffId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NNDKOICOGGH_ServerNotify Clone() {
      return new Unk2700_NNDKOICOGGH_ServerNotify(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 13;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_INDLFDCOFDG" field.</summary>
    public const int Unk2700INDLFDCOFDGFieldNumber = 11;
    private bool unk2700INDLFDCOFDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2700INDLFDCOFDG {
      get { return unk2700INDLFDCOFDG_; }
      set {
        unk2700INDLFDCOFDG_ = value;
      }
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 14;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_NNDKOICOGGH_ServerNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_NNDKOICOGGH_ServerNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (Unk2700INDLFDCOFDG != other.Unk2700INDLFDCOFDG) return false;
      if (BuffId != other.BuffId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (Unk2700INDLFDCOFDG != false) hash ^= Unk2700INDLFDCOFDG.GetHashCode();
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
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
      if (Unk2700INDLFDCOFDG != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk2700INDLFDCOFDG);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (Unk2700INDLFDCOFDG != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk2700INDLFDCOFDG);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (Unk2700INDLFDCOFDG != false) {
        size += 1 + 1;
      }
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_NNDKOICOGGH_ServerNotify other) {
      if (other == null) {
        return;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.Unk2700INDLFDCOFDG != false) {
        Unk2700INDLFDCOFDG = other.Unk2700INDLFDCOFDG;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
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
          case 88: {
            Unk2700INDLFDCOFDG = input.ReadBool();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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
          case 88: {
            Unk2700INDLFDCOFDG = input.ReadBool();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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
