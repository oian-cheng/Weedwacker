// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryMuqadasPotionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryMuqadasPotionInfo.proto</summary>
  public static partial class SceneGalleryMuqadasPotionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryMuqadasPotionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryMuqadasPotionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNTY2VuZUdhbGxlcnlNdXFhZGFzUG90aW9uSW5mby5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90byKIAQodU2NlbmVHYWxsZXJ5TXVx",
            "YWRhc1BvdGlvbkluZm8SDQoFc2NvcmUYASABKA0SGwoTVW5rMzMwMF9OSE9M",
            "R0dBRk1QSBgFIAEoDRIbChNVbmszMzAwX0xLRUlDT0xNUElJGAogASgNEh4K",
            "FmNhcHR1cmVfd2Vha25lc3NfY291bnQYDCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryMuqadasPotionInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryMuqadasPotionInfo.Parser, new[]{ "Score", "Unk3300NHOLGGAFMPH", "Unk3300LKEICOLMPII", "CaptureWeaknessCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryMuqadasPotionInfo : pb::IMessage<SceneGalleryMuqadasPotionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryMuqadasPotionInfo> _parser = new pb::MessageParser<SceneGalleryMuqadasPotionInfo>(() => new SceneGalleryMuqadasPotionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryMuqadasPotionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryMuqadasPotionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryMuqadasPotionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryMuqadasPotionInfo(SceneGalleryMuqadasPotionInfo other) : this() {
      score_ = other.score_;
      unk3300NHOLGGAFMPH_ = other.unk3300NHOLGGAFMPH_;
      unk3300LKEICOLMPII_ = other.unk3300LKEICOLMPII_;
      captureWeaknessCount_ = other.captureWeaknessCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryMuqadasPotionInfo Clone() {
      return new SceneGalleryMuqadasPotionInfo(this);
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 1;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NHOLGGAFMPH" field.</summary>
    public const int Unk3300NHOLGGAFMPHFieldNumber = 5;
    private uint unk3300NHOLGGAFMPH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NHOLGGAFMPH {
      get { return unk3300NHOLGGAFMPH_; }
      set {
        unk3300NHOLGGAFMPH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LKEICOLMPII" field.</summary>
    public const int Unk3300LKEICOLMPIIFieldNumber = 10;
    private uint unk3300LKEICOLMPII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LKEICOLMPII {
      get { return unk3300LKEICOLMPII_; }
      set {
        unk3300LKEICOLMPII_ = value;
      }
    }

    /// <summary>Field number for the "capture_weakness_count" field.</summary>
    public const int CaptureWeaknessCountFieldNumber = 12;
    private uint captureWeaknessCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CaptureWeaknessCount {
      get { return captureWeaknessCount_; }
      set {
        captureWeaknessCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryMuqadasPotionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryMuqadasPotionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Score != other.Score) return false;
      if (Unk3300NHOLGGAFMPH != other.Unk3300NHOLGGAFMPH) return false;
      if (Unk3300LKEICOLMPII != other.Unk3300LKEICOLMPII) return false;
      if (CaptureWeaknessCount != other.CaptureWeaknessCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Unk3300NHOLGGAFMPH != 0) hash ^= Unk3300NHOLGGAFMPH.GetHashCode();
      if (Unk3300LKEICOLMPII != 0) hash ^= Unk3300LKEICOLMPII.GetHashCode();
      if (CaptureWeaknessCount != 0) hash ^= CaptureWeaknessCount.GetHashCode();
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
      if (Score != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Score);
      }
      if (Unk3300NHOLGGAFMPH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300NHOLGGAFMPH);
      }
      if (Unk3300LKEICOLMPII != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300LKEICOLMPII);
      }
      if (CaptureWeaknessCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CaptureWeaknessCount);
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
      if (Score != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Score);
      }
      if (Unk3300NHOLGGAFMPH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300NHOLGGAFMPH);
      }
      if (Unk3300LKEICOLMPII != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300LKEICOLMPII);
      }
      if (CaptureWeaknessCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CaptureWeaknessCount);
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
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Unk3300NHOLGGAFMPH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NHOLGGAFMPH);
      }
      if (Unk3300LKEICOLMPII != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LKEICOLMPII);
      }
      if (CaptureWeaknessCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CaptureWeaknessCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryMuqadasPotionInfo other) {
      if (other == null) {
        return;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Unk3300NHOLGGAFMPH != 0) {
        Unk3300NHOLGGAFMPH = other.Unk3300NHOLGGAFMPH;
      }
      if (other.Unk3300LKEICOLMPII != 0) {
        Unk3300LKEICOLMPII = other.Unk3300LKEICOLMPII;
      }
      if (other.CaptureWeaknessCount != 0) {
        CaptureWeaknessCount = other.CaptureWeaknessCount;
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
            Score = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300NHOLGGAFMPH = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300LKEICOLMPII = input.ReadUInt32();
            break;
          }
          case 96: {
            CaptureWeaknessCount = input.ReadUInt32();
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
            Score = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300NHOLGGAFMPH = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300LKEICOLMPII = input.ReadUInt32();
            break;
          }
          case 96: {
            CaptureWeaknessCount = input.ReadUInt32();
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
