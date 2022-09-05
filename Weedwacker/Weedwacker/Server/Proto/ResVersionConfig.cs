// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ResVersionConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from ResVersionConfig.proto</summary>
  public static partial class ResVersionConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for ResVersionConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResVersionConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSZXNWZXJzaW9uQ29uZmlnLnByb3RvIqIBChBSZXNWZXJzaW9uQ29uZmln",
            "Eg8KB3ZlcnNpb24YASABKA0SDwoHcmVsb2dpbhgCIAEoCBILCgNtZDUYAyAB",
            "KAkSGgoScmVsZWFzZV90b3RhbF9zaXplGAQgASgJEhYKDnZlcnNpb25fc3Vm",
            "Zml4GAUgASgJEg4KBmJyYW5jaBgGIAEoCRIbChNuZXh0X3NjcmlwdF92ZXJz",
            "aW9uGAcgASgJQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.ResVersionConfig), global::Weedwacker.Server.Proto.ResVersionConfig.Parser, new[]{ "Version", "Relogin", "Md5", "ReleaseTotalSize", "VersionSuffix", "Branch", "NextScriptVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ResVersionConfig : pb::IMessage<ResVersionConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResVersionConfig> _parser = new pb::MessageParser<ResVersionConfig>(() => new ResVersionConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResVersionConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.ResVersionConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResVersionConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResVersionConfig(ResVersionConfig other) : this() {
      version_ = other.version_;
      relogin_ = other.relogin_;
      md5_ = other.md5_;
      releaseTotalSize_ = other.releaseTotalSize_;
      versionSuffix_ = other.versionSuffix_;
      branch_ = other.branch_;
      nextScriptVersion_ = other.nextScriptVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResVersionConfig Clone() {
      return new ResVersionConfig(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "relogin" field.</summary>
    public const int ReloginFieldNumber = 2;
    private bool relogin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Relogin {
      get { return relogin_; }
      set {
        relogin_ = value;
      }
    }

    /// <summary>Field number for the "md5" field.</summary>
    public const int Md5FieldNumber = 3;
    private string md5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Md5 {
      get { return md5_; }
      set {
        md5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "release_total_size" field.</summary>
    public const int ReleaseTotalSizeFieldNumber = 4;
    private string releaseTotalSize_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ReleaseTotalSize {
      get { return releaseTotalSize_; }
      set {
        releaseTotalSize_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version_suffix" field.</summary>
    public const int VersionSuffixFieldNumber = 5;
    private string versionSuffix_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string VersionSuffix {
      get { return versionSuffix_; }
      set {
        versionSuffix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "branch" field.</summary>
    public const int BranchFieldNumber = 6;
    private string branch_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Branch {
      get { return branch_; }
      set {
        branch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "next_script_version" field.</summary>
    public const int NextScriptVersionFieldNumber = 7;
    private string nextScriptVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NextScriptVersion {
      get { return nextScriptVersion_; }
      set {
        nextScriptVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResVersionConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResVersionConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (Relogin != other.Relogin) return false;
      if (Md5 != other.Md5) return false;
      if (ReleaseTotalSize != other.ReleaseTotalSize) return false;
      if (VersionSuffix != other.VersionSuffix) return false;
      if (Branch != other.Branch) return false;
      if (NextScriptVersion != other.NextScriptVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Version != 0) hash ^= Version.GetHashCode();
      if (Relogin != false) hash ^= Relogin.GetHashCode();
      if (Md5.Length != 0) hash ^= Md5.GetHashCode();
      if (ReleaseTotalSize.Length != 0) hash ^= ReleaseTotalSize.GetHashCode();
      if (VersionSuffix.Length != 0) hash ^= VersionSuffix.GetHashCode();
      if (Branch.Length != 0) hash ^= Branch.GetHashCode();
      if (NextScriptVersion.Length != 0) hash ^= NextScriptVersion.GetHashCode();
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
      if (Version != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      if (Relogin != false) {
        output.WriteRawTag(16);
        output.WriteBool(Relogin);
      }
      if (Md5.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Md5);
      }
      if (ReleaseTotalSize.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReleaseTotalSize);
      }
      if (VersionSuffix.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(VersionSuffix);
      }
      if (Branch.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Branch);
      }
      if (NextScriptVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(NextScriptVersion);
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
      if (Version != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Version);
      }
      if (Relogin != false) {
        output.WriteRawTag(16);
        output.WriteBool(Relogin);
      }
      if (Md5.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Md5);
      }
      if (ReleaseTotalSize.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReleaseTotalSize);
      }
      if (VersionSuffix.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(VersionSuffix);
      }
      if (Branch.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Branch);
      }
      if (NextScriptVersion.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(NextScriptVersion);
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
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (Relogin != false) {
        size += 1 + 1;
      }
      if (Md5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Md5);
      }
      if (ReleaseTotalSize.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReleaseTotalSize);
      }
      if (VersionSuffix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VersionSuffix);
      }
      if (Branch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Branch);
      }
      if (NextScriptVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextScriptVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResVersionConfig other) {
      if (other == null) {
        return;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      if (other.Relogin != false) {
        Relogin = other.Relogin;
      }
      if (other.Md5.Length != 0) {
        Md5 = other.Md5;
      }
      if (other.ReleaseTotalSize.Length != 0) {
        ReleaseTotalSize = other.ReleaseTotalSize;
      }
      if (other.VersionSuffix.Length != 0) {
        VersionSuffix = other.VersionSuffix;
      }
      if (other.Branch.Length != 0) {
        Branch = other.Branch;
      }
      if (other.NextScriptVersion.Length != 0) {
        NextScriptVersion = other.NextScriptVersion;
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
            Version = input.ReadUInt32();
            break;
          }
          case 16: {
            Relogin = input.ReadBool();
            break;
          }
          case 26: {
            Md5 = input.ReadString();
            break;
          }
          case 34: {
            ReleaseTotalSize = input.ReadString();
            break;
          }
          case 42: {
            VersionSuffix = input.ReadString();
            break;
          }
          case 50: {
            Branch = input.ReadString();
            break;
          }
          case 58: {
            NextScriptVersion = input.ReadString();
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
            Version = input.ReadUInt32();
            break;
          }
          case 16: {
            Relogin = input.ReadBool();
            break;
          }
          case 26: {
            Md5 = input.ReadString();
            break;
          }
          case 34: {
            ReleaseTotalSize = input.ReadString();
            break;
          }
          case 42: {
            VersionSuffix = input.ReadString();
            break;
          }
          case 50: {
            Branch = input.ReadString();
            break;
          }
          case 58: {
            NextScriptVersion = input.ReadString();
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
