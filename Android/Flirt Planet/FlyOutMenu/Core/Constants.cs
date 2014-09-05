//--------------------------------------------------------------------------------
//
// Core.Constants.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

namespace Core.Constants
{
	//----------------------------------------

	public enum kScreen
	{
		Boosts           =  0,
		Connections      =  1,
		FacebookPhotos   =  2,
		Flirtmail        =  3,
		FlirtmailCompose =  4,
		FlirtmailDetail  =  5,
		Gallery          =  6,
		Home             =  7,
		MatchingSauce    =  8,
		Meet             =  9,
		MeetResults      = 10,
		None             = 11,
		Profile          = 12,
		Settings         = 13,
		Splash           = 14,
	}

	//----------------------------------------

	public struct kFacebook
	{
		public const string AppID = "331457147001081";

		public const string Permissions = "email," +
										  "user_status," +
										  "user_photos," +
										  "user_birthday," +
										  "user_relationships," +
										  "user_relationship_details";
		// Facebook Graph Queries
		public const string UserAlbumsRequest     = "?fields=albums.fields(id,name,cover_photo,count).limit(25)";
		public const string AlbumPhotosRequest    = "?fields=photos.fields(id,images).limit(25)";
		public const string ThumbnailRequest      = "?fields=id,picture";
		public const string ProfilePictureRequest = "?fields=picture.width(500).height(500)";
		public const string FriendListRequest     = "?fields=friends.fields(id,name,picture.width(300).height(300))";
	}
	
	//----------------------------------------
	
	public struct kFeature
	{
		public const int FJPack            =  1;	
		public const int FJRefundContainer =  2;
		public const int PublicGallery     =  3;
		public const int FeaturedUser      =  4;
		public const int CreamOfTheCrop    =  5;
		public const int RatedYouHighly    =  6;
		public const int PriorityRequest   =  7;
		public const int HideConnections   =  8;
		public const int BrowseAnonymously =  9;
		public const int HideFBFriends     = 10;
	}

	//----------------------------------------

	public enum kPhotoType
	{
		Public,
		Private,
		Cover
	}

	//----------------------------------------

	public struct kBaseURL
	{
		public const string TermsOfService	= "http://www.trulysocialapps.com/privacy#!tos/ctm3";
		public const string PrivacyPolicy	= "http://www.trulysocialapps.com/privacy#!privacy/c1ykc";
		public const string Webservice		= "http://192.168.56.1/webservice/webservice.php";
		public const string Avatar			= "http://dev.meeteor.grsandbox.info/images/avatars/";
		public const string Photo			= "http://dev.meeteor.grsandbox.info/images/user_images/";
		public const string CoverPhoto		= "http://dev.meeteor.grsandbox.info/images/cover_photos/";
		public const string SecondOpinion	= "http://dev.meeteor.grsandbox.info/secondopinion/";
		public const string EntourageIMG	= "http://dev0.grsandbox.info/images/avatars/";
	}

	//----------------------------------------

	public struct kFont
	{
		public const string RobotoRegular   	   = "Roboto-Regular";
		public const string RobotoThin      	   = "Roboto-Thin";
		public const string RobotoLight 		   = "Roboto-Light";
		public const string RobotoBold             = "Roboto-Bold";
		//public const string RobotoBlack            = "Roboto-Black";
		//public const string RobotoCondensedRegular = "RobotoCondensed-Regular";
		//public const string RobotoCondensedLight   = "RobotoCondensed-Light";
	}

	//----------------------------------------

	public struct kMessage
	{
		public const string ApplicationName = "Flirt Planet Meet";

		public const string SO_Header = "Ask Your Friends";

