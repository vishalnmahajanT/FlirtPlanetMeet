//--------------------------------------------------------------------------------
//
// iOS.NimpData.cs - Data for the N-Imp Quiz
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

//using iOS.Extensions;
//using iOS.Common;

using Core.Data;


//--------------------------------------------------------------------------------

namespace flirtplanet
{
	public class NimpData
	{
		//----------------------------------------

		public enum NimpCategory
		{   
			Extraversion,
			Agreeable,
			Conscience,
			Neurotic,
			Openness,
			Traditional,
			Physical,
			Sincere,
			Playful,
			Polite
		}

		public enum Block
		{
			FirstLoad = -1,
			Practice = 0,
			Block1 = 1,
			Block2 = 2,
			Block3 = 3,
			Block4 = 4,
			Completed = 5
		}

		public enum NimpGrade
		{
			hi  = 0,
			med = 1,
			low = 2
		}

		//----------------------------------------

		static Dictionary <NimpCategory, List<string>> mTests = new Dictionary<NimpCategory, List<string>>()
		{
			{ NimpCategory.Extraversion, new List<string>() { "talkative", "outgoing", "energetic", "shy" } },
			{ NimpCategory.Agreeable, new List<string>() { "kind", "generous", "helpful", "selfish" } },
			{ NimpCategory.Conscience, new List<string>() { "reliable", "diligent", "punctual", "lazy" } },
			{ NimpCategory.Neurotic, new List<string>() { "nervous", "moody", "sad", "happy" } },
			{ NimpCategory.Openness, new List<string>() { "creative", "inventive", "educated", "stubborn" } },
			{ NimpCategory.Traditional, new List<string>() { "courteous", "traditional", "chivalrous", "casual" } },
			{ NimpCategory.Physical, new List<string>() { "sexy", "erotic", "desire", "celibate" } },
			{ NimpCategory.Sincere, new List<string>() { "supportive", "romantic", "honest", "fake" } },
			{ NimpCategory.Playful, new List<string>() { "fun", "playful", "harmless", "serious" } },
			{ NimpCategory.Polite, new List<string>() { "polite", "cautious", "courteous", "rude" } },
		};

		public static Dictionary <Block, string> PreRoundMessages = new Dictionary<Block, string>()
		{
			{ Block.FirstLoad, "This is a quick and easy personality test. \n\nWe don't want your data for marketing, so we won't ask you any personal questions, and no silly ones either! \n\nBy tapping into your subconscious we determine your personality traits, accurately and quickly. Then YOU will give this test an importance in your personal \"Matching Sauce\", so that YOU get to see the people that best match YOU. \n\nThere is REAL SCIENCE behind this test. Our in-house Neuroscientists from Neurosense designed this just for you. Remember to complete the Preferences Quiz also!\n\nIt takes less than 10 minutes and completing all 4 Blocks earns you 100 FJ!! \n\nBe sure you don't get distracted. Keep your eyes on the screen." },
			{ Block.Practice, "This quiz will consist of several trials in which a word is presented in the middle of the screen. The word will either be false or true and will be presented inside an ORANGE SQUARE.\n\nIf the word is false press the False button, and if it is true, press the True button.\n\nIt is important that you respond as quickly as you can. Try to react before the orange square disappears. If you make a mistake you will be prompted to try again.\n\nLet's begin with some practice trials. Click 'Practice' when you are ready to begin." },
			{ Block.Block1, "Next, you are going to be presented with the same task with one difference - a short statement (e.g., I am tall) will be shown briefly just before the word True or False appears. \n\nYour task is to just carry on as before pressing the TRUE and FALSE buttons as fast as you can when you see the corresponding word. You may think that some of the phrases apply to you, but this is NOT the task, just detect the presence of the word True or False as you did in the practice trials.\n\nClick CONTINUE when ready." },
			{ Block.Block2, "Looks like you got the hang of it now. Let's start the second block." },
			{ Block.Block3, "Keep powering through it! Let's start the third block." },
			{ Block.Block4, "Last one now!" }
		};

