// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AdjustTrackingInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AdjustTrackingInfo.proto</summary>
  public static partial class AdjustTrackingInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AdjustTrackingInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdjustTrackingInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBZGp1c3RUcmFja2luZ0luZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8iwgEKEkFkanVzdFRyYWNraW5nSW5mbxIbChNVbmsz",
            "MzAwX0NIQ09ITEdCSExCGAIgASgJEhsKE1VuazMzMDBfR0FNTEpQRktDR0MY",
            "CSABKAkSGwoTVW5rMzMwMF9PTk5NQk5PRFBJQRgEIAEoCRIbChNVbmszMzAw",
            "X01IRE9QQU1ETVBMGAYgASgJEhsKE1VuazMzMDBfSU5BSUVPTUNJRU0YByAB",
            "KAkSGwoTVW5rMzMwMF9LTEtGTElJT0ZLSxgDIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AdjustTrackingInfo), global::Weedwacker.Shared.Network.Proto.AdjustTrackingInfo.Parser, new[]{ "Unk3300CHCOHLGBHLB", "Unk3300GAMLJPFKCGC", "Unk3300ONNMBNODPIA", "Unk3300MHDOPAMDMPL", "Unk3300INAIEOMCIEM", "Unk3300KLKFLIIOFKK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AdjustTrackingInfo : pb::IMessage<AdjustTrackingInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdjustTrackingInfo> _parser = new pb::MessageParser<AdjustTrackingInfo>(() => new AdjustTrackingInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdjustTrackingInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AdjustTrackingInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdjustTrackingInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdjustTrackingInfo(AdjustTrackingInfo other) : this() {
      unk3300CHCOHLGBHLB_ = other.unk3300CHCOHLGBHLB_;
      unk3300GAMLJPFKCGC_ = other.unk3300GAMLJPFKCGC_;
      unk3300ONNMBNODPIA_ = other.unk3300ONNMBNODPIA_;
      unk3300MHDOPAMDMPL_ = other.unk3300MHDOPAMDMPL_;
      unk3300INAIEOMCIEM_ = other.unk3300INAIEOMCIEM_;
      unk3300KLKFLIIOFKK_ = other.unk3300KLKFLIIOFKK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdjustTrackingInfo Clone() {
      return new AdjustTrackingInfo(this);
    }

    /// <summary>Field number for the "Unk3300_CHCOHLGBHLB" field.</summary>
    public const int Unk3300CHCOHLGBHLBFieldNumber = 2;
    private string unk3300CHCOHLGBHLB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300CHCOHLGBHLB {
      get { return unk3300CHCOHLGBHLB_; }
      set {
        unk3300CHCOHLGBHLB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_GAMLJPFKCGC" field.</summary>
    public const int Unk3300GAMLJPFKCGCFieldNumber = 9;
    private string unk3300GAMLJPFKCGC_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300GAMLJPFKCGC {
      get { return unk3300GAMLJPFKCGC_; }
      set {
        unk3300GAMLJPFKCGC_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_ONNMBNODPIA" field.</summary>
    public const int Unk3300ONNMBNODPIAFieldNumber = 4;
    private string unk3300ONNMBNODPIA_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300ONNMBNODPIA {
      get { return unk3300ONNMBNODPIA_; }
      set {
        unk3300ONNMBNODPIA_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_MHDOPAMDMPL" field.</summary>
    public const int Unk3300MHDOPAMDMPLFieldNumber = 6;
    private string unk3300MHDOPAMDMPL_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300MHDOPAMDMPL {
      get { return unk3300MHDOPAMDMPL_; }
      set {
        unk3300MHDOPAMDMPL_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_INAIEOMCIEM" field.</summary>
    public const int Unk3300INAIEOMCIEMFieldNumber = 7;
    private string unk3300INAIEOMCIEM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300INAIEOMCIEM {
      get { return unk3300INAIEOMCIEM_; }
      set {
        unk3300INAIEOMCIEM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_KLKFLIIOFKK" field.</summary>
    public const int Unk3300KLKFLIIOFKKFieldNumber = 3;
    private string unk3300KLKFLIIOFKK_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300KLKFLIIOFKK {
      get { return unk3300KLKFLIIOFKK_; }
      set {
        unk3300KLKFLIIOFKK_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdjustTrackingInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdjustTrackingInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300CHCOHLGBHLB != other.Unk3300CHCOHLGBHLB) return false;
      if (Unk3300GAMLJPFKCGC != other.Unk3300GAMLJPFKCGC) return false;
      if (Unk3300ONNMBNODPIA != other.Unk3300ONNMBNODPIA) return false;
      if (Unk3300MHDOPAMDMPL != other.Unk3300MHDOPAMDMPL) return false;
      if (Unk3300INAIEOMCIEM != other.Unk3300INAIEOMCIEM) return false;
      if (Unk3300KLKFLIIOFKK != other.Unk3300KLKFLIIOFKK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300CHCOHLGBHLB.Length != 0) hash ^= Unk3300CHCOHLGBHLB.GetHashCode();
      if (Unk3300GAMLJPFKCGC.Length != 0) hash ^= Unk3300GAMLJPFKCGC.GetHashCode();
      if (Unk3300ONNMBNODPIA.Length != 0) hash ^= Unk3300ONNMBNODPIA.GetHashCode();
      if (Unk3300MHDOPAMDMPL.Length != 0) hash ^= Unk3300MHDOPAMDMPL.GetHashCode();
      if (Unk3300INAIEOMCIEM.Length != 0) hash ^= Unk3300INAIEOMCIEM.GetHashCode();
      if (Unk3300KLKFLIIOFKK.Length != 0) hash ^= Unk3300KLKFLIIOFKK.GetHashCode();
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
      if (Unk3300CHCOHLGBHLB.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Unk3300CHCOHLGBHLB);
      }
      if (Unk3300KLKFLIIOFKK.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Unk3300KLKFLIIOFKK);
      }
      if (Unk3300ONNMBNODPIA.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Unk3300ONNMBNODPIA);
      }
      if (Unk3300MHDOPAMDMPL.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Unk3300MHDOPAMDMPL);
      }
      if (Unk3300INAIEOMCIEM.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk3300INAIEOMCIEM);
      }
      if (Unk3300GAMLJPFKCGC.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Unk3300GAMLJPFKCGC);
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
      if (Unk3300CHCOHLGBHLB.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Unk3300CHCOHLGBHLB);
      }
      if (Unk3300KLKFLIIOFKK.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Unk3300KLKFLIIOFKK);
      }
      if (Unk3300ONNMBNODPIA.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Unk3300ONNMBNODPIA);
      }
      if (Unk3300MHDOPAMDMPL.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Unk3300MHDOPAMDMPL);
      }
      if (Unk3300INAIEOMCIEM.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk3300INAIEOMCIEM);
      }
      if (Unk3300GAMLJPFKCGC.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Unk3300GAMLJPFKCGC);
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
      if (Unk3300CHCOHLGBHLB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300CHCOHLGBHLB);
      }
      if (Unk3300GAMLJPFKCGC.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300GAMLJPFKCGC);
      }
      if (Unk3300ONNMBNODPIA.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300ONNMBNODPIA);
      }
      if (Unk3300MHDOPAMDMPL.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300MHDOPAMDMPL);
      }
      if (Unk3300INAIEOMCIEM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300INAIEOMCIEM);
      }
      if (Unk3300KLKFLIIOFKK.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300KLKFLIIOFKK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdjustTrackingInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300CHCOHLGBHLB.Length != 0) {
        Unk3300CHCOHLGBHLB = other.Unk3300CHCOHLGBHLB;
      }
      if (other.Unk3300GAMLJPFKCGC.Length != 0) {
        Unk3300GAMLJPFKCGC = other.Unk3300GAMLJPFKCGC;
      }
      if (other.Unk3300ONNMBNODPIA.Length != 0) {
        Unk3300ONNMBNODPIA = other.Unk3300ONNMBNODPIA;
      }
      if (other.Unk3300MHDOPAMDMPL.Length != 0) {
        Unk3300MHDOPAMDMPL = other.Unk3300MHDOPAMDMPL;
      }
      if (other.Unk3300INAIEOMCIEM.Length != 0) {
        Unk3300INAIEOMCIEM = other.Unk3300INAIEOMCIEM;
      }
      if (other.Unk3300KLKFLIIOFKK.Length != 0) {
        Unk3300KLKFLIIOFKK = other.Unk3300KLKFLIIOFKK;
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
          case 18: {
            Unk3300CHCOHLGBHLB = input.ReadString();
            break;
          }
          case 26: {
            Unk3300KLKFLIIOFKK = input.ReadString();
            break;
          }
          case 34: {
            Unk3300ONNMBNODPIA = input.ReadString();
            break;
          }
          case 50: {
            Unk3300MHDOPAMDMPL = input.ReadString();
            break;
          }
          case 58: {
            Unk3300INAIEOMCIEM = input.ReadString();
            break;
          }
          case 74: {
            Unk3300GAMLJPFKCGC = input.ReadString();
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
          case 18: {
            Unk3300CHCOHLGBHLB = input.ReadString();
            break;
          }
          case 26: {
            Unk3300KLKFLIIOFKK = input.ReadString();
            break;
          }
          case 34: {
            Unk3300ONNMBNODPIA = input.ReadString();
            break;
          }
          case 50: {
            Unk3300MHDOPAMDMPL = input.ReadString();
            break;
          }
          case 58: {
            Unk3300INAIEOMCIEM = input.ReadString();
            break;
          }
          case 74: {
            Unk3300GAMLJPFKCGC = input.ReadString();
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
