// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_BEINCMBJDAA_ClientReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_BEINCMBJDAA_ClientReq.proto</summary>
  public static partial class Unk2700BEINCMBJDAAClientReqReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_BEINCMBJDAA_ClientReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700BEINCMBJDAAClientReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVbmsyNzAwX0JFSU5DTUJKREFBX0NsaWVudFJlcS5wcm90byJ/Ch1Vbmsy",
            "NzAwX0JFSU5DTUJKREFBX0NsaWVudFJlcRIRCgl0YXJnZXRfaWQYASABKA0S",
            "GwoTVW5rMjcwMF9BRUlEQUpGSEJCQhgFIAEoAhIRCglzb3VyY2VfaWQYDSAB",
            "KA0SGwoTVW5rMjcwMF9KTExGR0FJT1BHQxgEIAEoAkIaqgIXV2VlZHdhY2tl",
            "ci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_BEINCMBJDAA_ClientReq), global::Weedwacker.Server.Proto.Unk2700_BEINCMBJDAA_ClientReq.Parser, new[]{ "TargetId", "Unk2700AEIDAJFHBBB", "SourceId", "Unk2700JLLFGAIOPGC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 333
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2700_BEINCMBJDAA_ClientReq : pb::IMessage<Unk2700_BEINCMBJDAA_ClientReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_BEINCMBJDAA_ClientReq> _parser = new pb::MessageParser<Unk2700_BEINCMBJDAA_ClientReq>(() => new Unk2700_BEINCMBJDAA_ClientReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_BEINCMBJDAA_ClientReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700BEINCMBJDAAClientReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BEINCMBJDAA_ClientReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BEINCMBJDAA_ClientReq(Unk2700_BEINCMBJDAA_ClientReq other) : this() {
      targetId_ = other.targetId_;
      unk2700AEIDAJFHBBB_ = other.unk2700AEIDAJFHBBB_;
      sourceId_ = other.sourceId_;
      unk2700JLLFGAIOPGC_ = other.unk2700JLLFGAIOPGC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BEINCMBJDAA_ClientReq Clone() {
      return new Unk2700_BEINCMBJDAA_ClientReq(this);
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 1;
    private uint targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_AEIDAJFHBBB" field.</summary>
    public const int Unk2700AEIDAJFHBBBFieldNumber = 5;
    private float unk2700AEIDAJFHBBB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk2700AEIDAJFHBBB {
      get { return unk2700AEIDAJFHBBB_; }
      set {
        unk2700AEIDAJFHBBB_ = value;
      }
    }

    /// <summary>Field number for the "source_id" field.</summary>
    public const int SourceIdFieldNumber = 13;
    private uint sourceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceId {
      get { return sourceId_; }
      set {
        sourceId_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_JLLFGAIOPGC" field.</summary>
    public const int Unk2700JLLFGAIOPGCFieldNumber = 4;
    private float unk2700JLLFGAIOPGC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk2700JLLFGAIOPGC {
      get { return unk2700JLLFGAIOPGC_; }
      set {
        unk2700JLLFGAIOPGC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_BEINCMBJDAA_ClientReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_BEINCMBJDAA_ClientReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetId != other.TargetId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk2700AEIDAJFHBBB, other.Unk2700AEIDAJFHBBB)) return false;
      if (SourceId != other.SourceId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk2700JLLFGAIOPGC, other.Unk2700JLLFGAIOPGC)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetId != 0) hash ^= TargetId.GetHashCode();
      if (Unk2700AEIDAJFHBBB != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk2700AEIDAJFHBBB);
      if (SourceId != 0) hash ^= SourceId.GetHashCode();
      if (Unk2700JLLFGAIOPGC != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk2700JLLFGAIOPGC);
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
      if (TargetId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TargetId);
      }
      if (Unk2700JLLFGAIOPGC != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Unk2700JLLFGAIOPGC);
      }
      if (Unk2700AEIDAJFHBBB != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Unk2700AEIDAJFHBBB);
      }
      if (SourceId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SourceId);
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
      if (TargetId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TargetId);
      }
      if (Unk2700JLLFGAIOPGC != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Unk2700JLLFGAIOPGC);
      }
      if (Unk2700AEIDAJFHBBB != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Unk2700AEIDAJFHBBB);
      }
      if (SourceId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SourceId);
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
      if (TargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetId);
      }
      if (Unk2700AEIDAJFHBBB != 0F) {
        size += 1 + 4;
      }
      if (SourceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceId);
      }
      if (Unk2700JLLFGAIOPGC != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_BEINCMBJDAA_ClientReq other) {
      if (other == null) {
        return;
      }
      if (other.TargetId != 0) {
        TargetId = other.TargetId;
      }
      if (other.Unk2700AEIDAJFHBBB != 0F) {
        Unk2700AEIDAJFHBBB = other.Unk2700AEIDAJFHBBB;
      }
      if (other.SourceId != 0) {
        SourceId = other.SourceId;
      }
      if (other.Unk2700JLLFGAIOPGC != 0F) {
        Unk2700JLLFGAIOPGC = other.Unk2700JLLFGAIOPGC;
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
            TargetId = input.ReadUInt32();
            break;
          }
          case 37: {
            Unk2700JLLFGAIOPGC = input.ReadFloat();
            break;
          }
          case 45: {
            Unk2700AEIDAJFHBBB = input.ReadFloat();
            break;
          }
          case 104: {
            SourceId = input.ReadUInt32();
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
            TargetId = input.ReadUInt32();
            break;
          }
          case 37: {
            Unk2700JLLFGAIOPGC = input.ReadFloat();
            break;
          }
          case 45: {
            Unk2700AEIDAJFHBBB = input.ReadFloat();
            break;
          }
          case 104: {
            SourceId = input.ReadUInt32();
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
