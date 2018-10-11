﻿using System.Collections.Generic;
using System.Linq;
using NeoSmart.Unicode;

namespace EmojiPicker
{
    public partial class EmojiPicker
    {
        private static readonly Dictionary<int, SingleEmoji[]> EmojiGroups = new Dictionary<int, SingleEmoji[]>
        {
            { 0, new []
                {
            /* 😀 */Emoji.GrinningFace,
	        /* 😁 */Emoji.GrinningFaceWithSmilingEyes,
	        /* 😂 */Emoji.FaceWithTearsOfJoy,
	        /* 🤣 */Emoji.RollingOnTheFloorLaughing,
	        /* 😃 */Emoji.SmilingFaceWithOpenMouth,
	        /* 😄 */Emoji.SmilingFaceWithOpenMouthAndSmilingEyes,
	        /* 😅 */Emoji.SmilingFaceWithOpenMouthAndColdSweat,
	        /* 😆 */Emoji.SmilingFaceWithOpenMouthAndClosedEyes,
	        /* 😉 */Emoji.WinkingFace,
	        /* 😊 */Emoji.SmilingFaceWithSmilingEyes,
	        /* 😋 */Emoji.FaceSavouringDeliciousFood,
	        /* 😎 */Emoji.SmilingFaceWithSunglasses,
	        /* 😍 */Emoji.SmilingFaceWithHeartEyes,
	        /* 😘 */Emoji.FaceBlowingAKiss,
	        /* 😗 */Emoji.KissingFace,
	        /* 😙 */Emoji.KissingFaceWithSmilingEyes,
	        /* 😚 */Emoji.KissingFaceWithClosedEyes,
	        /* 🙂 */Emoji.SlightlySmilingFace,
	        /* 🤗 */Emoji.HuggingFace,
	        /* 🤔 */Emoji.ThinkingFace,
	        /* 😐 */Emoji.NeutralFace,
	        /* 😑 */Emoji.ExpressionlessFace,
	        /* 😶 */Emoji.FaceWithoutMouth,
	        /* 🙄 */Emoji.FaceWithRollingEyes,
	        /* 😏 */Emoji.SmirkingFace,
	        /* 😣 */Emoji.PerseveringFace,
	        /* 😥 */Emoji.DisappointedButRelievedFace,
	        /* 😮 */Emoji.FaceWithOpenMouth,
	        /* 🤐 */Emoji.ZipperMouthFace,
	        /* 😯 */Emoji.HushedFace,
	        /* 😪 */Emoji.SleepyFace,
	        /* 😫 */Emoji.TiredFace,
	        /* 😴 */Emoji.SleepingFace,
	        /* 😌 */Emoji.RelievedFace,
	        /* 😛 */Emoji.FaceWithStuckOutTongue,
	        /* 😜 */Emoji.FaceWithStuckOutTongueAndWinkingEye,
	        /* 😝 */Emoji.FaceWithStuckOutTongueAndClosedEyes,
	        /* 🤤 */Emoji.DroolingFace,
	        /* 😒 */Emoji.UnamusedFace,
	        /* 😓 */Emoji.FaceWithColdSweat,
	        /* 😔 */Emoji.PensiveFace,
	        /* 😕 */Emoji.ConfusedFace,
	        /* 🙃 */Emoji.UpsideDownFace,
	        /* 🤑 */Emoji.MoneyMouthFace,
	        /* 😲 */Emoji.AstonishedFace,
	        /* 🙁 */Emoji.SlightlyFrowningFace,
	        /* 😖 */Emoji.ConfoundedFace,
	        /* 😞 */Emoji.DisappointedFace,
	        /* 😟 */Emoji.WorriedFace,
	        /* 😤 */Emoji.FaceWithSteamFromNose,
	        /* 😢 */Emoji.CryingFace,
	        /* 😭 */Emoji.LoudlyCryingFace,
	        /* 😦 */Emoji.FrowningFaceWithOpenMouth,
	        /* 😧 */Emoji.AnguishedFace,
	        /* 😨 */Emoji.FearfulFace,
	        /* 😩 */Emoji.WearyFace,
	        /* 😬 */Emoji.GrimacingFace,
	        /* 😰 */Emoji.FaceWithOpenMouthAndColdSweat,
	        /* 😱 */Emoji.FaceScreamingInFear,
	        /* 😳 */Emoji.FlushedFace,
	        /* 😵 */Emoji.DizzyFace,
	        /* 😡 */Emoji.PoutingFace,
	        /* 😠 */Emoji.AngryFace,
	        /* 😷 */Emoji.FaceWithMedicalMask,
	        /* 🤒 */Emoji.FaceWithThermometer,
	        /* 🤕 */Emoji.FaceWithHeadBandage,
	        /* 🤢 */Emoji.NauseatedFace,
	        /* 🤧 */Emoji.SneezingFace,
	        /* 😇 */Emoji.SmilingFaceWithHalo,
	        /* 🤠 */Emoji.CowboyHatFace,
	        /* 🤡 */Emoji.ClownFace,
	        /* 🤥 */Emoji.LyingFace,
	        /* 🤓 */Emoji.NerdFace,
	        /* 😈 */Emoji.SmilingFaceWithHorns,
	        /* 👿 */Emoji.AngryFaceWithHorns,
	        /* 👹 */Emoji.Ogre,
	        /* 👺 */Emoji.Goblin,
	        /* 💀 */Emoji.Skull,
	        /* 👻 */Emoji.Ghost,
	        /* 👽 */Emoji.Alien,
	        /* 👾 */Emoji.AlienMonster,
	        /* 🤖 */Emoji.RobotFace,
	        /* 💩 */Emoji.PileOfPoo,
	        /* 😺 */Emoji.SmilingCatFaceWithOpenMouth,
	        /* 😸 */Emoji.GrinningCatFaceWithSmilingEyes,
	        /* 😹 */Emoji.CatFaceWithTearsOfJoy,
	        /* 😻 */Emoji.SmilingCatFaceWithHeartEyes,
	        /* 😼 */Emoji.CatFaceWithWrySmile,
	        /* 😽 */Emoji.KissingCatFaceWithClosedEyes,
	        /* 🙀 */Emoji.WearyCatFace,
	        /* 😿 */Emoji.CryingCatFace,
	        /* 😾 */Emoji.PoutingCatFace,
	        /* 🙈 */Emoji.SeeNoEvilMonkey,
	        /* 🙉 */Emoji.HearNoEvilMonkey,
	        /* 🙊 */Emoji.SpeakNoEvilMonkey,
	        /* 👤 */Emoji.BustInSilhouette,
	        /* 👥 */Emoji.BustsInSilhouette,
	        /* 🤺 */Emoji.PersonFencing,
	        /* 👫 */Emoji.ManAndWomanHoldingHands,
	        /* 💏 */Emoji.Kiss,
	        /* 💑 */Emoji.CoupleWithHeart,
	        /* 👪 */Emoji.Family,
	        /* 👨‍👩‍👦‍👦 */Emoji.FamilyManWomanBoyBoy,
	        /* 👨‍👩‍👧‍👧 */Emoji.FamilyManWomanGirlGirl,
	        /* 👨‍👨‍👦 */Emoji.FamilyManManBoy,
	        /* 👨‍👨‍👧 */Emoji.FamilyManManGirl,
	        /* 👨‍👨‍👧‍👦 */Emoji.FamilyManManGirlBoy,
	        /* 👨‍👨‍👦‍👦 */Emoji.FamilyManManBoyBoy,
	        /* 👨‍👨‍👧‍👧 */Emoji.FamilyManManGirlGirl,
	        /* 👩‍👩‍👦 */Emoji.FamilyWomanWomanBoy,
	        /* 👩‍👩‍👧 */Emoji.FamilyWomanWomanGirl,
	        /* 👩‍👩‍👧‍👦 */Emoji.FamilyWomanWomanGirlBoy,
	        /* 👩‍👩‍👦‍👦 */Emoji.FamilyWomanWomanBoyBoy,
	        /* 👩‍👩‍👧‍👧 */Emoji.FamilyWomanWomanGirlGirl,
	        /* 👣 */Emoji.Footprints,
	        /* 👀 */Emoji.Eyes,
	        /* 👅 */Emoji.Tongue,
	        /* 👄 */Emoji.Mouth,
	        /* 🐵 */Emoji.MonkeyFace,
	        /* 🐒 */Emoji.Monkey,
	        /* 🦍 */Emoji.Gorilla,
	        /* 🐶 */Emoji.DogFace,
	        /* 🐕 */Emoji.Dog,
	        /* 🐩 */Emoji.Poodle,
	        /* 🐺 */Emoji.WolfFace,
	        /* 🦊 */Emoji.FoxFace,
	        /* 🐱 */Emoji.CatFace,
	        /* 🐈 */Emoji.Cat,
	        /* 🦁 */Emoji.LionFace,
	        /* 🐯 */Emoji.TigerFace,
	        /* 🐅 */Emoji.Tiger,
	        /* 🐆 */Emoji.Leopard,
	        /* 🐴 */Emoji.HorseFace,
	        /* 🐎 */Emoji.Horse,
	        /* 🦄 */Emoji.UnicornFace,
	        /* 🦌 */Emoji.Deer,
	        /* 🐮 */Emoji.CowFace,
	        /* 🐂 */Emoji.Ox,
	        /* 🐃 */Emoji.WaterBuffalo,
	        /* 🐄 */Emoji.Cow,
	        /* 🐷 */Emoji.PigFace,
	        /* 🐖 */Emoji.Pig,
	        /* 🐗 */Emoji.Boar,
	        /* 🐽 */Emoji.PigNose,
	        /* 🐏 */Emoji.Ram,
	        /* 🐑 */Emoji.Ewe,
	        /* 🐐 */Emoji.Goat,
	        /* 🐪 */Emoji.Camel,
	        /* 🐫 */Emoji.TwoHumpCamel,
	        /* 🐘 */Emoji.Elephant,
	        /* 🦏 */Emoji.Rhinoceros,
	        /* 🐭 */Emoji.MouseFace,
	        /* 🐁 */Emoji.Mouse,
	        /* 🐀 */Emoji.Rat,
	        /* 🐹 */Emoji.HamsterFace,
	        /* 🐰 */Emoji.RabbitFace,
	        /* 🐇 */Emoji.Rabbit,
	        /* 🦇 */Emoji.Bat,
	        /* 🐻 */Emoji.BearFace,
	        /* 🐨 */Emoji.Koala,
	        /* 🐼 */Emoji.PandaFace,
	        /* 🐾 */Emoji.PawPrints,
	        /* 🦃 */Emoji.Turkey,
	        /* 🐔 */Emoji.Chicken,
	        /* 🐓 */Emoji.Rooster,
	        /* 🐣 */Emoji.HatchingChick,
	        /* 🐤 */Emoji.BabyChick,
	        /* 🐥 */Emoji.FrontFacingBabyChick,
	        /* 🐦 */Emoji.Bird,
	        /* 🐧 */Emoji.Penguin,
	        /* 🦅 */Emoji.Eagle,
	        /* 🦆 */Emoji.Duck,
	        /* 🦉 */Emoji.Owl,
	        /* 🐸 */Emoji.FrogFace,
	        /* 🐊 */Emoji.Crocodile,
	        /* 🐢 */Emoji.Turtle,
	        /* 🦎 */Emoji.Lizard,
	        /* 🐍 */Emoji.Snake,
	        /* 🐲 */Emoji.DragonFace,
	        /* 🐉 */Emoji.Dragon,
	        /* 🐳 */Emoji.SpoutingWhale,
	        /* 🐋 */Emoji.Whale,
	        /* 🐬 */Emoji.Dolphin,
	        /* 🐟 */Emoji.Fish,
	        /* 🐠 */Emoji.TropicalFish,
	        /* 🐡 */Emoji.Blowfish,
	        /* 🦈 */Emoji.Shark,
	        /* 🐙 */Emoji.Octopus,
	        /* 🐚 */Emoji.SpiralShell,
	        /* 🦀 */Emoji.Crab,
	        /* 🦐 */Emoji.Shrimp,
	        /* 🦑 */Emoji.Squid,
	        /* 🐌 */Emoji.Snail,
	        /* 🦋 */Emoji.Butterfly,
	        /* 🐛 */Emoji.Bug,
	        /* 🐜 */Emoji.Ant,
	        /* 🐝 */Emoji.Honeybee,
	        /* 🐞 */Emoji.LadyBeetle,
	        /* 🦂 */Emoji.Scorpion
                }
            },
            { 1, new []
                {
	        /* 👩 */Emoji.Woman,
	        /* 👨 */Emoji.Man,
	        /* 🧑 */Emoji.Adult,
            /* 👶 */Emoji.Baby,
	        /* 🧒 */Emoji.Child,
	        /* 👦 */Emoji.Boy,
	        /* 👧 */Emoji.Girl,
	        /* 🧓 */Emoji.OlderAdult,
	        /* 👴 */Emoji.OldMan,
	        /* 👵 */Emoji.OldWoman,
	        /* 👨‍⚕️ */Emoji.ManHealthWorker,
	        /* 👩‍⚕️ */Emoji.WomanHealthWorker,
	        /* 👨‍🎓 */Emoji.ManStudent,
	        /* 👩‍🎓 */Emoji.WomanStudent,
	        /* 👨‍🏫 */Emoji.ManTeacher,
	        /* 👩‍🏫 */Emoji.WomanTeacher,
	        /* 👨‍⚖️ */Emoji.ManJudge,
	        /* 👩‍⚖️ */Emoji.WomanJudge,
	        /* 👨‍🌾 */Emoji.ManFarmer,
	        /* 👩‍🌾 */Emoji.WomanFarmer,
	        /* 👨‍🍳 */Emoji.ManCook,
	        /* 👩‍🍳 */Emoji.WomanCook,
	        /* 👨‍🔧 */Emoji.ManMechanic,
	        /* 👩‍🔧 */Emoji.WomanMechanic,
	        /* 👨‍🏭 */Emoji.ManFactoryWorker,
	        /* 👩‍🏭 */Emoji.WomanFactoryWorker,
	        /* 👨‍💼 */Emoji.ManOfficeWorker,
	        /* 👩‍💼 */Emoji.WomanOfficeWorker,
	        /* 👨‍🔬 */Emoji.ManScientist,
	        /* 👩‍🔬 */Emoji.WomanScientist,
	        /* 👨‍💻 */Emoji.ManTechnologist,
	        /* 👩‍💻 */Emoji.WomanTechnologist,
	        /* 👨‍🎤 */Emoji.ManSinger,
	        /* 👩‍🎤 */Emoji.WomanSinger,
	        /* 👨‍🎨 */Emoji.ManArtist,
	        /* 👩‍🎨 */Emoji.WomanArtist,
	        /* 👨‍✈️ */Emoji.ManPilot,
	        /* 👩‍✈️ */Emoji.WomanPilot,
	        /* 👨‍🚀 */Emoji.ManAstronaut,
	        /* 👩‍🚀 */Emoji.WomanAstronaut,
	        /* 👨‍🚒 */Emoji.ManFirefighter,
	        /* 👩‍🚒 */Emoji.WomanFirefighter,
	        /* 👮‍♂️ */Emoji.ManPoliceOfficer,
	        /* 👮‍♀️ */Emoji.WomanPoliceOfficer,
	        /* 🕵️‍♂️ */Emoji.ManDetective,
	        /* 🕵️‍♀️ */Emoji.WomanDetective,
	        /* 💂‍♂️ */Emoji.ManGuard,
	        /* 💂‍♀️ */Emoji.WomanGuard,
	        /* 👷‍♂️ */Emoji.ManConstructionWorker,
	        /* 👷‍♀️ */Emoji.WomanConstructionWorker,
	        /* 🤴 */Emoji.Prince,
	        /* 👸 */Emoji.Princess,
	        /* 👳‍♂️ */Emoji.ManWearingTurban,
	        /* 👳‍♀️ */Emoji.WomanWearingTurban,
	        /* 👲 */Emoji.ManWithChineseCap,
	        /* 🧕 */Emoji.WomanWithHeadscarf,
	        /* 🧔 */Emoji.BeardedPerson,
	        /* 👱‍♂️ */Emoji.BlondHairedMan,
	        /* 👱‍♀️ */Emoji.BlondHairedWoman,
	        /* 🤵 */Emoji.ManInTuxedo,
	        /* 👰 */Emoji.BrideWithVeil,
	        /* 🤰 */Emoji.PregnantWoman,
	        /* 🤱 */Emoji.BreastFeeding,
	        /* 👼 */Emoji.BabyAngel,
	        /* 🎅 */Emoji.SantaClaus,
	        /* 🤶 */Emoji.MrsClaus,
	        /* 🧙‍♀️ */Emoji.WomanMage,
	        /* 🧙‍♂️ */Emoji.ManMage,
	        /* 🧚‍♀️ */Emoji.WomanFairy,
	        /* 🧚‍♂️ */Emoji.ManFairy,
	        /* 🧛‍♀️ */Emoji.WomanVampire,
	        /* 🧛‍♂️ */Emoji.ManVampire,
	        /* 🧜‍♀️ */Emoji.Mermaid,
	        /* 🧜‍♂️ */Emoji.Merman,
	        /* 🧝‍♀️ */Emoji.WomanElf,
	        /* 🧝‍♂️ */Emoji.ManElf,
	        /* 🧟‍♀️ */Emoji.WomanZombie,
	        /* 🧟‍♂️ */Emoji.ManZombie,
	        /* 🙍‍♂️ */Emoji.ManFrowning,
	        /* 🙍‍♀️ */Emoji.WomanFrowning,
	        /* 🙎‍♂️ */Emoji.ManPouting,
	        /* 🙎‍♀️ */Emoji.WomanPouting,
	        /* 🙅‍♂️ */Emoji.ManGesturingNo,
	        /* 🙅‍♀️ */Emoji.WomanGesturingNo,
	        /* 🙆‍♂️ */Emoji.ManGesturingOk,
	        /* 🙆‍♀️ */Emoji.WomanGesturingOk,
	        /* 💁‍♂️ */Emoji.ManTippingHand,
	        /* 💁‍♀️ */Emoji.WomanTippingHand,
	        /* 🙋‍♂️ */Emoji.ManRaisingHand,
	        /* 🙋‍♀️ */Emoji.WomanRaisingHand,
	        /* 🙇‍♂️ */Emoji.ManBowing,
	        /* 🙇‍♀️ */Emoji.WomanBowing,
	        /* 🤦‍♂️ */Emoji.ManFacepalming,
	        /* 🤦‍♀️ */Emoji.WomanFacepalming,
	        /* 🤷‍♂️ */Emoji.ManShrugging,
	        /* 🤷‍♀️ */Emoji.WomanShrugging,
	        /* 💆‍♂️ */Emoji.ManGettingMassage,
	        /* 💆‍♀️ */Emoji.WomanGettingMassage,
	        /* 💇‍♂️ */Emoji.ManGettingHaircut,
	        /* 💇‍♀️ */Emoji.WomanGettingHaircut,
	        /* 🚶‍♂️ */Emoji.ManWalking,
	        /* 🚶‍♀️ */Emoji.WomanWalking,
	        /* 🏃‍♂️ */Emoji.ManRunning,
	        /* 🏃‍♀️ */Emoji.WomanRunning,
	        /* 💃 */Emoji.WomanDancing,
	        /* 🕺 */Emoji.ManDancing,
	        /* 🧖‍♀️ */Emoji.WomanInSteamyRoom,
	        /* 🧖‍♂️ */Emoji.ManInSteamyRoom,
	        /* 🧗‍♀️ */Emoji.WomanClimbing,
	        /* 🧗‍♂️ */Emoji.ManClimbing,
	        /* 🧘‍♀️ */Emoji.WomanInLotusPosition,
	        /* 🧘‍♂️ */Emoji.ManInLotusPosition,
	        /* 🛀 */Emoji.PersonTakingBath,
	        /* 🛌 */Emoji.PersonInBed,
	        /* 🏇 */Emoji.HorseRacing,
	        /* 🏂 */Emoji.Snowboarder,
	        /* 🏌️‍♂️ */Emoji.ManGolfing,
	        /* 🏌️‍♀️ */Emoji.WomanGolfing,
	        /* 🏄‍♂️ */Emoji.ManSurfing,
	        /* 🏄‍♀️ */Emoji.WomanSurfing,
	        /* 🚣‍♂️ */Emoji.ManRowingBoat,
	        /* 🚣‍♀️ */Emoji.WomanRowingBoat,
	        /* 🏊‍♂️ */Emoji.ManSwimming,
	        /* 🏊‍♀️ */Emoji.WomanSwimming,
	        /* ⛹️‍♂️ */Emoji.ManBouncingBall,
	        /* ⛹️‍♀️ */Emoji.WomanBouncingBall,
	        /* 🏋️‍♂️ */Emoji.ManLiftingWeights,
	        /* 🏋️‍♀️ */Emoji.WomanLiftingWeights,
	        /* 🚴‍♂️ */Emoji.ManBiking,
	        /* 🚴‍♀️ */Emoji.WomanBiking,
	        /* 🚵‍♂️ */Emoji.ManMountainBiking,
	        /* 🚵‍♀️ */Emoji.WomanMountainBiking,
	        /* 🤸‍♂️ */Emoji.ManCartwheeling,
	        /* 🤸‍♀️ */Emoji.WomanCartwheeling,
	        /* 🤽‍♂️ */Emoji.ManPlayingWaterPolo,
	        /* 🤽‍♀️ */Emoji.WomanPlayingWaterPolo,
	        /* 🤾‍♂️ */Emoji.ManPlayingHandball,
	        /* 🤾‍♀️ */Emoji.WomanPlayingHandball,
	        /* 🤹‍♂️ */Emoji.ManJuggling,
	        /* 🤹‍♀️ */Emoji.WomanJuggling,
	        /* 🤳 */Emoji.Selfie,
	        /* 💪 */Emoji.FlexedBiceps,
	        /* 👈 */Emoji.BackhandIndexPointingLeft,
	        /* 👉 */Emoji.BackhandIndexPointingRight,
	        /* 👆 */Emoji.BackhandIndexPointingUp,
	        /* 👇 */Emoji.BackhandIndexPointingDown,
	        /* 🤞 */Emoji.CrossedFingers,
	        /* 🖖 */Emoji.VulcanSalute,
	        /* 🤘 */Emoji.SignOfTheHorns,
	        /* 🤙 */Emoji.CallMeHand,
	        /* ✋ */Emoji.RaisedHand,
	        /* 👌 */Emoji.OkHand,
	        /* 👍 */Emoji.ThumbsUp,
	        /* 👎 */Emoji.ThumbsDown,
	        /* ✊ */Emoji.RaisedFist,
	        /* 👊 */Emoji.OncomingFist,
	        /* 🤛 */Emoji.LeftFacingFist,
	        /* 🤜 */Emoji.RightFacingFist,
	        /* 🤚 */Emoji.RaisedBackOfHand,
	        /* 👋 */Emoji.WavingHand,
	        /* 🤟 */Emoji.LoveYouGesture,
	        /* 👏 */Emoji.ClappingHands,
	        /* 👐 */Emoji.OpenHands,
	        /* 🙌 */Emoji.RaisingHands,
	        /* 🤲 */Emoji.PalmsUpTogether,
	        /* 🙏 */Emoji.FoldedHands,
	        /* 🤝 */Emoji.Handshake,
	        /* 💅 */Emoji.NailPolish,
	        /* 👂 */Emoji.Ear,
	        /* 👃 */Emoji.Nose
                }
            },
            { 2, new []
                {
            /* 🎈 */Emoji.Balloon,
            /* 💋 */Emoji.KissMark,
	        /* 💣 */Emoji.Bomb,
	        /* 👓 */Emoji.Glasses,
	        /* 👔 */Emoji.Necktie,
	        /* 👕 */Emoji.TShirt,
	        /* 👖 */Emoji.Jeans,
	        /* 🧣 */Emoji.Scarf,
	        /* 🧤 */Emoji.Gloves,
	        /* 🧥 */Emoji.Coat,
	        /* 🧦 */Emoji.Socks,
	        /* 👗 */Emoji.Dress,
	        /* 👘 */Emoji.Kimono,
	        /* 👙 */Emoji.Bikini,
	        /* 👚 */Emoji.WomansClothes,
	        /* 👛 */Emoji.Purse,
	        /* 👜 */Emoji.Handbag,
	        /* 👝 */Emoji.ClutchBag,
	        /* 🎒 */Emoji.SchoolBackpack,
	        /* 👞 */Emoji.MansShoe,
	        /* 👟 */Emoji.RunningShoe,
	        /* 👠 */Emoji.HighHeeledShoe,
	        /* 👡 */Emoji.WomansSandal,
	        /* 👢 */Emoji.WomansBoot,
	        /* 👑 */Emoji.Crown,
	        /* 👒 */Emoji.WomansHat,
	        /* 🎩 */Emoji.TopHat,
	        /* 🎓 */Emoji.GraduationCap,
	        /* 🧢 */Emoji.BilledCap,
	        /* 📿 */Emoji.PrayerBeads,
	        /* 💄 */Emoji.Lipstick,
	        /* 💍 */Emoji.Ring,
	        /* 💎 */Emoji.GemStone,
	        /* 🔪 */Emoji.KitchenKnife,
	        /* 🎠 */Emoji.CarouselHorse,
	        /* 🎡 */Emoji.FerrisWheel,
	        /* 🎢 */Emoji.RollerCoaster,
	        /* 🎪 */Emoji.CircusTent,
	        /* 🎭 */Emoji.PerformingArts,
	        /* 🎨 */Emoji.ArtistPalette,
	        /* 🎰 */Emoji.SlotMachine,
	        /* 🛶 */Emoji.Canoe,
	        /* ⌛ */Emoji.Hourglass,
	        /* ⏳ */Emoji.HourglassWithFlowingSand,
	        /* ⌚ */Emoji.Watch,
	        /* ⏰ */Emoji.AlarmClock,
	        /* 🎃 */Emoji.JackOLantern,
	        /* 🎄 */Emoji.ChristmasTree,
	        /* 🎆 */Emoji.Fireworks,
	        /* 🎇 */Emoji.Sparkler,
	        /* ✨ */Emoji.Sparkles,
	        /* 🎉 */Emoji.PartyPopper,
	        /* 🎊 */Emoji.ConfettiBall,
	        /* 🎋 */Emoji.TanabataTree,
	        /* 🎍 */Emoji.PineDecoration,
	        /* 🎎 */Emoji.JapaneseDolls,
	        /* 🎏 */Emoji.CarpStreamer,
	        /* 🎐 */Emoji.WindChime,
	        /* 🎑 */Emoji.MoonViewingCeremony,
	        /* 🎀 */Emoji.Ribbon,
	        /* 🎁 */Emoji.WrappedGift,
	        /* 🎫 */Emoji.Ticket,
	        /* 🏆 */Emoji.Trophy,
	        /* 🏅 */Emoji.SportsMedal,
	        /* 🥇 */Emoji.FirstPlaceMedal,
	        /* 🥈 */Emoji.SecondPlaceMedal,
	        /* 🥉 */Emoji.ThirdPlaceMedal,
	        /* ⚽ */Emoji.SoccerBall,
	        /* ⚾ */Emoji.Baseball,
	        /* 🏀 */Emoji.Basketball,
	        /* 🏐 */Emoji.Volleyball,
	        /* 🏈 */Emoji.AmericanFootball,
	        /* 🏉 */Emoji.RugbyFootball,
	        /* 🎾 */Emoji.Tennis,
	        /* 🎱 */Emoji.Pool8Ball,
	        /* 🎳 */Emoji.Bowling,
	        /* 🏑 */Emoji.FieldHockey,
	        /* 🏒 */Emoji.IceHockey,
	        /* 🏓 */Emoji.PingPong,
	        /* 🏸 */Emoji.Badminton,
	        /* 🥊 */Emoji.BoxingGlove,
	        /* 🥋 */Emoji.MartialArtsUniform,
	        /* 🥅 */Emoji.GoalNet,
	        /* 🎯 */Emoji.DirectHit,
	        /* ⛳ */Emoji.FlagInHole,
	        /* 🎣 */Emoji.FishingPole,
	        /* 🎽 */Emoji.RunningShirt,
	        /* 🎿 */Emoji.Skis,
	        /* 🛷 */Emoji.Sled,
	        /* 🥌 */Emoji.CurlingStone,
	        /* 🎮 */Emoji.VideoGame,
	        /* 🎲 */Emoji.GameDie,
	        /* 🃏 */Emoji.Joker,
	        /* 🀄 */Emoji.MahjongRedDragon,
	        /* 🎴 */Emoji.FlowerPlayingCards,
	        /* 🔈 */Emoji.SpeakerLowVolume,
	        /* 🔉 */Emoji.SpeakerMediumVolume,
	        /* 🔊 */Emoji.SpeakerHighVolume,
	        /* 📢 */Emoji.Loudspeaker,
	        /* 📣 */Emoji.Megaphone,
	        /* 📯 */Emoji.PostalHorn,
	        /* 🔔 */Emoji.Bell,
	        /* 🎼 */Emoji.MusicalScore,
	        /* 🎵 */Emoji.MusicalNote,
	        /* 🎶 */Emoji.MusicalNotes,
	        /* 🎤 */Emoji.Microphone,
	        /* 🎧 */Emoji.Headphone,
	        /* 📻 */Emoji.Radio,
	        /* 🎷 */Emoji.Saxophone,
	        /* 🎸 */Emoji.Guitar,
	        /* 🎹 */Emoji.MusicalKeyboard,
	        /* 🎺 */Emoji.Trumpet,
	        /* 🎻 */Emoji.Violin,
	        /* 🥁 */Emoji.Drum,
	        /* 📱 */Emoji.MobilePhone,
	        /* 📲 */Emoji.MobilePhoneWithArrow,
	        /* 📞 */Emoji.TelephoneReceiver,
	        /* 📟 */Emoji.Pager,
	        /* 📠 */Emoji.FaxMachine,
	        /* 🔋 */Emoji.Battery,
	        /* 🔌 */Emoji.ElectricPlug,
	        /* 💻 */Emoji.LaptopComputer,
	        /* 💽 */Emoji.ComputerDisk,
	        /* 💾 */Emoji.FloppyDisk,
	        /* 💿 */Emoji.OpticalDisk,
	        /* 📀 */Emoji.Dvd,
	        /* 🎥 */Emoji.MovieCamera,
	        /* 🎬 */Emoji.ClapperBoard,
	        /* 📺 */Emoji.Television,
	        /* 📷 */Emoji.Camera,
	        /* 📸 */Emoji.CameraWithFlash,
	        /* 📹 */Emoji.VideoCamera,
	        /* 📼 */Emoji.Videocassette,
	        /* 🔍 */Emoji.LeftPointingMagnifyingGlass,
	        /* 🔎 */Emoji.RightPointingMagnifyingGlass,
	        /* 🔬 */Emoji.Microscope,
	        /* 🔭 */Emoji.Telescope,
	        /* 📡 */Emoji.SatelliteAntenna,
	        /* 💡 */Emoji.LightBulb,
	        /* 🔦 */Emoji.Flashlight,
	        /* 🏮 */Emoji.RedPaperLantern,
	        /* 📔 */Emoji.NotebookWithDecorativeCover,
	        /* 📕 */Emoji.ClosedBook,
	        /* 📖 */Emoji.OpenBook,
	        /* 📗 */Emoji.GreenBook,
	        /* 📘 */Emoji.BlueBook,
	        /* 📙 */Emoji.OrangeBook,
	        /* 📚 */Emoji.Books,
	        /* 📓 */Emoji.Notebook,
	        /* 📒 */Emoji.Ledger,
	        /* 📃 */Emoji.PageWithCurl,
	        /* 📜 */Emoji.Scroll,
	        /* 📄 */Emoji.PageFacingUp,
	        /* 📰 */Emoji.Newspaper,
	        /* 📑 */Emoji.BookmarkTabs,
	        /* 🔖 */Emoji.Bookmark,
	        /* 💰 */Emoji.MoneyBag,
	        /* 💴 */Emoji.YenBanknote,
	        /* 💵 */Emoji.DollarBanknote,
	        /* 💶 */Emoji.EuroBanknote,
	        /* 💷 */Emoji.PoundBanknote,
	        /* 💸 */Emoji.MoneyWithWings,
	        /* 💳 */Emoji.CreditCard,
	        /* 📧 */Emoji.EMail,
	        /* 📨 */Emoji.IncomingEnvelope,
	        /* 📩 */Emoji.EnvelopeWithArrow,
	        /* 📤 */Emoji.OutboxTray,
	        /* 📥 */Emoji.InboxTray,
	        /* 📦 */Emoji.Package,
	        /* 📫 */Emoji.ClosedMailboxWithRaisedFlag,
	        /* 📪 */Emoji.ClosedMailboxWithLoweredFlag,
	        /* 📬 */Emoji.OpenMailboxWithRaisedFlag,
	        /* 📭 */Emoji.OpenMailboxWithLoweredFlag,
	        /* 📮 */Emoji.Postbox,
	        /* 📝 */Emoji.Memo,
	        /* 💼 */Emoji.Briefcase,
	        /* 📁 */Emoji.FileFolder,
	        /* 📂 */Emoji.OpenFileFolder,
	        /* 📅 */Emoji.Calendar,
	        /* 📆 */Emoji.TearOffCalendar,
	        /* 📇 */Emoji.CardIndex,
	        /* 📈 */Emoji.ChartIncreasing,
	        /* 📉 */Emoji.ChartDecreasing,
	        /* 📊 */Emoji.BarChart,
	        /* 📋 */Emoji.Clipboard,
	        /* 📌 */Emoji.Pushpin,
	        /* 📍 */Emoji.RoundPushpin,
	        /* 📎 */Emoji.Paperclip,
	        /* 📏 */Emoji.StraightRuler,
	        /* 📐 */Emoji.TriangularRuler,
	        /* 🔒 */Emoji.Locked,
	        /* 🔓 */Emoji.Unlocked,
	        /* 🔏 */Emoji.LockedWithPen,
	        /* 🔐 */Emoji.LockedWithKey,
	        /* 🔑 */Emoji.Key,
	        /* 🔨 */Emoji.Hammer,
	        /* 🔫 */Emoji.Pistol,
	        /* 🏹 */Emoji.BowAndArrow,
	        /* 🔧 */Emoji.Wrench,
	        /* 🔩 */Emoji.NutAndBolt,
	        /* 🔗 */Emoji.Link,
	        /* 💉 */Emoji.Syringe,
	        /* 💊 */Emoji.Pill,
	        /* 🚬 */Emoji.Cigarette,
	        /* 🗿 */Emoji.Moai,
	        /* 🔮 */Emoji.CrystalBall,
	        /* 🛒 */Emoji.ShoppingCart,
	        /* 🏧 */Emoji.AtmSign,
	        /* 🎦 */Emoji.Cinema,
	        /* 📳 */Emoji.VibrationMode,
	        /* 📴 */Emoji.MobilePhoneOff
                }
            },
            { 3, new []
                {
            /* 🍔 */Emoji.Hamburger,
            /* 🍟 */Emoji.FrenchFries,
            /* 🍕 */Emoji.Pizza,
            /* 🌭 */Emoji.HotDog,
            /* 🥪 */Emoji.Sandwich,
            /* 🌮 */Emoji.Taco,
            /* 🌯 */Emoji.Burrito,
	        /* 🥐 */Emoji.Croissant,
	        /* 🥖 */Emoji.BaguetteBread,
	        /* 🥨 */Emoji.Pretzel,
	        /* 🥞 */Emoji.Pancakes,
	        /* 🧀 */Emoji.CheeseWedge,
	        /* 🍖 */Emoji.MeatOnBone,
	        /* 🍗 */Emoji.PoultryLeg,
	        /* 🥩 */Emoji.CutOfMeat,
	        /* 🥓 */Emoji.Bacon,
	        /* 🥙 */Emoji.StuffedFlatbread,
	        /* 🥚 */Emoji.Egg,
	        /* 🍳 */Emoji.Cooking,
	        /* 🥘 */Emoji.ShallowPanOfFood,
	        /* 🍲 */Emoji.PotOfFood,
	        /* 🥣 */Emoji.BowlWithSpoon,
	        /* 🥗 */Emoji.GreenSalad,
	        /* 🍿 */Emoji.Popcorn,
	        /* 🥫 */Emoji.CannedFood,
	        /* 🍱 */Emoji.BentoBox,
	        /* 🍘 */Emoji.RiceCracker,
	        /* 🍙 */Emoji.RiceBall,
	        /* 🍚 */Emoji.CookedRice,
	        /* 🍛 */Emoji.CurryRice,
	        /* 🍜 */Emoji.SteamingBowl,
	        /* 🍝 */Emoji.Spaghetti,
	        /* 🍠 */Emoji.RoastedSweetPotato,
	        /* 🍢 */Emoji.Oden,
	        /* 🍣 */Emoji.Sushi,
	        /* 🍤 */Emoji.FriedShrimp,
	        /* 🍥 */Emoji.FishCakeWithSwirl,
	        /* 🍡 */Emoji.Dango,
	        /* 🥟 */Emoji.Dumpling,
	        /* 🥠 */Emoji.FortuneCookie,
	        /* 🥡 */Emoji.TakeoutBox,
	        /* 🍦 */Emoji.SoftIceCream,
	        /* 🍧 */Emoji.ShavedIce,
	        /* 🍨 */Emoji.IceCream,
	        /* 🍩 */Emoji.Doughnut,
	        /* 🍪 */Emoji.Cookie,
	        /* 🎂 */Emoji.BirthdayCake,
	        /* 🍰 */Emoji.Shortcake,
	        /* 🥧 */Emoji.Pie,
	        /* 🍫 */Emoji.ChocolateBar,
	        /* 🍬 */Emoji.Candy,
	        /* 🍭 */Emoji.Lollipop,
	        /* 🍮 */Emoji.Custard,
	        /* 🍯 */Emoji.HoneyPot,
	        /* 🍼 */Emoji.BabyBottle,
	        /* 🥛 */Emoji.GlassOfMilk,
	        /* ☕ */Emoji.HotBeverage,
	        /* 🍵 */Emoji.TeacupWithoutHandle,
	        /* 🍶 */Emoji.Sake,
	        /* 🍾 */Emoji.BottleWithPoppingCork,
	        /* 🍷 */Emoji.WineGlass,
	        /* 🍸 */Emoji.CocktailGlass,
	        /* 🍹 */Emoji.TropicalDrink,
	        /* 🍺 */Emoji.BeerMug,
	        /* 🍻 */Emoji.ClinkingBeerMugs,
	        /* 🥂 */Emoji.ClinkingGlasses,
	        /* 🥃 */Emoji.TumblerGlass,
	        /* 🥤 */Emoji.CupWithStraw,
	        /* 🥢 */Emoji.Chopsticks,
	        /* 🍴 */Emoji.ForkAndKnife,
	        /* ☐☐ */Emoji.Spoon,
	        /* 🏺 */Emoji.Amphora,
            /* 💐 */Emoji.Bouquet,
            /* 🌸 */Emoji.CherryBlossom,
            /* 🌹 */Emoji.Rose,
            /* 🥀 */Emoji.WiltedFlower,
            /* 🌺 */Emoji.Hibiscus,
            /* 🌻 */Emoji.Sunflower,
            /* 🌼 */Emoji.Blossom,
            /* 🌷 */Emoji.Tulip,
            /* 🌱 */Emoji.Seedling,
            /* 🌲 */Emoji.EvergreenTree,
            /* 🌳 */Emoji.DeciduousTree,
            /* 🌴 */Emoji.PalmTree,
            /* 🌵 */Emoji.Cactus,
            /* 🌾 */Emoji.SheafOfRice,
            /* 🌿 */Emoji.Herb,
            /* 🍀 */Emoji.FourLeafClover,
            /* 🍁 */Emoji.MapleLeaf,
            /* 🍂 */Emoji.FallenLeaf,
            /* 🍃 */Emoji.LeafFlutteringInWind,
            /* 🍇 */Emoji.Grapes,
            /* 🍈 */Emoji.Melon,
            /* 🍉 */Emoji.Watermelon,
            /* 🍊 */Emoji.Tangerine,
            /* 🍋 */Emoji.Lemon,
            /* 🍌 */Emoji.Banana,
            /* 🍍 */Emoji.Pineapple,
            /* 🍎 */Emoji.RedApple,
            /* 🍏 */Emoji.GreenApple,
            /* 🍐 */Emoji.Pear,
            /* 🍑 */Emoji.Peach,
            /* 🍒 */Emoji.Cherries,
            /* 🍓 */Emoji.Strawberry,
            /* 🥝 */Emoji.KiwiFruit,
            /* 🍅 */Emoji.Tomato,
            /* 🥥 */Emoji.Coconut,
            /* 🥑 */Emoji.Avocado,
            /* 🍆 */Emoji.Eggplant,
            /* 🥔 */Emoji.Potato,
            /* 🥕 */Emoji.Carrot,
            /* 🌽 */Emoji.EarOfCorn,
            /* 🥒 */Emoji.Cucumber,
            /* 🥦 */Emoji.Broccoli,
            /* 🍄 */Emoji.Mushroom,
            /* 🥜 */Emoji.Peanuts,
            /* 🌰 */Emoji.Chestnut,
            /* 🍞 */Emoji.Bread
                }
            },
            { 4, new []
                {
            /* 🚗 */Emoji.Automobile,
            /* 🚘 */Emoji.OncomingAutomobile,
	        /* 🚂 */Emoji.Locomotive,
	        /* 🚃 */Emoji.RailwayCar,
	        /* 🚄 */Emoji.HighSpeedTrain,
	        /* 🚅 */Emoji.HighSpeedTrainWithBulletNose,
	        /* 🚆 */Emoji.Train,
	        /* 🚇 */Emoji.Metro,
	        /* 🚈 */Emoji.LightRail,
	        /* 🚉 */Emoji.Station,
	        /* 🚊 */Emoji.Tram,
	        /* 🚝 */Emoji.Monorail,
	        /* 🚞 */Emoji.MountainRailway,
	        /* 🚋 */Emoji.TramCar,
	        /* 🚌 */Emoji.Bus,
	        /* 🚍 */Emoji.OncomingBus,
	        /* 🚎 */Emoji.Trolleybus,
	        /* 🚐 */Emoji.Minibus,
	        /* 🚑 */Emoji.Ambulance,
	        /* 🚒 */Emoji.FireEngine,
	        /* 🚓 */Emoji.PoliceCar,
	        /* 🚔 */Emoji.OncomingPoliceCar,
	        /* 🚕 */Emoji.Taxi,
	        /* 🚖 */Emoji.OncomingTaxi,
	        /* 🚙 */Emoji.SportUtilityVehicle,
	        /* 🚚 */Emoji.DeliveryTruck,
	        /* 🚛 */Emoji.ArticulatedLorry,
	        /* 🚜 */Emoji.Tractor,
	        /* 🚲 */Emoji.Bicycle,
	        /* 🛴 */Emoji.KickScooter,
	        /* 🛵 */Emoji.MotorScooter,
	        /* 🚏 */Emoji.BusStop,
	        /* ⛽ */Emoji.FuelPump,
	        /* 🚨 */Emoji.PoliceCarLight,
	        /* 🚥 */Emoji.HorizontalTrafficLight,
	        /* 🚦 */Emoji.VerticalTrafficLight,
	        /* 🚧 */Emoji.Construction,
	        /* ⚓ */Emoji.Anchor,
	        /* ⛵ */Emoji.Sailboat,
	        /* 🚤 */Emoji.Speedboat,
	        /* 🚢 */Emoji.Ship,
	        /* 🛫 */Emoji.AirplaneDeparture,
	        /* 🛬 */Emoji.AirplaneArrival,
	        /* 💺 */Emoji.Seat,
	        /* 🚁 */Emoji.Helicopter,
	        /* 🚟 */Emoji.SuspensionRailway,
	        /* 🚠 */Emoji.MountainCableway,
	        /* 🚡 */Emoji.AerialTramway,
	        /* 🚀 */Emoji.Rocket,
	        /* 🛸 */Emoji.FlyingSaucer,
	        /* 🚪 */Emoji.Door,
	        /* 🚽 */Emoji.Toilet,
	        /* 🚿 */Emoji.Shower,
	        /* 🛁 */Emoji.Bathtub,
	        /* 🌑 */Emoji.NewMoon,
	        /* 🌒 */Emoji.WaxingCrescentMoon,
	        /* 🌓 */Emoji.FirstQuarterMoon,
	        /* 🌔 */Emoji.WaxingGibbousMoon,
	        /* 🌕 */Emoji.FullMoon,
	        /* 🌖 */Emoji.WaningGibbousMoon,
	        /* 🌗 */Emoji.LastQuarterMoon,
	        /* 🌘 */Emoji.WaningCrescentMoon,
	        /* 🌙 */Emoji.CrescentMoon,
	        /* 🌚 */Emoji.NewMoonFace,
	        /* 🌛 */Emoji.FirstQuarterMoonWithFace,
	        /* 🌜 */Emoji.LastQuarterMoonWithFace,
	        /* 🌝 */Emoji.FullMoonWithFace,
	        /* 🌞 */Emoji.SunWithFace,
	        /* ⭐ */Emoji.WhiteMediumStar,
	        /* 🌟 */Emoji.GlowingStar,
	        /* 🌠 */Emoji.ShootingStar,
	        /* ⛅ */Emoji.SunBehindCloud,
	        /* 🌀 */Emoji.Cyclone,
	        /* 🌈 */Emoji.Rainbow,
	        /* 🌂 */Emoji.ClosedUmbrella,
	        /* ☔ */Emoji.UmbrellaWithRainDrops,
	        /* ⚡ */Emoji.HighVoltage,
	        /* ⛄ */Emoji.SnowmanWithoutSnow,
	        /* 🔥 */Emoji.Fire,
	        /* 💧 */Emoji.Droplet,
	        /* 🌊 */Emoji.WaterWave,
	        /* 🏁 */Emoji.ChequeredFlag,
	        /* 🚩 */Emoji.TriangularFlag,
	        /* 🎌 */Emoji.CrossedFlags,
	        /* 🏴 */Emoji.BlackFlag,
            /* 🌍 */Emoji.GlobeShowingEuropeAfrica,
            /* 🌎 */Emoji.GlobeShowingAmericas,
            /* 🌏 */Emoji.GlobeShowingAsiaAustralia,
            /* 🗾 */Emoji.MapOfJapan,
            /* 🌋 */Emoji.Volcano,
            /* 🗻 */Emoji.MountFuji,
            /* 🏡 */Emoji.HouseWithGarden,
            /* 🏢 */Emoji.OfficeBuilding,
            /* 🏣 */Emoji.JapanesePostOffice,
            /* 🏤 */Emoji.PostOffice,
            /* 🏥 */Emoji.Hospital,
            /* 🏦 */Emoji.Bank,
            /* 🏨 */Emoji.Hotel,
            /* 🏩 */Emoji.LoveHotel,
            /* 🏪 */Emoji.ConvenienceStore,
            /* 🏫 */Emoji.School,
            /* 🏬 */Emoji.DepartmentStore,
            /* 🏭 */Emoji.Factory,
            /* 🏯 */Emoji.JapaneseCastle,
            /* 🏰 */Emoji.Castle,
            /* 💒 */Emoji.Wedding,
            /* 🗼 */Emoji.TokyoTower,
            /* 🗽 */Emoji.StatueOfLiberty,
            /* ⛪ */Emoji.Church,
            /* 🕌 */Emoji.Mosque,
            /* 🕍 */Emoji.Synagogue,
            /* 🕋 */Emoji.Kaaba,
            /* ⛲ */Emoji.Fountain,
            /* ⛺ */Emoji.Tent,
            /* 🌁 */Emoji.Foggy,
            /* 🌃 */Emoji.NightWithStars,
            /* 🌄 */Emoji.SunriseOverMountains,
            /* 🌅 */Emoji.Sunrise,
            /* 🌆 */Emoji.CityscapeAtDusk,
            /* 🌇 */Emoji.Sunset,
            /* 🌉 */Emoji.BridgeAtNight,
            /* 🌌 */Emoji.MilkyWay,
            /* 💈 */Emoji.BarberPole
                }
            },
            { 5, new []
                {
	        /* 💙 */Emoji.RedHeart,
	        /* 💙 */Emoji.BlueHeart,
	        /* 💚 */Emoji.GreenHeart,
	        /* 💛 */Emoji.YellowHeart,
	        /* 🧡 */Emoji.OrangeHeart,
	        /* 💜 */Emoji.PurpleHeart,
	        /* 🖤 */Emoji.BlackHeart,
            /* 💘 */Emoji.HeartWithArrow,
            /* 💓 */Emoji.BeatingHeart,
            /* 💔 */Emoji.BrokenHeart,
            /* 💕 */Emoji.TwoHearts,
            /* 💖 */Emoji.SparklingHeart,
            /* 💗 */Emoji.GrowingHeart,
	        /* 💝 */Emoji.HeartWithRibbon,
	        /* 💞 */Emoji.RevolvingHearts,
	        /* 💟 */Emoji.HeartDecoration,
	        /* 💌 */Emoji.LoveLetter,
	        /* 💤 */Emoji.Zzz,
	        /* 💢 */Emoji.AngerSymbol,
	        /* 💥 */Emoji.Collision,
	        /* 💦 */Emoji.SweatDroplets,
	        /* 💨 */Emoji.DashingAway,
	        /* 💫 */Emoji.Dizzy,
	        /* 💬 */Emoji.SpeechBalloon,
	        /* 💭 */Emoji.ThoughtBalloon,
	        /* 💮 */Emoji.WhiteFlower,
	        /* 🌐 */Emoji.GlobeWithMeridians,
	        /* 🛑 */Emoji.StopSign,
	        /* 🔇 */Emoji.MutedSpeaker,
	        /* 🔕 */Emoji.BellWithSlash,
	        /* 💹 */Emoji.ChartIncreasingWithYen,
	        /* 💱 */Emoji.CurrencyExchange,
	        /* 💲 */Emoji.HeavyDollarSign,
	        /* 🚮 */Emoji.LitterInBinSign,
	        /* 🚰 */Emoji.PotableWater,
	        /* ♿ */Emoji.WheelchairSymbol,
	        /* 🚹 */Emoji.MensRoom,
	        /* 🚺 */Emoji.WomensRoom,
	        /* 🚻 */Emoji.Restroom,
	        /* 🚼 */Emoji.BabySymbol,
	        /* 🚾 */Emoji.WaterCloset,
	        /* 🛂 */Emoji.PassportControl,
	        /* 🛃 */Emoji.Customs,
	        /* 🛄 */Emoji.BaggageClaim,
	        /* 🛅 */Emoji.LeftLuggage,
	        /* 🚸 */Emoji.ChildrenCrossing,
	        /* ⛔ */Emoji.NoEntry,
	        /* 🚫 */Emoji.Prohibited,
	        /* 🚳 */Emoji.NoBicycles,
	        /* 🚭 */Emoji.NoSmoking,
	        /* 🚯 */Emoji.NoLittering,
	        /* 🚱 */Emoji.NonPotableWater,
	        /* 🚷 */Emoji.NoPedestrians,
	        /* 📵 */Emoji.NoMobilePhones,
	        /* 🔞 */Emoji.NoOneUnderEighteen,
	        /* 🔃 */Emoji.ClockwiseVerticalArrows,
	        /* 🔄 */Emoji.AnticlockwiseArrowsButton,
	        /* 🔙 */Emoji.BackArrow,
	        /* 🔚 */Emoji.EndArrow,
	        /* 🔛 */Emoji.OnArrow,
	        /* 🔜 */Emoji.SoonArrow,
	        /* 🔝 */Emoji.TopArrow,
	        /* 🛐 */Emoji.PlaceOfWorship,
	        /* 🕎 */Emoji.Menorah,
	        /* 🔯 */Emoji.DottedSixPointedStar,
	        /* ♈ */Emoji.Aries,
	        /* ♉ */Emoji.Taurus,
	        /* ♊ */Emoji.Gemini,
	        /* ♋ */Emoji.Cancer,
	        /* ♌ */Emoji.Leo,
	        /* ♍ */Emoji.Virgo,
	        /* ♎ */Emoji.Libra,
	        /* ♏ */Emoji.Scorpius,
	        /* ♐ */Emoji.Sagittarius,
	        /* ♑ */Emoji.Capricorn,
	        /* ♒ */Emoji.Aquarius,
	        /* ♓ */Emoji.Pisces,
	        /* ⛎ */Emoji.Ophiuchus,
	        /* 🔀 */Emoji.ShuffleTracksButton,
	        /* 🔁 */Emoji.RepeatButton,
	        /* 🔂 */Emoji.RepeatSingleButton,
	        /* ⏩ */Emoji.FastForwardButton,
	        /* ⏪ */Emoji.FastReverseButton,
	        /* 🔼 */Emoji.UpButton,
	        /* ⏫ */Emoji.FastUpButton,
	        /* 🔽 */Emoji.DownButton,
	        /* ⏬ */Emoji.FastDownButton,
	        /* 🔅 */Emoji.DimButton,
	        /* 🔆 */Emoji.BrightButton,
	        /* 📶 */Emoji.AntennaBars,
	        /* 🔱 */Emoji.TridentEmblem,
	        /* 📛 */Emoji.NameBadge,
	        /* 🔰 */Emoji.JapaneseSymbolForBeginner,
	        /* ⭕ */Emoji.HeavyLargeCircle,
	        /* ✅ */Emoji.WhiteHeavyCheckMark,
	        /* ❌ */Emoji.CrossMark,
	        /* ❎ */Emoji.CrossMarkButton,
	        /* ➕ */Emoji.HeavyPlusSign,
	        /* ➖ */Emoji.HeavyMinusSign,
	        /* ➗ */Emoji.HeavyDivisionSign,
	        /* ➰ */Emoji.CurlyLoop,
	        /* ➿ */Emoji.DoubleCurlyLoop,
	        /* ❓ */Emoji.QuestionMark,
	        /* ❔ */Emoji.WhiteQuestionMark,
	        /* ❕ */Emoji.WhiteExclamationMark,
	        /* ❗ */Emoji.ExclamationMark,
	        /* #️⃣ */Emoji.KeycapHash,
	        /* *️⃣ */Emoji.KeycapAsterisk,
	        /* 0️⃣ */Emoji.Keycap0,
	        /* 1️⃣ */Emoji.Keycap1,
	        /* 2️⃣ */Emoji.Keycap2,
	        /* 3️⃣ */Emoji.Keycap3,
	        /* 4️⃣ */Emoji.Keycap4,
	        /* 5️⃣ */Emoji.Keycap5,
	        /* 6️⃣ */Emoji.Keycap6,
	        /* 7️⃣ */Emoji.Keycap7,
	        /* 8️⃣ */Emoji.Keycap8,
	        /* 9️⃣ */Emoji.Keycap9,
	        /* 🔟 */Emoji.Keycap10,
	        /* 💯 */Emoji.HundredPoints,
	        /* 🔠 */Emoji.InputLatinUppercase,
	        /* 🔡 */Emoji.InputLatinLowercase,
	        /* 🔢 */Emoji.InputNumbers,
	        /* 🔣 */Emoji.InputSymbols,
	        /* 🔤 */Emoji.InputLatinLetters,
	        /* 🆎 */Emoji.AbButtonBloodType,
	        /* 🆑 */Emoji.ClButton,
	        /* 🆒 */Emoji.CoolButton,
	        /* 🆓 */Emoji.FreeButton,
	        /* 🆔 */Emoji.IdButton,
	        /* 🆕 */Emoji.NewButton,
	        /* 🆖 */Emoji.NgButton,
	        /* 🆗 */Emoji.OkButton,
	        /* 🆘 */Emoji.SosButton,
	        /* 🆚 */Emoji.VsButton,
	        /* 🈁 */Emoji.JapaneseHereButton,
	        /* 🈶 */Emoji.JapaneseNotFreeOfChargeButton,
	        /* 🈯 */Emoji.JapaneseReservedButton,
	        /* 🉐 */Emoji.JapaneseBargainButton,
	        /* 🈹 */Emoji.JapaneseDiscountButton,
	        /* 🈚 */Emoji.JapaneseFreeOfChargeButton,
	        /* 🈲 */Emoji.JapaneseProhibitedButton,
	        /* 🉑 */Emoji.JapaneseAcceptableButton,
	        /* 🈸 */Emoji.JapaneseApplicationButton,
	        /* 🈴 */Emoji.JapanesePassingGradeButton,
	        /* 🈳 */Emoji.JapaneseVacancyButton,
	        /* 🈺 */Emoji.JapaneseOpenForBusinessButton,
	        /* 🈵 */Emoji.JapaneseNoVacancyButton,
	        /* ◽ */Emoji.WhiteMediumSmallSquare,
	        /* ◾ */Emoji.BlackMediumSmallSquare,
	        /* ⬛ */Emoji.BlackLargeSquare,
	        /* ⬜ */Emoji.WhiteLargeSquare,
	        /* 🔶 */Emoji.LargeOrangeDiamond,
	        /* 🔷 */Emoji.LargeBlueDiamond,
	        /* 🔸 */Emoji.SmallOrangeDiamond,
	        /* 🔹 */Emoji.SmallBlueDiamond,
	        /* 🔺 */Emoji.RedTrianglePointedUp,
	        /* 🔻 */Emoji.RedTrianglePointedDown,
	        /* 💠 */Emoji.DiamondWithADot,
	        /* 🔘 */Emoji.RadioButton,
	        /* 🔲 */Emoji.BlackSquareButton,
	        /* 🔳 */Emoji.WhiteSquareButton,
	        /* ⚪ */Emoji.WhiteCircle,
	        /* ⚫ */Emoji.BlackCircle,
	        /* 🔴 */Emoji.RedCircle,
	        /* 🔵 */Emoji.BlueCircle, 	        
            /* 🕛 */Emoji.TwelveOclock,
            /* 🕧 */Emoji.TwelveThirty,
            /* 🕐 */Emoji.OneOclock,
            /* 🕜 */Emoji.OneThirty,
            /* 🕑 */Emoji.TwoOclock,
            /* 🕝 */Emoji.TwoThirty,
            /* 🕒 */Emoji.ThreeOclock,
            /* 🕞 */Emoji.ThreeThirty,
            /* 🕓 */Emoji.FourOclock,
            /* 🕟 */Emoji.FourThirty,
            /* 🕔 */Emoji.FiveOclock,
            /* 🕠 */Emoji.FiveThirty,
            /* 🕕 */Emoji.SixOclock,
            /* 🕡 */Emoji.SixThirty,
            /* 🕖 */Emoji.SevenOclock,
            /* 🕢 */Emoji.SevenThirty,
            /* 🕗 */Emoji.EightOclock,
            /* 🕣 */Emoji.EightThirty,
            /* 🕘 */Emoji.NineOclock,
            /* 🕤 */Emoji.NineThirty,
            /* 🕙 */Emoji.TenOclock,
            /* 🕥 */Emoji.TenThirty,
            /* 🕚 */Emoji.ElevenOclock,
            /* 🕦 */Emoji.ElevenThirty
                }
            }
        };

        private static readonly EmojiSkinTone[] SkinTones =
        {
            new EmojiSkinTone("✋", "", EmojiGroups[1]),
            new EmojiSkinTone("✋🏻", ": light skin tone", EmojiGroups[1]),
            new EmojiSkinTone("✋🏼", ": medium-light skin tone", EmojiGroups[1]),
            new EmojiSkinTone("✋🏽", ": medium skin tone", EmojiGroups[1]),
            new EmojiSkinTone("✋🏾", ": medium-dark skin tone", EmojiGroups[1]),
            new EmojiSkinTone("✋🏿", ": dark skin tone", EmojiGroups[1])
        };

        private SingleEmoji[] AllEmoji() => EmojiGroups.Values.SelectMany(s => s).ToArray();
    }
}
