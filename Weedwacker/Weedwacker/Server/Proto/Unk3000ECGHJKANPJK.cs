// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_ECGHJKANPJK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_ECGHJKANPJK.proto</summary>
  public static partial class Unk3000ECGHJKANPJKReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_ECGHJKANPJK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000ECGHJKANPJKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0VDR0hKS0FOUEpLLnByb3RvIjgKE1VuazMwMDBfRUNHSEpL",
            "QU5QSksSEAoIc3RhZ2VfaWQYCSABKA0SDwoHaXNfb3BlbhgBIAEoCEIaqgIX",
            "V2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK), global::Weedwacker.Server.Proto.Unk3000_ECGHJKANPJK.Parser, new[]{ "StageId", "IsOpen" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk3000_ECGHJKANPJK : pb::IMessage<Unk3000_ECGHJKANPJK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_ECGHJKANPJK> _parser = new pb::MessageParser<Unk3000_ECGHJKANPJK>(() => new Unk3000_ECGHJKANPJK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_ECGHJKANPJK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk3000ECGHJKANPJKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ECGHJKANPJK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ECGHJKANPJK(Unk3000_ECGHJKANPJK other) : this() {
      stageId_ = other.stageId_;
      isOpen_ = other.isOpen_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_ECGHJKANPJK Clone() {
      return new Unk3000_ECGHJKANPJK(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 9;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 1;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_ECGHJKANPJK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_ECGHJKANPJK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (IsOpen != other.IsOpen) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
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
      if (IsOpen != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsOpen);
      }
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
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
      if (IsOpen != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsOpen);
      }
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_ECGHJKANPJK other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
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
            IsOpen = input.ReadBool();
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
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
            IsOpen = input.ReadBool();
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
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
