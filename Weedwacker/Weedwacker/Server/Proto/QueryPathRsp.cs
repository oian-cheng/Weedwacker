// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryPathRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from QueryPathRsp.proto</summary>
  public static partial class QueryPathRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryPathRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryPathRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJRdWVyeVBhdGhSc3AucHJvdG8aDFZlY3Rvci5wcm90byLlAQoMUXVlcnlQ",
            "YXRoUnNwEhAKCHF1ZXJ5X2lkGAwgASgFEhgKB2Nvcm5lcnMYBiADKAsyBy5W",
            "ZWN0b3ISMgoMcXVlcnlfc3RhdHVzGAggASgOMhwuUXVlcnlQYXRoUnNwLlBh",
            "dGhTdGF0dXNUeXBlEg8KB3JldGNvZGUYASABKAUiZAoOUGF0aFN0YXR1c1R5",
            "cGUSGQoVUEFUSF9TVEFUVVNfVFlQRV9GQUlMEAASGQoVUEFUSF9TVEFUVVNf",
            "VFlQRV9TVUNDEAESHAoYUEFUSF9TVEFUVVNfVFlQRV9QQVJUSUFMEAJCGqoC",
            "F1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.QueryPathRsp), global::Weedwacker.Server.Proto.QueryPathRsp.Parser, new[]{ "QueryId", "Corners", "QueryStatus", "Retcode" }, null, new[]{ typeof(global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2398
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class QueryPathRsp : pb::IMessage<QueryPathRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryPathRsp> _parser = new pb::MessageParser<QueryPathRsp>(() => new QueryPathRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryPathRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.QueryPathRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryPathRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryPathRsp(QueryPathRsp other) : this() {
      queryId_ = other.queryId_;
      corners_ = other.corners_.Clone();
      queryStatus_ = other.queryStatus_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryPathRsp Clone() {
      return new QueryPathRsp(this);
    }

    /// <summary>Field number for the "query_id" field.</summary>
    public const int QueryIdFieldNumber = 12;
    private int queryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int QueryId {
      get { return queryId_; }
      set {
        queryId_ = value;
      }
    }

    /// <summary>Field number for the "corners" field.</summary>
    public const int CornersFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Vector> _repeated_corners_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Server.Proto.Vector.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Vector> corners_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Vector>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Vector> Corners {
      get { return corners_; }
    }

    /// <summary>Field number for the "query_status" field.</summary>
    public const int QueryStatusFieldNumber = 8;
    private global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType queryStatus_ = global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType.Fail;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType QueryStatus {
      get { return queryStatus_; }
      set {
        queryStatus_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
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
      return Equals(other as QueryPathRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryPathRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QueryId != other.QueryId) return false;
      if(!corners_.Equals(other.corners_)) return false;
      if (QueryStatus != other.QueryStatus) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QueryId != 0) hash ^= QueryId.GetHashCode();
      hash ^= corners_.GetHashCode();
      if (QueryStatus != global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType.Fail) hash ^= QueryStatus.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      corners_.WriteTo(output, _repeated_corners_codec);
      if (QueryStatus != global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType.Fail) {
        output.WriteRawTag(64);
        output.WriteEnum((int) QueryStatus);
      }
      if (QueryId != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(QueryId);
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
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      corners_.WriteTo(ref output, _repeated_corners_codec);
      if (QueryStatus != global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType.Fail) {
        output.WriteRawTag(64);
        output.WriteEnum((int) QueryStatus);
      }
      if (QueryId != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(QueryId);
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
      if (QueryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(QueryId);
      }
      size += corners_.CalculateSize(_repeated_corners_codec);
      if (QueryStatus != global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType.Fail) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QueryStatus);
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
    public void MergeFrom(QueryPathRsp other) {
      if (other == null) {
        return;
      }
      if (other.QueryId != 0) {
        QueryId = other.QueryId;
      }
      corners_.Add(other.corners_);
      if (other.QueryStatus != global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType.Fail) {
        QueryStatus = other.QueryStatus;
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
          case 8: {
            Retcode = input.ReadInt32();
            break;
          }
          case 50: {
            corners_.AddEntriesFrom(input, _repeated_corners_codec);
            break;
          }
          case 64: {
            QueryStatus = (global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType) input.ReadEnum();
            break;
          }
          case 96: {
            QueryId = input.ReadInt32();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 50: {
            corners_.AddEntriesFrom(ref input, _repeated_corners_codec);
            break;
          }
          case 64: {
            QueryStatus = (global::Weedwacker.Server.Proto.QueryPathRsp.Types.PathStatusType) input.ReadEnum();
            break;
          }
          case 96: {
            QueryId = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the QueryPathRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum PathStatusType {
        [pbr::OriginalName("PATH_STATUS_TYPE_FAIL")] Fail = 0,
        [pbr::OriginalName("PATH_STATUS_TYPE_SUCC")] Succ = 1,
        [pbr::OriginalName("PATH_STATUS_TYPE_PARTIAL")] Partial = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