		public static Dictionary <Block, string> PostRoundMessages = new Dictionary<Block, string>()
		{
			{ Block.Practice, "That's the end of the practice."},
			{ Block.Block1, "Well done! You completed the first block.\n\nWith all blocks complete you will earn your Reward, and we'll have an accurate picture of you. \n\nJust 3 more to go now.\n\nIf you wish to continue later, your progress will be saved." },
			{ Block.Block2, "Well done! You completed the second block. \n\nOnly 2 more blocks to go." },
			{ Block.Block3, "Well done! You completed the third block." },
			{ Block.Block4, "Well done! \n\nYou completed the Personality Test.\n\nYour Reward and your Results are waiting!" }
		};

		public static Dictionary <Tuple<NimpCategory, string>, string> PersonalPersonalityText = new Dictionary<Tuple<NimpCategory, string>, string>()
		{
			{ Tuple.Create(NimpCategory.Traditional, 			"hi"), 	"You believe in traditional gender roles – males should do the chasing and females should be the chased and while you think it’s OK for females to use nonverbal behaviour to signal interest (e.g., by making eye contact), you think that males should make the first move. You believe that males should be courteous and considerate in courtship, and although it’s OK for females to make the first move, females tend to be more worried about the risk of rejection if she did. You usually need to know someone for a long time before developing a relationship with them." },
			{ Tuple.Create(NimpCategory.Traditional, 			"med"), "Sometimes you feel like being very traditional – males should be courteous and make the first move, and at other times you can be very modern in your thinking and think it’s OK for females to take control." },
			{ Tuple.Create(NimpCategory.Traditional, 			"low"), "You believe in a degree of equality between the sexes, for example, you think it’s really OK for females to make the first move. You don’t believe that males should be overly courteous or believe that females are the ‘weaker’ sex. It may not take too long for you to become involved in a relationship once you have met someone you like." }, 

			{ Tuple.Create(NimpCategory.Physical, 				"hi"),	"For you the main purpose of flirting is sex. You enjoy the sexual innuendos of a conversation. In flirting, you are comfortable in showing your sexual interest and you are very good at detecting someone who might be interested in you. So, flirting for you is really about detecting the possibility of a relationship – a short fling or maybe more. Either way, your relationships tend to move very quickly!" },
			{ Tuple.Create(NimpCategory.Physical,				"med"),	"Part of the reason why you flirt is to determine if someone is interested in you physically. Though, this does not dominate your flirting, it is often on your mind." },
			{ Tuple.Create(NimpCategory.Physical,				"low"), "You tend to avoid talking about sex and sexual innuendo when flirting with someone. You also tend to hide or disguise any sexual interest you may be feeling. You therefore tend to take your time in developing relationships." },

			{ Tuple.Create(NimpCategory.Sincere,				"hi"),	"For you, the main reason for flirting is to establish a meaningful relationship. You believe that both partners should be honest and sincere – wearing your heart on your sleeve but also being a good listener. You tend to show great interest in people you like and try to find out more about them, their dreams and ambitions. You seek intimacy – perhaps too soon – and want it to lead to mutual dependence and emotional attachment. In flirting you will be supportive, friendly and sincere. You are likely to be a very romantic person, but tend to withhold your sexual interest early on. Your relationships tend to develop quite quickly." },
			{ Tuple.Create(NimpCategory.Sincere,				"med"),	"For you, getting involved with someone is an important reason for flirting. You are, however, cautious at times and tend not to disclose things about yourself until you begin to feel more comfortable. Once you are confident and comfortable with the other person, your relationship with them will tend to run smoothly." },
			{ Tuple.Create(NimpCategory.Sincere,				"low"),	"What worries you most about flirting is getting too involved. You tend to be cautious and will often be conservative with the truth. The thought of becoming too emotionally attached and dependent on someone too soon tends to turn you off, so for that reason you move slowly." },

			{ Tuple.Create(NimpCategory.Playful,				"hi"),	"For you, flirting is fun and need not necessarily lead to a relationship. You often flirt purely for the fun of flirting and when it leads to a date, your primary goal is to have a good time. You are not overly concerned what people think about you and this allows you to be more playful and less inhibited than most people when flirting. Many females just want to have fun on a first date. For you finding out if you have sexual chemistry is more important than having thoughts about developing a meaningful relationship." },
			{ Tuple.Create(NimpCategory.Playful,				"med"),	"Flirting is both fun and serious for you. While it is pleasurable just exchanging banter you are focused on trying to determine whether a relationship with this person is worth pursuing." },
			{ Tuple.Create(NimpCategory.Playful,				"low"),	"When you flirt prefer to be straight talking and honest rather than too jovial or superficial. You can often be shy but will open up for the right person." },

			{ Tuple.Create(NimpCategory.Polite,					"hi"),	"When it comes to flirting, you are very polite and cautious. For you, flirting is about being in control and adhering to the rules of courtship. You tend to be concerned about appearing too needy or trying too hard – you are worried about making a fool of yourself. Your attitude to first dates is very conservative and you don’t like to be the centre of attention. Many females will be cautious in flirting, as sexual harassment is a greater concern for them. An important goal of flirting for you is to seek a deep and meaningful relationship." },
			{ Tuple.Create(NimpCategory.Polite,					"med"),	"When you flirt you can be quite concerned about how you are perceived and can be quite cautious in the language you use. You would be happy to meet someone for a short fling or develop something more long term, depending upon the circumstances." },
			{ Tuple.Create(NimpCategory.Polite,					"low"),	"You tend to throw caution to the wind when it comes to flirting. You aren’t very inhibited with the language you use and the ideas you are prepared to pursue in a conversation. You are a very relaxed person and have a very liberal attitude to most things. Jumping into a long-term relationship is not your main priority." },

			{ Tuple.Create(NimpCategory.Extraversion,			"hi"),	"You tend to be outgoing, enjoy socializing, and like to be the center of attention." },
			{ Tuple.Create(NimpCategory.Extraversion,			"med"),	"You can be outgoing and occasionally like to be the center of attention. However, you often prefer your own company and you may be shy and reserved at times." },
			{ Tuple.Create(NimpCategory.Extraversion,			"low"),	"You prefer your own company than be with a crowd of people, and you may be rather shy and reserved." },

			{ Tuple.Create(NimpCategory.Agreeable,				"hi"),	"You are a very warm, empathetic kind of person, who tries hard to understand other people's perspectives." },
			{ Tuple.Create(NimpCategory.Agreeable,				"med"),	"You can be a warm, empathetic kind of person, who tries hard to understand other people's perspectives. However, you can also be cautious of other people, such that you sometimes find it hard to put your trust in others or give them praise." },
			{ Tuple.Create(NimpCategory.Agreeable,				"low"),	"Most of the time you are wary of other people, such that you find it hard to put your trust in others or give them praise." },

			{ Tuple.Create(NimpCategory.Conscience,				"hi"),	"You seem to be a very organised and efficient person who likes planning and prioritising tasks. You generally think before acting on something." },
			{ Tuple.Create(NimpCategory.Conscience,				"med"),	"Generally, you are quite an organised and efficient person who often thinks before acting on something. However, there are times when you prefer not to plan ahead or be too organised. Some aspects of your life can be a little chaotic and you sometimes forget important things." },
			{ Tuple.Create(NimpCategory.Conscience,				"low"),	"You seem to prefer not to plan ahead or be too organised. You probably have a chaotic lifestyle and like it that way. You have a laidback attitude towards many things." },

			{ Tuple.Create(NimpCategory.Neurotic,				"hi"),	"You can be a rather nervous or moody kind of person and people may describe you as rather highly-strung and temperamental." },
			{ Tuple.Create(NimpCategory.Neurotic,				"med"),	"There are times when you are rather nervous or moody and other times when you can be rather cool, calm, and collected." },
			{ Tuple.Create(NimpCategory.Neurotic,				"low"),	"You can be rather cool, calm, and collected, and good at hiding your true emotions." },

			{ Tuple.Create(NimpCategory.Openness,				"hi"),	"You have a wide range of interests, have a vivid imagination, and are generally curious about the world you live in." },
			{ Tuple.Create(NimpCategory.Openness,				"med"),	"It is likely that you have several interests and are generally curious about the world you live in, though you tend to prefer the simple life." },
			{ Tuple.Create(NimpCategory.Openness,				"low"),	"You prefer simplicity over complexity. Although you have a small number of interests, you are quite focused on each of them. You probably didn't enjoy school or college." }
		};

