// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_NBFOJLAHFCA_ServerNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_NBFOJLAHFCA_ServerNotify.proto</summary>
  public static partial class Unk2700NBFOJLAHFCAServerNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_NBFOJLAHFCA_ServerNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700NBFOJLAHFCAServerNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZVbmsyNzAwX05CRk9KTEFIRkNBX1NlcnZlck5vdGlmeS5wcm90bxoZVW5r",
            "MjcwMF9KTVBDR01CSEpMRy5wcm90byJyCiBVbmsyNzAwX05CRk9KTEFIRkNB",
            "X1NlcnZlck5vdGlmeRIxChNVbmsyNzAwX0tLREhOR0dFRkRJGAwgAygLMhQu",
            "VW5rMjcwMF9KTVBDR01CSEpMRxIbChNVbmsyNzAwX0JIT0VCQ05PRUVHGAQg",
            "ASgNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700JMPCGMBHJLGReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_NBFOJLAHFCA_ServerNotify), global::Weedwacker.Server.Proto.Unk2700_NBFOJLAHFCA_ServerNotify.Parser, new[]{ "Unk2700KKDHNGGEFDI", "Unk2700BHOEBCNOEEG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5928
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_NBFOJLAHFCA_ServerNotify : pb::IMessage<Unk2700_NBFOJLAHFCA_ServerNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_NBFOJLAHFCA_ServerNotify> _parser = new pb::MessageParser<Unk2700_NBFOJLAHFCA_ServerNotify>(() => new Unk2700_NBFOJLAHFCA_ServerNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_NBFOJLAHFCA_ServerNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700NBFOJLAHFCAServerNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NBFOJLAHFCA_ServerNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NBFOJLAHFCA_ServerNotify(Unk2700_NBFOJLAHFCA_ServerNotify other) : this() {
      unk2700KKDHNGGEFDI_ = other.unk2700KKDHNGGEFDI_.Clone();
      unk2700BHOEBCNOEEG_ = other.unk2700BHOEBCNOEEG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_NBFOJLAHFCA_ServerNotify Clone() {
      return new Unk2700_NBFOJLAHFCA_ServerNotify(this);
    }

    /// <summary>Field number for the "Unk2700_KKDHNGGEFDI" field.</summary>
    public const int Unk2700KKDHNGGEFDIFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_JMPCGMBHJLG> _repeated_unk2700KKDHNGGEFDI_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Server.Proto.Unk2700_JMPCGMBHJLG.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_JMPCGMBHJLG> unk2700KKDHNGGEFDI_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_JMPCGMBHJLG>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_JMPCGMBHJLG> Unk2700KKDHNGGEFDI {
      get { return unk2700KKDHNGGEFDI_; }
    }

    /// <summary>Field number for the "Unk2700_BHOEBCNOEEG" field.</summary>
    public const int Unk2700BHOEBCNOEEGFieldNumber = 4;
    private uint unk2700BHOEBCNOEEG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700BHOEBCNOEEG {
      get { return unk2700BHOEBCNOEEG_; }
      set {
        unk2700BHOEBCNOEEG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_NBFOJLAHFCA_ServerNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_NBFOJLAHFCA_ServerNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700KKDHNGGEFDI_.Equals(other.unk2700KKDHNGGEFDI_)) return false;
      if (Unk2700BHOEBCNOEEG != other.Unk2700BHOEBCNOEEG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700KKDHNGGEFDI_.GetHashCode();
      if (Unk2700BHOEBCNOEEG != 0) hash ^= Unk2700BHOEBCNOEEG.GetHashCode();
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
      if (Unk2700BHOEBCNOEEG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk2700BHOEBCNOEEG);
      }
      unk2700KKDHNGGEFDI_.WriteTo(output, _repeated_unk2700KKDHNGGEFDI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk2700BHOEBCNOEEG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk2700BHOEBCNOEEG);
      }
      unk2700KKDHNGGEFDI_.WriteTo(ref output, _repeated_unk2700KKDHNGGEFDI_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700KKDHNGGEFDI_.CalculateSize(_repeated_unk2700KKDHNGGEFDI_codec);
      if (Unk2700BHOEBCNOEEG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700BHOEBCNOEEG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_NBFOJLAHFCA_ServerNotify other) {
      if (other == null) {
        return;
      }
      unk2700KKDHNGGEFDI_.Add(other.unk2700KKDHNGGEFDI_);
      if (other.Unk2700BHOEBCNOEEG != 0) {
        Unk2700BHOEBCNOEEG = other.Unk2700BHOEBCNOEEG;
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
          case 32: {
            Unk2700BHOEBCNOEEG = input.ReadUInt32();
            break;
          }
          case 98: {
            unk2700KKDHNGGEFDI_.AddEntriesFrom(input, _repeated_unk2700KKDHNGGEFDI_codec);
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
          case 32: {
            Unk2700BHOEBCNOEEG = input.ReadUInt32();
            break;
          }
          case 98: {
            unk2700KKDHNGGEFDI_.AddEntriesFrom(ref input, _repeated_unk2700KKDHNGGEFDI_codec);
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
