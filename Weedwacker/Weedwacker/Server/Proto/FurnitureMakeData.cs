// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FurnitureMakeData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from FurnitureMakeData.proto</summary>
  public static partial class FurnitureMakeDataReflection {

    #region Descriptor
    /// <summary>File descriptor for FurnitureMakeData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FurnitureMakeDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdGdXJuaXR1cmVNYWtlRGF0YS5wcm90byKFAQoRRnVybml0dXJlTWFrZURh",
            "dGESDQoFaW5kZXgYDyABKA0SEAoIZHVyX3RpbWUYASABKA0SEgoKYmVnaW5f",
            "dGltZRgLIAEoBxIXCg9hY2NlbGVyYXRlX3RpbWUYBiABKAcSEQoJYXZhdGFy",
            "X2lkGAIgASgNEg8KB21ha2VfaWQYBSABKA1CGqoCF1dlZWR3YWNrZXIuU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.FurnitureMakeData), global::Weedwacker.Server.Proto.FurnitureMakeData.Parser, new[]{ "Index", "DurTime", "BeginTime", "AccelerateTime", "AvatarId", "MakeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FurnitureMakeData : pb::IMessage<FurnitureMakeData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FurnitureMakeData> _parser = new pb::MessageParser<FurnitureMakeData>(() => new FurnitureMakeData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FurnitureMakeData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.FurnitureMakeDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeData(FurnitureMakeData other) : this() {
      index_ = other.index_;
      durTime_ = other.durTime_;
      beginTime_ = other.beginTime_;
      accelerateTime_ = other.accelerateTime_;
      avatarId_ = other.avatarId_;
      makeId_ = other.makeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeData Clone() {
      return new FurnitureMakeData(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 15;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "dur_time" field.</summary>
    public const int DurTimeFieldNumber = 1;
    private uint durTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DurTime {
      get { return durTime_; }
      set {
        durTime_ = value;
      }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 11;
    private uint beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "accelerate_time" field.</summary>
    public const int AccelerateTimeFieldNumber = 6;
    private uint accelerateTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AccelerateTime {
      get { return accelerateTime_; }
      set {
        accelerateTime_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 2;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "make_id" field.</summary>
    public const int MakeIdFieldNumber = 5;
    private uint makeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MakeId {
      get { return makeId_; }
      set {
        makeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FurnitureMakeData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FurnitureMakeData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (DurTime != other.DurTime) return false;
      if (BeginTime != other.BeginTime) return false;
      if (AccelerateTime != other.AccelerateTime) return false;
      if (AvatarId != other.AvatarId) return false;
      if (MakeId != other.MakeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (DurTime != 0) hash ^= DurTime.GetHashCode();
      if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
      if (AccelerateTime != 0) hash ^= AccelerateTime.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (MakeId != 0) hash ^= MakeId.GetHashCode();
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
      if (DurTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DurTime);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AvatarId);
      }
      if (MakeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MakeId);
      }
      if (AccelerateTime != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(AccelerateTime);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(93);
        output.WriteFixed32(BeginTime);
      }
      if (Index != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Index);
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
      if (DurTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DurTime);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AvatarId);
      }
      if (MakeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MakeId);
      }
      if (AccelerateTime != 0) {
        output.WriteRawTag(53);
        output.WriteFixed32(AccelerateTime);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(93);
        output.WriteFixed32(BeginTime);
      }
      if (Index != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Index);
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
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (DurTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DurTime);
      }
      if (BeginTime != 0) {
        size += 1 + 4;
      }
      if (AccelerateTime != 0) {
        size += 1 + 4;
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (MakeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MakeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FurnitureMakeData other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.DurTime != 0) {
        DurTime = other.DurTime;
      }
      if (other.BeginTime != 0) {
        BeginTime = other.BeginTime;
      }
      if (other.AccelerateTime != 0) {
        AccelerateTime = other.AccelerateTime;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.MakeId != 0) {
        MakeId = other.MakeId;
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
            DurTime = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            MakeId = input.ReadUInt32();
            break;
          }
          case 53: {
            AccelerateTime = input.ReadFixed32();
            break;
          }
          case 93: {
            BeginTime = input.ReadFixed32();
            break;
          }
          case 120: {
            Index = input.ReadUInt32();
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
            DurTime = input.ReadUInt32();
            break;
          }
          case 16: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            MakeId = input.ReadUInt32();
            break;
          }
          case 53: {
            AccelerateTime = input.ReadFixed32();
            break;
          }
          case 93: {
            BeginTime = input.ReadFixed32();
            break;
          }
          case 120: {
            Index = input.ReadUInt32();
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