		public const string Connect_NoConnections     = "You do not have any connections at this time. Why not try browsing a few profiles and send them a connection request?";
		public const string Connect_NoSentRequests    = "You do not have any sent requests. Why not browse some profiles and try to connect to them?";
		public const string Connect_NoPendingRequests = "You do not have any pending connections.";
		public const string Connect_NoWatched 		  = "You are not currently watching any profiles.";
		public const string Mail_NoConnections 		  = "No connections.";
		public const string Mail_FailedVerify 		  = "Mail cannot be sent without a recipient selected or a message written.";
		public const string Profile_OwnNoPhotos 	  = "You do not have any photos uploaded. Try clicking the '+' icon to add some!";
		public const string Profile_OtherNoPhotos 	  = "No photos yet.";
		public const string Meet_NoMatches 			  = "No matches found. Consider expanding the range of the search filters.";
		public const string Meet_SwipeHelp 			  = "<< swipe for more >>";
		public const string Boost_WebserviceError 	  = "Unable to connect to the store. Try again later.";
		public const string Boost_NotEnoughGold		  = "Not enough gold to make purchase.";
		public const string FB_Logout                 = "Please press the Home button to complete the logout process, otherwise close this message to cancel.";
		
		public const string FB_PermissionsDenied = "If you cancelled the login process, disregard this " + 
												   "message, otherwise, please ensure that your Facebook " + 
												   "account information is up-to-date in your device settings " +
												   "or anywhere else it's being used and that you have allowed " + 
												   "Flirt Planet to access your account before logging in again.";
														 
		public const string FB_ExpiredSession = "Your Facebook session has expired. In order to continue using Flirt " +
											    "Planet Meet, please press the home button to logout and then " +
											    "re-launch the app to login again. Note, if this message persists, " +
											    "please ensure your Facebook account information is up-to-date " +
											    "anywhere you are currently logged-in to Facebook on this device";

		public const string SecondOpinion_ConfirmText = "Like this match, but you're not quite sure yet?\n\n" +
		                                                "Your friends can help! It's easy! Ask them for their opinion and earn 40 Flirt Juice right now. You get your results in 48h.\n\n" +
		                                                "Remember, you can only ask for a second opinion on each user once, so involve as many friends as you can to get more opinions!";

		public const string MS_StartPersonalityTest   = "Click the blue icon to take the Personality Test.";
	}

	//----------------------------------------

	public struct kImage
	{
		public const string Avatar_Hashed = "2798d6746dc0df336b8237c6a2dd89af.jpg";

		public const string Boosts_AddBoost					= "DD_Boosts_btn_add_boost";
		public const string Boosts_BoostPlaceholder			= "DD_Boosts_boost_placeholder";
		public const string Boosts_CloakingDevice			= "DD_Boosts_icn_cloaking_device";
		public const string Boosts_HideConnections			= "DD_Boosts_icn_hide_connections";
		public const string Boosts_HideFBFriends			= "DD_Boosts_icn_facebook";
		public const string Boosts_GoldIcon					= "DD_Boosts_icn_gold";
		public const string Boosts_ShootingStar_Bronze		= "DD_Boosts_icn_shooting_star_bronze";
		public const string Boosts_ShootingStar_Silver		= "DD_Boosts_icn_shooting_star_silver";
		public const string Boosts_ShootingStar_Gold		= "DD_Boosts_icn_shooting_star_gold";
		public const string Boosts_QualityScanner_Bronze	= "DD_Boosts_icn_quality_scanner_bronze";
		public const string Boosts_QualityScanner_Silver	= "DD_Boosts_icn_quality_scanner_silver";
		public const string Boosts_QualityScanner_Gold		= "DD_Boosts_icn_quality_scanner_gold";
		public const string Boosts_SideTab_Boosts			= "DD_Boosts_icn_side_boosts";
		public const string Boosts_SideTab_BoostsHit		= "DD_Boosts_icn_side_boosts_hit";
		public const string Boosts_SideTab_Inventory		= "DD_Boosts_icn_side_inventory";
		public const string Boosts_SideTab_InventoryHit		= "DD_Boosts_icn_side_inventory_hit";
		public const string Boosts_SideTab_JuicePack		= "DD_Boosts_icn_side_juicepack";
		public const string Boosts_SideTab_JuicePackHit		= "DD_Boosts_icn_side_juicepack_hit";

		public const string Boosts_Bottle0 				= "DD_Boosts_icn_bottle0";
		public const string Boosts_Bottle1 				= "DD_Boosts_icn_bottle1";
		public const string Boosts_Bottle2 				= "DD_Boosts_icn_bottle2";
		public const string Boosts_Bottle3 				= "DD_Boosts_icn_bottle3";
		public const string Boosts_Bottle4 				= "DD_Boosts_icn_bottle4";
		public const string Boosts_Bottle5 				= "DD_Boosts_icn_bottle5";

