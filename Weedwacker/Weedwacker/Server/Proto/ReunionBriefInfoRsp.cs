// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReunionBriefInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ReunionBriefInfoRsp.proto</summary>
  public static partial class ReunionBriefInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ReunionBriefInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReunionBriefInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSZXVuaW9uQnJpZWZJbmZvUnNwLnByb3RvGhZSZXVuaW9uQnJpZWZJbmZv",
            "LnByb3RvImoKE1JldW5pb25CcmllZkluZm9Sc3ASEwoLaXNfYWN0aXZhdGUY",
            "DSABKAgSDwoHcmV0Y29kZRgOIAEoBRItChJyZXVuaW9uX2JyaWVmX2luZm8Y",
            "BSABKAsyES5SZXVuaW9uQnJpZWZJbmZvQhqqAhdXZWVkd2Fja2VyLlNlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.ReunionBriefInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ReunionBriefInfoRsp), global::Weedwacker.Server.Proto.ReunionBriefInfoRsp.Parser, new[]{ "IsActivate", "Retcode", "ReunionBriefInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5068
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class ReunionBriefInfoRsp : pb::IMessage<ReunionBriefInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReunionBriefInfoRsp> _parser = new pb::MessageParser<ReunionBriefInfoRsp>(() => new ReunionBriefInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReunionBriefInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ReunionBriefInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionBriefInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionBriefInfoRsp(ReunionBriefInfoRsp other) : this() {
      isActivate_ = other.isActivate_;
      retcode_ = other.retcode_;
      reunionBriefInfo_ = other.reunionBriefInfo_ != null ? other.reunionBriefInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionBriefInfoRsp Clone() {
      return new ReunionBriefInfoRsp(this);
    }

    /// <summary>Field number for the "is_activate" field.</summary>
    public const int IsActivateFieldNumber = 13;
    private bool isActivate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActivate {
      get { return isActivate_; }
      set {
        isActivate_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "reunion_brief_info" field.</summary>
    public const int ReunionBriefInfoFieldNumber = 5;
    private global::Weedwacker.Server.Proto.ReunionBriefInfo reunionBriefInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.ReunionBriefInfo ReunionBriefInfo {
      get { return reunionBriefInfo_; }
      set {
        reunionBriefInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReunionBriefInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReunionBriefInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsActivate != other.IsActivate) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(ReunionBriefInfo, other.ReunionBriefInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsActivate != false) hash ^= IsActivate.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (reunionBriefInfo_ != null) hash ^= ReunionBriefInfo.GetHashCode();
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
      if (reunionBriefInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReunionBriefInfo);
      }
      if (IsActivate != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsActivate);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (reunionBriefInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ReunionBriefInfo);
      }
      if (IsActivate != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsActivate);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (IsActivate != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (reunionBriefInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReunionBriefInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReunionBriefInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsActivate != false) {
        IsActivate = other.IsActivate;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.reunionBriefInfo_ != null) {
        if (reunionBriefInfo_ == null) {
          ReunionBriefInfo = new global::Weedwacker.Server.Proto.ReunionBriefInfo();
        }
        ReunionBriefInfo.MergeFrom(other.ReunionBriefInfo);
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
          case 42: {
            if (reunionBriefInfo_ == null) {
              ReunionBriefInfo = new global::Weedwacker.Server.Proto.ReunionBriefInfo();
            }
            input.ReadMessage(ReunionBriefInfo);
            break;
          }
          case 104: {
            IsActivate = input.ReadBool();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
            if (reunionBriefInfo_ == null) {
              ReunionBriefInfo = new global::Weedwacker.Server.Proto.ReunionBriefInfo();
            }
            input.ReadMessage(ReunionBriefInfo);
            break;
          }
          case 104: {
            IsActivate = input.ReadBool();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
