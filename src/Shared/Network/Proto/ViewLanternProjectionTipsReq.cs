// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ViewLanternProjectionTipsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ViewLanternProjectionTipsReq.proto</summary>
  public static partial class ViewLanternProjectionTipsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ViewLanternProjectionTipsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ViewLanternProjectionTipsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJWaWV3TGFudGVyblByb2plY3Rpb25UaXBzUmVxLnByb3RvEh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGhVDbGllbnRJbnB1dFR5cGUucHJv",
            "dG8iewocVmlld0xhbnRlcm5Qcm9qZWN0aW9uVGlwc1JlcRJECgppbnB1dF90",
            "eXBlGA4gASgOMjAuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5D",
            "bGllbnRJbnB1dFR5cGUSFQoNaXNfaW5wdXRfdGlwcxgHIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ClientInputTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ViewLanternProjectionTipsReq), global::Weedwacker.Shared.Network.Proto.ViewLanternProjectionTipsReq.Parser, new[]{ "InputType", "IsInputTips" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8560;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class ViewLanternProjectionTipsReq : pb::IMessage<ViewLanternProjectionTipsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ViewLanternProjectionTipsReq> _parser = new pb::MessageParser<ViewLanternProjectionTipsReq>(() => new ViewLanternProjectionTipsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ViewLanternProjectionTipsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ViewLanternProjectionTipsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ViewLanternProjectionTipsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ViewLanternProjectionTipsReq(ViewLanternProjectionTipsReq other) : this() {
      inputType_ = other.inputType_;
      isInputTips_ = other.isInputTips_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ViewLanternProjectionTipsReq Clone() {
      return new ViewLanternProjectionTipsReq(this);
    }

    /// <summary>Field number for the "input_type" field.</summary>
    public const int InputTypeFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.ClientInputType inputType_ = global::Weedwacker.Shared.Network.Proto.ClientInputType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ClientInputType InputType {
      get { return inputType_; }
      set {
        inputType_ = value;
      }
    }

    /// <summary>Field number for the "is_input_tips" field.</summary>
    public const int IsInputTipsFieldNumber = 7;
    private bool isInputTips_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInputTips {
      get { return isInputTips_; }
      set {
        isInputTips_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ViewLanternProjectionTipsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ViewLanternProjectionTipsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InputType != other.InputType) return false;
      if (IsInputTips != other.IsInputTips) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (InputType != global::Weedwacker.Shared.Network.Proto.ClientInputType.None) hash ^= InputType.GetHashCode();
      if (IsInputTips != false) hash ^= IsInputTips.GetHashCode();
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
      if (IsInputTips != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsInputTips);
      }
      if (InputType != global::Weedwacker.Shared.Network.Proto.ClientInputType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) InputType);
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
      if (IsInputTips != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsInputTips);
      }
      if (InputType != global::Weedwacker.Shared.Network.Proto.ClientInputType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) InputType);
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
      if (InputType != global::Weedwacker.Shared.Network.Proto.ClientInputType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InputType);
      }
      if (IsInputTips != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ViewLanternProjectionTipsReq other) {
      if (other == null) {
        return;
      }
      if (other.InputType != global::Weedwacker.Shared.Network.Proto.ClientInputType.None) {
        InputType = other.InputType;
      }
      if (other.IsInputTips != false) {
        IsInputTips = other.IsInputTips;
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
            IsInputTips = input.ReadBool();
            break;
          }
          case 112: {
            InputType = (global::Weedwacker.Shared.Network.Proto.ClientInputType) input.ReadEnum();
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
            IsInputTips = input.ReadBool();
            break;
          }
          case 112: {
            InputType = (global::Weedwacker.Shared.Network.Proto.ClientInputType) input.ReadEnum();
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
