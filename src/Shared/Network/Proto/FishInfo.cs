// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FishInfo.proto</summary>
  public static partial class FishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5GaXNoSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90byJECghGaXNoSW5mbxIbChNVbmszMzAwX0FLRkJGRURDRUxOGA4gASgN",
            "EhsKE1VuazMzMDBfRklJQ0xCRUZITEwYByABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FishInfo), global::Weedwacker.Shared.Network.Proto.FishInfo.Parser, new[]{ "Unk3300AKFBFEDCELN", "Unk3300FIICLBEFHLL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FishInfo : pb::IMessage<FishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishInfo> _parser = new pb::MessageParser<FishInfo>(() => new FishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishInfo(FishInfo other) : this() {
      unk3300AKFBFEDCELN_ = other.unk3300AKFBFEDCELN_;
      unk3300FIICLBEFHLL_ = other.unk3300FIICLBEFHLL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishInfo Clone() {
      return new FishInfo(this);
    }

    /// <summary>Field number for the "Unk3300_AKFBFEDCELN" field.</summary>
    public const int Unk3300AKFBFEDCELNFieldNumber = 14;
    private uint unk3300AKFBFEDCELN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AKFBFEDCELN {
      get { return unk3300AKFBFEDCELN_; }
      set {
        unk3300AKFBFEDCELN_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FIICLBEFHLL" field.</summary>
    public const int Unk3300FIICLBEFHLLFieldNumber = 7;
    private uint unk3300FIICLBEFHLL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FIICLBEFHLL {
      get { return unk3300FIICLBEFHLL_; }
      set {
        unk3300FIICLBEFHLL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300AKFBFEDCELN != other.Unk3300AKFBFEDCELN) return false;
      if (Unk3300FIICLBEFHLL != other.Unk3300FIICLBEFHLL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300AKFBFEDCELN != 0) hash ^= Unk3300AKFBFEDCELN.GetHashCode();
      if (Unk3300FIICLBEFHLL != 0) hash ^= Unk3300FIICLBEFHLL.GetHashCode();
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
      if (Unk3300FIICLBEFHLL != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300FIICLBEFHLL);
      }
      if (Unk3300AKFBFEDCELN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300AKFBFEDCELN);
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
      if (Unk3300FIICLBEFHLL != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300FIICLBEFHLL);
      }
      if (Unk3300AKFBFEDCELN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300AKFBFEDCELN);
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
      if (Unk3300AKFBFEDCELN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AKFBFEDCELN);
      }
      if (Unk3300FIICLBEFHLL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FIICLBEFHLL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300AKFBFEDCELN != 0) {
        Unk3300AKFBFEDCELN = other.Unk3300AKFBFEDCELN;
      }
      if (other.Unk3300FIICLBEFHLL != 0) {
        Unk3300FIICLBEFHLL = other.Unk3300FIICLBEFHLL;
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
          case 56: {
            Unk3300FIICLBEFHLL = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300AKFBFEDCELN = input.ReadUInt32();
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
          case 56: {
            Unk3300FIICLBEFHLL = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300AKFBFEDCELN = input.ReadUInt32();
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
