// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReunionPrivilegeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ReunionPrivilegeInfo.proto</summary>
  public static partial class ReunionPrivilegeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ReunionPrivilegeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReunionPrivilegeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSZXVuaW9uUHJpdmlsZWdlSW5mby5wcm90byJYChRSZXVuaW9uUHJpdmls",
            "ZWdlSW5mbxIVCg1jdXJfZGF5X2NvdW50GAcgASgNEhMKC3RvdGFsX2NvdW50",
            "GAogASgNEhQKDHByaXZpbGVnZV9pZBgEIAEoDUIaqgIXV2VlZHdhY2tlci5T",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ReunionPrivilegeInfo), global::Weedwacker.Server.Proto.ReunionPrivilegeInfo.Parser, new[]{ "CurDayCount", "TotalCount", "PrivilegeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReunionPrivilegeInfo : pb::IMessage<ReunionPrivilegeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReunionPrivilegeInfo> _parser = new pb::MessageParser<ReunionPrivilegeInfo>(() => new ReunionPrivilegeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReunionPrivilegeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ReunionPrivilegeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionPrivilegeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionPrivilegeInfo(ReunionPrivilegeInfo other) : this() {
      curDayCount_ = other.curDayCount_;
      totalCount_ = other.totalCount_;
      privilegeId_ = other.privilegeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionPrivilegeInfo Clone() {
      return new ReunionPrivilegeInfo(this);
    }

    /// <summary>Field number for the "cur_day_count" field.</summary>
    public const int CurDayCountFieldNumber = 7;
    private uint curDayCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurDayCount {
      get { return curDayCount_; }
      set {
        curDayCount_ = value;
      }
    }

    /// <summary>Field number for the "total_count" field.</summary>
    public const int TotalCountFieldNumber = 10;
    private uint totalCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalCount {
      get { return totalCount_; }
      set {
        totalCount_ = value;
      }
    }

    /// <summary>Field number for the "privilege_id" field.</summary>
    public const int PrivilegeIdFieldNumber = 4;
    private uint privilegeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrivilegeId {
      get { return privilegeId_; }
      set {
        privilegeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReunionPrivilegeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReunionPrivilegeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurDayCount != other.CurDayCount) return false;
      if (TotalCount != other.TotalCount) return false;
      if (PrivilegeId != other.PrivilegeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurDayCount != 0) hash ^= CurDayCount.GetHashCode();
      if (TotalCount != 0) hash ^= TotalCount.GetHashCode();
      if (PrivilegeId != 0) hash ^= PrivilegeId.GetHashCode();
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
      if (PrivilegeId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PrivilegeId);
      }
      if (CurDayCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CurDayCount);
      }
      if (TotalCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TotalCount);
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
      if (PrivilegeId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PrivilegeId);
      }
      if (CurDayCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CurDayCount);
      }
      if (TotalCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TotalCount);
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
      if (CurDayCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurDayCount);
      }
      if (TotalCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalCount);
      }
      if (PrivilegeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrivilegeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReunionPrivilegeInfo other) {
      if (other == null) {
        return;
      }
      if (other.CurDayCount != 0) {
        CurDayCount = other.CurDayCount;
      }
      if (other.TotalCount != 0) {
        TotalCount = other.TotalCount;
      }
      if (other.PrivilegeId != 0) {
        PrivilegeId = other.PrivilegeId;
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
          case 32: {
            PrivilegeId = input.ReadUInt32();
            break;
          }
          case 56: {
            CurDayCount = input.ReadUInt32();
            break;
          }
          case 80: {
            TotalCount = input.ReadUInt32();
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
          case 32: {
            PrivilegeId = input.ReadUInt32();
            break;
          }
          case 56: {
            CurDayCount = input.ReadUInt32();
            break;
          }
          case 80: {
            TotalCount = input.ReadUInt32();
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
