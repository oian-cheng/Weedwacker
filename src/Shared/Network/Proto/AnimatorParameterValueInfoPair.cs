// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AnimatorParameterValueInfoPair.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AnimatorParameterValueInfoPair.proto</summary>
  public static partial class AnimatorParameterValueInfoPairReflection {

    #region Descriptor
    /// <summary>File descriptor for AnimatorParameterValueInfoPair.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnimatorParameterValueInfoPairReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRBbmltYXRvclBhcmFtZXRlclZhbHVlSW5mb1BhaXIucHJvdG8SH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aIEFuaW1hdG9yUGFyYW1ldGVy",
            "VmFsdWVJbmZvLnByb3RvIoUBCh5BbmltYXRvclBhcmFtZXRlclZhbHVlSW5m",
            "b1BhaXISDwoHbmFtZV9pZBgBIAEoBRJSCg1hbmltYXRvcl9wYXJhGAIgASgL",
            "MjsuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5BbmltYXRvclBh",
            "cmFtZXRlclZhbHVlSW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfoPair), global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfoPair.Parser, new[]{ "NameId", "AnimatorPara" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AnimatorParameterValueInfoPair : pb::IMessage<AnimatorParameterValueInfoPair>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnimatorParameterValueInfoPair> _parser = new pb::MessageParser<AnimatorParameterValueInfoPair>(() => new AnimatorParameterValueInfoPair());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AnimatorParameterValueInfoPair> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfoPairReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorParameterValueInfoPair() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorParameterValueInfoPair(AnimatorParameterValueInfoPair other) : this() {
      nameId_ = other.nameId_;
      animatorPara_ = other.animatorPara_ != null ? other.animatorPara_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AnimatorParameterValueInfoPair Clone() {
      return new AnimatorParameterValueInfoPair(this);
    }

    /// <summary>Field number for the "name_id" field.</summary>
    public const int NameIdFieldNumber = 1;
    private int nameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NameId {
      get { return nameId_; }
      set {
        nameId_ = value;
      }
    }

    /// <summary>Field number for the "animator_para" field.</summary>
    public const int AnimatorParaFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfo animatorPara_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfo AnimatorPara {
      get { return animatorPara_; }
      set {
        animatorPara_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AnimatorParameterValueInfoPair);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AnimatorParameterValueInfoPair other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NameId != other.NameId) return false;
      if (!object.Equals(AnimatorPara, other.AnimatorPara)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NameId != 0) hash ^= NameId.GetHashCode();
      if (animatorPara_ != null) hash ^= AnimatorPara.GetHashCode();
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
      if (NameId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NameId);
      }
      if (animatorPara_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AnimatorPara);
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
      if (NameId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NameId);
      }
      if (animatorPara_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AnimatorPara);
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
      if (NameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NameId);
      }
      if (animatorPara_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AnimatorPara);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AnimatorParameterValueInfoPair other) {
      if (other == null) {
        return;
      }
      if (other.NameId != 0) {
        NameId = other.NameId;
      }
      if (other.animatorPara_ != null) {
        if (animatorPara_ == null) {
          AnimatorPara = new global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfo();
        }
        AnimatorPara.MergeFrom(other.AnimatorPara);
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
            NameId = input.ReadInt32();
            break;
          }
          case 18: {
            if (animatorPara_ == null) {
              AnimatorPara = new global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfo();
            }
            input.ReadMessage(AnimatorPara);
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
            NameId = input.ReadInt32();
            break;
          }
          case 18: {
            if (animatorPara_ == null) {
              AnimatorPara = new global::Weedwacker.Shared.Network.Proto.AnimatorParameterValueInfo();
            }
            input.ReadMessage(AnimatorPara);
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
