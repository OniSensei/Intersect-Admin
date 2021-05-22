Imports Newtonsoft.Json.Linq

Module JsonDeserializer
    Public Class oAuthToken
        Public Property access_token As String
        Public Property token_type As String
        Public Property expires_in As Integer
        Public Property refresh_token As String
        Public Property issued As Date
        Public Property expires As Date
    End Class

    Public Class ServerInfo
        Public Property Name As String
        Public Property Port As Integer
    End Class

    Public Class ServerStats
        Public Property uptime As Integer
        Public Property cps As Integer
        Public Property connectedClients As Integer
        Public Property onlineCount As Integer
    End Class

    Public Class ServerConfig
        Public Property GameName As String
        Public Property ServerPort As Integer
        Public Property AdminOnly As Boolean
        Public Property BlockClientRegistrations As Boolean
        Public Property AnimatedSprites As List(Of String)
        Public Property ValidPasswordResetTimeMinutes As Integer
        Public Property UPnP As Boolean
        Public Property Chat As ServerConfigChat
        Public Property Combat As ServerConfigCombat
        Public Property EventWatchdogKillThreshold As Integer
        Public Property Map As ServerConfigMap
        Public Property Player As ServerConfigPlayer
        Public Property Party As ServerConfigParty
        Public Property Loot As ServerConfigLoot
        Public Property Passability As ServerConfigPassability
        Public Property SmtpValid As Boolean
        Public Property OpenPortChecker As Boolean
    End Class

    Public Class ServerConfigChat
        Public Property MaxChatLength As Integer
        Public Property MinIntervalBetweenChats As Integer
    End Class

    Public Class ServerConfigCombat
        Public Property BlockingSlow As Integer
        Public Property CombatTime As Integer
        Public Property MaxAttackRate As Integer
        Public Property MaxDashSpeed As Integer
        Public Property MinAttackRate As Integer
        Public Property RegenTime As Integer
    End Class

    Public Class ServerConfigMap
        Public Property GameBorderStyle As Integer
        Public Property Height As Integer
        Public Property ItemAttributeRespawnTime As Integer
        Public Property TileHeight As Integer
        Public Property TileWidth As Integer
        Public Property Width As Integer
        Public Property ZDimensionVisible As Boolean
    End Class

    Public Class ServerConfigPlayer
        Public Property ItemDropChance As Integer
        Public Property MaxBank As Integer
        Public Property MaxCharacters As Integer
        Public Property MaxInventory As Integer
        Public Property MaxLevel As Integer
        Public Property MaxSpells As Integer
        Public Property MaxStat As Integer
        Public Property RequestTimeout As Integer
        Public Property TradeRange As Integer
    End Class

    Public Class ServerConfigParty
        Public Property MaximumMembers As Integer
        Public Property InviteRange As Integer
        Public Property SharedXpRange As Integer
        Public Property NpcDeathCommonEventStartRange As Integer
    End Class

    Public Class ServerConfigLoot
        Public Property ItemDespawnTime As Integer
        Public Property ItemOwnershipTime As Integer
        Public Property ShowUnownedItems As Boolean
        Public Property ConsolidateMapDrops As Boolean
    End Class

    Public Class ServerConfigPassability
        Public Property Arena As Boolean
        Public Property Normal As Boolean
        Public Property Safe As Boolean
    End Class

    Public Class NameColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class PlayersOnlineEntry
        Public Property Name As String
        Public Property InBank As Boolean
        Public Property UserId As String
        Public Property MaxVitals As Integer()
        Public Property ClassId As String
        Public Property Gender As Integer
        Public Property Exp As Integer
        Public Property StatPoints As Integer
        Public Property Equipment As Integer()
        Public Property LastOnline As DateTime
        Public Property Trading As String
        Public Property InBag As Boolean
        Public Property InShop As Boolean
        Public Property ExperienceToNextLevel As Integer
        Public Property MapId As String
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Z As Integer
        Public Property Dir As Integer
        Public Property Sprite As String
        Public Property Face As String
        Public Property Level As Integer
        Public Property Vitals As Integer()
        Public Property BaseStats As Integer()
        Public Property StatPointAllocations As Integer()
        Public Property NameColor As NameColor
        Public Property Id As String
        Public Property Dead As Boolean
    End Class

    Public Class PlayersOnline
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As PlayersOnlineEntry()
    End Class

    Public Class GlobalMessageColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class ChatMessage
        Public Property Message As String
        Public Property Color As GlobalMessageColor
        Public Property Target As String
    End Class

    Public Class GlobalMessage
        Public Property success As Boolean
        Public Property chatMessage As ChatMessage
    End Class

    Public Class Light
        Public Property Color As GlobalMessageColor
        Public Property Expand As Double
        Public Property Intensity As Integer
        Public Property OffsetX As Integer
        Public Property OffsetY As Integer
        Public Property Size As Integer
        Public Property TileX As Integer
        Public Property TileY As Integer
    End Class

    Public Class Spawn
        Public Property Direction As Integer
        Public Property NpcId As String
        Public Property X As Integer
        Public Property Y As Integer
    End Class

    Public Class PlayerLightColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class GameObjectsMapValue
        Public Property Name As String
        Public Property EventIds As String()
        Public Property Up As String
        Public Property Down As String
        Public Property Left As String
        Public Property Right As String
        Public Property Revision As Integer
        Public Property Lights As Light()
        Public Property LocalEventsJson As String
        Public Property Spawns As Spawn()
        Public Property Music As String
        Public Property Sound As Object
        Public Property IsIndoors As Boolean
        Public Property Panorama As String
        Public Property Fog As String
        Public Property FogXSpeed As Integer
        Public Property FogYSpeed As Integer
        Public Property FogTransparency As Integer
        Public Property RHue As Integer
        Public Property GHue As Integer
        Public Property BHue As Integer
        Public Property AHue As Integer
        Public Property Brightness As Integer
        Public Property ZoneType As Integer
        Public Property PlayerLightSize As Integer
        Public Property PlayerLightIntensity As Integer
        Public Property PlayerLightExpand As Double
        Public Property PlayerLightColor As PlayerLightColor
        Public Property OverlayGraphic As String
        Public Property WeatherAnimationId As String
        Public Property WeatherXSpeed As Integer
        Public Property WeatherYSpeed As Integer
        Public Property WeatherIntensity As Integer
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsMapEntry
        Public Property Key As String
        Public Property Value As GameObjectsMapValue
    End Class

    Public Class GameObjectsMap
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsMapEntry()
    End Class

    Public Class AttackOnSightConditions
        Public Property Lists As String
    End Class

    Public Class Drop
        Public Property Chance As Double
        Public Property ItemId As String
        Public Property Quantity As Integer
    End Class

    Public Class PlayerCanAttackConditions
        Public Property Lists As String
    End Class

    Public Class PlayerFriendConditions
        Public Property Lists As String
    End Class

    Public Class GameObjectsNpcValue
        Public Property Name As String
        Public Property AttackOnSightConditions As AttackOnSightConditions
        Public Property Drops As Drop()
        Public Property MaxVital As Integer()
        Public Property PlayerCanAttackConditions As PlayerCanAttackConditions
        Public Property PlayerFriendConditions As PlayerFriendConditions
        Public Property Stats As Integer()
        Public Property VitalRegen As Integer()
        Public Property AggroList As String()
        Public Property AttackAllies As Boolean
        Public Property AttackAnimationId As String
        Public Property Aggressive As Boolean
        Public Property Movement As Integer
        Public Property Swarm As Boolean
        Public Property FleeHealthPercentage As Integer
        Public Property FocusHighestDamageDealer As Boolean
        Public Property Damage As Integer
        Public Property DamageType As Integer
        Public Property CritChance As Integer
        Public Property CritMultiplier As Double
        Public Property AttackSpeedModifier As Integer
        Public Property AttackSpeedValue As Integer
        Public Property OnDeathEventId As String
        Public Property OnDeathPartyEventId As String
        Public Property Experience As Integer
        Public Property Level As Integer
        Public Property NpcVsNpcEnabled As Boolean
        Public Property Scaling As Integer
        Public Property ScalingStat As Integer
        Public Property SightRange As Integer
        Public Property SpawnDuration As Integer
        Public Property SpellFrequency As Integer
        Public Property Spells As String()
        Public Property Sprite As String
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsNpcEntry
        Public Property Key As String
        Public Property Value As GameObjectsNpcValue
    End Class

    Public Class GameObjectsNpc
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsNpcEntry()
    End Class

    Public Class GameObjectsQuestTask
        Public Property Id As String
        Public Property CompletionEventId As String
        Public Property Objective As Integer
        Public Property TargetId As String
        Public Property Quantity As Integer
        Public Property Description As String
    End Class

    Public Class GameObjectsQuestRequirements
        Public Property Lists As String
    End Class

    Public Class GameObjectsQuestValue
        Public Property Name As String
        Public Property RemoveEvents As Object()
        Public Property Tasks As GameObjectsQuestTask()
        Public Property StartDescription As String
        Public Property BeforeDescription As String
        Public Property EndDescription As String
        Public Property InProgressDescription As String
        Public Property LogAfterComplete As Boolean
        Public Property LogBeforeOffer As Boolean
        Public Property Quitable As Boolean
        Public Property Repeatable As Boolean
        Public Property Requirements As GameObjectsQuestRequirements
        Public Property StartEventId As String
        Public Property EndEventId As String
        Public Property LocalEventsJson As String
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsQuestEntry
        Public Property Key As String
        Public Property Value As GameObjectsQuestValue
    End Class

    Public Class GameObjectsQuest
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsQuestEntry()
    End Class

    Public Class GameObjectsMapDetailsSpawn
        Public Property Direction As Integer
        Public Property NpcId As String
        Public Property X As Integer
        Public Property Y As Integer
    End Class

    Public Class GameObjectsMapDetailsPlayerLightColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class GameObjectsMapDetails
        Public Property Name As String
        Public Property EventIds As String()
        Public Property Up As String
        Public Property Down As String
        Public Property Left As String
        Public Property Right As String
        Public Property Revision As Integer
        Public Property Lights As Object()
        Public Property LocalEventsJson As String
        Public Property Spawns As GameObjectsMapDetailsSpawn()
        Public Property Music As String
        Public Property Sound As String
        Public Property IsIndoors As Boolean
        Public Property Panorama As String
        Public Property Fog As String
        Public Property FogXSpeed As Integer
        Public Property FogYSpeed As Integer
        Public Property FogTransparency As Integer
        Public Property RHue As Integer
        Public Property GHue As Integer
        Public Property BHue As Integer
        Public Property AHue As Integer
        Public Property Brightness As Integer
        Public Property ZoneType As Integer
        Public Property PlayerLightSize As Integer
        Public Property PlayerLightIntensity As Integer
        Public Property PlayerLightExpand As Double
        Public Property PlayerLightColor As GameObjectsMapDetailsPlayerLightColor
        Public Property OverlayGraphic As String
        Public Property WeatherAnimationId As String
        Public Property WeatherXSpeed As Integer
        Public Property WeatherYSpeed As Integer
        Public Property WeatherIntensity As Integer
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    '---------------------------------------------------------

    Public Class ListUsersPower
        Public Property Editor As Boolean
        Public Property Ban As Boolean
        Public Property Kick As Boolean
        Public Property Mute As Boolean
        Public Property Api As Boolean
        Public Property PersonalInformation As Boolean
    End Class

    Public Class ListUsersValue
        Public Property Id As String
        Public Property Name As String
        Public Property Email As String
        Public Property Power As ListUsersPower
        Public Property PasswordResetCode As Object
        Public Property IsMuted As Boolean
        Public Property MuteReason As Object
    End Class

    Public Class ListUsers
        Public Property Total As Integer
        Public Property Page As Integer
        Public Property PageSize As Integer
        Public Property Count As Integer
        Public Property Values As ListUsersValue()
    End Class

    '--------------------------------------------------------
    Public Class ListPlayersSpellCooldowns
        Public Property Blob As Long
    End Class

    Public Class ListPlayersNameColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class ListPlayersColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class ListPlayersHeaderLabel
        Public Property Label As String
        Public Property Color As ListPlayersColor
    End Class

    Public Class ListPlayersFooterLabel
        Public Property Label As String
        Public Property Color As ListPlayersColor
    End Class

    Public Class ListPlayersValue
        Public Property Name As String
        Public Property InBank As Boolean
        Public Property SpellCooldowns As ListPlayersSpellCooldowns
        Public Property UserId As String
        Public Property MaxVitals As Integer()
        Public Property ClassId As String
        Public Property Gender As Integer
        Public Property Exp As Integer
        Public Property StatPoints As Integer
        Public Property Equipment As Integer()
        Public Property LastOnline As DateTime
        Public Property ExperienceToNextLevel As Integer
        Public Property Trading As String
        Public Property InBag As Boolean
        Public Property InShop As Boolean
        Public Property MapId As String
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Z As Integer
        Public Property Dir As Integer
        Public Property Sprite As String
        Public Property Face As String
        Public Property Level As Integer
        Public Property Vitals As Integer()
        Public Property BaseStats As Integer()
        Public Property StatPointAllocations As Integer()
        Public Property NameColor As ListPlayersNameColor
        Public Property Id As String
        Public Property HeaderLabel As ListPlayersHeaderLabel
        Public Property FooterLabel As ListPlayersFooterLabel
        Public Property Dead As Boolean
    End Class

    Public Class ListPlayersExtra
        Public Property sortDirection As Integer
    End Class

    Public Class ListPlayers
        Public Property Total As Integer
        Public Property Page As Integer
        Public Property PageSize As Integer
        Public Property Count As Integer
        Public Property Values As ListPlayersValue()
        Public Property Sort As Object
        Public Property Extra As ListPlayersExtra
    End Class
    '------------------------------------------------------------

    Public Class UserDetailsPower
        Public Property Editor As Boolean
        Public Property Ban As Boolean
        Public Property Kick As Boolean
        Public Property Mute As Boolean
        Public Property Api As Boolean
        Public Property PersonalInformation As Boolean
    End Class

    Public Class UserDetails
        Public Property Id As String
        Public Property Name As String
        Public Property Email As String
        Public Property Power As UserDetailsPower
        Public Property PasswordResetCode As Object
        Public Property IsMuted As Boolean
        Public Property MuteReason As Object
    End Class

    '--------------------------------------------------
    Public Class ClassDetailsExperienceOverrides
    End Class

    Public Class ClassDetailsSprite
        Public Property Face As String
        Public Property Gender As Integer
        Public Property Sprite As String
    End Class

    Public Class ClassDetailsValue
        Public Property Name As String
        Public Property BaseStat As Integer()
        Public Property BaseVital As Integer()
        Public Property ExperienceOverrides As ClassDetailsExperienceOverrides
        Public Property Items As Object()
        Public Property Spells As Object()
        Public Property Sprites As ClassDetailsSprite()
        Public Property StatIncrease As Integer()
        Public Property VitalIncrease As Integer()
        Public Property VitalRegen As Integer()
        Public Property AttackAnimationId As String
        Public Property BasePoints As Integer
        Public Property CritChance As Integer
        Public Property CritMultiplier As Double
        Public Property Damage As Integer
        Public Property DamageType As Integer
        Public Property AttackSpeedModifier As Integer
        Public Property AttackSpeedValue As Integer
        Public Property BaseExp As Integer
        Public Property ExpIncrease As Integer
        Public Property IncreasePercentage As Boolean
        Public Property Locked As Boolean
        Public Property PointIncrease As Integer
        Public Property Scaling As Integer
        Public Property ScalingStat As Integer
        Public Property SpawnMapId As String
        Public Property SpawnX As Integer
        Public Property SpawnY As Integer
        Public Property SpawnDir As Integer
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class ClassDetailsEntry
        Public Property Key As String
        Public Property Value As ClassDetailsValue
    End Class

    Public Class ClassDetails
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As ClassDetailsEntry()
    End Class

    Public Class Inventory
        Public Property Slot As Integer
        Public Property BagId As String
        Public Property ItemId As String
        Public Property Quantity As Integer
        Public Property StatBuffs As Integer()
    End Class

    Public Class Bank
        Public Property Slot As Integer
        Public Property BagId As Object
        Public Property ItemId As String
        Public Property Quantity As Integer
        Public Property StatBuffs As Integer()
    End Class

    Public Class PlayerItems
        Public Property inventory As Inventory()
        Public Property bank As Bank()
    End Class

    '------------------------------------------------------
    Public Class GameObjectsClassExperienceOverrides
    End Class

    Public Class GameObjectsClassSprite
        Public Property Face As String
        Public Property Gender As Integer
        Public Property Sprite As String
    End Class

    Public Class Value
        Public Property Name As String
        Public Property BaseStat As Integer()
        Public Property BaseVital As Integer()
        Public Property ExperienceOverrides As GameObjectsClassExperienceOverrides
        Public Property Items As Object()
        Public Property Spells As Object()
        Public Property Sprites As GameObjectsClassSprite()
        Public Property StatIncrease As Integer()
        Public Property VitalIncrease As Integer()
        Public Property VitalRegen As Integer()
        Public Property AttackAnimationId As String
        Public Property BasePoints As Integer
        Public Property CritChance As Integer
        Public Property CritMultiplier As Double
        Public Property Damage As Integer
        Public Property DamageType As Integer
        Public Property AttackSpeedModifier As Integer
        Public Property AttackSpeedValue As Integer
        Public Property BaseExp As Integer
        Public Property ExpIncrease As Integer
        Public Property IncreasePercentage As Boolean
        Public Property Locked As Boolean
        Public Property PointIncrease As Integer
        Public Property Scaling As Integer
        Public Property ScalingStat As Integer
        Public Property SpawnMapId As String
        Public Property SpawnX As Integer
        Public Property SpawnY As Integer
        Public Property SpawnDir As Integer
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsClassEntry
        Public Property Key As String
        Public Property Value As Value
    End Class

    Public Class GameObjectsClass
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsClassEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsAnimationColor
        Public Property A As Integer
        Public Property R As Integer
        Public Property G As Integer
        Public Property B As Integer
    End Class

    Public Class GameObjectsAnimationLower
        Public Property Sprite As String
        Public Property FrameCount As Integer
        Public Property XFrames As Integer
        Public Property YFrames As Integer
        Public Property FrameSpeed As Integer
        Public Property LoopCount As Integer
        Public Property DisableRotations As Boolean
        Public Property AlternateRenderLayer As Boolean
        Public Property Lights As GameObjectsAnimationLight()
    End Class

    Public Class GameObjectsAnimationLight
        Public Property Color As GameObjectsAnimationColor
        Public Property Expand As Double
        Public Property Intensity As Integer
        Public Property OffsetX As Integer
        Public Property OffsetY As Integer
        Public Property Size As Integer
        Public Property TileX As Integer
        Public Property TileY As Integer
    End Class

    Public Class GameObjectsAnimationUpper
        Public Property Sprite As String
        Public Property FrameCount As Integer
        Public Property XFrames As Integer
        Public Property YFrames As Integer
        Public Property FrameSpeed As Integer
        Public Property LoopCount As Integer
        Public Property DisableRotations As Boolean
        Public Property AlternateRenderLayer As Boolean
        Public Property Lights As GameObjectsAnimationLight()
    End Class

    Public Class GameObjectsAnimationValue
        Public Property Name As String
        Public Property Lower As GameObjectsAnimationLower
        Public Property Upper As GameObjectsAnimationUpper
        Public Property Sound As Object
        Public Property CompleteSound As Boolean
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsAnimationEntry
        Public Property Key As String
        Public Property Value As GameObjectsAnimationValue
    End Class

    Public Class GameObjectsAnimation
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsAnimationEntry()
    End Class

    '------------------------------------------------------
    Public Class GameObjectsItemUsageRequirements
        Public Property Lists As String
    End Class

    Public Class GameObjectsItemConsumable
        Public Property Type As Integer
        Public Property Value As Integer
        Public Property Percentage As Integer
    End Class

    Public Class GameObjectsItemEffect
        Public Property Type As Integer
        Public Property Percentage As Integer
    End Class

    Public Class GameObjectsItemValue
        Public Property Name As String
        Public Property UsageRequirements As GameObjectsItemUsageRequirements
        Public Property AnimationId As String
        Public Property AttackAnimationId As String
        Public Property EquipmentAnimationId As String
        Public Property Bound As Boolean
        Public Property CritChance As Integer
        Public Property CritMultiplier As Double
        Public Property Cooldown As Integer
        Public Property Damage As Integer
        Public Property DamageType As Integer
        Public Property AttackSpeedModifier As Integer
        Public Property AttackSpeedValue As Integer
        Public Property Consumable As GameObjectsItemConsumable
        Public Property EquipmentSlot As Integer
        Public Property TwoHanded As Boolean
        Public Property Effect As GameObjectsItemEffect
        Public Property SlotCount As Integer
        Public Property SpellId As String
        Public Property QuickCast As Boolean
        Public Property DestroySpell As Boolean
        Public Property EventId As String
        Public Property Description As String
        Public Property FemalePaperdoll As String
        Public Property ItemType As Integer
        Public Property MalePaperdoll As String
        Public Property Icon As String
        Public Property Price As Integer
        Public Property Rarity As Integer
        Public Property ProjectileId As String
        Public Property Scaling As Integer
        Public Property ScalingStat As Integer
        Public Property Speed As Integer
        Public Property Stackable As Boolean
        Public Property StatGrowth As Integer
        Public Property Tool As Integer
        Public Property VitalsGiven As Integer()
        Public Property VitalsRegen As Integer()
        Public Property PercentageVitalsGiven As Integer()
        Public Property StatsGiven As Integer()
        Public Property PercentageStatsGiven As Integer()
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsItemEntry
        Public Property Key As String
        Public Property Value As GameObjectsItemValue
    End Class

    Public Class GameObjectsItem
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsItemEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsProjectileAnimation
        Public Property AnimationId As String
        Public Property AutoRotate As Boolean
        Public Property SpawnRange As Integer
    End Class

    Public Class GameObjectsProjectileSpawnLocations
        Public Property Directions As Boolean
    End Class

    Public Class GameObjectsProjectileValue
        Public Property Name As String
        Public Property Animations As GameObjectsProjectileAnimation()
        Public Property SpawnLocations As GameObjectsProjectileSpawnLocations()
        Public Property AmmoItemId As String
        Public Property AmmoRequired As Integer
        Public Property Delay As Integer
        Public Property GrappleHook As Boolean
        Public Property IgnoreActiveResources As Boolean
        Public Property IgnoreExhaustedResources As Boolean
        Public Property IgnoreMapBlocks As Boolean
        Public Property IgnoreZDimension As Boolean
        Public Property PierceTarget As Boolean
        Public Property Knockback As Integer
        Public Property Quantity As Integer
        Public Property Range As Integer
        Public Property Speed As Integer
        Public Property SpellId As String
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsProjectileEntry
        Public Property Key As String
        Public Property Value As Value
    End Class

    Public Class GameObjectsProjectile
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsProjectileEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsResourceDrop
        Public Property Chance As Double
        Public Property ItemId As String
        Public Property Quantity As Integer
    End Class

    Public Class GameObjectsResourceHarvestingRequirements
        Public Property Lists As String
    End Class

    Public Class GameObjectsResourceInitial
        Public Property Graphic As String
        Public Property RenderBelowEntities As Boolean
        Public Property GraphicFromTileset As Boolean
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Width As Integer
        Public Property Height As Integer
    End Class

    Public Class GameObjectsResourceExhausted
        Public Property Graphic As String
        Public Property RenderBelowEntities As Boolean
        Public Property GraphicFromTileset As Boolean
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Width As Integer
        Public Property Height As Integer
    End Class

    Public Class GameObjectsResourceValue
        Public Property Name As String
        Public Property Drops As GameObjectsResourceDrop()
        Public Property HarvestingRequirements As GameObjectsResourceHarvestingRequirements
        Public Property Initial As GameObjectsResourceInitial
        Public Property Exhausted As GameObjectsResourceExhausted
        Public Property AnimationId As String
        Public Property EventId As String
        Public Property VitalRegen As Integer
        Public Property MaxHp As Integer
        Public Property MinHp As Integer
        Public Property SpawnDuration As Integer
        Public Property Tool As Integer
        Public Property WalkableAfter As Boolean
        Public Property WalkableBefore As Boolean
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsResourceEntry
        Public Property Key As String
        Public Property Value As GameObjectsResourceValue
    End Class

    Public Class GameObjectsResource
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsResourceEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsShopBuyingItem
        Public Property CostItemId As String
        Public Property CostItemQuantity As Integer
        Public Property ItemId As String
    End Class

    Public Class GameObjectsShopSellingItem
        Public Property CostItemId As String
        Public Property CostItemQuantity As Integer
        Public Property ItemId As String
    End Class

    Public Class GameObjectsShopValue
        Public Property Name As String
        Public Property BuyingItems As GameObjectsShopBuyingItem()
        Public Property SellingItems As GameObjectsShopSellingItem()
        Public Property BuyingWhitelist As Boolean
        Public Property DefaultCurrencyId As String
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsShopEntry
        Public Property Key As String
        Public Property Value As GameObjectsShopValue
    End Class

    Public Class GameObjectsShop
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsShopEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsSpellCastingRequirements
        Public Property Lists As String
    End Class

    Public Class GameObjectsSpellCombat
        Public Property VitalDiff As Integer()
        Public Property CritChance As Integer
        Public Property CritMultiplier As Double
        Public Property DamageType As Integer
        Public Property HitRadius As Integer
        Public Property Friendly As Boolean
        Public Property CastRange As Integer
        Public Property ProjectileId As String
        Public Property StatDiff As Integer()
        Public Property PercentageStatDiff As Integer()
        Public Property Scaling As Integer
        Public Property ScalingStat As Integer
        Public Property TargetType As Integer
        Public Property HoTDoT As Boolean
        Public Property HotDotInterval As Integer
        Public Property Duration As Integer
        Public Property Effect As Integer
        Public Property TransformSprite As Object
        Public Property OnHitDuration As Integer
        Public Property TrapDuration As Integer
    End Class

    Public Class GameObjectsSpellWarp
        Public Property MapId As String
        Public Property X As Integer
        Public Property Y As Integer
        Public Property Dir As Integer
    End Class

    Public Class GameObjectsSpellDash
        Public Property IgnoreMapBlocks As Boolean
        Public Property IgnoreActiveResources As Boolean
        Public Property IgnoreInactiveResources As Boolean
        Public Property IgnoreZDimensionAttributes As Boolean
    End Class

    Public Class GameObjectsSpellValue
        Public Property Name As String
        Public Property VitalCost As Integer()
        Public Property SpellType As Integer
        Public Property Description As String
        Public Property Icon As String
        Public Property CastAnimationId As String
        Public Property HitAnimationId As String
        Public Property CastDuration As Integer
        Public Property CooldownDuration As Integer
        Public Property Bound As Boolean
        Public Property CastingRequirements As GameObjectsSpellCastingRequirements
        Public Property Combat As GameObjectsSpellCombat
        Public Property Warp As GameObjectsSpellWarp
        Public Property Dash As GameObjectsSpellDash
        Public Property EventId As String
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsSpellEntry
        Public Property Key As String
        Public Property Value As GameObjectsSpellValue
    End Class

    Public Class GameObjectsSpell
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsSpellEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsCraftTablesValue
        Public Property Name As String
        Public Property Crafts As String()
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsCraftTablesEntry
        Public Property Key As String
        Public Property Value As GameObjectsCraftTablesValue
    End Class

    Public Class GameObjectsCraftTables
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsCraftTablesEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsCraftsIngredient
        Public Property ItemId As String
        Public Property Quantity As Integer
    End Class

    Public Class GameObjectsCraftsValue
        Public Property ItemId As String
        Public Property Name As String
        Public Property Quantity As Integer
        Public Property Time As Integer
        Public Property Ingredients As GameObjectsCraftsIngredient()
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsCraftsEntry
        Public Property Key As String
        Public Property Value As GameObjectsCraftsValue
    End Class

    Public Class GameObjectsCrafts
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsCraftsEntry()
    End Class
    '------------------------------------------------------
    Public Class GameObjectsEventCondition
        Public Property Type As Integer
        Public Property Access As Integer
        Public Property Negated As Boolean
    End Class

    Public Class GameObjectsEventCommand
        Public Property Type As Integer
        Public Property Text As String
        Public Property Color As String
        Public Property Ammount As Integer
        Public Property Channel As Integer
        Public Property AnimationId As String
        Public Property Dir As Integer?
        Public Property MapId As String
        Public Property EntityId As String
        Public Property X As Integer?
        Public Property Y As Integer?
        Public Property SpellId As String
        Public Property Add As Boolean
        Public Property BranchIds As String()
    End Class

    Public Class GameObjectsEventCommandLists
        Public Property GameObjectsEventCommand As GameObjectsEventCommand()
    End Class

    Public Class GameObjectsEventConditionLists
        Public Property Lists As String
    End Class

    Public Class GameObjectsEventGraphic
        Public Property Filename As String
        Public Property Height As Integer
        Public Property Type As Integer
        Public Property Width As Integer
        Public Property X As Integer
        Public Property Y As Integer
    End Class

    Public Class GameObjectsEventRoute
        Public Property Actions As Object()
        Public Property IgnoreIfBlocked As Boolean
        Public Property RepeatRoute As Boolean
        Public Property Target As String
    End Class

    Public Class GameObjectsEventMovement
        Public Property Type As Integer
        Public Property Frequency As Integer
        Public Property Speed As Integer
        Public Property Route As GameObjectsEventRoute
    End Class

    Public Class GameObjectsEventPage
        Public Property AnimationId As String
        Public Property CommandLists As GameObjectsEventCommandLists
        Public Property ConditionLists As GameObjectsEventConditionLists
        Public Property Description As String
        Public Property DirectionFix As Boolean
        Public Property DisablePreview As Boolean
        Public Property FaceGraphic As Object
        Public Property Graphic As GameObjectsEventGraphic
        Public Property HideName As Boolean
        Public Property InteractionFreeze As Boolean
        Public Property Layer As Integer
        Public Property Movement As GameObjectsEventMovement
        Public Property Passable As Boolean
        Public Property Trigger As Integer
        Public Property CommonTrigger As Integer
        Public Property TriggerCommand As String
        Public Property TriggerVal As String
        Public Property WalkingAnimation As Boolean
    End Class

    Public Class GameObjectsEventValue
        Public Property Name As String
        Public Property MapId As String
        Public Property SpawnX As Integer
        Public Property SpawnY As Integer
        Public Property CommonEvent As Boolean
        Public Property GlobalB As Boolean
        Public Property Pages As GameObjectsEventPage()
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsEventEntry
        Public Property Key As String
        Public Property Value As GameObjectsEventValue
    End Class

    Public Class GameObjectsEvent
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsEventEntry()
    End Class

    '------------------------------------------------------

    Public Class GameObjectsPlayerVarValue
        Public Property Name As String
        Public Property TextId As String
        Public Property Type As Integer
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsPlayerVarEntry
        Public Property Key As String
        Public Property Value As GameObjectsPlayerVarValue
    End Class

    Public Class GameObjectsPlayerVar
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsPlayerVarEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsServerVarValue
        Public Property Name As String
        Public Property TextId As String
        Public Property Type As Integer
        Public Property Value As Object
        Public Property Folder As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsServerVarEntry
        Public Property Key As String
        Public Property Value As GameObjectsServerVarValue
    End Class

    Public Class GameObjectsServerVar
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsServerVarEntry()
    End Class
    '------------------------------------------------------

    Public Class GameObjectsServerTilesetValue
        Public Property Name As String
        Public Property Id As String
        Public Property TimeCreated As Long
    End Class

    Public Class GameObjectsServerTilesetEntry
        Public Property Key As String
        Public Property Value As GameObjectsServerTilesetValue
    End Class

    Public Class GameObjectsServerTileset
        Public Property total As Integer
        Public Property Page As Integer
        Public Property count As Integer
        Public Property entries As GameObjectsServerTilesetEntry()
    End Class
End Module
