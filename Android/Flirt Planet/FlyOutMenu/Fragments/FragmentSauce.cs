using System;
using System.Timers;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RadialProgress;
using System.Collections.Generic;
using Core.Business;
using Core.Constants;
using Android.Graphics;

namespace flirtplanet
{
	public class FragmentSauce : Fragment, SeekBar.IOnSeekBarChangeListener
	{
		RadialProgressView blueProgress, roseProgress, lavenderProgress;
		Timer timer;
		//	Button btn;
		public static SeekBar AquaBlue;
		public static SeekBar DustyRose;
		public static SeekBar Lavender;
		View view;

		string mPersonalityTestResults;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{

			Context contextThemeWrapper = new ContextThemeWrapper(this.Activity, Resource.Style.FlirtTheme);

			// clone the inflater using the ContextThemeWrapper
			LayoutInflater localInflater = inflater.CloneInContext(contextThemeWrapper);

			view = localInflater.Inflate(Resource.Layout.fragment_sauce, container, false);

			// inflate the layout using the cloned inflater, not default inflater
			//return localInflater.inflate(Resource.Layout.fragment_sauce, container, false);

		
			blueProgress = view.FindViewById<RadialProgressView> (Resource.Id.pr_blue);
			roseProgress = view.FindViewById<RadialProgressView> (Resource.Id.pr_rose);
			lavenderProgress = view.FindViewById<RadialProgressView> (Resource.Id.pr_lavender);

			var EditPreference = view.FindViewById<ImageButton> (Resource.Id.im_EditPreference);
			var TestPersonality = view.FindViewById<ImageButton> (Resource.Id.ib_personalityTest);
			var mPersonalitySummary = view.FindViewById<TextView> (Resource.Id.tv_personalityText);

			var profileProgress = view.FindViewById<ImageView> (Resource.Id.rp_goal);
			var percentComplete = view.FindViewById<TextView> (Resource.Id.tv_Complete);
			percentComplete.Text = (((FragmentHome.goalsComplete / MainUser.Goals.Count) * 100).ToString() + "% Complete");
			profileProgress.SetImageDrawable (new CircleProgress (FragmentHome.goalsComplete,profileProgress.LayoutParameters.Width));

			var zodiacElement = view.FindViewById<ImageView> (Resource.Id.im_zodiac);
			var zodiacText = view.FindViewById<TextView> (Resource.Id.tv_zodiac);
			var updateSauce = view.FindViewById<TextView> (Resource.Id.tv_updateSauce);

			AquaBlue = view.FindViewById<SeekBar> (Resource.Id.sk_aquaBlue);

			AquaBlue.SetOnSeekBarChangeListener (this);

			DustyRose = view.FindViewById<SeekBar> (Resource.Id.sk_dustyRose);

			DustyRose.SetOnSeekBarChangeListener (this);

			Lavender = view.FindViewById<SeekBar> (Resource.Id.sk_lavender);

			Lavender.SetOnSeekBarChangeListener (this);

			//MainUser.MatchingSauce = MatchingSauceBus.GetMatchingSauce(MainUser.AppUser.UniqUser);
			while (MainUser.MatchingSauce == null) { MainUser.MatchingSauce = MatchingSauceBus.GetMatchingSauce(MainUser.AppUser.UniqUser); }

			AquaBlue.Progress = MainUser.MatchingSauce.NIMPPersonality;
			OnProgressChanged (AquaBlue, AquaBlue.Progress, true);

			Lavender.Progress = MainUser.MatchingSauce.NIMPFlirt;
			OnProgressChanged (Lavender, Lavender.Progress, true);

			DustyRose.Progress = MainUser.MatchingSauce.Zodiac;
			OnProgressChanged (DustyRose, DustyRose.Progress, true);

			mPersonalityTestResults = _PrepareNimpResults(NimpData.GetPersonality(MainUser.MatchingSauce));
			zodiacElement.SetColorFilter (Color.Gray);
			zodiacElement.SetImageResource (MSZodiacElement._GetImageForZodiac (MainUser.MatchingSauce.ZodiacSign.ToLower()));
			zodiacText.Text = MainUser.MatchingSauce.ZodiacSign;

			updateSauce.Click += (sender, e) => 
			{
				updateSauce.Text = "Updating...";
				updateSauce.Enabled = true;

				Handler animator = new Handler ();
				System.Action NumberAnim = null;
				NumberAnim = ()=> 
				{
					updateSauce.Text = "Update";
					updateSauce.Enabled = true;

					animator.RemoveCallbacks(NumberAnim);
				};

				animator.PostDelayed (NumberAnim, 1500);

				MainUser.MatchingSauce.NIMPPersonality = AquaBlue.Progress;
				MainUser.MatchingSauce.NIMPFlirt = Lavender.Progress;
				MainUser.MatchingSauce.Zodiac = DustyRose.Progress;

				MatchingSauceBus.UpdateMatchingSauce(MainUser.MatchingSauce);
			};

			if ((mPersonalityTestResults.Equals (kMessage.MS_StartPersonalityTest))) {
				mPersonalitySummary.Hint = mPersonalityTestResults;
			} else {
				mPersonalitySummary.Text = mPersonalityTestResults;
			}
		
			FragmentHome._BuildGoalList ();

			EditPreference.Click += (object sender, EventArgs e) => {
				getPreferencePopup();
			};

			TestPersonality.Click += (object sender, EventArgs e) => {
				NimpController nimp = new NimpController(this.Activity);
			};
			AddTakeTestButtons (view);
			return view;
		}


