// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: player.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoApi.Proto {

  /// <summary>Holder for reflection information generated from player.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PlayerReflection {

    #region Descriptor
    /// <summary>File descriptor for player.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxwbGF5ZXIucHJvdG8SElBva2Vtb25Hb0FwaS5Qcm90byIfCg9TZXR0aW5n",
            "c1JlcXVlc3QSDAoEVVVJRBgBIAEoCSLsAgoTQ2xpZW50UGxheWVyRGV0YWls",
            "cxIVCg1jcmVhdGlvbl90aW1lGAEgASgDEhAKCHVzZXJuYW1lGAIgASgJEgwK",
            "BHRlYW0YBSABKAUSEAoIdHV0b3JpYWwYByABKAwSMAoGYXZhdGFyGAggASgL",
            "MiAuUG9rZW1vbkdvQXBpLlByb3RvLlBsYXllckF2YXRhchIUCgxwb2tlX3N0",
            "b3JhZ2UYCSABKAUSFAoMaXRlbV9zdG9yYWdlGAogASgFEjMKC2RhaWx5X2Jv",
            "bnVzGAsgASgLMh4uUG9rZW1vbkdvQXBpLlByb3RvLkRhaWx5Qm9udXMSDQoF",
            "YmFkZ2UYDCABKAkSOgoIc2V0dGluZ3MYDSABKAsyKC5Qb2tlbW9uR29BcGku",
            "UHJvdG8uQ29udGFjdFNldHRpbmdzUHJvdG8SLgoIY3VycmVuY3kYDiADKAsy",
            "HC5Qb2tlbW9uR29BcGkuUHJvdG8uQ3VycmVuY3kilAEKDFBsYXllckF2YXRh",
            "chIOCgZBdmF0YXIYCCABKAUSDAoEU2tpbhgCIAEoBRIMCgRIYWlyGAMgASgF",
            "Eg0KBVNoaXJ0GAQgASgFEg0KBVBhbnRzGAUgASgFEgsKA0hhdBgGIAEoBRIN",
            "CgVTaG9lcxgHIAEoBRIMCgRFeWVzGAkgASgFEhAKCEJhY2twYWNrGAogASgF",
            "IlkKCkRhaWx5Qm9udXMSHgoWTmV4dENvbGxlY3RUaW1lc3RhbXBNcxgBIAEo",
            "AxIrCiNOZXh0RGVmZW5kZXJCb251c0NvbGxlY3RUaW1lc3RhbXBNcxgCIAEo",
            "AyIoCghDdXJyZW5jeRIMCgR0eXBlGAEgASgJEg4KBmFtb3VudBgCIAEoBSJS",
            "ChRDb250YWN0U2V0dGluZ3NQcm90bxIbChNTZW5kTWFya2V0aW5nRW1haWxz",
            "GAEgASgIEh0KFVNlbmRQdXNoTm90aWZpY2F0aW9ucxgCIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoApi.Proto.SettingsRequest), global::PokemonGoApi.Proto.SettingsRequest.Parser, new[]{ "UUID" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoApi.Proto.ClientPlayerDetails), global::PokemonGoApi.Proto.ClientPlayerDetails.Parser, new[]{ "CreationTime", "Username", "Team", "Tutorial", "Avatar", "PokeStorage", "ItemStorage", "DailyBonus", "Badge", "Settings", "Currency" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoApi.Proto.PlayerAvatar), global::PokemonGoApi.Proto.PlayerAvatar.Parser, new[]{ "Avatar", "Skin", "Hair", "Shirt", "Pants", "Hat", "Shoes", "Eyes", "Backpack" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoApi.Proto.DailyBonus), global::PokemonGoApi.Proto.DailyBonus.Parser, new[]{ "NextCollectTimestampMs", "NextDefenderBonusCollectTimestampMs" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoApi.Proto.Currency), global::PokemonGoApi.Proto.Currency.Parser, new[]{ "Type", "Amount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoApi.Proto.ContactSettingsProto), global::PokemonGoApi.Proto.ContactSettingsProto.Parser, new[]{ "SendMarketingEmails", "SendPushNotifications" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SettingsRequest : pb::IMessage<SettingsRequest> {
    private static readonly pb::MessageParser<SettingsRequest> _parser = new pb::MessageParser<SettingsRequest>(() => new SettingsRequest());
    public static pb::MessageParser<SettingsRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoApi.Proto.PlayerReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SettingsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SettingsRequest(SettingsRequest other) : this() {
      uUID_ = other.uUID_;
    }

    public SettingsRequest Clone() {
      return new SettingsRequest(this);
    }

    /// <summary>Field number for the "UUID" field.</summary>
    public const int UUIDFieldNumber = 1;
    private string uUID_ = "";
    public string UUID {
      get { return uUID_; }
      set {
        uUID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SettingsRequest);
    }

    public bool Equals(SettingsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UUID != other.UUID) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (UUID.Length != 0) hash ^= UUID.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UUID.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UUID);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (UUID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UUID);
      }
      return size;
    }

    public void MergeFrom(SettingsRequest other) {
      if (other == null) {
        return;
      }
      if (other.UUID.Length != 0) {
        UUID = other.UUID;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            UUID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ClientPlayerDetails : pb::IMessage<ClientPlayerDetails> {
    private static readonly pb::MessageParser<ClientPlayerDetails> _parser = new pb::MessageParser<ClientPlayerDetails>(() => new ClientPlayerDetails());
    public static pb::MessageParser<ClientPlayerDetails> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoApi.Proto.PlayerReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ClientPlayerDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ClientPlayerDetails(ClientPlayerDetails other) : this() {
      creationTime_ = other.creationTime_;
      username_ = other.username_;
      team_ = other.team_;
      tutorial_ = other.tutorial_;
      Avatar = other.avatar_ != null ? other.Avatar.Clone() : null;
      pokeStorage_ = other.pokeStorage_;
      itemStorage_ = other.itemStorage_;
      DailyBonus = other.dailyBonus_ != null ? other.DailyBonus.Clone() : null;
      badge_ = other.badge_;
      Settings = other.settings_ != null ? other.Settings.Clone() : null;
      currency_ = other.currency_.Clone();
    }

    public ClientPlayerDetails Clone() {
      return new ClientPlayerDetails(this);
    }

    /// <summary>Field number for the "creation_time" field.</summary>
    public const int CreationTimeFieldNumber = 1;
    private long creationTime_;
    public long CreationTime {
      get { return creationTime_; }
      set {
        creationTime_ = value;
      }
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 2;
    private string username_ = "";
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team" field.</summary>
    public const int TeamFieldNumber = 5;
    private int team_;
    public int Team {
      get { return team_; }
      set {
        team_ = value;
      }
    }

    /// <summary>Field number for the "tutorial" field.</summary>
    public const int TutorialFieldNumber = 7;
    private pb::ByteString tutorial_ = pb::ByteString.Empty;
    public pb::ByteString Tutorial {
      get { return tutorial_; }
      set {
        tutorial_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "avatar" field.</summary>
    public const int AvatarFieldNumber = 8;
    private global::PokemonGoApi.Proto.PlayerAvatar avatar_;
    public global::PokemonGoApi.Proto.PlayerAvatar Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    /// <summary>Field number for the "poke_storage" field.</summary>
    public const int PokeStorageFieldNumber = 9;
    private int pokeStorage_;
    public int PokeStorage {
      get { return pokeStorage_; }
      set {
        pokeStorage_ = value;
      }
    }

    /// <summary>Field number for the "item_storage" field.</summary>
    public const int ItemStorageFieldNumber = 10;
    private int itemStorage_;
    public int ItemStorage {
      get { return itemStorage_; }
      set {
        itemStorage_ = value;
      }
    }

    /// <summary>Field number for the "daily_bonus" field.</summary>
    public const int DailyBonusFieldNumber = 11;
    private global::PokemonGoApi.Proto.DailyBonus dailyBonus_;
    public global::PokemonGoApi.Proto.DailyBonus DailyBonus {
      get { return dailyBonus_; }
      set {
        dailyBonus_ = value;
      }
    }

    /// <summary>Field number for the "badge" field.</summary>
    public const int BadgeFieldNumber = 12;
    private string badge_ = "";
    public string Badge {
      get { return badge_; }
      set {
        badge_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 13;
    private global::PokemonGoApi.Proto.ContactSettingsProto settings_;
    public global::PokemonGoApi.Proto.ContactSettingsProto Settings {
      get { return settings_; }
      set {
        settings_ = value;
      }
    }

    /// <summary>Field number for the "currency" field.</summary>
    public const int CurrencyFieldNumber = 14;
    private static readonly pb::FieldCodec<global::PokemonGoApi.Proto.Currency> _repeated_currency_codec
        = pb::FieldCodec.ForMessage(114, global::PokemonGoApi.Proto.Currency.Parser);
    private readonly pbc::RepeatedField<global::PokemonGoApi.Proto.Currency> currency_ = new pbc::RepeatedField<global::PokemonGoApi.Proto.Currency>();
    public pbc::RepeatedField<global::PokemonGoApi.Proto.Currency> Currency {
      get { return currency_; }
    }

    public override bool Equals(object other) {
      return Equals(other as ClientPlayerDetails);
    }

    public bool Equals(ClientPlayerDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CreationTime != other.CreationTime) return false;
      if (Username != other.Username) return false;
      if (Team != other.Team) return false;
      if (Tutorial != other.Tutorial) return false;
      if (!object.Equals(Avatar, other.Avatar)) return false;
      if (PokeStorage != other.PokeStorage) return false;
      if (ItemStorage != other.ItemStorage) return false;
      if (!object.Equals(DailyBonus, other.DailyBonus)) return false;
      if (Badge != other.Badge) return false;
      if (!object.Equals(Settings, other.Settings)) return false;
      if(!currency_.Equals(other.currency_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (CreationTime != 0L) hash ^= CreationTime.GetHashCode();
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      if (Tutorial.Length != 0) hash ^= Tutorial.GetHashCode();
      if (avatar_ != null) hash ^= Avatar.GetHashCode();
      if (PokeStorage != 0) hash ^= PokeStorage.GetHashCode();
      if (ItemStorage != 0) hash ^= ItemStorage.GetHashCode();
      if (dailyBonus_ != null) hash ^= DailyBonus.GetHashCode();
      if (Badge.Length != 0) hash ^= Badge.GetHashCode();
      if (settings_ != null) hash ^= Settings.GetHashCode();
      hash ^= currency_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (CreationTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CreationTime);
      }
      if (Username.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Username);
      }
      if (Team != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Team);
      }
      if (Tutorial.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(Tutorial);
      }
      if (avatar_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Avatar);
      }
      if (PokeStorage != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(PokeStorage);
      }
      if (ItemStorage != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(ItemStorage);
      }
      if (dailyBonus_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(DailyBonus);
      }
      if (Badge.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Badge);
      }
      if (settings_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Settings);
      }
      currency_.WriteTo(output, _repeated_currency_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (CreationTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CreationTime);
      }
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Team);
      }
      if (Tutorial.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Tutorial);
      }
      if (avatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
      }
      if (PokeStorage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokeStorage);
      }
      if (ItemStorage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemStorage);
      }
      if (dailyBonus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyBonus);
      }
      if (Badge.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Badge);
      }
      if (settings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
      }
      size += currency_.CalculateSize(_repeated_currency_codec);
      return size;
    }

    public void MergeFrom(ClientPlayerDetails other) {
      if (other == null) {
        return;
      }
      if (other.CreationTime != 0L) {
        CreationTime = other.CreationTime;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.Team != 0) {
        Team = other.Team;
      }
      if (other.Tutorial.Length != 0) {
        Tutorial = other.Tutorial;
      }
      if (other.avatar_ != null) {
        if (avatar_ == null) {
          avatar_ = new global::PokemonGoApi.Proto.PlayerAvatar();
        }
        Avatar.MergeFrom(other.Avatar);
      }
      if (other.PokeStorage != 0) {
        PokeStorage = other.PokeStorage;
      }
      if (other.ItemStorage != 0) {
        ItemStorage = other.ItemStorage;
      }
      if (other.dailyBonus_ != null) {
        if (dailyBonus_ == null) {
          dailyBonus_ = new global::PokemonGoApi.Proto.DailyBonus();
        }
        DailyBonus.MergeFrom(other.DailyBonus);
      }
      if (other.Badge.Length != 0) {
        Badge = other.Badge;
      }
      if (other.settings_ != null) {
        if (settings_ == null) {
          settings_ = new global::PokemonGoApi.Proto.ContactSettingsProto();
        }
        Settings.MergeFrom(other.Settings);
      }
      currency_.Add(other.currency_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            CreationTime = input.ReadInt64();
            break;
          }
          case 18: {
            Username = input.ReadString();
            break;
          }
          case 40: {
            Team = input.ReadInt32();
            break;
          }
          case 58: {
            Tutorial = input.ReadBytes();
            break;
          }
          case 66: {
            if (avatar_ == null) {
              avatar_ = new global::PokemonGoApi.Proto.PlayerAvatar();
            }
            input.ReadMessage(avatar_);
            break;
          }
          case 72: {
            PokeStorage = input.ReadInt32();
            break;
          }
          case 80: {
            ItemStorage = input.ReadInt32();
            break;
          }
          case 90: {
            if (dailyBonus_ == null) {
              dailyBonus_ = new global::PokemonGoApi.Proto.DailyBonus();
            }
            input.ReadMessage(dailyBonus_);
            break;
          }
          case 98: {
            Badge = input.ReadString();
            break;
          }
          case 106: {
            if (settings_ == null) {
              settings_ = new global::PokemonGoApi.Proto.ContactSettingsProto();
            }
            input.ReadMessage(settings_);
            break;
          }
          case 114: {
            currency_.AddEntriesFrom(input, _repeated_currency_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PlayerAvatar : pb::IMessage<PlayerAvatar> {
    private static readonly pb::MessageParser<PlayerAvatar> _parser = new pb::MessageParser<PlayerAvatar>(() => new PlayerAvatar());
    public static pb::MessageParser<PlayerAvatar> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoApi.Proto.PlayerReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PlayerAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PlayerAvatar(PlayerAvatar other) : this() {
      avatar_ = other.avatar_;
      skin_ = other.skin_;
      hair_ = other.hair_;
      shirt_ = other.shirt_;
      pants_ = other.pants_;
      hat_ = other.hat_;
      shoes_ = other.shoes_;
      eyes_ = other.eyes_;
      backpack_ = other.backpack_;
    }

    public PlayerAvatar Clone() {
      return new PlayerAvatar(this);
    }

    /// <summary>Field number for the "Avatar" field.</summary>
    public const int AvatarFieldNumber = 8;
    private int avatar_;
    public int Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    /// <summary>Field number for the "Skin" field.</summary>
    public const int SkinFieldNumber = 2;
    private int skin_;
    public int Skin {
      get { return skin_; }
      set {
        skin_ = value;
      }
    }

    /// <summary>Field number for the "Hair" field.</summary>
    public const int HairFieldNumber = 3;
    private int hair_;
    public int Hair {
      get { return hair_; }
      set {
        hair_ = value;
      }
    }

    /// <summary>Field number for the "Shirt" field.</summary>
    public const int ShirtFieldNumber = 4;
    private int shirt_;
    public int Shirt {
      get { return shirt_; }
      set {
        shirt_ = value;
      }
    }

    /// <summary>Field number for the "Pants" field.</summary>
    public const int PantsFieldNumber = 5;
    private int pants_;
    public int Pants {
      get { return pants_; }
      set {
        pants_ = value;
      }
    }

    /// <summary>Field number for the "Hat" field.</summary>
    public const int HatFieldNumber = 6;
    private int hat_;
    public int Hat {
      get { return hat_; }
      set {
        hat_ = value;
      }
    }

    /// <summary>Field number for the "Shoes" field.</summary>
    public const int ShoesFieldNumber = 7;
    private int shoes_;
    public int Shoes {
      get { return shoes_; }
      set {
        shoes_ = value;
      }
    }

    /// <summary>Field number for the "Eyes" field.</summary>
    public const int EyesFieldNumber = 9;
    private int eyes_;
    public int Eyes {
      get { return eyes_; }
      set {
        eyes_ = value;
      }
    }

    /// <summary>Field number for the "Backpack" field.</summary>
    public const int BackpackFieldNumber = 10;
    private int backpack_;
    public int Backpack {
      get { return backpack_; }
      set {
        backpack_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PlayerAvatar);
    }

    public bool Equals(PlayerAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Avatar != other.Avatar) return false;
      if (Skin != other.Skin) return false;
      if (Hair != other.Hair) return false;
      if (Shirt != other.Shirt) return false;
      if (Pants != other.Pants) return false;
      if (Hat != other.Hat) return false;
      if (Shoes != other.Shoes) return false;
      if (Eyes != other.Eyes) return false;
      if (Backpack != other.Backpack) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Avatar != 0) hash ^= Avatar.GetHashCode();
      if (Skin != 0) hash ^= Skin.GetHashCode();
      if (Hair != 0) hash ^= Hair.GetHashCode();
      if (Shirt != 0) hash ^= Shirt.GetHashCode();
      if (Pants != 0) hash ^= Pants.GetHashCode();
      if (Hat != 0) hash ^= Hat.GetHashCode();
      if (Shoes != 0) hash ^= Shoes.GetHashCode();
      if (Eyes != 0) hash ^= Eyes.GetHashCode();
      if (Backpack != 0) hash ^= Backpack.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Skin != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Skin);
      }
      if (Hair != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Hair);
      }
      if (Shirt != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Shirt);
      }
      if (Pants != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Pants);
      }
      if (Hat != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Hat);
      }
      if (Shoes != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Shoes);
      }
      if (Avatar != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Avatar);
      }
      if (Eyes != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Eyes);
      }
      if (Backpack != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Backpack);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Avatar != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Avatar);
      }
      if (Skin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Skin);
      }
      if (Hair != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hair);
      }
      if (Shirt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Shirt);
      }
      if (Pants != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Pants);
      }
      if (Hat != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hat);
      }
      if (Shoes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Shoes);
      }
      if (Eyes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Eyes);
      }
      if (Backpack != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Backpack);
      }
      return size;
    }

    public void MergeFrom(PlayerAvatar other) {
      if (other == null) {
        return;
      }
      if (other.Avatar != 0) {
        Avatar = other.Avatar;
      }
      if (other.Skin != 0) {
        Skin = other.Skin;
      }
      if (other.Hair != 0) {
        Hair = other.Hair;
      }
      if (other.Shirt != 0) {
        Shirt = other.Shirt;
      }
      if (other.Pants != 0) {
        Pants = other.Pants;
      }
      if (other.Hat != 0) {
        Hat = other.Hat;
      }
      if (other.Shoes != 0) {
        Shoes = other.Shoes;
      }
      if (other.Eyes != 0) {
        Eyes = other.Eyes;
      }
      if (other.Backpack != 0) {
        Backpack = other.Backpack;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 16: {
            Skin = input.ReadInt32();
            break;
          }
          case 24: {
            Hair = input.ReadInt32();
            break;
          }
          case 32: {
            Shirt = input.ReadInt32();
            break;
          }
          case 40: {
            Pants = input.ReadInt32();
            break;
          }
          case 48: {
            Hat = input.ReadInt32();
            break;
          }
          case 56: {
            Shoes = input.ReadInt32();
            break;
          }
          case 64: {
            Avatar = input.ReadInt32();
            break;
          }
          case 72: {
            Eyes = input.ReadInt32();
            break;
          }
          case 80: {
            Backpack = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DailyBonus : pb::IMessage<DailyBonus> {
    private static readonly pb::MessageParser<DailyBonus> _parser = new pb::MessageParser<DailyBonus>(() => new DailyBonus());
    public static pb::MessageParser<DailyBonus> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoApi.Proto.PlayerReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DailyBonus() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DailyBonus(DailyBonus other) : this() {
      nextCollectTimestampMs_ = other.nextCollectTimestampMs_;
      nextDefenderBonusCollectTimestampMs_ = other.nextDefenderBonusCollectTimestampMs_;
    }

    public DailyBonus Clone() {
      return new DailyBonus(this);
    }

    /// <summary>Field number for the "NextCollectTimestampMs" field.</summary>
    public const int NextCollectTimestampMsFieldNumber = 1;
    private long nextCollectTimestampMs_;
    public long NextCollectTimestampMs {
      get { return nextCollectTimestampMs_; }
      set {
        nextCollectTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "NextDefenderBonusCollectTimestampMs" field.</summary>
    public const int NextDefenderBonusCollectTimestampMsFieldNumber = 2;
    private long nextDefenderBonusCollectTimestampMs_;
    public long NextDefenderBonusCollectTimestampMs {
      get { return nextDefenderBonusCollectTimestampMs_; }
      set {
        nextDefenderBonusCollectTimestampMs_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DailyBonus);
    }

    public bool Equals(DailyBonus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NextCollectTimestampMs != other.NextCollectTimestampMs) return false;
      if (NextDefenderBonusCollectTimestampMs != other.NextDefenderBonusCollectTimestampMs) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (NextCollectTimestampMs != 0L) hash ^= NextCollectTimestampMs.GetHashCode();
      if (NextDefenderBonusCollectTimestampMs != 0L) hash ^= NextDefenderBonusCollectTimestampMs.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (NextCollectTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(NextCollectTimestampMs);
      }
      if (NextDefenderBonusCollectTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(NextDefenderBonusCollectTimestampMs);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (NextCollectTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextCollectTimestampMs);
      }
      if (NextDefenderBonusCollectTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextDefenderBonusCollectTimestampMs);
      }
      return size;
    }

    public void MergeFrom(DailyBonus other) {
      if (other == null) {
        return;
      }
      if (other.NextCollectTimestampMs != 0L) {
        NextCollectTimestampMs = other.NextCollectTimestampMs;
      }
      if (other.NextDefenderBonusCollectTimestampMs != 0L) {
        NextDefenderBonusCollectTimestampMs = other.NextDefenderBonusCollectTimestampMs;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            NextCollectTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            NextDefenderBonusCollectTimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Currency : pb::IMessage<Currency> {
    private static readonly pb::MessageParser<Currency> _parser = new pb::MessageParser<Currency>(() => new Currency());
    public static pb::MessageParser<Currency> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoApi.Proto.PlayerReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Currency() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Currency(Currency other) : this() {
      type_ = other.type_;
      amount_ = other.amount_;
    }

    public Currency Clone() {
      return new Currency(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private int amount_;
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Currency);
    }

    public bool Equals(Currency other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Amount != other.Amount) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Amount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Amount);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      return size;
    }

    public void MergeFrom(Currency other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Type = input.ReadString();
            break;
          }
          case 16: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ContactSettingsProto : pb::IMessage<ContactSettingsProto> {
    private static readonly pb::MessageParser<ContactSettingsProto> _parser = new pb::MessageParser<ContactSettingsProto>(() => new ContactSettingsProto());
    public static pb::MessageParser<ContactSettingsProto> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoApi.Proto.PlayerReflection.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ContactSettingsProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ContactSettingsProto(ContactSettingsProto other) : this() {
      sendMarketingEmails_ = other.sendMarketingEmails_;
      sendPushNotifications_ = other.sendPushNotifications_;
    }

    public ContactSettingsProto Clone() {
      return new ContactSettingsProto(this);
    }

    /// <summary>Field number for the "SendMarketingEmails" field.</summary>
    public const int SendMarketingEmailsFieldNumber = 1;
    private bool sendMarketingEmails_;
    public bool SendMarketingEmails {
      get { return sendMarketingEmails_; }
      set {
        sendMarketingEmails_ = value;
      }
    }

    /// <summary>Field number for the "SendPushNotifications" field.</summary>
    public const int SendPushNotificationsFieldNumber = 2;
    private bool sendPushNotifications_;
    public bool SendPushNotifications {
      get { return sendPushNotifications_; }
      set {
        sendPushNotifications_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ContactSettingsProto);
    }

    public bool Equals(ContactSettingsProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SendMarketingEmails != other.SendMarketingEmails) return false;
      if (SendPushNotifications != other.SendPushNotifications) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SendMarketingEmails != false) hash ^= SendMarketingEmails.GetHashCode();
      if (SendPushNotifications != false) hash ^= SendPushNotifications.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SendMarketingEmails != false) {
        output.WriteRawTag(8);
        output.WriteBool(SendMarketingEmails);
      }
      if (SendPushNotifications != false) {
        output.WriteRawTag(16);
        output.WriteBool(SendPushNotifications);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SendMarketingEmails != false) {
        size += 1 + 1;
      }
      if (SendPushNotifications != false) {
        size += 1 + 1;
      }
      return size;
    }

    public void MergeFrom(ContactSettingsProto other) {
      if (other == null) {
        return;
      }
      if (other.SendMarketingEmails != false) {
        SendMarketingEmails = other.SendMarketingEmails;
      }
      if (other.SendPushNotifications != false) {
        SendPushNotifications = other.SendPushNotifications;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            SendMarketingEmails = input.ReadBool();
            break;
          }
          case 16: {
            SendPushNotifications = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
