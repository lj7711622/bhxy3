﻿namespace MoleMole
{
    using System;

    public enum NotifyTypes
    {
        None,
        NetwrokPacket,
        SetSpaceShipActive,
        SetSpaceShipLight,
        DestroyLoadingScene,
        LoadingSceneDestroyed,
        OnSocketDisconnect,
        OnSocketConnect,
        OnQuitGameDialogShow,
        OnQuitGameDialogDestroy,
        ShowScoinExchangeInfo,
        ShowStaminaExchangeInfo,
        ShowStaminaExchangeInfo2,
        SetBackButtonActive,
        SetPlayerStatusWidgetDisplay,
        SelectAvtarIconChange,
        SelectAvtarSkillIconChange,
        CreateAvatarUIModels,
        FinishCreateAvatarUIModels,
        TeamMemberChanged,
        PlayAvtarChangeEffect,
        SubSkillStatusCacheUpdate,
        UnlockAvatar,
        ShouldShowSPExchange,
        BeforeAvatarLevelUp,
        SetLevelDifficulty,
        PlayerLevelUp,
        AvatarLevelUp,
        StageEnd,
        StageDropListUpdated,
        RequestEnterEndlessActivity,
        RefreshChapterSelectPage,
        MonsterCloseUpEnd,
        DestroyComboHelpDialog,
        OnAvatarCreate,
        ShowDamegeText,
        SetTimeCountDownTextActive,
        SetTimeCountDownText,
        SetTimesUpText,
        ShowAddTimeText,
        ShowHelperCutIn,
        ShowDefendModeText,
        SetDefendModeText,
        DropItemConutChanged,
        ShowLevelDisplayText,
        SetTimerText,
        AttackLanded,
        SetupLocalAvatarStatus,
        AvatarSelectForRevive,
        PostStageReady,
        ResitComboClear,
        BattleBegin,
        AttackBtnVisible,
        EvadeBtnVisible,
        JoystickVisible,
        UltraBtnVisible,
        PauseBtnVisible,
        PauseBtnEnable,
        SPBarVisible,
        HPBarVisible,
        SwapBtnVisible,
        EcoModeVisible,
        SelectItemIconChange,
        SetSellViewActive,
        SetStorageSortType,
        RefreshStorageShowing,
        EquipPowerupOrEvo,
        StigmataNewAffix,
        RefreshStigmataDetailView,
        SetFriendSortType,
        ChangeTalkingFriend,
        AnimCallBack,
        AnimDestroyContext,
        PowerUpAndEvoEffect,
        TutorialWitchTime,
        TutorialBranchAttack,
        TutorialUltraAttack,
        TutorialEliteAttack,
        TutorialSwapAttack,
        TutorialNatureRestrain,
        TutorialSwapAndRestrain,
        TutorialMonsterBlock,
        TutorialMonsterTeleport,
        TutorialMonsterShield,
        TutorialMonsterRobotDodge,
        TutorialPlayerTeaching,
        ShowMihoyoLoginUI,
        MihoyoAccountLoginSuccess,
        MihoyoAccountInfoChanged,
        MihoyoAccountRegisterSuccess,
        SDKAccountLoginSuccess,
        ShowLoadAssetText,
        SetLoadAssetText,
        DownloadResAssetSucc,
        ShowThunderWeather,
        ShowRandomWeather,
        ShowDefaultWeather,
        FadeOutGameEntrySplash,
        SetDescImage,
        ShowVersionText,
        PlayAnimAfterLoad,
        MissionUpdated,
        MissionRewardGot,
        MissionRewardAvatarGot,
        MissionDeleted,
        EndlessActivityEnd,
        EndlessActivitySettlement,
        EndlessActivityBegin,
        EndlessSettlementAnimationEnd,
        AvatarDie,
        EndlessAppliedToolChange,
        BulletinPopUpUpdate,
        EnterMainPage,
        ExitMainPage,
        OnIslandCameraLanded,
        OnIslandCameraPreLanded,
        OnIslandCameraFocus,
        OnIslandCameraPreFocus,
        OnCabinBeginExtend,
        OnCabinLevelUpSucc,
        DispatchAvatarChanged,
        OnIslandScoinBtnClick,
        OnPlotFinished,
        RefreshRechargeTab,
        SelectRechargeItem,
        SelectStoreGoodsItem,
        ActivtyShopScheduleChange
    }
}