		void HandleClick (object sender, EventArgs e)
		{
			if (timer != null) {
				timer.Stop();
				timer.Close();
				timer = null;
				return;
			}

			blueProgress.Value = blueProgress.MinValue;
			roseProgress.Value = blueProgress.MinValue;
			lavenderProgress.Value = blueProgress.MinValue;


			timer = new Timer(20);
			timer.Elapsed += HandleElapsed;
			timer.Start();

		}

		void HandleElapsed (object sender, ElapsedEventArgs e)
		{
			blueProgress.Value ++;
			roseProgress.Value ++;
			lavenderProgress.Value ++;

			if (blueProgress.Value >= blueProgress.MaxValue) {
				blueProgress.Value = 0;
				roseProgress.Value = 0;
				lavenderProgress.Value = 0;
			}
		}

		static string _PrepareNimpResults(List<string> nimpText)
		{
			string displayText = "";
			if (nimpText.Count == 0)
			{
				displayText = kMessage.MS_StartPersonalityTest;
			}
			else
			{
				foreach (string text in nimpText)
				{
					displayText += "   \"" + text + "\"\n";
				}
			}
			return displayText;
		}

		public void AddTakeTestButtons(View view)
		{
			var takeTest = view.FindViewById<ImageButton> (Resource.Id.ib_personalityTest);
			var mMoreButton = view.FindViewById<TextView> (Resource.Id.tv_moreText);

			bool show =(mPersonalityTestResults.Equals(kMessage.MS_StartPersonalityTest)) ? true : false;

			if (show)
				mMoreButton.Visibility = ViewStates.Invisible;
			else
				mMoreButton.Visibility = ViewStates.Visible;

			mMoreButton.Click += (object sender, EventArgs e) => {

				Popup.getScrollPopup(this.Activity,mPersonalityTestResults);
			};
				

			int currentBlock = NimpController.PullCurrentBlock();

			if (currentBlock == -1)
			{
				// Error, unable to load, don't add the buttons.
				return;
			}
			if (currentBlock < 5) {
				takeTest.Visibility = ViewStates.Visible;
			} else {
				takeTest.Visibility = ViewStates.Gone;
			}
		}


