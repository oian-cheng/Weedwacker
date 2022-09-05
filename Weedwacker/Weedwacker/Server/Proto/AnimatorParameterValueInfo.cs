// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnimatorParameterValueInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from AnimatorParameterValueInfo.proto</summary>
  public static partial class AnimatorParameterValueInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AnimatorParameterValueInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnimatorParameterValueInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBBbmltYXRvclBhcmFtZXRlclZhbHVlSW5mby5wcm90byJ3ChpBbmltYXRv",
            "clBhcmFtZXRlclZhbHVlSW5mbxIRCglwYXJhX3R5cGUYASABKA0SEQoHaW50",
            "X3ZhbBgCIAEoBUgAEhMKCWZsb2F0X3ZhbBgDIAEoAkgAEhIKCGJvb2xfdmFs",
            "GAQgASgISABCCgoIcGFyYV92YWxCGqoCF1dlZWR3YWNrZXIuU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.AnimatorParameterValueInfo), global::Weedwacker.Server.Proto.AnimatorParameterValueInfo.Parser, new[]{ "ParaType", "IntVal", "FloatVal", "BoolVal" }, new[]{ "ParaVal" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AnimatorParameterValueInfo : pb::IMessage<AnimatorParameterValueInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnimatorParameterValueInfo> _parser = new pb::MessageParser<AnimatorParameterValueInfo>(() => new AnimatorParameterValueInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AnimatorParameterValueInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.AnimatorParameterValueInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorParameterValueInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorParameterValueInfo(AnimatorParameterValueInfo other) : this() {
      paraType_ = other.paraType_;
      switch (other.ParaValCase) {
        case ParaValOneofCase.IntVal:
          IntVal = other.IntVal;
          break;
        case ParaValOneofCase.FloatVal:
          FloatVal = other.FloatVal;
          break;
        case ParaValOneofCase.BoolVal:
          BoolVal = other.BoolVal;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorParameterValueInfo Clone() {
      return new AnimatorParameterValueInfo(this);
    }

    /// <summary>Field number for the "para_type" field.</summary>
    public const int ParaTypeFieldNumber = 1;
    private uint paraType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParaType {
      get { return paraType_; }
      set {
        paraType_ = value;
      }
    }

    /// <summary>Field number for the "int_val" field.</summary>
    public const int IntValFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntVal {
      get { return paraValCase_ == ParaValOneofCase.IntVal ? (int) paraVal_ : 0; }
      set {
        paraVal_ = value;
        paraValCase_ = ParaValOneofCase.IntVal;
      }
    }

    /// <summary>Field number for the "float_val" field.</summary>
    public const int FloatValFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FloatVal {
      get { return paraValCase_ == ParaValOneofCase.FloatVal ? (float) paraVal_ : 0F; }
      set {
        paraVal_ = value;
        paraValCase_ = ParaValOneofCase.FloatVal;
      }
    }

    /// <summary>Field number for the "bool_val" field.</summary>
    public const int BoolValFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BoolVal {
      get { return paraValCase_ == ParaValOneofCase.BoolVal ? (bool) paraVal_ : false; }
      set {
        paraVal_ = value;
        paraValCase_ = ParaValOneofCase.BoolVal;
      }
    }

    private object paraVal_;
    /// <summary>Enum of possible cases for the "para_val" oneof.</summary>
    public enum ParaValOneofCase {
      None = 0,
      IntVal = 2,
      FloatVal = 3,
      BoolVal = 4,
    }
    private ParaValOneofCase paraValCase_ = ParaValOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParaValOneofCase ParaValCase {
      get { return paraValCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearParaVal() {
      paraValCase_ = ParaValOneofCase.None;
      paraVal_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AnimatorParameterValueInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AnimatorParameterValueInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ParaType != other.ParaType) return false;
      if (IntVal != other.IntVal) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatVal, other.FloatVal)) return false;
      if (BoolVal != other.BoolVal) return false;
      if (ParaValCase != other.ParaValCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ParaType != 0) hash ^= ParaType.GetHashCode();
      if (paraValCase_ == ParaValOneofCase.IntVal) hash ^= IntVal.GetHashCode();
      if (paraValCase_ == ParaValOneofCase.FloatVal) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatVal);
      if (paraValCase_ == ParaValOneofCase.BoolVal) hash ^= BoolVal.GetHashCode();
      hash ^= (int) paraValCase_;
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
      if (ParaType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParaType);
      }
      if (paraValCase_ == ParaValOneofCase.IntVal) {
        output.WriteRawTag(16);
        output.WriteInt32(IntVal);
      }
      if (paraValCase_ == ParaValOneofCase.FloatVal) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatVal);
      }
      if (paraValCase_ == ParaValOneofCase.BoolVal) {
        output.WriteRawTag(32);
        output.WriteBool(BoolVal);
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
      if (ParaType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParaType);
      }
      if (paraValCase_ == ParaValOneofCase.IntVal) {
        output.WriteRawTag(16);
        output.WriteInt32(IntVal);
      }
      if (paraValCase_ == ParaValOneofCase.FloatVal) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatVal);
      }
      if (paraValCase_ == ParaValOneofCase.BoolVal) {
        output.WriteRawTag(32);
        output.WriteBool(BoolVal);
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
      if (ParaType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParaType);
      }
      if (paraValCase_ == ParaValOneofCase.IntVal) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntVal);
      }
      if (paraValCase_ == ParaValOneofCase.FloatVal) {
        size += 1 + 4;
      }
      if (paraValCase_ == ParaValOneofCase.BoolVal) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AnimatorParameterValueInfo other) {
      if (other == null) {
        return;
      }
      if (other.ParaType != 0) {
        ParaType = other.ParaType;
      }
      switch (other.ParaValCase) {
        case ParaValOneofCase.IntVal:
          IntVal = other.IntVal;
          break;
        case ParaValOneofCase.FloatVal:
          FloatVal = other.FloatVal;
          break;
        case ParaValOneofCase.BoolVal:
          BoolVal = other.BoolVal;
          break;
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
            ParaType = input.ReadUInt32();
            break;
          }
          case 16: {
            IntVal = input.ReadInt32();
            break;
          }
          case 29: {
            FloatVal = input.ReadFloat();
            break;
          }
          case 32: {
            BoolVal = input.ReadBool();
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
            ParaType = input.ReadUInt32();
            break;
          }
          case 16: {
            IntVal = input.ReadInt32();
            break;
          }
          case 29: {
            FloatVal = input.ReadFloat();
            break;
          }
          case 32: {
            BoolVal = input.ReadBool();
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
