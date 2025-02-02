// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Equip.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Equip.proto</summary>
  public static partial class EquipReflection {

    #region Descriptor
    /// <summary>File descriptor for Equip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquipReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtFcXVpcC5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "bxoPUmVsaXF1YXJ5LnByb3RvGgxXZWFwb24ucHJvdG8ioAEKBUVxdWlwEhEK",
            "CWlzX2xvY2tlZBgDIAEoCBI/CglyZWxpcXVhcnkYASABKAsyKi5XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlJlbGlxdWFyeUgAEjkKBndlYXBv",
            "bhgCIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uV2Vh",
            "cG9uSABCCAoGZGV0YWlsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ReliquaryReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WeaponReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Equip), global::Weedwacker.Shared.Network.Proto.Equip.Parser, new[]{ "IsLocked", "Reliquary", "Weapon" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Equip : pb::IMessage<Equip>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Equip> _parser = new pb::MessageParser<Equip>(() => new Equip());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Equip> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EquipReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equip() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equip(Equip other) : this() {
      isLocked_ = other.isLocked_;
      switch (other.DetailCase) {
        case DetailOneofCase.Reliquary:
          Reliquary = other.Reliquary.Clone();
          break;
        case DetailOneofCase.Weapon:
          Weapon = other.Weapon.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equip Clone() {
      return new Equip(this);
    }

    /// <summary>Field number for the "is_locked" field.</summary>
    public const int IsLockedFieldNumber = 3;
    private bool isLocked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsLocked {
      get { return isLocked_; }
      set {
        isLocked_ = value;
      }
    }

    /// <summary>Field number for the "reliquary" field.</summary>
    public const int ReliquaryFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Reliquary Reliquary {
      get { return detailCase_ == DetailOneofCase.Reliquary ? (global::Weedwacker.Shared.Network.Proto.Reliquary) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Reliquary;
      }
    }

    /// <summary>Field number for the "weapon" field.</summary>
    public const int WeaponFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Weapon Weapon {
      get { return detailCase_ == DetailOneofCase.Weapon ? (global::Weedwacker.Shared.Network.Proto.Weapon) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Weapon;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      Reliquary = 1,
      Weapon = 2,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Equip);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Equip other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsLocked != other.IsLocked) return false;
      if (!object.Equals(Reliquary, other.Reliquary)) return false;
      if (!object.Equals(Weapon, other.Weapon)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsLocked != false) hash ^= IsLocked.GetHashCode();
      if (detailCase_ == DetailOneofCase.Reliquary) hash ^= Reliquary.GetHashCode();
      if (detailCase_ == DetailOneofCase.Weapon) hash ^= Weapon.GetHashCode();
      hash ^= (int) detailCase_;
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
      if (detailCase_ == DetailOneofCase.Reliquary) {
        output.WriteRawTag(10);
        output.WriteMessage(Reliquary);
      }
      if (detailCase_ == DetailOneofCase.Weapon) {
        output.WriteRawTag(18);
        output.WriteMessage(Weapon);
      }
      if (IsLocked != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsLocked);
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
      if (detailCase_ == DetailOneofCase.Reliquary) {
        output.WriteRawTag(10);
        output.WriteMessage(Reliquary);
      }
      if (detailCase_ == DetailOneofCase.Weapon) {
        output.WriteRawTag(18);
        output.WriteMessage(Weapon);
      }
      if (IsLocked != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsLocked);
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
      if (IsLocked != false) {
        size += 1 + 1;
      }
      if (detailCase_ == DetailOneofCase.Reliquary) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reliquary);
      }
      if (detailCase_ == DetailOneofCase.Weapon) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Weapon);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Equip other) {
      if (other == null) {
        return;
      }
      if (other.IsLocked != false) {
        IsLocked = other.IsLocked;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.Reliquary:
          if (Reliquary == null) {
            Reliquary = new global::Weedwacker.Shared.Network.Proto.Reliquary();
          }
          Reliquary.MergeFrom(other.Reliquary);
          break;
        case DetailOneofCase.Weapon:
          if (Weapon == null) {
            Weapon = new global::Weedwacker.Shared.Network.Proto.Weapon();
          }
          Weapon.MergeFrom(other.Weapon);
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
          case 10: {
            global::Weedwacker.Shared.Network.Proto.Reliquary subBuilder = new global::Weedwacker.Shared.Network.Proto.Reliquary();
            if (detailCase_ == DetailOneofCase.Reliquary) {
              subBuilder.MergeFrom(Reliquary);
            }
            input.ReadMessage(subBuilder);
            Reliquary = subBuilder;
            break;
          }
          case 18: {
            global::Weedwacker.Shared.Network.Proto.Weapon subBuilder = new global::Weedwacker.Shared.Network.Proto.Weapon();
            if (detailCase_ == DetailOneofCase.Weapon) {
              subBuilder.MergeFrom(Weapon);
            }
            input.ReadMessage(subBuilder);
            Weapon = subBuilder;
            break;
          }
          case 24: {
            IsLocked = input.ReadBool();
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
            global::Weedwacker.Shared.Network.Proto.Reliquary subBuilder = new global::Weedwacker.Shared.Network.Proto.Reliquary();
            if (detailCase_ == DetailOneofCase.Reliquary) {
              subBuilder.MergeFrom(Reliquary);
            }
            input.ReadMessage(subBuilder);
            Reliquary = subBuilder;
            break;
          }
          case 18: {
            global::Weedwacker.Shared.Network.Proto.Weapon subBuilder = new global::Weedwacker.Shared.Network.Proto.Weapon();
            if (detailCase_ == DetailOneofCase.Weapon) {
              subBuilder.MergeFrom(Weapon);
            }
            input.ReadMessage(subBuilder);
            Weapon = subBuilder;
            break;
          }
          case 24: {
            IsLocked = input.ReadBool();
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
