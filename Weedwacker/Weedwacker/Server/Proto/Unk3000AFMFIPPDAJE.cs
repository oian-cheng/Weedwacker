// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3000_AFMFIPPDAJE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk3000_AFMFIPPDAJE.proto</summary>
  public static partial class Unk3000AFMFIPPDAJEReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3000_AFMFIPPDAJE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3000AFMFIPPDAJEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMDAwX0FGTUZJUFBEQUpFLnByb3RvIrgBChNVbmszMDAwX0FGTUZJ",
            "UFBEQUpFEkkKE1VuazMwMDBfT0JMQ0tFTEhCR0gYAyADKAsyLC5VbmszMDAw",
            "X0FGTUZJUFBEQUpFLlVuazMwMDBPQkxDS0VMSEJHSEVudHJ5EhsKE1VuazMw",
            "MDBfTE9GTkZNSkZHTkIYDCABKA0aOQoXVW5rMzAwME9CTENLRUxIQkdIRW50",
            "cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIaqgIXV2VlZHdh",
            "Y2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk3000_AFMFIPPDAJE), global::Weedwacker.Server.Proto.Unk3000_AFMFIPPDAJE.Parser, new[]{ "Unk3000OBLCKELHBGH", "Unk3000LOFNFMJFGNB" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4576
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk3000_AFMFIPPDAJE : pb::IMessage<Unk3000_AFMFIPPDAJE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3000_AFMFIPPDAJE> _parser = new pb::MessageParser<Unk3000_AFMFIPPDAJE>(() => new Unk3000_AFMFIPPDAJE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3000_AFMFIPPDAJE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk3000AFMFIPPDAJEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_AFMFIPPDAJE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_AFMFIPPDAJE(Unk3000_AFMFIPPDAJE other) : this() {
      unk3000OBLCKELHBGH_ = other.unk3000OBLCKELHBGH_.Clone();
      unk3000LOFNFMJFGNB_ = other.unk3000LOFNFMJFGNB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3000_AFMFIPPDAJE Clone() {
      return new Unk3000_AFMFIPPDAJE(this);
    }

    /// <summary>Field number for the "Unk3000_OBLCKELHBGH" field.</summary>
    public const int Unk3000OBLCKELHBGHFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk3000OBLCKELHBGH_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> unk3000OBLCKELHBGH_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk3000OBLCKELHBGH {
      get { return unk3000OBLCKELHBGH_; }
    }

    /// <summary>Field number for the "Unk3000_LOFNFMJFGNB" field.</summary>
    public const int Unk3000LOFNFMJFGNBFieldNumber = 12;
    private uint unk3000LOFNFMJFGNB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3000LOFNFMJFGNB {
      get { return unk3000LOFNFMJFGNB_; }
      set {
        unk3000LOFNFMJFGNB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3000_AFMFIPPDAJE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3000_AFMFIPPDAJE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Unk3000OBLCKELHBGH.Equals(other.Unk3000OBLCKELHBGH)) return false;
      if (Unk3000LOFNFMJFGNB != other.Unk3000LOFNFMJFGNB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Unk3000OBLCKELHBGH.GetHashCode();
      if (Unk3000LOFNFMJFGNB != 0) hash ^= Unk3000LOFNFMJFGNB.GetHashCode();
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
      unk3000OBLCKELHBGH_.WriteTo(output, _map_unk3000OBLCKELHBGH_codec);
      if (Unk3000LOFNFMJFGNB != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3000LOFNFMJFGNB);
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
      unk3000OBLCKELHBGH_.WriteTo(ref output, _map_unk3000OBLCKELHBGH_codec);
      if (Unk3000LOFNFMJFGNB != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3000LOFNFMJFGNB);
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
      size += unk3000OBLCKELHBGH_.CalculateSize(_map_unk3000OBLCKELHBGH_codec);
      if (Unk3000LOFNFMJFGNB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3000LOFNFMJFGNB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3000_AFMFIPPDAJE other) {
      if (other == null) {
        return;
      }
      unk3000OBLCKELHBGH_.Add(other.unk3000OBLCKELHBGH_);
      if (other.Unk3000LOFNFMJFGNB != 0) {
        Unk3000LOFNFMJFGNB = other.Unk3000LOFNFMJFGNB;
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
          case 26: {
            unk3000OBLCKELHBGH_.AddEntriesFrom(input, _map_unk3000OBLCKELHBGH_codec);
            break;
          }
          case 96: {
            Unk3000LOFNFMJFGNB = input.ReadUInt32();
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
          case 26: {
            unk3000OBLCKELHBGH_.AddEntriesFrom(ref input, _map_unk3000OBLCKELHBGH_codec);
            break;
          }
          case 96: {
            Unk3000LOFNFMJFGNB = input.ReadUInt32();
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