		public const string Common_Edit                 = "DD_icn_edit";
		public const string Common_BackChevron          = "DD_btn_back_chevron";
		public const string Common_BackChevron_White    = "DD_btn_back_chevron_white";
		public const string Common_Tab_Blue             = "DD_Tab_Blue";
		public const string Common_ChartFrame           = "DD_Home_Chart_frame";
		public const string Common_Chisel_Vert          = "DD_Home_chisel_line_long_vertical";
		public const string Common_Chisel_Horz          = "DD_Home_chisel_short_horizontal";
		public const string Common_DefaultImage         = "DD_DefaultImage";
		public const string Common_Close_Gray           = "DD_Splash_btn_close_gray";
		public const string Common_Close_White          = "DD_Splash_btn_close_white";
		public const string Common_Tickbox              = "DD_Header_icn_tickbox";
		public const string Common_Tickbox_Empty        = "DD_Header_icn_tickbox_empty";
		public const string Common_TickboxGreen         = "DD_Header_icn_tickbox_green";
		public const string Common_FlirtPlanet          = "DD_Home_logo_flirt_planet";
		public const string Common_PhotoMask            = "DD_Home_Photo_mask";
		public const string Common_Overlay_Short        = "DD_overlay_short";
		public const string Common_Gold                 = "DD_icn_gold";
		public const string Common_Back                 = "DD_btn_back";
		public const string Common_Connect              = "DD_icn_connect";
		public const string Common_Drop                 = "DD_icn_drop";
		public const string Common_Facebook_White       = "DD_icn_facebook_white";
		public const string Common_SecondOpinion_White  = "DD_icn_second_opinion_white";
		public const string Common_SecondOpinion_Result = "DD_icn_second_opinion_review";

		public const string Connect_Accept				= "DD_Con_icn_accept";
		public const string Connect_Connections			= "DD_Con_icn_connections";
		public const string Connect_Connections_Hit		= "DD_Con_icn_connections_hit";
		public const string Connect_Decline				= "DD_Con_icn_decline";
		public const string Connect_MatchingSauce		= "DD_Con_icn_matching_sauce";
		public const string Connect_Received			= "DD_Con_icn_received";
		public const string Connect_Received_Hit		= "DD_Con_icn_received_hit";
		public const string Connect_Sent				= "DD_Con_icn_sent";
		public const string Connect_Sent_Hit			= "DD_Con_icn_sent_hit";
		public const string Connect_SentRequest_Ribbon	= "DD_Con_icn_ribbon_sentrequests";
		public const string Connect_WatchList_Blue 		= "DD_Con_icn_add_to_watchlist";
		public const string Connect_WatchList_White		= "DD_Con_icn_watchlist_hit";
		public const string Connect_WatchList_Gray 		= "DD_Con_icn_watchlist";
		public const string Connect_WatchList_Ribbon	= "DD_Con_icn_ribbon_from_watchlist";
		public const string Connect_SecondOpinion		= "DD_Con_icn_second_opinion";
		public const string Connect_SecondOpinion_Hit	= "DD_Con_icn_second_opinion_hit";
		public const string Connect_Entourage			= "DD_Con_icn_entourage";
		public const string Connect_Entourage_Hit		= "DD_Con_icn_entourage_hit";
		public const string Connect_FPLogo              = "DD_Con_icn_flirt_planet";
		public const string Connect_PriorityMessage     = "DD_Con_icn_priorty_message";

