// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtRushMoveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from EvtRushMoveNotify.proto</summary>
  public static partial class EvtRushMoveNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtRushMoveNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtRushMoveNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdFdnRSdXNoTW92ZU5vdGlmeS5wcm90bxoVRXZ0UnVzaE1vdmVJbmZvLnBy",
            "b3RvGhFGb3J3YXJkVHlwZS5wcm90byJlChFFdnRSdXNoTW92ZU5vdGlmeRIi",
            "Cgxmb3J3YXJkX3R5cGUYASABKA4yDC5Gb3J3YXJkVHlwZRIsChJldnRfcnVz",
            "aF9tb3ZlX2luZm8YDyABKAsyEC5FdnRSdXNoTW92ZUluZm9CGqoCF1dlZWR3",
            "YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.EvtRushMoveInfoReflection.Descriptor, global::Weedwacker.Server.Proto.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.EvtRushMoveNotify), global::Weedwacker.Server.Proto.EvtRushMoveNotify.Parser, new[]{ "ForwardType", "EvtRushMoveInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 375
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class EvtRushMoveNotify : pb::IMessage<EvtRushMoveNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtRushMoveNotify> _parser = new pb::MessageParser<EvtRushMoveNotify>(() => new EvtRushMoveNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtRushMoveNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.EvtRushMoveNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveNotify(EvtRushMoveNotify other) : this() {
      forwardType_ = other.forwardType_;
      evtRushMoveInfo_ = other.evtRushMoveInfo_ != null ? other.evtRushMoveInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveNotify Clone() {
      return new EvtRushMoveNotify(this);
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 1;
    private global::Weedwacker.Server.Proto.ForwardType forwardType_ = global::Weedwacker.Server.Proto.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "evt_rush_move_info" field.</summary>
    public const int EvtRushMoveInfoFieldNumber = 15;
    private global::Weedwacker.Server.Proto.EvtRushMoveInfo evtRushMoveInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.EvtRushMoveInfo EvtRushMoveInfo {
      get { return evtRushMoveInfo_; }
      set {
        evtRushMoveInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtRushMoveNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtRushMoveNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ForwardType != other.ForwardType) return false;
      if (!object.Equals(EvtRushMoveInfo, other.EvtRushMoveInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ForwardType != global::Weedwacker.Server.Proto.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (evtRushMoveInfo_ != null) hash ^= EvtRushMoveInfo.GetHashCode();
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
      if (ForwardType != global::Weedwacker.Server.Proto.ForwardType.Local) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ForwardType);
      }
      if (evtRushMoveInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(EvtRushMoveInfo);
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
      if (ForwardType != global::Weedwacker.Server.Proto.ForwardType.Local) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ForwardType);
      }
      if (evtRushMoveInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(EvtRushMoveInfo);
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
      if (ForwardType != global::Weedwacker.Server.Proto.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (evtRushMoveInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EvtRushMoveInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtRushMoveNotify other) {
      if (other == null) {
        return;
      }
      if (other.ForwardType != global::Weedwacker.Server.Proto.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.evtRushMoveInfo_ != null) {
        if (evtRushMoveInfo_ == null) {
          EvtRushMoveInfo = new global::Weedwacker.Server.Proto.EvtRushMoveInfo();
        }
        EvtRushMoveInfo.MergeFrom(other.EvtRushMoveInfo);
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
            ForwardType = (global::Weedwacker.Server.Proto.ForwardType) input.ReadEnum();
            break;
          }
          case 122: {
            if (evtRushMoveInfo_ == null) {
              EvtRushMoveInfo = new global::Weedwacker.Server.Proto.EvtRushMoveInfo();
            }
            input.ReadMessage(EvtRushMoveInfo);
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
            ForwardType = (global::Weedwacker.Server.Proto.ForwardType) input.ReadEnum();
            break;
          }
          case 122: {
            if (evtRushMoveInfo_ == null) {
              EvtRushMoveInfo = new global::Weedwacker.Server.Proto.EvtRushMoveInfo();
            }
            input.ReadMessage(EvtRushMoveInfo);
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
