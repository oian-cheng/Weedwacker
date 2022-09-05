// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SeaLampContributeItemRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from SeaLampContributeItemRsp.proto</summary>
  public static partial class SeaLampContributeItemRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SeaLampContributeItemRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SeaLampContributeItemRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TZWFMYW1wQ29udHJpYnV0ZUl0ZW1Sc3AucHJvdG8idwoYU2VhTGFtcENv",
            "bnRyaWJ1dGVJdGVtUnNwEhgKEGFkZF9jb250cmlidXRpb24YByABKA0SFAoM",
            "YWRkX3Byb2dyZXNzGAEgASgNEhoKEnRvdGFsX2NvbnRyaWJ1dGlvbhgOIAEo",
            "DRIPCgdyZXRjb2RlGAYgASgFQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.SeaLampContributeItemRsp), global::Weedwacker.Server.Proto.SeaLampContributeItemRsp.Parser, new[]{ "AddContribution", "AddProgress", "TotalContribution", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2139
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class SeaLampContributeItemRsp : pb::IMessage<SeaLampContributeItemRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SeaLampContributeItemRsp> _parser = new pb::MessageParser<SeaLampContributeItemRsp>(() => new SeaLampContributeItemRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SeaLampContributeItemRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.SeaLampContributeItemRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampContributeItemRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampContributeItemRsp(SeaLampContributeItemRsp other) : this() {
      addContribution_ = other.addContribution_;
      addProgress_ = other.addProgress_;
      totalContribution_ = other.totalContribution_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampContributeItemRsp Clone() {
      return new SeaLampContributeItemRsp(this);
    }

    /// <summary>Field number for the "add_contribution" field.</summary>
    public const int AddContributionFieldNumber = 7;
    private uint addContribution_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddContribution {
      get { return addContribution_; }
      set {
        addContribution_ = value;
      }
    }

    /// <summary>Field number for the "add_progress" field.</summary>
    public const int AddProgressFieldNumber = 1;
    private uint addProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddProgress {
      get { return addProgress_; }
      set {
        addProgress_ = value;
      }
    }

    /// <summary>Field number for the "total_contribution" field.</summary>
    public const int TotalContributionFieldNumber = 14;
    private uint totalContribution_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalContribution {
      get { return totalContribution_; }
      set {
        totalContribution_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
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
      return Equals(other as SeaLampContributeItemRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SeaLampContributeItemRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AddContribution != other.AddContribution) return false;
      if (AddProgress != other.AddProgress) return false;
      if (TotalContribution != other.TotalContribution) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AddContribution != 0) hash ^= AddContribution.GetHashCode();
      if (AddProgress != 0) hash ^= AddProgress.GetHashCode();
      if (TotalContribution != 0) hash ^= TotalContribution.GetHashCode();
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
      if (AddProgress != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AddProgress);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (AddContribution != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AddContribution);
      }
      if (TotalContribution != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalContribution);
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
      if (AddProgress != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AddProgress);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (AddContribution != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AddContribution);
      }
      if (TotalContribution != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalContribution);
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
      if (AddContribution != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddContribution);
      }
      if (AddProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddProgress);
      }
      if (TotalContribution != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalContribution);
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
    public void MergeFrom(SeaLampContributeItemRsp other) {
      if (other == null) {
        return;
      }
      if (other.AddContribution != 0) {
        AddContribution = other.AddContribution;
      }
      if (other.AddProgress != 0) {
        AddProgress = other.AddProgress;
      }
      if (other.TotalContribution != 0) {
        TotalContribution = other.TotalContribution;
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
            AddProgress = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 56: {
            AddContribution = input.ReadUInt32();
            break;
          }
          case 112: {
            TotalContribution = input.ReadUInt32();
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
            AddProgress = input.ReadUInt32();
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 56: {
            AddContribution = input.ReadUInt32();
            break;
          }
          case 112: {
            TotalContribution = input.ReadUInt32();
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