		public static Dictionary <Tuple<NimpCategory, string>, string> FemalePersonalityText = new Dictionary<Tuple<NimpCategory, string>, string>()
		{
			{ Tuple.Create(NimpCategory.Traditional, 			"hi"), 	"She believes in traditional gender roles – males should do the chasing and females should be the chased and while she thinks it’s OK for females to use nonverbal behaviour to signal interest (e.g., by making eye contact), she thinks that males should make the first move. She believes that males should be courteous and considerate in courtship, and although it’s OK for females to make the first move, females tend to be more worried about the risk of rejection if she did. She usually needs to know someone for a long time before developing a relationship with them." },
			{ Tuple.Create(NimpCategory.Traditional, 			"med"), "Sometimes she feels like being very traditional – males should be courteous and make the first move, and at other times she can be very modern in her thinking and think it’s OK for females to take control." },
			{ Tuple.Create(NimpCategory.Traditional, 			"low"), "She believes in a degree of equality between the sexes, for example, she might think it’s really OK for females to make the first move. She doesn’t believe that males should be overly courteous or believe that females are the ‘weaker’ sex. It may not take too long for her to become involved in a relationship once she has met someone she likes." }, 

			{ Tuple.Create(NimpCategory.Physical, 				"hi"),	"For her the main purpose of flirting is sex. She enjoys the sexual innuendos of a conversation. In flirting, she is comfortable in showing her sexual interest and she is very good at detecting someone who might be interested in herself. So, flirting for her is really about detecting the possibility of a relationship – a short fling or maybe more. Either way, her relationships tend to move very quickly!" },
			{ Tuple.Create(NimpCategory.Physical,				"med"),	"Part of the reason why she flirts is to determine if someone is interested in her physically. Though, this does not dominate her flirting, it is often on her mind." },
			{ Tuple.Create(NimpCategory.Physical,				"low"), "She tends to avoid talking about sex and sexual innuendo when flirting with someone. She also tends to hide or disguise any sexual interest she may be feeling. She therefore tends to take her time in developing relationships." },

			{ Tuple.Create(NimpCategory.Sincere,				"hi"),	"For her, the main reason for flirting is to establish a meaningful relationship. She believes that both partners should be honest and sincere – wearing her heart on her sleeve but also being a good listener. She tends to show great interest in people she likes and try to find out more about them, their dreams and ambitions. She seeks intimacy – perhaps too soon – and wants it to lead to mutual dependence and emotional attachment. In flirting she will be supportive, friendly and sincere. She is likely to be a very romantic person, but tends to withhold her sexual interest early on. Her relationships tend to develop quite quickly." },
			{ Tuple.Create(NimpCategory.Sincere,				"med"),	"For her, getting involved with someone is an important reason for flirting. She is, however, cautious at times and tends not to disclose things about herself until she begins to feel more comfortable. Once she is confident and comfortable with the other person, her relationship with them will tend to run smoothly." },
			{ Tuple.Create(NimpCategory.Sincere,				"low"),	"What worries her most about flirting is getting too involved. She tends to be cautious and will often be conservative with the truth. The thought of becoming too emotionally attached and dependent on someone too soon tends to turn her off, so for that reason she moves slowly." },

			{ Tuple.Create(NimpCategory.Playful,				"hi"),	"For her, flirting is fun and need not necessarily lead to a relationship. She often flirts purely for the fun of flirting and when it leads to a date, her primary goal is to have a good time. She is not overly concerned with what people think about her and this allows her to be more playful and less inhibited than most people when flirting. Many females just want to have fun on a first date. For her finding out if she has sexual chemistry is more important than having thoughts about developing a meaningful relationship." },
			{ Tuple.Create(NimpCategory.Playful,				"med"),	"Flirting is both fun and serious for her. While it is pleasurable just exchanging banter she is focused on trying to determine whether a relationship with this person is worth pursuing." },
			{ Tuple.Create(NimpCategory.Playful,				"low"),	"When she flirts she prefers to be straight talking and honest rather than too jovial or superficial. She can often be shy but will open up for the right person." },

			{ Tuple.Create(NimpCategory.Polite,					"hi"),	"When it comes to flirting, she is very polite and cautious. For her, flirting is about being in control and adhering to the rules of courtship. She tends to be concerned about appearing too needy or trying too hard – she is worried about making a fool of herself. Her attitude to first dates is very conservative and she doesn’t like to be the center of attention. Many females will be cautious in flirting, as sexual harassment is a greater concern for them. An important goal of flirting for her is to seek a deep and meaningful relationship." },
			{ Tuple.Create(NimpCategory.Polite,					"med"),	"When she flirts she can be quite concerned about how she is perceived and can be quite cautious in the language she uses. She would be happy to meet someone for a short fling or develop something more long term, depending upon the circumstances." },
			{ Tuple.Create(NimpCategory.Polite,					"low"),	"She tends to throw caution to the wind when it comes to flirting. She isn’t very inhibited with the language she uses and the ideas she is prepared to pursue in a conversation. She is a very relaxed person and has a very liberal attitude to most things. Jumping into a long-term relationship is not her main priority." },

			{ Tuple.Create(NimpCategory.Extraversion,			"hi"),	"She tends to be outgoing, enjoys socializing, and likes to be the center of attention." },
			{ Tuple.Create(NimpCategory.Extraversion,			"med"),	"She can be outgoing and occasionally likes to be the center of attention. However, she often prefers her own company and she may be shy and reserved at times." },
			{ Tuple.Create(NimpCategory.Extraversion,			"low"),	"She prefers her own company than be with a crowd of people, and she may be rather shy and reserved." },

			{ Tuple.Create(NimpCategory.Agreeable,				"hi"),	"She is a very warm, empathetic kind of person, who tries hard to understand other people's perspectives." },
			{ Tuple.Create(NimpCategory.Agreeable,				"med"),	"She can be a warm, empathetic kind of person, who tries hard to understand other people's perspectives. However, she can also be cautious of other people, such that she sometimes finds it hard to put her trust in others or give them praise." },
			{ Tuple.Create(NimpCategory.Agreeable,				"low"),	"Most of the time she is wary of other people, such that she finds it hard to put her trust in others or give them praise." },

			{ Tuple.Create(NimpCategory.Conscience,				"hi"),	"She seems to be a very organized and efficient person who likes planning and prioritizing tasks. She generally thinks before acting on something." },
			{ Tuple.Create(NimpCategory.Conscience,				"med"),	"Generally, she is quite an organized and efficient person who often thinks before acting on something. However, there are times when she prefers not to plan ahead or be too organized. Some aspects of her life can be a little chaotic and she sometimes forget important things." },
			{ Tuple.Create(NimpCategory.Conscience,				"low"),	"She seems to prefer not to plan ahead or be too organized. She probably has a chaotic lifestyle and likes it that way. She has a laidback attitude towards many things." },

			{ Tuple.Create(NimpCategory.Neurotic,				"hi"),	"She can be a rather nervous or moody kind of person and people may describe her as rather highly-strung and temperamental." },
			{ Tuple.Create(NimpCategory.Neurotic,				"med"),	"There are times when she is rather nervous or moody and other times when she can be rather cool, calm, and collected." },
			{ Tuple.Create(NimpCategory.Neurotic,				"low"),	"She can be rather cool, calm, and collected, and good at hiding her true emotions." },

			{ Tuple.Create(NimpCategory.Openness,				"hi"),	"She has a wide range of interests, has a vivid imagination, and is generally curious about the world she lives in." },
			{ Tuple.Create(NimpCategory.Openness,				"med"),	"It is likely that she has several interests and is generally curious about the world she lives in, though she tends to prefer the simple life." },
			{ Tuple.Create(NimpCategory.Openness,				"low"),	"She prefers simplicity over complexity. Although she has a small number of interests, she is quite focused on each of them. She probably didn't enjoy school or college." }
		};