		public void getPreferencePopup()
		{
			AlertDialog ad;
			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (this.Activity);
			//	LayoutInflater inflater = this.LayoutInflater;
			ad = builder.Create ();
			int[] questionResource = {Resource.Id.rg_questions1,Resource.Id.rg_questions2,Resource.Id.rg_questions3,Resource.Id.rg_questions4,Resource.Id.rg_questions5,
				Resource.Id.rg_questions6,Resource.Id.rg_questions7,Resource.Id.rg_questions8,Resource.Id.rg_questions9,Resource.Id.rg_questions10};
			// Private Vars
			List<NimpData.NimpCategory> 				mMapQuestionToCategory = new List<NimpData.NimpCategory>();
			Dictionary<NimpData.NimpCategory, string> 	mPreferences = new Dictionary<NimpData.NimpCategory, string>();
			Dictionary<NimpData.NimpCategory, string> 	mDuplicate = new Dictionary<NimpData.NimpCategory, string>();

			mMapQuestionToCategory.Add(NimpData.NimpCategory.Traditional);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Physical);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Playful);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Sincere);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Polite);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Extraversion);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Agreeable);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Conscience);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Neurotic);
			mMapQuestionToCategory.Add(NimpData.NimpCategory.Openness);

				var customView = this.Activity.LayoutInflater.Inflate(Resource.Layout.QuizPreference, null);

			/*//Bind to its state change
			/*		(customView.FindViewById<RadioGroup> (Resource.Id.rg_questions1)).CheckedChange += (object sender, RadioGroup.CheckedChangeEventArgs e) =>  {
				RadioGroup rb = (RadioGroup)sender;
				int i = rb.CheckedRadioButtonId;
				Toast.MakeText(this.Activity, "Navigation selection changed ", ToastLength.Short).Show();
			};

			*/

			for (int idx = 0; idx < questionResource.Length; idx++) {
				
				//QuizQuestion question = mQuiz.Questions[idx];
				NimpData.NimpCategory category = mMapQuestionToCategory[idx];

				//	if (!_ReverseIfNeurotic(question, category))
				///mPreferences[category] = ((NimpData.NimpGrade)question.SelectedIndex).ToString();
					
				(customView.FindViewById<RadioGroup> (questionResource[idx])).CheckedChange += (object sender, RadioGroup.CheckedChangeEventArgs e) =>  {
					RadioGroup questionGroup = (RadioGroup)sender;

					int questions = questionGroup.CheckedRadioButtonId;
					//RadioButton questionCategory = customView.FindViewById<RadioButton>(j);
					/*
					if (idx==9)
						_ReverseIfNeurotic(ref questions);


					switch(questions){
					case Resource.Id.hi:	cat = "hi";				break;
					case Resource.Id.mid:	cat = "mid";			break;
					case Resource.Id.low:	cat = "low";			break;
					}
*/
					mPreferences[category] = _ReverseIfNeurotic(idx,questions);

					//	Toast.MakeText(this.Activity, "Navigation selection changed ", ToastLength.Short).Show();
				};
			}
			var Submitbtn = customView.FindViewById<Button> (Resource.Id.btn_QuizUpdate);
			Submitbtn.Click += (object sender, EventArgs e) => {

				string[] prefResult = null;
				if(mPreferences.Count==10){
					do { prefResult = MatchingSauceBus.UpdateNIMPPreferencesGoal(ref MainUser.AppUser, 
						mPreferences[NimpData.NimpCategory.Extraversion],
						mPreferences[NimpData.NimpCategory.Agreeable],
						mPreferences[NimpData.NimpCategory.Conscience],
						mPreferences[NimpData.NimpCategory.Neurotic],
						mPreferences[NimpData.NimpCategory.Openness],
						mPreferences[NimpData.NimpCategory.Traditional],
						mPreferences[NimpData.NimpCategory.Physical],
						mPreferences[NimpData.NimpCategory.Sincere],
						mPreferences[NimpData.NimpCategory.Playful],
						mPreferences[NimpData.NimpCategory.Polite],
								ref MainUser.Goals); } while (prefResult == null);
				}
				else{
					new Popup().getpopup(this.Activity,Resource.String.error,Resource.String.Validate_prefrence,"CONTINUE");
				}
				if(mPreferences.Count==10){
					ad.Dismiss();

				if (prefResult.Length > 1)
				{
					if (prefResult[2] == "true")
					{
						// Refresh MatchingSauceVC
						//	RefreshUI.Fire();

						// Check to refresh iPad's HomeVC
						//iPad.HomeVC homeVC = mParentVC as iPad.HomeVC;
						//if (homeVC != null) homeVC.OnReturnFromChildVC();
					}

					_DisplayRewardPopup(prefResult[0] == "Rewarded");
				}
				else
					_DisplayRewardPopup(false);
				}
			};

			var Cancelbtn = customView.FindViewById<Button> (Resource.Id.btn_QuizCancel);
			Cancelbtn.Click += (object sender, EventArgs e) => {
				ad.Dismiss();
			};

			builder.SetView(customView);
			ad = builder.Create ();
			ad.SetCancelable(true);

			ad.Show ();
		}

		//----------------------------------------

		void _DisplayRewardPopup(bool givenReward)
		{
			new Popup().getpopup(this.Activity,Resource.String.quiz_taken,Resource.String.reward_message,"OK");

			if (givenReward)
			{
				new Popup().getpopup(this.Activity,Resource.String.quiz_taken,Resource.String.new_reward_message,"OK");
				//function calll back
				FlirtPlanetActivity.FlyoutNav.AdjustJuice ();
				FlirtPlanetActivity.FlyoutNav.refreshJuiceGold();
			}
		}

		// Neuroticism is backwards
		string _ReverseIfNeurotic(int question ,int category)
		{
			string cat=null;
			if (question == 8) {
				switch (category) {
				case Resource.Id.hi:
					cat = "low";
					break;
				case Resource.Id.mid:
					cat = "mid";
					break;
				case Resource.Id.low:
					cat = "hi";
					break;
				}

				return cat;
			} 

			else {
				switch (category) {
				case Resource.Id.hi:
					cat = "hi";
					break;
				case Resource.Id.mid:
					cat = "mid";
					break;
				case Resource.Id.low:
					cat = "low";
					break;
				}

				return cat;
			}

		}

		public void OnProgressChanged(SeekBar seekBar, int progress, bool fromTouch) 
		{
			if (fromTouch) {
				if (seekBar.Id == Resource.Id.sk_aquaBlue) {
			
					blueProgress.Value = progress;
					roseProgress.Value = (int)System.Math.Floor ((100 - blueProgress.Value)  / 2);
					lavenderProgress.Value = (int)System.Math.Ceiling ((100 - blueProgress.Value)  / 2);

					DustyRose.Progress = (int)System.Math.Floor ((100 - blueProgress.Value)  / 2);
					Lavender.Progress = (int)System.Math.Ceiling ((100 - blueProgress.Value) / 2);


				} else if (seekBar.Id == Resource.Id.sk_dustyRose) {

					roseProgress.Value = progress;
					blueProgress.Value = (int)System.Math.Floor ((100 - roseProgress.Value)  / 2);
					lavenderProgress.Value = (int)System.Math.Ceiling ((100 - roseProgress.Value)  / 2);

					AquaBlue.Progress = (int)System.Math.Floor ((100 - roseProgress.Value)  / 2);
					Lavender.Progress = (int)System.Math.Ceiling ((100 - roseProgress.Value)  / 2);


				} else {
					lavenderProgress.Value = progress;
					blueProgress.Value = (int)System.Math.Floor ((100 - lavenderProgress.Value)  / 2);
					roseProgress.Value = (int)System.Math.Ceiling ((100 - lavenderProgress.Value)  / 2);

				
					AquaBlue.Progress = (int)System.Math.Floor ((100 - lavenderProgress.Value)  / 2);
					DustyRose.Progress = (int)System.Math.Ceiling ((100 - lavenderProgress.Value)  / 2);
				}	
			}
		}

		public void OnStartTrackingTouch(SeekBar seekBar) {
		}

		public void OnStopTrackingTouch(SeekBar seekBar) {
		}
	}
}


