using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using Core.Business;
using Core.Data;
using Android.Views.InputMethods;

namespace flirtplanet
{
	public class DialogView 
	{
		static List<DetailQuestion> mDetailQuestions = null;
		static Spinner spin;
		static Spinner spin1;
		static Spinner spin2;
		static string answer0 = null;
		static string answer1 = null;
		static string answer2 = null;
		static List<DetailAnswer> useranswer1 =null;

		static List<int> resTagID=null;
		static DetailAnswer ListAnswer = null;


		public static View OnCreateView(Activity activity, int type,bool canedit)
		{
			AlertDialog ad;
			int UniquserQuestion = 0;int answerID=0;

			Android.App.AlertDialog.Builder builder = new AlertDialog.Builder (activity);
			ad = builder.Create ();

			LinearLayout ll = new LinearLayout(activity);

			ll.Orientation = Orientation.Vertical;
			ll.SetVerticalGravity ( GravityFlags.CenterVertical);

			LinearLayout.LayoutParams layoutParams = new LinearLayout.LayoutParams(
				LinearLayout.LayoutParams.FillParent, LinearLayout.LayoutParams.FillParent);


			var layout = new TableLayout (activity);

			if (canedit) {
				layout.SetPadding (15, 15, 15, 15);
				layout.SetBackgroundColor (Color.ParseColor ("#ff00c1f8"));
				FrameLayout.LayoutParams lp = new FrameLayout.LayoutParams (TableRow.LayoutParams.FillParent, TableRow.LayoutParams.FillParent);
				layout.LayoutParameters = lp;
				layout.SetColumnStretchable (1, true);
			} 
			else {

			}
			List<DetailQuestion> questions = GetQuestions (type);
			Spinner spinner;
			List<DetailAnswer> answer=null;
			resTagID = new List<int> ();
			resTagID.Add (Resource.Id.sp420);
			resTagID.Add (Resource.Id.sp421);
			resTagID.Add (Resource.Id.sp422);


			for(int i =0;i<questions.Count;i++){
				answer = questions [i].AnswerList;
				// create a spinner
				spinner = new Spinner (activity);
				//answer text
				TextView Anstext = new TextView(activity);
				Anstext.SetTextColor (Color.Black);
				var items = new List<string> ();
				for (int j = 0; j < answer.Count; j++) {
					items.Add (answer [j].AnswerText);
				}
				TableRow Row = new TableRow(activity);
				TextView Quetext = new TextView(activity);
				Quetext.SetTextColor (Color.Black);
				// set the text to "text xx"
				// add the TextView and the CheckBox to the new TableRow
				Quetext.Text = questions [i].QuestionText;
				UniquserQuestion =  answer [i].UniqUserQuestion;

				answerID = userAnswer (questions [i]);
			

				if (canedit) {
					var adapter = new ArrayAdapter<string> (activity, Resource.Layout.custom_spinner_meet, items);

					spinner.Adapter = adapter;
					spinner.SetTag (resTagID[i],spinner);
					spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(ItemSelectedHandler);
					spinner.SetSelection (answerID);
					Row.AddView(Quetext);
					Row.AddView (spinner);
				}
				else {

					// set the text to "text xx"
					Anstext.SetPadding (10, 0, 10, 10);
					Anstext.Text = items[answerID];
					Quetext.SetTypeface (null, TypefaceStyle.Bold);
					Anstext.Gravity = GravityFlags.Center;
					Quetext.Gravity = GravityFlags.Center;
					ll.AddView(Quetext);
					ll.AddView (Anstext);
				}

				//				Row.AddView(text);
				if (canedit) {
					layout.AddView (Row, new TableLayout.LayoutParams (TableLayout.LayoutParams.WrapContent, TableLayout.LayoutParams.WrapContent));
				}
			}


			//layoutParams.SetMargins(100, 20, 100, 0);
			if (canedit) 
				ll.AddView (layout);
			layoutParams.Gravity = GravityFlags.Center;

			ll.LayoutParameters = layoutParams;

			Button update = new Button(activity);
			Button ok = new Button(activity);

			update.Click += (object sender, EventArgs e) => {

				List<DetailAnswer> uniqAnswer= new List<DetailAnswer>();
				List<string> ans = new List<string>();

				ans.Add(answer0);
				ans.Add(answer1);
				ans.Add(answer2);
				List<DetailQuestion> temp = new List<DetailQuestion>();
				for(int i =0;i<questions.Count;i++){
					ListAnswer =  ProfileBus.GrabOptionID(mDetailQuestions, questions[i].UniqUserQuestion, ans[i]);
					useranswer1 = ProfileBus.GrabUserAnswers(ProfileData.mUser.DetailAnswers, questions[i].UniqUserQuestion);

					string[] detailsChanged = null;
					do {
						detailsChanged = ProfileBus.UpdateUserDetailQuestionsGoal(ref MainUser.AppUser, useranswer1[0].UniqUserQuestionAnswer, ListAnswer.UniqUserAnswer, ref MainUser.Goals);
					} while (detailsChanged == null);

					ProfileData.mUser.UpdateUserAnswer( useranswer1[0].UniqUserQuestionAnswer, ListAnswer.UniqUserAnswer, ListAnswer.AnswerText);
				
					FragmentProfile.updateGrid();
					//DeferNotifyDataSetChanged();
					//	if(i==0)
					//	detailsText = ListAnswer.AnswerText;
				}
				ad.Dismiss();
			};

			ok.Click += (object sender, EventArgs e) => {
				ad.Dismiss();
			};

				update.Text = "Update";

			ok.Text ="OK";
			update.SetBackgroundColor(Color.ParseColor("#ff323232"));
			update.SetTextColor(Color.ParseColor("#ffffffff"));
			ok.SetBackgroundColor(Color.ParseColor("#ff323232"));
			ok.SetTextColor(Color.ParseColor("#ffffffff"));
			if (canedit)
				ll.AddView (update);
			else
				ll.AddView (ok);

			builder.SetView(ll);
			ad = builder.Create ();
			ad.SetCancelable(true);
			ad.Show ();


		
			return ll;
		}