		public const string Detail_BodyArt_Blue   	= "detail_bodyart_blue";
		public const string Detail_BodyArt_Grey   	= "detail_bodyart_grey";
		public const string Detail_BodyType_Blue  	= "detail_bodytype_blue";
		public const string Detail_BodyType_Grey  	= "detail_bodytype_grey-";
		public const string Detail_Diet_Blue      	= "detail_diet_blue";
		public const string Detail_Diet_Grey      	= "detail_diet_grey";
		public const string Detail_Education_Blue	= "detail_education_blue";
		public const string Detail_Education_Grey 	= "detail_education_grey-";
		public const string Detail_Ethnicity_Blue 	= "detail_ethnicity_blue";
		public const string Detail_Ethnicity_Grey 	= "detail_ethnicity_grey";
		public const string Detail_Habits_Blue    	= "detail_habits_blue";
		public const string Detail_Habits_Grey   	= "detail_habits_grey";
		public const string Detail_Height_Blue    	= "detail_height_blue-";
		public const string Detail_Height_Grey    	= "detail_height_grey ";
		public const string Detail_Income_Blue    	= "detail_income_blue";
		public const string Detail_Income_Grey    	= "detail_income_grey";
		public const string Detail_Kids_Blue      	= "detail_kids_blue";
		public const string Detail_Kids_Grey      	= "detail_kids_grey";
		public const string Detail_Pets_Blue      	= "detail_pets_blue";
		public const string Detail_Pets_Grey      	= "detail_pets_grey";
		public const string Detail_Religion_Blue 	= "detail_religion_blue";
		public const string Detail_Religion_Grey  	= "detail_religion_grey";
		public const string Detail_Speaks_Blue    	= "detail_speaks_blue";
		public const string Detail_Speaks_Grey    	= "detail_speaks_grey";

		public const string FG_10Bonus 				= "DD_FG_icn_10_bonus";
		public const string FG_15Bonus 				= "DD_FG_icn_15_bonus";
		public const string FG_50Bonus 				= "DD_FG_icn_50_bonus";
		public const string FG_75Bonus 				= "DD_FG_icn_75_bonus";

		public const string FG_20Gold   			= "DD_FG_icn_20_flirt_gold";
		public const string FG_90Gold   			= "DD_FG_icn_90_flirt_gold";
		public const string FG_110Gold  			= "DD_FG_icn_110_flirt_gold";
		public const string FG_335Gold  			= "DD_FG_icn_335_flirt_gold";
		public const string FG_1190Gold 			= "DD_FG_icn_1190_flirt_gold";
		public const string FG_2800Gold 			= "DD_FG_icn_2800_flirt_gold";

		public const string FJ_10Discount 			= "DD_FJ_icn_10_discount";
		public const string FJ_20Discount 			= "DD_FJ_icn_20_discount";
		public const string FJ_25Discount 			= "DD_FJ_icn_25_discount";
		public const string FJ_40Discount 			= "DD_FJ_icn_40_discount";

		public const string FJ_1Pack  				= "DD_FJ_icn_flirt_juice_1pack";
		public const string FJ_5Pack  				= "DD_FJ_icn_flirt_juice_5packs";
		public const string FJ_20Pack 				= "DD_FJ_icn_flirt_juice_20packs";

		public const string Footer_Flag 			= "DD_profile_flag_unconnect";

		public const string Global_HorizTabBar 		  = "DD_Global_HorizTabBar";
		
		public const string Head_Cheveron             = "DD_Header_icn_chevron";
		public const string Head_Inventory            = "DD_Header_icn_inventory";
		public const string Head_LogoSmall            = "DD_Header_LogoSmall";
		public const string Head_MatchingSauce        = "DD_Header_icn_matching_sauce";
		public const string Head_Menu                 = "DD_Header_icn_menu";
		public const string Head_Notification         = "DD_Header_icn_notification";
		public const string Head_Notification_Hit     = "DD_Header_icn_notification_hit";
		public const string Head_NewNotifications     = "DD_Header_icn_new_notifications";
		public const string Head_NewNotifications_Hit = "DD_Header_icn_new_notifications_hit";
		public const string Head_NotificationCounter  = "DD_Header_icn_notification_counter";
		public const string Head_Pending              = "DD_Header_icn_pending";
		public const string Head_Profile              = "DD_Header_icn_profile";
		public const string Head_Profile_Hit          = "DD_Header_icn_profile_hit";
		public const string Head_Settings             = "DD_Header_icn_settings";
		public const string Head_Settings_Hit         = "DD_Header_icn_settings_hit";
		public const string Head_UnreadMessages       = "DD_Header_icn_unread_messages";

		public const string Mail_NewMessage  	  	  = "DD_FlirtMail_icn_new_message";
		public const string Mail_NewMessage_White 	  = "DD_FlirtMail_icn_new_message_white";
		public const string Mail_SendMessage	  	  = "DD_FlirtMail_icn_send_message";

