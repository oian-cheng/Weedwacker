// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_LGHJBAEBJKE_ServerRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_LGHJBAEBJKE_ServerRsp.proto</summary>
  public static partial class Unk2700LGHJBAEBJKEServerRspReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_LGHJBAEBJKE_ServerRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700LGHJBAEBJKEServerRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX0xHSEpCQUVCSktFX1NlcnZlclJzcC5wcm90bxoZVW5rMjcw",
            "MF9NSUJCSEFFTUFHSS5wcm90bxoZVW5rMjcwMF9PR0tJRE5QTU1LRy5wcm90",
            "byKWAQodVW5rMjcwMF9MR0hKQkFFQkpLRV9TZXJ2ZXJSc3ASDwoHcmV0Y29k",
            "ZRgKIAEoBRIxChNVbmsyNzAwX0hLSUZERkdISk9LGA4gASgLMhQuVW5rMjcw",
            "MF9PR0tJRE5QTU1LRxIxChNVbmsyNzAwX0tMT0FGUE1IT0tJGAUgAygLMhQu",
            "VW5rMjcwMF9NSUJCSEFFTUFHSUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700MIBBHAEMAGIReflection.Descriptor, global::Weedwacker.Server.Proto.Unk2700OGKIDNPMMKGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_LGHJBAEBJKE_ServerRsp), global::Weedwacker.Server.Proto.Unk2700_LGHJBAEBJKE_ServerRsp.Parser, new[]{ "Retcode", "Unk2700HKIFDFGHJOK", "Unk2700KLOAFPMHOKI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 6227
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_LGHJBAEBJKE_ServerRsp : pb::IMessage<Unk2700_LGHJBAEBJKE_ServerRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_LGHJBAEBJKE_ServerRsp> _parser = new pb::MessageParser<Unk2700_LGHJBAEBJKE_ServerRsp>(() => new Unk2700_LGHJBAEBJKE_ServerRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_LGHJBAEBJKE_ServerRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700LGHJBAEBJKEServerRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_LGHJBAEBJKE_ServerRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_LGHJBAEBJKE_ServerRsp(Unk2700_LGHJBAEBJKE_ServerRsp other) : this() {
      retcode_ = other.retcode_;
      unk2700HKIFDFGHJOK_ = other.unk2700HKIFDFGHJOK_ != null ? other.unk2700HKIFDFGHJOK_.Clone() : null;
      unk2700KLOAFPMHOKI_ = other.unk2700KLOAFPMHOKI_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_LGHJBAEBJKE_ServerRsp Clone() {
      return new Unk2700_LGHJBAEBJKE_ServerRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_HKIFDFGHJOK" field.</summary>
    public const int Unk2700HKIFDFGHJOKFieldNumber = 14;
    private global::Weedwacker.Server.Proto.Unk2700_OGKIDNPMMKG unk2700HKIFDFGHJOK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk2700_OGKIDNPMMKG Unk2700HKIFDFGHJOK {
      get { return unk2700HKIFDFGHJOK_; }
      set {
        unk2700HKIFDFGHJOK_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_KLOAFPMHOKI" field.</summary>
    public const int Unk2700KLOAFPMHOKIFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_MIBBHAEMAGI> _repeated_unk2700KLOAFPMHOKI_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Server.Proto.Unk2700_MIBBHAEMAGI.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_MIBBHAEMAGI> unk2700KLOAFPMHOKI_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_MIBBHAEMAGI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_MIBBHAEMAGI> Unk2700KLOAFPMHOKI {
      get { return unk2700KLOAFPMHOKI_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_LGHJBAEBJKE_ServerRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_LGHJBAEBJKE_ServerRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(Unk2700HKIFDFGHJOK, other.Unk2700HKIFDFGHJOK)) return false;
      if(!unk2700KLOAFPMHOKI_.Equals(other.unk2700KLOAFPMHOKI_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (unk2700HKIFDFGHJOK_ != null) hash ^= Unk2700HKIFDFGHJOK.GetHashCode();
      hash ^= unk2700KLOAFPMHOKI_.GetHashCode();
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
      unk2700KLOAFPMHOKI_.WriteTo(output, _repeated_unk2700KLOAFPMHOKI_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (unk2700HKIFDFGHJOK_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Unk2700HKIFDFGHJOK);
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
      unk2700KLOAFPMHOKI_.WriteTo(ref output, _repeated_unk2700KLOAFPMHOKI_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (unk2700HKIFDFGHJOK_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Unk2700HKIFDFGHJOK);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (unk2700HKIFDFGHJOK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700HKIFDFGHJOK);
      }
      size += unk2700KLOAFPMHOKI_.CalculateSize(_repeated_unk2700KLOAFPMHOKI_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_LGHJBAEBJKE_ServerRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.unk2700HKIFDFGHJOK_ != null) {
        if (unk2700HKIFDFGHJOK_ == null) {
          Unk2700HKIFDFGHJOK = new global::Weedwacker.Server.Proto.Unk2700_OGKIDNPMMKG();
        }
        Unk2700HKIFDFGHJOK.MergeFrom(other.Unk2700HKIFDFGHJOK);
      }
      unk2700KLOAFPMHOKI_.Add(other.unk2700KLOAFPMHOKI_);
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
          case 42: {
            unk2700KLOAFPMHOKI_.AddEntriesFrom(input, _repeated_unk2700KLOAFPMHOKI_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            if (unk2700HKIFDFGHJOK_ == null) {
              Unk2700HKIFDFGHJOK = new global::Weedwacker.Server.Proto.Unk2700_OGKIDNPMMKG();
            }
            input.ReadMessage(Unk2700HKIFDFGHJOK);
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
          case 42: {
            unk2700KLOAFPMHOKI_.AddEntriesFrom(ref input, _repeated_unk2700KLOAFPMHOKI_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            if (unk2700HKIFDFGHJOK_ == null) {
              Unk2700HKIFDFGHJOK = new global::Weedwacker.Server.Proto.Unk2700_OGKIDNPMMKG();
            }
            input.ReadMessage(Unk2700HKIFDFGHJOK);
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