		public static Dictionary <Tuple<NimpCategory, string>, string> MalePersonalityText = new Dictionary<Tuple<NimpCategory, string>, string>()
		{
			{ Tuple.Create(NimpCategory.Traditional, 			"hi"), 	"He believes in traditional gender roles – males should do the chasing and females should be the chased and while he thinks it’s OK for females to use nonverbal behaviour to signal interest (e.g., by making eye contact), he thinks that males should make the first move. He believes that males should be courteous and considerate in courtship. He usually needs to know someone for a long time before developing a relationship with them." },
			{ Tuple.Create(NimpCategory.Traditional, 			"med"), "Sometimes he feels like being very traditional – males should be courteous and make the first move, and at other times he can be very modern in his thinking and think it’s OK for females to take control." },
			{ Tuple.Create(NimpCategory.Traditional, 			"low"), "He believes in a degree of equality between the sexes, for example, he might think it’s really OK for females to make the first move. He doesn’t believe that males should be overly courteous or believe that females are the ‘weaker’ sex. It may not take too long for him to become involved in a relationship once he has met someone he likes." }, 

			{ Tuple.Create(NimpCategory.Physical, 				"hi"),	"For him the main purpose of flirting is sex. He enjoys the sexual innuendos of a conversation. In flirting, he is comfortable in showing his sexual interest and he is very good at detecting someone who might be interested in himself. So, flirting for him is really about detecting the possibility of a relationship – a short fling or maybe more. Either way, his relationships tend to move very quickly!" },
			{ Tuple.Create(NimpCategory.Physical,				"med"),	"Part of the reason why he flirts is to determine if someone is interested in him physically. Though, this does not dominate his flirting, it is often on his mind." },
			{ Tuple.Create(NimpCategory.Physical,				"low"), "He tends to avoid talking about sex and sexual innuendo when flirting with someone. He also tends to hide or disguise any sexual interest he may be feeling. He therefore tends to take his time in developing relationships." },

			{ Tuple.Create(NimpCategory.Sincere,				"hi"),	"For him, the main reason for flirting is to establish a meaningful relationship. He believes that both partners should be honest and sincere – wearing his heart on his sleeve but also being a good listener. He tends to show great interest in people he likes and try to find out more about them, their dreams and ambitions. He seeks intimacy – perhaps too soon – and wants it to lead to mutual dependence and emotional attachment. In flirting he will be supportive, friendly and sincere. He is likely to be a very romantic person, but tends to withhold his sexual interest early on. His relationships tend to develop quite quickly." },
			{ Tuple.Create(NimpCategory.Sincere,				"med"),	"For him, getting involved with someone is an important reason for flirting. He is, however, cautious at times and tends not to disclose things about himself until he begins to feel more comfortable. Once he is confident and comfortable with the other person, his relationship with them will tend to run smoothly." },
			{ Tuple.Create(NimpCategory.Sincere,				"low"),	"What worries him most about flirting is getting too involved. He tends to be cautious and will often be conservative with the truth. The thought of becoming too emotionally attached and dependent on someone too soon tends to turn him off, so for that reason he moves slowly." },

			{ Tuple.Create(NimpCategory.Playful,				"hi"),	"For him, flirting is fun and need not necessarily lead to a relationship. He often flirts purely for the fun of flirting and when it leads to a date, his primary goal is to have a good time. He is not overly concerned with what people think about him and this allows him to be more playful and less inhibited than most people when flirting. For him, finding out if he has sexual chemistry is more important than having thoughts about developing a meaningful relationship." },
			{ Tuple.Create(NimpCategory.Playful,				"med"),	"Flirting is both fun and serious for him. While it is pleasurable just exchanging banter he is focused on trying to determine whether a relationship with this person is worth pursuing." },
			{ Tuple.Create(NimpCategory.Playful,				"low"),	"When he flirts he prefers to be straight talking and honest rather than too jovial or superficial. He can often be shy but will open up for the right person." },

			{ Tuple.Create(NimpCategory.Polite,					"hi"),	"When it comes to flirting, he is very polite and cautious. For him, flirting is about being in control and adhering to the rules of courtship. He tends to be concerned about appearing too needy or trying too hard – he is worried about making a fool of himself. His attitude to first dates is very conservative and he doesn’t like to be the center of attention. An important goal of flirting for him is to seek a deep and meaningful relationship." },
			{ Tuple.Create(NimpCategory.Polite,					"med"),	"When he flirts he can be quite concerned about how he is perceived and can be quite cautious in the language he uses. He would be happy to meet someone for a short fling or develop something more long term, depending upon the circumstances." },
			{ Tuple.Create(NimpCategory.Polite,					"low"),	"He tends to throw caution to the wind when it comes to flirting. He isn’t very inhibited with the language he uses and the ideas he is prepared to pursue in a conversation. He is a very relaxed person and has a very liberal attitude to most things. Jumping into a long-term relationship is not his main priority." },

			{ Tuple.Create(NimpCategory.Extraversion,			"hi"),	"He tends to be outgoing, enjoys socializing, and likes to be the center of attention." },
			{ Tuple.Create(NimpCategory.Extraversion,			"med"),	"He can be outgoing and occasionally likes to be the center of attention. However, he often prefers his own company and he may be shy and reserved at times." },
			{ Tuple.Create(NimpCategory.Extraversion,			"low"),	"He prefers his own company than be with a crowd of people, and he may be rather shy and reserved." },

			{ Tuple.Create(NimpCategory.Agreeable,				"hi"),	"He is a very warm, empathetic kind of person, who tries hard to understand other people's perspectives." },
			{ Tuple.Create(NimpCategory.Agreeable,				"med"),	"He can be a warm, empathetic kind of person, who tries hard to understand other people's perspectives. However, he can also be cautious of other people, such that he sometimes finds it hard to put his trust in others or give them praise." },
			{ Tuple.Create(NimpCategory.Agreeable,				"low"),	"Most of the time he is wary of other people, such that he finds it hard to put his trust in others or give them praise." },

			{ Tuple.Create(NimpCategory.Conscience,				"hi"),	"He seems to be a very organized and efficient person who likes planning and prioritizing tasks. He generally thinks before acting on something." },
			{ Tuple.Create(NimpCategory.Conscience,				"med"),	"Generally, he is quite an organized and efficient person who often thinks before acting on something. However, there are times when he prefers not to plan ahead or be too organized. Some aspects of his life can be a little chaotic and he sometimes forget important things." },
			{ Tuple.Create(NimpCategory.Conscience,				"low"),	"He seems to prefer not to plan ahead or be too organized. He probably has a chaotic lifestyle and likes it that way. He has a laidback attitude towards many things." },

			{ Tuple.Create(NimpCategory.Neurotic,				"hi"),	"He can be a rather nervous or moody kind of person and people may describe him as rather highly-strung and temperamental." },
			{ Tuple.Create(NimpCategory.Neurotic,				"med"),	"There are times when he is rather nervous or moody and other times when he can be rather cool, calm, and collected." },
			{ Tuple.Create(NimpCategory.Neurotic,				"low"),	"He can be rather cool, calm, and collected, and good at hiding his true emotions." },

			{ Tuple.Create(NimpCategory.Openness,				"hi"),	"He has a wide range of interests, has a vivid imagination, and is generally curious about the world he lives in." },
			{ Tuple.Create(NimpCategory.Openness,				"med"),	"It is likely that he has several interests and is generally curious about the world he lives in, though he tends to prefer the simple life." },
			{ Tuple.Create(NimpCategory.Openness,				"low"),	"He prefers simplicity over complexity. Although he has a small number of interests, he is quite focused on each of them. He probably didn't enjoy school or college." }
		};

