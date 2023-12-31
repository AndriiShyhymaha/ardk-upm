// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ardk_next_telemetry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Niantic.Lightship.AR.Protobuf {

  /// <summary>Holder for reflection information generated from ardk_next_telemetry.proto</summary>
  public static partial class ArdkNextTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for ardk_next_telemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArdkNextTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlhcmRrX25leHRfdGVsZW1ldHJ5LnByb3RvEg5hcmRrLnRlbGVtZXRyeRoY",
            "YXJfY29tbW9uX21ldGFkYXRhLnByb3RvIuEBChpBcmRrTmV4dFRlbGVtZXRy",
            "eU9tbmlQcm90bxJDChRpbml0aWFsaXphdGlvbl9ldmVudBgBIAEoCzIjLmFy",
            "ZGsudGVsZW1ldHJ5LkluaXRpYWxpemF0aW9uRXZlbnRIABI8ChJhcl9jb21t",
            "b25fbWV0YWRhdGEY6AcgASgLMh8ubmFyLnRlbGVtZXRyeS5BUkNvbW1vbk1l",
            "dGFkYXRhEhYKDWRldmVsb3Blcl9rZXkY6QcgASgJEhUKDHRpbWVzdGFtcF9t",
            "cxjqByABKANCEQoPdGVsZW1ldHJ5X2V2ZW50IisKE0luaXRpYWxpemF0aW9u",
            "RXZlbnQSFAoMaW5zdGFsbF9tb2RlGAEgASgJQmQKHmNvbS5uaWFudGljbGFi",
            "cy5hcmRrLnRlbGVtZXRyeUgDWiBuaWFudGljL2xpZ2h0c2hpcC9hcmRrL3Rl",
            "bGVtZXRyeaoCHU5pYW50aWMuTGlnaHRzaGlwLkFSLlByb3RvYnVmYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Niantic.ARDK.AR.Protobuf.ArCommonMetadataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Niantic.Lightship.AR.Protobuf.ArdkNextTelemetryOmniProto), global::Niantic.Lightship.AR.Protobuf.ArdkNextTelemetryOmniProto.Parser, new[]{ "InitializationEvent", "ArCommonMetadata", "DeveloperKey", "TimestampMs" }, new[]{ "TelemetryEvent" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Niantic.Lightship.AR.Protobuf.InitializationEvent), global::Niantic.Lightship.AR.Protobuf.InitializationEvent.Parser, new[]{ "InstallMode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ArdkNextTelemetryOmniProto : pb::IMessage<ArdkNextTelemetryOmniProto> {
    private static readonly pb::MessageParser<ArdkNextTelemetryOmniProto> _parser = new pb::MessageParser<ArdkNextTelemetryOmniProto>(() => new ArdkNextTelemetryOmniProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArdkNextTelemetryOmniProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Niantic.Lightship.AR.Protobuf.ArdkNextTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArdkNextTelemetryOmniProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArdkNextTelemetryOmniProto(ArdkNextTelemetryOmniProto other) : this() {
      ArCommonMetadata = other.arCommonMetadata_ != null ? other.ArCommonMetadata.Clone() : null;
      developerKey_ = other.developerKey_;
      timestampMs_ = other.timestampMs_;
      switch (other.TelemetryEventCase) {
        case TelemetryEventOneofCase.InitializationEvent:
          InitializationEvent = other.InitializationEvent.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArdkNextTelemetryOmniProto Clone() {
      return new ArdkNextTelemetryOmniProto(this);
    }

    /// <summary>Field number for the "initialization_event" field.</summary>
    public const int InitializationEventFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Niantic.Lightship.AR.Protobuf.InitializationEvent InitializationEvent {
      get { return telemetryEventCase_ == TelemetryEventOneofCase.InitializationEvent ? (global::Niantic.Lightship.AR.Protobuf.InitializationEvent) telemetryEvent_ : null; }
      set {
        telemetryEvent_ = value;
        telemetryEventCase_ = value == null ? TelemetryEventOneofCase.None : TelemetryEventOneofCase.InitializationEvent;
      }
    }

    /// <summary>Field number for the "ar_common_metadata" field.</summary>
    public const int ArCommonMetadataFieldNumber = 1000;
    private global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata arCommonMetadata_;
    /// <summary>
    ///  Common metadata for all the telemetry protos.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata ArCommonMetadata {
      get { return arCommonMetadata_; }
      set {
        arCommonMetadata_ = value;
      }
    }

    /// <summary>Field number for the "developer_key" field.</summary>
    public const int DeveloperKeyFieldNumber = 1001;
    private string developerKey_ = "";
    /// <summary>
    ///  Lightship developer key
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeveloperKey {
      get { return developerKey_; }
      set {
        developerKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp_ms" field.</summary>
    public const int TimestampMsFieldNumber = 1002;
    private long timestampMs_;
    /// <summary>
    ///  Timestamp contain an epoch time in millis (millis after Jan 1, 1970 UTC).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TimestampMs {
      get { return timestampMs_; }
      set {
        timestampMs_ = value;
      }
    }

    private object telemetryEvent_;
    /// <summary>Enum of possible cases for the "telemetry_event" oneof.</summary>
    public enum TelemetryEventOneofCase {
      None = 0,
      InitializationEvent = 1,
    }
    private TelemetryEventOneofCase telemetryEventCase_ = TelemetryEventOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryEventOneofCase TelemetryEventCase {
      get { return telemetryEventCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTelemetryEvent() {
      telemetryEventCase_ = TelemetryEventOneofCase.None;
      telemetryEvent_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArdkNextTelemetryOmniProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArdkNextTelemetryOmniProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(InitializationEvent, other.InitializationEvent)) return false;
      if (!object.Equals(ArCommonMetadata, other.ArCommonMetadata)) return false;
      if (DeveloperKey != other.DeveloperKey) return false;
      if (TimestampMs != other.TimestampMs) return false;
      if (TelemetryEventCase != other.TelemetryEventCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (telemetryEventCase_ == TelemetryEventOneofCase.InitializationEvent) hash ^= InitializationEvent.GetHashCode();
      if (arCommonMetadata_ != null) hash ^= ArCommonMetadata.GetHashCode();
      if (DeveloperKey.Length != 0) hash ^= DeveloperKey.GetHashCode();
      if (TimestampMs != 0L) hash ^= TimestampMs.GetHashCode();
      hash ^= (int) telemetryEventCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (telemetryEventCase_ == TelemetryEventOneofCase.InitializationEvent) {
        output.WriteRawTag(10);
        output.WriteMessage(InitializationEvent);
      }
      if (arCommonMetadata_ != null) {
        output.WriteRawTag(194, 62);
        output.WriteMessage(ArCommonMetadata);
      }
      if (DeveloperKey.Length != 0) {
        output.WriteRawTag(202, 62);
        output.WriteString(DeveloperKey);
      }
      if (TimestampMs != 0L) {
        output.WriteRawTag(208, 62);
        output.WriteInt64(TimestampMs);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (telemetryEventCase_ == TelemetryEventOneofCase.InitializationEvent) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InitializationEvent);
      }
      if (arCommonMetadata_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ArCommonMetadata);
      }
      if (DeveloperKey.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(DeveloperKey);
      }
      if (TimestampMs != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(TimestampMs);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArdkNextTelemetryOmniProto other) {
      if (other == null) {
        return;
      }
      if (other.arCommonMetadata_ != null) {
        if (arCommonMetadata_ == null) {
          arCommonMetadata_ = new global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata();
        }
        ArCommonMetadata.MergeFrom(other.ArCommonMetadata);
      }
      if (other.DeveloperKey.Length != 0) {
        DeveloperKey = other.DeveloperKey;
      }
      if (other.TimestampMs != 0L) {
        TimestampMs = other.TimestampMs;
      }
      switch (other.TelemetryEventCase) {
        case TelemetryEventOneofCase.InitializationEvent:
          InitializationEvent = other.InitializationEvent;
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            global::Niantic.Lightship.AR.Protobuf.InitializationEvent subBuilder = new global::Niantic.Lightship.AR.Protobuf.InitializationEvent();
            if (telemetryEventCase_ == TelemetryEventOneofCase.InitializationEvent) {
              subBuilder.MergeFrom(InitializationEvent);
            }
            input.ReadMessage(subBuilder);
            InitializationEvent = subBuilder;
            break;
          }
          case 8002: {
            if (arCommonMetadata_ == null) {
              arCommonMetadata_ = new global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata();
            }
            input.ReadMessage(arCommonMetadata_);
            break;
          }
          case 8010: {
            DeveloperKey = input.ReadString();
            break;
          }
          case 8016: {
            TimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class InitializationEvent : pb::IMessage<InitializationEvent> {
    private static readonly pb::MessageParser<InitializationEvent> _parser = new pb::MessageParser<InitializationEvent>(() => new InitializationEvent());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitializationEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Niantic.Lightship.AR.Protobuf.ArdkNextTelemetryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializationEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializationEvent(InitializationEvent other) : this() {
      installMode_ = other.installMode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializationEvent Clone() {
      return new InitializationEvent(this);
    }

    /// <summary>Field number for the "install_mode" field.</summary>
    public const int InstallModeFieldNumber = 1;
    private string installMode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstallMode {
      get { return installMode_; }
      set {
        installMode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitializationEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitializationEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InstallMode != other.InstallMode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (InstallMode.Length != 0) hash ^= InstallMode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (InstallMode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InstallMode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (InstallMode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstallMode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitializationEvent other) {
      if (other == null) {
        return;
      }
      if (other.InstallMode.Length != 0) {
        InstallMode = other.InstallMode;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            InstallMode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