		public const string Meet_FilterExpand         = "DD_Meet_icn_filter_expand";
		public const string Meet_FilterExpand_Blue    = "DD_Meet_icn_filter_blue_expand";
		public const string Meet_FilterCollapse       = "DD_Meet_icn_filter_minimise";
		public const string Meet_FilterCollapse_Blue  = "DD_Meet_icn_filter_blue_minimise";
		public const string Meet_ProfileDetails       = "DD_Meet_icn_profile_details";
		public const string Meet_ProfileDetails_Hit   = "DD_Meet_icn_profile_details_hit";

		public const string MS_Header_Icon 			  = "DD_MS_icn_matching_sauce";
		public const string MS_Header_Icon_Gray 	  = "DD_MS_icn_matching_sauce_gray";

		public const string MS_Zodiac_Aquarius    = "DD_MS_icn_zodiac_aquarius";
		public const string MS_Zodiac_Aries       = "DD_MS_icn_zodiac_aries";
		public const string MS_Zodiac_Cancer      = "DD_MS_icn_zodiac_cancer";
		public const string MS_Zodiac_Capricorn   = "DD_MS_icn_zodiac_capricorn";
		public const string MS_Zodiac_Gemini      = "DD_MS_icn_zodiac_gemini";
		public const string MS_Zodiac_Leo         = "DD_MS_icn_zodiac_leo";
		public const string MS_Zodiac_Libra       = "DD_MS_icn_zodiac_libra";
		public const string MS_Zodiac_Pisces      = "DD_MS_icn_zodiac_pisces";
		public const string MS_Zodiac_Sagittarius = "DD_MS_icn_zodiac_sagittarius";
		public const string MS_Zodiac_Scorpio     = "DD_MS_icn_zodiac_scorpio";
		public const string MS_Zodiac_Taurus      = "DD_MS_icn_zodiac_taurus";
		public const string MS_Zodiac_Virgo       = "DD_MS_icn_zodiac_virgo";
		
		public const string NavMenu_Boosts      = "DD_MS_icn_menu_boosts";
		public const string NavMenu_Connections = "DD_MS_icn_menu_connections";
		public const string NavMenu_FlirtGold   = "DD_MS_icn_menu_flirt_gold";
		public const string NavMenu_FlirtJuice  = "DD_MS_icn_menu_flirt_juice";
		public const string NavMenu_Home        = "DD_MS_icn_menu_home";
		public const string NavMenu_Mail        = "DD_MS_icn_menu_mail";
		public const string NavMenu_Meet        = "DD_MS_icn_menu_meet";
		public const string NavMenu_Settings	= "DD_MS_icn_menu_settings";

		public const string Nimp_Title = "HeartomaticTitle";

		public const string Notif_FJRefund = "DD_icn_flirtjuice_note";

		public const string Profile_Connect_Disabled_M = "DD_profile_icn_connect_mobile_disabled";
		public const string Profile_Connect_M          = "DD_profile_icn_connect_mobile";
		public const string Profile_Connections_M      = "DD_profile_icn_connections_mobile";
		public const string Profile_Facebook_M         = "DD_profile_icn_facebook_mobile";
		public const string Profile_MatchingSauce_M    = "DD_profile_icn_matching_sauce_mobile";
		public const string Profile_Reviews_M          = "DD_profile_icn_reviews_mobile";
		public const string Profile_Star_Empty         = "DD_profile_star_empty";
		public const string Profile_Star_Filled        = "DD_profile_star_filled";
		public const string Profile_Exclamation 	   = "DD_profile_icn_exclamation";

		public const string Splash_AppLogo       = "DD_Splash_Logo";
		public const string Splash_StartNow      = "DD_Splash_btn_start_now";
		public const string Splash_StartNow_Grey = "DD_Splash_btn_Start_not_grey";
	}

	public struct kCircularImageSize
	{
		public const int myFlyOutPic = 120;
		public const int freshFaces = 200;
		public const int userGalleryImage = 170;
		public const int mailDetailImage = 60;
		public const int galleryImageView = 60;
	}

	//----------------------------------------

} // End Namespace: Core.Constants

//--------------------------------------------------------------------------------
// EOF