		static List<string> spinnerText =new List<string>();

		public static void ItemSelectedHandler (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;

			//Merchant merch = (Merchant)spinner.SelectedItem;
			string toast = string.Format ("Selected text is {0}", spinner.GetItemAtPosition (e.Position));
			//Toast.MakeText (activity, toast, ToastLength.Long).Show ();
			//var spin = spinner.GetTag(Resource.Id.btn_side_boosts);
			//	for (int i = 0; i < resTagID.Count; i++) {
			 spin = (Spinner)spinner.GetTag (resTagID [0]);
			 spin1 = (Spinner)spinner.GetTag (resTagID [1]);
			 spin2 = (Spinner)spinner.GetTag (resTagID [2]);

			if(null != spin)
				answer0 = spin.SelectedItem.ToString ();
			//spinnerText.Add(spin.SelectedItem.ToString ());
			if(null != spin1)
				answer1 = spin1.SelectedItem.ToString ();
			if(null != spin2)
				answer2 = spin2.SelectedItem.ToString ();
			Console.WriteLine ("spin :{0} spin1 :{1} spin2 :{2}", answer0,answer1,answer2);
			//}

			spinnerText.Add(Convert.ToString(spinner.GetItemAtPosition (e.Position)));
		}

		public static List<DetailQuestion> DetailQuestions
		{
			get
			{
				if (mDetailQuestions == null)
				{
					mDetailQuestions = BusinessBase.GetDetailQuestions();

					while (mDetailQuestions == null)
					{
						mDetailQuestions = BusinessBase.GetDetailQuestions();
					}
				}
				return mDetailQuestions;
			}
		}

		public static int userAnswer(DetailQuestion question){
			string returnText = "---";
			List<DetailAnswer> userAnswer = ProfileBus.GrabUserAnswers(ProfileData.mUser.DetailAnswers, question.UniqUserQuestion);

			int userSelectedAnswerId = 0;

			for (int id = 0; id < question.AnswerList.Count; id++)
			{
				DetailAnswer answer = question.AnswerList[id];

				if (answer.AnswerText == userAnswer[0].AnswerText)
				{
					userSelectedAnswerId = answer.UniqUserAnswer;
					if (returnText.Equals("---"))
					{
						returnText = userAnswer[0].AnswerText;
					}
					return id;
				}
			}
			return 0;
		}

		public static string GetDescription(int queId)
		{
			string returnText = "---";
			List<DetailQuestion> questions = GetQuestions (queId);
			foreach (DetailQuestion question in questions)
			{
				List<DetailAnswer> userAnswer = ProfileBus.GrabUserAnswers(ProfileData.mUser.DetailAnswers, question.UniqUserQuestion);

				int userSelectedAnswerId = 0;

				for (int id = 0; id < question.AnswerList.Count; id++)
				{
					DetailAnswer answer = question.AnswerList[id];

					if (answer.AnswerText == userAnswer[0].AnswerText)
					{
						userSelectedAnswerId = answer.UniqUserAnswer;
						if (returnText.Equals("---"))
						{
							returnText = userAnswer[0].AnswerText;
						}
					}
				}
			}
			return returnText;
		}

		public static List<DetailQuestion> GetQuestions(int id)
		{
			var detailQuestions = new List<DetailQuestion>();

			string desiredQuestionText = "";
			switch (id)
			{
			case  0:  desiredQuestionText = "?";                       break;
			case  1:  desiredQuestionText = "Education";               break;
			case  2:  desiredQuestionText = "Speaks";                  break;
			case  3:  desiredQuestionText = "Children|Want Children";  break;
			case  4:  desiredQuestionText = "Ethnicity";               break;
			case  5:  desiredQuestionText = "Religion";                break;
			case  6:  desiredQuestionText = "Drinking|Smoking|Drugs";  break;
			case  7:  desiredQuestionText = "Pets";                    break;
			case  8:  desiredQuestionText = "Body Type";               break;
			case  9:  desiredQuestionText = "Diet";                    break;
			case 10:  desiredQuestionText = "Income|Job";              break;
			case 11:  desiredQuestionText = "Body Art";                break;
			default:  desiredQuestionText = "?";                       break;
			}

			if (!desiredQuestionText.Equals("?"))
			{
				string[] questionList = desiredQuestionText.Split('|');

				foreach (string questionText in questionList)
				{
					foreach (DetailQuestion question in DetailQuestions)
					{
						if (question.QuestionText.Equals(questionText))
						{
							detailQuestions.Add(question);
							break;
						}
					}
				}
			}

			return detailQuestions;
		}
	}
}
