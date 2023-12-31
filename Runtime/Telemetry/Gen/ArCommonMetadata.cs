// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ar_common_metadata.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Niantic.ARDK.AR.Protobuf {

  /// <summary>Holder for reflection information generated from ar_common_metadata.proto</summary>
  public static partial class ArCommonMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for ar_common_metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArCommonMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chhhcl9jb21tb25fbWV0YWRhdGEucHJvdG8SDW5hci50ZWxlbWV0cnki6gEK",
            "EEFSQ29tbW9uTWV0YWRhdGESFgoOYXBwbGljYXRpb25faWQYASABKAkSEAoI",
            "cGxhdGZvcm0YAiABKAkSFAoMbWFudWZhY3R1cmVyGAMgASgJEhQKDGRldmlj",
            "ZV9tb2RlbBgEIAEoCRIPCgd1c2VyX2lkGAUgASgJEhEKCWNsaWVudF9pZBgG",
            "IAEoCRIUCgxkZXZlbG9wZXJfaWQYByABKAkSFAoMYXJka192ZXJzaW9uGAgg",
            "ASgJEhwKFGFyZGtfYXBwX2luc3RhbmNlX2lkGAkgASgJEhIKCnJlcXVlc3Rf",
            "aWQYCiABKAlCVgohY29tLm5pYW50aWNwcm9qZWN0LmFyZGsudGVsZW1ldHJ5",
            "WhZuaWFudGljL2FyZGsvdGVsZW1ldHJ5qgIYTmlhbnRpYy5BUkRLLkFSLlBy",
            "b3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata), global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata.Parser, new[]{ "ApplicationId", "Platform", "Manufacturer", "DeviceModel", "UserId", "ClientId", "DeveloperId", "ArdkVersion", "ArdkAppInstanceId", "RequestId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ARCommonMetadata : pb::IMessage<ARCommonMetadata> {
    private static readonly pb::MessageParser<ARCommonMetadata> _parser = new pb::MessageParser<ARCommonMetadata>(() => new ARCommonMetadata());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ARCommonMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Niantic.ARDK.AR.Protobuf.ArCommonMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ARCommonMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ARCommonMetadata(ARCommonMetadata other) : this() {
      applicationId_ = other.applicationId_;
      platform_ = other.platform_;
      manufacturer_ = other.manufacturer_;
      deviceModel_ = other.deviceModel_;
      userId_ = other.userId_;
      clientId_ = other.clientId_;
      developerId_ = other.developerId_;
      ardkVersion_ = other.ardkVersion_;
      ardkAppInstanceId_ = other.ardkAppInstanceId_;
      requestId_ = other.requestId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ARCommonMetadata Clone() {
      return new ARCommonMetadata(this);
    }

    /// <summary>Field number for the "application_id" field.</summary>
    public const int ApplicationIdFieldNumber = 1;
    private string applicationId_ = "";
    /// <summary>
    ///  Name/ID of the application which sent this request
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApplicationId {
      get { return applicationId_; }
      set {
        applicationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 2;
    private string platform_ = "";
    /// <summary>
    ///  e.g. IOS, android
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Platform {
      get { return platform_; }
      set {
        platform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manufacturer" field.</summary>
    public const int ManufacturerFieldNumber = 3;
    private string manufacturer_ = "";
    /// <summary>
    ///  e.g. Apple, Google
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Manufacturer {
      get { return manufacturer_; }
      set {
        manufacturer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_model" field.</summary>
    public const int DeviceModelFieldNumber = 4;
    private string deviceModel_ = "";
    /// <summary>
    ///  e.g. iPhone 12
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceModel {
      get { return deviceModel_; }
      set {
        deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 5;
    private string userId_ = "";
    /// <summary>
    ///  Verified user ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_id" field.</summary>
    public const int ClientIdFieldNumber = 6;
    private string clientId_ = "";
    /// <summary>
    ///  Client device ID, provided by ARDK
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientId {
      get { return clientId_; }
      set {
        clientId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "developer_id" field.</summary>
    public const int DeveloperIdFieldNumber = 7;
    private string developerId_ = "";
    /// <summary>
    ///  Developer ID, resolved from API key
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeveloperId {
      get { return developerId_; }
      set {
        developerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ardk_version" field.</summary>
    public const int ArdkVersionFieldNumber = 8;
    private string ardkVersion_ = "";
    /// <summary>
    ///  ARDK version
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ArdkVersion {
      get { return ardkVersion_; }
      set {
        ardkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ardk_app_instance_id" field.</summary>
    public const int ArdkAppInstanceIdFieldNumber = 9;
    private string ardkAppInstanceId_ = "";
    /// <summary>
    ///  ARDK application instance ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ArdkAppInstanceId {
      get { return ardkAppInstanceId_; }
      set {
        ardkAppInstanceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 10;
    private string requestId_ = "";
    /// <summary>
    ///  Guid request id encoded into a string. May be null 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RequestId {
      get { return requestId_; }
      set {
        requestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ARCommonMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ARCommonMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ApplicationId != other.ApplicationId) return false;
      if (Platform != other.Platform) return false;
      if (Manufacturer != other.Manufacturer) return false;
      if (DeviceModel != other.DeviceModel) return false;
      if (UserId != other.UserId) return false;
      if (ClientId != other.ClientId) return false;
      if (DeveloperId != other.DeveloperId) return false;
      if (ArdkVersion != other.ArdkVersion) return false;
      if (ArdkAppInstanceId != other.ArdkAppInstanceId) return false;
      if (RequestId != other.RequestId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ApplicationId.Length != 0) hash ^= ApplicationId.GetHashCode();
      if (Platform.Length != 0) hash ^= Platform.GetHashCode();
      if (Manufacturer.Length != 0) hash ^= Manufacturer.GetHashCode();
      if (DeviceModel.Length != 0) hash ^= DeviceModel.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (ClientId.Length != 0) hash ^= ClientId.GetHashCode();
      if (DeveloperId.Length != 0) hash ^= DeveloperId.GetHashCode();
      if (ArdkVersion.Length != 0) hash ^= ArdkVersion.GetHashCode();
      if (ArdkAppInstanceId.Length != 0) hash ^= ArdkAppInstanceId.GetHashCode();
      if (RequestId.Length != 0) hash ^= RequestId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ApplicationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ApplicationId);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Platform);
      }
      if (Manufacturer.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Manufacturer);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeviceModel);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserId);
      }
      if (ClientId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientId);
      }
      if (DeveloperId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DeveloperId);
      }
      if (ArdkVersion.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ArdkVersion);
      }
      if (ArdkAppInstanceId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ArdkAppInstanceId);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(RequestId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ApplicationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApplicationId);
      }
      if (Platform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Platform);
      }
      if (Manufacturer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manufacturer);
      }
      if (DeviceModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (ClientId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientId);
      }
      if (DeveloperId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeveloperId);
      }
      if (ArdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArdkVersion);
      }
      if (ArdkAppInstanceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArdkAppInstanceId);
      }
      if (RequestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ARCommonMetadata other) {
      if (other == null) {
        return;
      }
      if (other.ApplicationId.Length != 0) {
        ApplicationId = other.ApplicationId;
      }
      if (other.Platform.Length != 0) {
        Platform = other.Platform;
      }
      if (other.Manufacturer.Length != 0) {
        Manufacturer = other.Manufacturer;
      }
      if (other.DeviceModel.Length != 0) {
        DeviceModel = other.DeviceModel;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.ClientId.Length != 0) {
        ClientId = other.ClientId;
      }
      if (other.DeveloperId.Length != 0) {
        DeveloperId = other.DeveloperId;
      }
      if (other.ArdkVersion.Length != 0) {
        ArdkVersion = other.ArdkVersion;
      }
      if (other.ArdkAppInstanceId.Length != 0) {
        ArdkAppInstanceId = other.ArdkAppInstanceId;
      }
      if (other.RequestId.Length != 0) {
        RequestId = other.RequestId;
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
            ApplicationId = input.ReadString();
            break;
          }
          case 18: {
            Platform = input.ReadString();
            break;
          }
          case 26: {
            Manufacturer = input.ReadString();
            break;
          }
          case 34: {
            DeviceModel = input.ReadString();
            break;
          }
          case 42: {
            UserId = input.ReadString();
            break;
          }
          case 50: {
            ClientId = input.ReadString();
            break;
          }
          case 58: {
            DeveloperId = input.ReadString();
            break;
          }
          case 66: {
            ArdkVersion = input.ReadString();
            break;
          }
          case 74: {
            ArdkAppInstanceId = input.ReadString();
            break;
          }
          case 82: {
            RequestId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
