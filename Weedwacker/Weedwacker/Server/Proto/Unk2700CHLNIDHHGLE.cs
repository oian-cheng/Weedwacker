// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_CHLNIDHHGLE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_CHLNIDHHGLE.proto</summary>
  public static partial class Unk2700CHLNIDHHGLEReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_CHLNIDHHGLE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700CHLNIDHHGLEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0NITE5JREhIR0xFLnByb3RvGhlVbmsyNzAwX01PRkFCUE5H",
            "SUtQLnByb3RvInAKE1VuazI3MDBfQ0hMTklESEhHTEUSDQoFc2NvcmUYCCAB",
            "KA0SJAoGcmVhc29uGA4gASgOMhQuVW5rMjcwMF9NT0ZBQlBOR0lLUBIRCglo",
            "aXRfY291bnQYCiABKA0SEQoJb3duZXJfdWlkGAYgASgNQhqqAhdXZWVkd2Fj",
            "a2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700MOFABPNGIKPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_CHLNIDHHGLE), global::Weedwacker.Server.Proto.Unk2700_CHLNIDHHGLE.Parser, new[]{ "Score", "Reason", "HitCount", "OwnerUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_CHLNIDHHGLE : pb::IMessage<Unk2700_CHLNIDHHGLE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_CHLNIDHHGLE> _parser = new pb::MessageParser<Unk2700_CHLNIDHHGLE>(() => new Unk2700_CHLNIDHHGLE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_CHLNIDHHGLE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700CHLNIDHHGLEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CHLNIDHHGLE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CHLNIDHHGLE(Unk2700_CHLNIDHHGLE other) : this() {
      score_ = other.score_;
      reason_ = other.reason_;
      hitCount_ = other.hitCount_;
      ownerUid_ = other.ownerUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CHLNIDHHGLE Clone() {
      return new Unk2700_CHLNIDHHGLE(this);
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 8;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 14;
    private global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP reason_ = global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "hit_count" field.</summary>
    public const int HitCountFieldNumber = 10;
    private uint hitCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HitCount {
      get { return hitCount_; }
      set {
        hitCount_ = value;
      }
    }

    /// <summary>Field number for the "owner_uid" field.</summary>
    public const int OwnerUidFieldNumber = 6;
    private uint ownerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerUid {
      get { return ownerUid_; }
      set {
        ownerUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_CHLNIDHHGLE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_CHLNIDHHGLE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Score != other.Score) return false;
      if (Reason != other.Reason) return false;
      if (HitCount != other.HitCount) return false;
      if (OwnerUid != other.OwnerUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) hash ^= Reason.GetHashCode();
      if (HitCount != 0) hash ^= HitCount.GetHashCode();
      if (OwnerUid != 0) hash ^= OwnerUid.GetHashCode();
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
      if (OwnerUid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OwnerUid);
      }
      if (Score != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Score);
      }
      if (HitCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HitCount);
      }
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Reason);
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
      if (OwnerUid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OwnerUid);
      }
      if (Score != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Score);
      }
      if (HitCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HitCount);
      }
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        output.WriteRawTag(112);
        output.WriteEnum((int) Reason);
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
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Reason != global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (HitCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HitCount);
      }
      if (OwnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_CHLNIDHHGLE other) {
      if (other == null) {
        return;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Reason != global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP.Unk2700Dgjfkkiblcj) {
        Reason = other.Reason;
      }
      if (other.HitCount != 0) {
        HitCount = other.HitCount;
      }
      if (other.OwnerUid != 0) {
        OwnerUid = other.OwnerUid;
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
          case 48: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 64: {
            Score = input.ReadUInt32();
            break;
          }
          case 80: {
            HitCount = input.ReadUInt32();
            break;
          }
          case 112: {
            Reason = (global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP) input.ReadEnum();
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
          case 48: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 64: {
            Score = input.ReadUInt32();
            break;
          }
          case 80: {
            HitCount = input.ReadUInt32();
            break;
          }
          case 112: {
            Reason = (global::Weedwacker.Server.Proto.Unk2700_MOFABPNGIKP) input.ReadEnum();
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