		//----------------------------------------

		public static List<NimpTrial> GetTrials(Block currentBlock)
		{
			List<NimpTrial> trials = new List<NimpTrial>();

			foreach (NimpCategory category in GetCategories(currentBlock))
			{
				var tests = mTests[category];

				for (int idx = 0; idx < tests.Count; idx++)
				{
					string test = tests[idx];

					NimpTrial trueTrial = new NimpTrial(idx) { Text = test, DisplayTrue = true, Attempted = false };
					trials.Add(trueTrial);
					trials.Add(trueTrial);
				}

				for (int idx = 0; idx < tests.Count; idx++)
				{
					string test = tests[idx];

					NimpTrial falseTrial = new NimpTrial(idx) { Text = test, DisplayTrue = false, Attempted = false };
					trials.Add(falseTrial);
					trials.Add(falseTrial);
				}
			}

			///trials.Shuffle();

			int goodThroughIndex = 1; // Always need the previous one

			while (goodThroughIndex < (trials.Count - 1))
			{
				for (int idx = goodThroughIndex; idx < trials.Count; idx++)
				{
					NimpTrial currentTrial = trials[idx];
					NimpTrial previousTrial = trials[idx - 1];
				
					if (previousTrial.Text.Equals(currentTrial.Text))
					{
						// Remove it and move it to the end, then restart  

						trials.Remove(currentTrial);

						bool found = false;

						// Go through the list again to find an opening
						for (int findOpeningIndex = 1; findOpeningIndex < trials.Count; findOpeningIndex++)
						{
							NimpTrial findOpeningPrev = trials[findOpeningIndex - 1];
							NimpTrial findOpeningNext = trials[findOpeningIndex];

							if (findOpeningNext.Text != currentTrial.Text && findOpeningPrev.Text != currentTrial.Text)
							{
								found = true;
								trials.Insert(trials.IndexOf(findOpeningNext), currentTrial);
								break;
							}
						}

						// If couldn't find an opening, then just put it at the end. We should only have one doubled up attribute max that way.
						if (!found)
							trials.Add(currentTrial);
					}

					goodThroughIndex = idx;
				}
			}

			return trials;
		}

