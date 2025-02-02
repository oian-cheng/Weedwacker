// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UnlockPersonalLineRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UnlockPersonalLineRsp.proto</summary>
  public static partial class UnlockPersonalLineRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UnlockPersonalLineRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnlockPersonalLineRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtVbmxvY2tQZXJzb25hbExpbmVSc3AucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8icgoVVW5sb2NrUGVyc29uYWxMaW5lUnNwEhgK",
            "EHBlcnNvbmFsX2xpbmVfaWQYBCABKA0SDwoHcmV0Y29kZRgMIAEoBRIPCgVs",
            "ZXZlbBgKIAEoDUgAEhQKCmNoYXB0ZXJfaWQYAyABKA1IAEIHCgVwYXJhbWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UnlockPersonalLineRsp), global::Weedwacker.Shared.Network.Proto.UnlockPersonalLineRsp.Parser, new[]{ "PersonalLineId", "Retcode", "Level", "ChapterId" }, new[]{ "Param" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 421;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class UnlockPersonalLineRsp : pb::IMessage<UnlockPersonalLineRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UnlockPersonalLineRsp> _parser = new pb::MessageParser<UnlockPersonalLineRsp>(() => new UnlockPersonalLineRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UnlockPersonalLineRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UnlockPersonalLineRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockPersonalLineRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockPersonalLineRsp(UnlockPersonalLineRsp other) : this() {
      personalLineId_ = other.personalLineId_;
      retcode_ = other.retcode_;
      switch (other.ParamCase) {
        case ParamOneofCase.Level:
          Level = other.Level;
          break;
        case ParamOneofCase.ChapterId:
          ChapterId = other.ChapterId;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UnlockPersonalLineRsp Clone() {
      return new UnlockPersonalLineRsp(this);
    }

    /// <summary>Field number for the "personal_line_id" field.</summary>
    public const int PersonalLineIdFieldNumber = 4;
    private uint personalLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PersonalLineId {
      get { return personalLineId_; }
      set {
        personalLineId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return paramCase_ == ParamOneofCase.Level ? (uint) param_ : 0; }
      set {
        param_ = value;
        paramCase_ = ParamOneofCase.Level;
      }
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return paramCase_ == ParamOneofCase.ChapterId ? (uint) param_ : 0; }
      set {
        param_ = value;
        paramCase_ = ParamOneofCase.ChapterId;
      }
    }

    private object param_;
    /// <summary>Enum of possible cases for the "param" oneof.</summary>
    public enum ParamOneofCase {
      None = 0,
      Level = 10,
      ChapterId = 3,
    }
    private ParamOneofCase paramCase_ = ParamOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParamOneofCase ParamCase {
      get { return paramCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearParam() {
      paramCase_ = ParamOneofCase.None;
      param_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UnlockPersonalLineRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UnlockPersonalLineRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PersonalLineId != other.PersonalLineId) return false;
      if (Retcode != other.Retcode) return false;
      if (Level != other.Level) return false;
      if (ChapterId != other.ChapterId) return false;
      if (ParamCase != other.ParamCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PersonalLineId != 0) hash ^= PersonalLineId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (paramCase_ == ParamOneofCase.Level) hash ^= Level.GetHashCode();
      if (paramCase_ == ParamOneofCase.ChapterId) hash ^= ChapterId.GetHashCode();
      hash ^= (int) paramCase_;
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
      if (paramCase_ == ParamOneofCase.ChapterId) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChapterId);
      }
      if (PersonalLineId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PersonalLineId);
      }
      if (paramCase_ == ParamOneofCase.Level) {
        output.WriteRawTag(80);
        output.WriteUInt32(Level);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
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
      if (paramCase_ == ParamOneofCase.ChapterId) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChapterId);
      }
      if (PersonalLineId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PersonalLineId);
      }
      if (paramCase_ == ParamOneofCase.Level) {
        output.WriteRawTag(80);
        output.WriteUInt32(Level);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
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
      if (PersonalLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PersonalLineId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (paramCase_ == ParamOneofCase.Level) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (paramCase_ == ParamOneofCase.ChapterId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UnlockPersonalLineRsp other) {
      if (other == null) {
        return;
      }
      if (other.PersonalLineId != 0) {
        PersonalLineId = other.PersonalLineId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      switch (other.ParamCase) {
        case ParamOneofCase.Level:
          Level = other.Level;
          break;
        case ParamOneofCase.ChapterId:
          ChapterId = other.ChapterId;
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
          case 24: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 32: {
            PersonalLineId = input.ReadUInt32();
            break;
          }
          case 80: {
            Level = input.ReadUInt32();
            break;
          }
          case 96: {
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
          case 24: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 32: {
            PersonalLineId = input.ReadUInt32();
            break;
          }
          case 80: {
            Level = input.ReadUInt32();
            break;
          }
          case 96: {
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
