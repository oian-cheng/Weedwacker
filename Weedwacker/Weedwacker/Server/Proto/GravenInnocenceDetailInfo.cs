// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GravenInnocenceDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from GravenInnocenceDetailInfo.proto</summary>
  public static partial class GravenInnocenceDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GravenInnocenceDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GravenInnocenceDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HcmF2ZW5Jbm5vY2VuY2VEZXRhaWxJbmZvLnByb3RvGhlVbmszMDAwX0FM",
            "UEVBQ09NSVBHLnByb3RvGhlVbmszMDAwX0ZGT0JFS01PSE9JLnByb3RvGhlV",
            "bmszMDAwX0lMTE5LQkROR0tQLnByb3RvGhlVbmszMDAwX09GTUZGRUNNS0xF",
            "LnByb3RvIoICChlHcmF2ZW5Jbm5vY2VuY2VEZXRhaWxJbmZvEhkKEWlzX2Nv",
            "bnRlbnRfY2xvc2VkGAggASgIEjEKE1VuazMwMDBfSkdKS0FCSVBHTEsYCiAB",
            "KAsyFC5VbmszMDAwX09GTUZGRUNNS0xFEjEKE1VuazMwMDBfQ0RESUZITkVE",
            "T08YByABKAsyFC5VbmszMDAwX0lMTE5LQkROR0tQEjEKE1VuazMwMDBfQkRG",
            "SU9QQklPRUIYDSABKAsyFC5VbmszMDAwX0FMUEVBQ09NSVBHEjEKE1VuazMw",
            "MDBfS0RQSkdHRU5BSk0YDCABKAsyFC5VbmszMDAwX0ZGT0JFS01PSE9JQhqq",
            "AhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk3000ALPEACOMIPGReflection.Descriptor, global::Weedwacker.Server.Proto.Unk3000FFOBEKMOHOIReflection.Descriptor, global::Weedwacker.Server.Proto.Unk3000ILLNKBDNGKPReflection.Descriptor, global::Weedwacker.Server.Proto.Unk3000OFMFFECMKLEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.GravenInnocenceDetailInfo), global::Weedwacker.Server.Proto.GravenInnocenceDetailInfo.Parser, new[]{ "IsContentClosed", "Unk3000JGJKABIPGLK", "Unk3000CDDIFHNEDOO", "Unk3000BDFIOPBIOEB", "Unk3000KDPJGGENAJM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GravenInnocenceDetailInfo : pb::IMessage<GravenInnocenceDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GravenInnocenceDetailInfo> _parser = new pb::MessageParser<GravenInnocenceDetailInfo>(() => new GravenInnocenceDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GravenInnocenceDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.GravenInnocenceDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GravenInnocenceDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GravenInnocenceDetailInfo(GravenInnocenceDetailInfo other) : this() {
      isContentClosed_ = other.isContentClosed_;
      unk3000JGJKABIPGLK_ = other.unk3000JGJKABIPGLK_ != null ? other.unk3000JGJKABIPGLK_.Clone() : null;
      unk3000CDDIFHNEDOO_ = other.unk3000CDDIFHNEDOO_ != null ? other.unk3000CDDIFHNEDOO_.Clone() : null;
      unk3000BDFIOPBIOEB_ = other.unk3000BDFIOPBIOEB_ != null ? other.unk3000BDFIOPBIOEB_.Clone() : null;
      unk3000KDPJGGENAJM_ = other.unk3000KDPJGGENAJM_ != null ? other.unk3000KDPJGGENAJM_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GravenInnocenceDetailInfo Clone() {
      return new GravenInnocenceDetailInfo(this);
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 8;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_JGJKABIPGLK" field.</summary>
    public const int Unk3000JGJKABIPGLKFieldNumber = 10;
    private global::Weedwacker.Server.Proto.Unk3000_OFMFFECMKLE unk3000JGJKABIPGLK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk3000_OFMFFECMKLE Unk3000JGJKABIPGLK {
      get { return unk3000JGJKABIPGLK_; }
      set {
        unk3000JGJKABIPGLK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_CDDIFHNEDOO" field.</summary>
    public const int Unk3000CDDIFHNEDOOFieldNumber = 7;
    private global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP unk3000CDDIFHNEDOO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP Unk3000CDDIFHNEDOO {
      get { return unk3000CDDIFHNEDOO_; }
      set {
        unk3000CDDIFHNEDOO_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_BDFIOPBIOEB" field.</summary>
    public const int Unk3000BDFIOPBIOEBFieldNumber = 13;
    private global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG unk3000BDFIOPBIOEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG Unk3000BDFIOPBIOEB {
      get { return unk3000BDFIOPBIOEB_; }
      set {
        unk3000BDFIOPBIOEB_ = value;
      }
    }

    /// <summary>Field number for the "Unk3000_KDPJGGENAJM" field.</summary>
    public const int Unk3000KDPJGGENAJMFieldNumber = 12;
    private global::Weedwacker.Server.Proto.Unk3000_FFOBEKMOHOI unk3000KDPJGGENAJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk3000_FFOBEKMOHOI Unk3000KDPJGGENAJM {
      get { return unk3000KDPJGGENAJM_; }
      set {
        unk3000KDPJGGENAJM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GravenInnocenceDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GravenInnocenceDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsContentClosed != other.IsContentClosed) return false;
      if (!object.Equals(Unk3000JGJKABIPGLK, other.Unk3000JGJKABIPGLK)) return false;
      if (!object.Equals(Unk3000CDDIFHNEDOO, other.Unk3000CDDIFHNEDOO)) return false;
      if (!object.Equals(Unk3000BDFIOPBIOEB, other.Unk3000BDFIOPBIOEB)) return false;
      if (!object.Equals(Unk3000KDPJGGENAJM, other.Unk3000KDPJGGENAJM)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (unk3000JGJKABIPGLK_ != null) hash ^= Unk3000JGJKABIPGLK.GetHashCode();
      if (unk3000CDDIFHNEDOO_ != null) hash ^= Unk3000CDDIFHNEDOO.GetHashCode();
      if (unk3000BDFIOPBIOEB_ != null) hash ^= Unk3000BDFIOPBIOEB.GetHashCode();
      if (unk3000KDPJGGENAJM_ != null) hash ^= Unk3000KDPJGGENAJM.GetHashCode();
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
      if (unk3000CDDIFHNEDOO_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unk3000CDDIFHNEDOO);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsContentClosed);
      }
      if (unk3000JGJKABIPGLK_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk3000JGJKABIPGLK);
      }
      if (unk3000KDPJGGENAJM_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Unk3000KDPJGGENAJM);
      }
      if (unk3000BDFIOPBIOEB_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Unk3000BDFIOPBIOEB);
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
      if (unk3000CDDIFHNEDOO_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Unk3000CDDIFHNEDOO);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsContentClosed);
      }
      if (unk3000JGJKABIPGLK_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk3000JGJKABIPGLK);
      }
      if (unk3000KDPJGGENAJM_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Unk3000KDPJGGENAJM);
      }
      if (unk3000BDFIOPBIOEB_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Unk3000BDFIOPBIOEB);
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
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (unk3000JGJKABIPGLK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3000JGJKABIPGLK);
      }
      if (unk3000CDDIFHNEDOO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3000CDDIFHNEDOO);
      }
      if (unk3000BDFIOPBIOEB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3000BDFIOPBIOEB);
      }
      if (unk3000KDPJGGENAJM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3000KDPJGGENAJM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GravenInnocenceDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.unk3000JGJKABIPGLK_ != null) {
        if (unk3000JGJKABIPGLK_ == null) {
          Unk3000JGJKABIPGLK = new global::Weedwacker.Server.Proto.Unk3000_OFMFFECMKLE();
        }
        Unk3000JGJKABIPGLK.MergeFrom(other.Unk3000JGJKABIPGLK);
      }
      if (other.unk3000CDDIFHNEDOO_ != null) {
        if (unk3000CDDIFHNEDOO_ == null) {
          Unk3000CDDIFHNEDOO = new global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP();
        }
        Unk3000CDDIFHNEDOO.MergeFrom(other.Unk3000CDDIFHNEDOO);
      }
      if (other.unk3000BDFIOPBIOEB_ != null) {
        if (unk3000BDFIOPBIOEB_ == null) {
          Unk3000BDFIOPBIOEB = new global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG();
        }
        Unk3000BDFIOPBIOEB.MergeFrom(other.Unk3000BDFIOPBIOEB);
      }
      if (other.unk3000KDPJGGENAJM_ != null) {
        if (unk3000KDPJGGENAJM_ == null) {
          Unk3000KDPJGGENAJM = new global::Weedwacker.Server.Proto.Unk3000_FFOBEKMOHOI();
        }
        Unk3000KDPJGGENAJM.MergeFrom(other.Unk3000KDPJGGENAJM);
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
          case 58: {
            if (unk3000CDDIFHNEDOO_ == null) {
              Unk3000CDDIFHNEDOO = new global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP();
            }
            input.ReadMessage(Unk3000CDDIFHNEDOO);
            break;
          }
          case 64: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 82: {
            if (unk3000JGJKABIPGLK_ == null) {
              Unk3000JGJKABIPGLK = new global::Weedwacker.Server.Proto.Unk3000_OFMFFECMKLE();
            }
            input.ReadMessage(Unk3000JGJKABIPGLK);
            break;
          }
          case 98: {
            if (unk3000KDPJGGENAJM_ == null) {
              Unk3000KDPJGGENAJM = new global::Weedwacker.Server.Proto.Unk3000_FFOBEKMOHOI();
            }
            input.ReadMessage(Unk3000KDPJGGENAJM);
            break;
          }
          case 106: {
            if (unk3000BDFIOPBIOEB_ == null) {
              Unk3000BDFIOPBIOEB = new global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG();
            }
            input.ReadMessage(Unk3000BDFIOPBIOEB);
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
          case 58: {
            if (unk3000CDDIFHNEDOO_ == null) {
              Unk3000CDDIFHNEDOO = new global::Weedwacker.Server.Proto.Unk3000_ILLNKBDNGKP();
            }
            input.ReadMessage(Unk3000CDDIFHNEDOO);
            break;
          }
          case 64: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 82: {
            if (unk3000JGJKABIPGLK_ == null) {
              Unk3000JGJKABIPGLK = new global::Weedwacker.Server.Proto.Unk3000_OFMFFECMKLE();
            }
            input.ReadMessage(Unk3000JGJKABIPGLK);
            break;
          }
          case 98: {
            if (unk3000KDPJGGENAJM_ == null) {
              Unk3000KDPJGGENAJM = new global::Weedwacker.Server.Proto.Unk3000_FFOBEKMOHOI();
            }
            input.ReadMessage(Unk3000KDPJGGENAJM);
            break;
          }
          case 106: {
            if (unk3000BDFIOPBIOEB_ == null) {
              Unk3000BDFIOPBIOEB = new global::Weedwacker.Server.Proto.Unk3000_ALPEACOMIPG();
            }
            input.ReadMessage(Unk3000BDFIOPBIOEB);
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