		//----------------------------------------

		public static List<NimpCategory> GetCategories(Block currentBlock)
		{
			List<NimpCategory> categories = new List<NimpCategory>();

			switch (currentBlock)
			{
				case Block.Block1:
					categories.Add(NimpCategory.Extraversion);
					categories.Add(NimpCategory.Agreeable);
					break;
				case Block.Block2:
					categories.Add(NimpCategory.Conscience);
					categories.Add(NimpCategory.Neurotic);
					break;
				case Block.Block3:
					categories.Add(NimpCategory.Openness);
					categories.Add(NimpCategory.Traditional);
					categories.Add(NimpCategory.Physical);
					break;
				case Block.Block4:
					categories.Add(NimpCategory.Sincere);
					categories.Add(NimpCategory.Playful);
					categories.Add(NimpCategory.Polite);
					break;
			}

			return categories;
		}

		//----------------------------------------

		static string BuildDemographicResult(NimpController controller)
		{
			int blockNum = (int)controller.CurrentBlock;
			string gender = (MainUser.AppUser.GetGender().ToUpper() == "MALE") ? "M" : "F";

			string leftButtonValue = (controller.IsLeftTrue) ? "T" : "F";

			string result = MainUser.AppUser.UniqUser.ToString() + "$" +
			                gender + "$" +
			                controller.Handed + "$" +
							MainUser.AppUser.GetAge().ToString() + "$" +
			                blockNum.ToString() + "$" +
			                leftButtonValue + "$";

			return result;
		}

