// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassCurScheduleUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from BattlePassCurScheduleUpdateNotify.proto</summary>
  public static partial class BattlePassCurScheduleUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassCurScheduleUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassCurScheduleUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidCYXR0bGVQYXNzQ3VyU2NoZWR1bGVVcGRhdGVOb3RpZnkucHJvdG8aGEJh",
            "dHRsZVBhc3NTY2hlZHVsZS5wcm90byJpCiFCYXR0bGVQYXNzQ3VyU2NoZWR1",
            "bGVVcGRhdGVOb3RpZnkSGQoRaGF2ZV9jdXJfc2NoZWR1bGUYCyABKAgSKQoM",
            "Y3VyX3NjaGVkdWxlGAEgASgLMhMuQmF0dGxlUGFzc1NjaGVkdWxlQhqqAhdX",
            "ZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.BattlePassScheduleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.BattlePassCurScheduleUpdateNotify), global::Weedwacker.Server.Proto.BattlePassCurScheduleUpdateNotify.Parser, new[]{ "HaveCurSchedule", "CurSchedule" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2607
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class BattlePassCurScheduleUpdateNotify : pb::IMessage<BattlePassCurScheduleUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassCurScheduleUpdateNotify> _parser = new pb::MessageParser<BattlePassCurScheduleUpdateNotify>(() => new BattlePassCurScheduleUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassCurScheduleUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.BattlePassCurScheduleUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassCurScheduleUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassCurScheduleUpdateNotify(BattlePassCurScheduleUpdateNotify other) : this() {
      haveCurSchedule_ = other.haveCurSchedule_;
      curSchedule_ = other.curSchedule_ != null ? other.curSchedule_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassCurScheduleUpdateNotify Clone() {
      return new BattlePassCurScheduleUpdateNotify(this);
    }

    /// <summary>Field number for the "have_cur_schedule" field.</summary>
    public const int HaveCurScheduleFieldNumber = 11;
    private bool haveCurSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HaveCurSchedule {
      get { return haveCurSchedule_; }
      set {
        haveCurSchedule_ = value;
      }
    }

    /// <summary>Field number for the "cur_schedule" field.</summary>
    public const int CurScheduleFieldNumber = 1;
    private global::Weedwacker.Server.Proto.BattlePassSchedule curSchedule_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.BattlePassSchedule CurSchedule {
      get { return curSchedule_; }
      set {
        curSchedule_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassCurScheduleUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassCurScheduleUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HaveCurSchedule != other.HaveCurSchedule) return false;
      if (!object.Equals(CurSchedule, other.CurSchedule)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HaveCurSchedule != false) hash ^= HaveCurSchedule.GetHashCode();
      if (curSchedule_ != null) hash ^= CurSchedule.GetHashCode();
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
      if (curSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CurSchedule);
      }
      if (HaveCurSchedule != false) {
        output.WriteRawTag(88);
        output.WriteBool(HaveCurSchedule);
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
      if (curSchedule_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CurSchedule);
      }
      if (HaveCurSchedule != false) {
        output.WriteRawTag(88);
        output.WriteBool(HaveCurSchedule);
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
      if (HaveCurSchedule != false) {
        size += 1 + 1;
      }
      if (curSchedule_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurSchedule);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassCurScheduleUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.HaveCurSchedule != false) {
        HaveCurSchedule = other.HaveCurSchedule;
      }
      if (other.curSchedule_ != null) {
        if (curSchedule_ == null) {
          CurSchedule = new global::Weedwacker.Server.Proto.BattlePassSchedule();
        }
        CurSchedule.MergeFrom(other.CurSchedule);
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
          case 10: {
            if (curSchedule_ == null) {
              CurSchedule = new global::Weedwacker.Server.Proto.BattlePassSchedule();
            }
            input.ReadMessage(CurSchedule);
            break;
          }
          case 88: {
            HaveCurSchedule = input.ReadBool();
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
          case 10: {
            if (curSchedule_ == null) {
              CurSchedule = new global::Weedwacker.Server.Proto.BattlePassSchedule();
            }
            input.ReadMessage(CurSchedule);
            break;
          }
          case 88: {
            HaveCurSchedule = input.ReadBool();
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
