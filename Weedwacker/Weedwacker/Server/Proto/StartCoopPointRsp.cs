// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartCoopPointRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from StartCoopPointRsp.proto</summary>
  public static partial class StartCoopPointRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartCoopPointRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartCoopPointRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTdGFydENvb3BQb2ludFJzcC5wcm90bxoOTWFpbkNvb3AucHJvdG8ibgoR",
            "U3RhcnRDb29wUG9pbnRSc3ASEAoIaXNfc3RhcnQYCSABKAgSIgoPc3RhcnRf",
            "bWFpbl9jb29wGA8gASgLMgkuTWFpbkNvb3ASEgoKY29vcF9wb2ludBgNIAEo",
            "DRIPCgdyZXRjb2RlGAggASgFQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.MainCoopReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.StartCoopPointRsp), global::Weedwacker.Server.Proto.StartCoopPointRsp.Parser, new[]{ "IsStart", "StartMainCoop", "CoopPoint", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1964
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class StartCoopPointRsp : pb::IMessage<StartCoopPointRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartCoopPointRsp> _parser = new pb::MessageParser<StartCoopPointRsp>(() => new StartCoopPointRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartCoopPointRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.StartCoopPointRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartCoopPointRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartCoopPointRsp(StartCoopPointRsp other) : this() {
      isStart_ = other.isStart_;
      startMainCoop_ = other.startMainCoop_ != null ? other.startMainCoop_.Clone() : null;
      coopPoint_ = other.coopPoint_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartCoopPointRsp Clone() {
      return new StartCoopPointRsp(this);
    }

    /// <summary>Field number for the "is_start" field.</summary>
    public const int IsStartFieldNumber = 9;
    private bool isStart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStart {
      get { return isStart_; }
      set {
        isStart_ = value;
      }
    }

    /// <summary>Field number for the "start_main_coop" field.</summary>
    public const int StartMainCoopFieldNumber = 15;
    private global::Weedwacker.Server.Proto.MainCoop startMainCoop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.MainCoop StartMainCoop {
      get { return startMainCoop_; }
      set {
        startMainCoop_ = value;
      }
    }

    /// <summary>Field number for the "coop_point" field.</summary>
    public const int CoopPointFieldNumber = 13;
    private uint coopPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoopPoint {
      get { return coopPoint_; }
      set {
        coopPoint_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartCoopPointRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartCoopPointRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsStart != other.IsStart) return false;
      if (!object.Equals(StartMainCoop, other.StartMainCoop)) return false;
      if (CoopPoint != other.CoopPoint) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsStart != false) hash ^= IsStart.GetHashCode();
      if (startMainCoop_ != null) hash ^= StartMainCoop.GetHashCode();
      if (CoopPoint != 0) hash ^= CoopPoint.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (IsStart != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsStart);
      }
      if (CoopPoint != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CoopPoint);
      }
      if (startMainCoop_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(StartMainCoop);
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
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (IsStart != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsStart);
      }
      if (CoopPoint != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CoopPoint);
      }
      if (startMainCoop_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(StartMainCoop);
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
      if (IsStart != false) {
        size += 1 + 1;
      }
      if (startMainCoop_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartMainCoop);
      }
      if (CoopPoint != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoopPoint);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartCoopPointRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsStart != false) {
        IsStart = other.IsStart;
      }
      if (other.startMainCoop_ != null) {
        if (startMainCoop_ == null) {
          StartMainCoop = new global::Weedwacker.Server.Proto.MainCoop();
        }
        StartMainCoop.MergeFrom(other.StartMainCoop);
      }
      if (other.CoopPoint != 0) {
        CoopPoint = other.CoopPoint;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            IsStart = input.ReadBool();
            break;
          }
          case 104: {
            CoopPoint = input.ReadUInt32();
            break;
          }
          case 122: {
            if (startMainCoop_ == null) {
              StartMainCoop = new global::Weedwacker.Server.Proto.MainCoop();
            }
            input.ReadMessage(StartMainCoop);
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
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            IsStart = input.ReadBool();
            break;
          }
          case 104: {
            CoopPoint = input.ReadUInt32();
            break;
          }
          case 122: {
            if (startMainCoop_ == null) {
              StartMainCoop = new global::Weedwacker.Server.Proto.MainCoop();
            }
            input.ReadMessage(StartMainCoop);
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