		//----------------------------------------

		public static string BuildResult(NimpController controller, List<NimpTrial> trials)
		{
			string result = NimpData.BuildDemographicResult(controller);

			foreach (NimpTrial trial in trials)
			{
				string tOrF = (trial.GotRightFirstTry) ? "T" : "F";
				result = result + tOrF + "$" + trial.MSResponseTime + "$";
			}

			float errorRate = 0.0f;
		
			// Protect from divide by zero error
			if (controller.NumTrials > 0) 
				errorRate = (float)controller.NumWrong / (float)controller.NumTrials;

			result = result + errorRate.ToString();

			return result;
		}

		//----------------------------------------

		public static List<string> GetPersonality(MatchingSauce sauce)
		{
			List<string> personalityTexts = new List<string>();

			foreach (NimpCategory category in Enum.GetValues(typeof(NimpCategory)))
			{
				string sauceGrade = (string)sauce.GetType().GetProperty(category.ToString()).GetValue(sauce, null);

				if (!sauceGrade.Equals("none"))
					personalityTexts.Add(PersonalPersonalityText[Tuple.Create(category, sauceGrade)]);
			}

			return personalityTexts;
		}

		//----------------------------------------

		public static List<string> GetMatchingPersonality(MatchingSauce sauce, User connectedUser)
		{
			var matchingCategoryTexts = new List<string>();

			foreach (NimpCategory category in Enum.GetValues(typeof(NimpCategory)))
			{
				string sauceGrade = (string)sauce.GetType().GetProperty(category.ToString()).GetValue(sauce, null);
				string connectedGrade = (string)connectedUser.GetType().GetProperty(category.ToString()).GetValue(connectedUser, null);

				if (sauceGrade.Equals(connectedGrade) && !sauceGrade.Equals("none"))
				{
					if (connectedUser.GetGender().ToUpper() == "MALE")
						matchingCategoryTexts.Add(MalePersonalityText[Tuple.Create(category, sauceGrade)]);
					else
						matchingCategoryTexts.Add(FemalePersonalityText[Tuple.Create(category, sauceGrade)]);
				}
			}

			return matchingCategoryTexts;
		}

		//----------------------------------------

		public static List<string> GetDominantFlirtStyles(User user)
		{
			List<string> flirtStyles = new List<string>();

			foreach (NimpCategory category in Enum.GetValues(typeof(NimpCategory)))
			{
				string flirtStyleGrade = (string)user.GetType().GetProperty(category.ToString()).GetValue(user, null);

				if (flirtStyleGrade.Equals("hi"))
					flirtStyles.Add(category.ToString());
			}

			return flirtStyles;
		}

		//----------------------------------------

	} // End Class: NimpData

} // End Namespace: iOS

//--------------------------------------------------------------------------------
// EOF

